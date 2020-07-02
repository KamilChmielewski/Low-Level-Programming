#pragma once
#include <queue>
#include <mutex>
#include <thread>
#include <vector>
#include <functional>
#include <condition_variable>
#include <atomic>
#include <iostream>

#define FRAMES 100
class notfication_queue
{
private:
	std::deque<std::function<void()>> _q;
	std::mutex _mutex;
	std::condition_variable _ready;
	bool _done{ false };
public:
	void done()
	{
		{
			std::unique_lock<std::mutex> lock{ _mutex };
			_done = true;
		}
		_ready.notify_all();
	}

	bool try_pop(std::function<void()>& x)
	{
		std::unique_lock<std::mutex> lock{ _mutex, std::try_to_lock};
		if (!lock || _q.empty()) return false;
		x = std::move(_q.front());
		_q.pop_front();
		return true;
	}

	bool pop(std::function<void()>& x)
	{
		std::unique_lock<std::mutex> lock{ _mutex };
		while (_q.empty() && !_done) _ready.wait(lock);
		if (_q.empty()) return false;
		x = std::move(_q.front());
		_q.pop_front();
		return true;
	}

	
	bool try_push(std::function<void()>&& f)
	{
		{
			std::unique_lock<std::mutex> lock{ _mutex, std::try_to_lock };
			if (!lock) return false;
			_q.emplace_back(std::forward<std::function<void()>>(f));
		}
		_ready.notify_one();
		return true;
	}
	bool push(std::function<void()>&& f)
	{
		{
			std::unique_lock<std::mutex> lock{ _mutex };
			_q.emplace_back(std::forward<std::function<void()>>(f));
		}
		_ready.notify_one();
		return true;
	}

};


class task_system
{
	const unsigned _count{ std::thread::hardware_concurrency() };
	std::vector<std::thread> _threads;
	std::vector<notfication_queue> _q{_count};
	std::atomic<unsigned> _index{ 0 }; 
	std::atomic<unsigned> _iteration{ 0 };
	//std::atomic<unsigned> _iteration{ 0 };

	void run(unsigned i)
	{
		while (true)
		{
			std::function<void()> f;
			for (unsigned n = 0; n != _count; n++)
			{
				unsigned value = (i + n) % _count;
				if (_q[value].try_pop(f)) break;
			}
			if (!f && !_q[i].pop(f)) break;

			f();
		}
	}
public:
	task_system()
	{
		for (unsigned i = 0; i < _count; i++)
		{
			_threads.emplace_back([&, i] {run(i); });
		}
	}
	~task_system()
	{
		for (auto& e : _q)
		{
			e.done();
		}
		for (auto& e : _threads)
		{
			e.join();
		}
		
	}

	void stop()
	{
		for (auto& e : _q)
		{
			e.done();
		}
		for (auto& e : _threads)
		{
			e.join();
		}
	}

	void async_(std::function<void()>&& f)
	{
		unsigned i = _index++;
		for (unsigned n = 0; n != _count; n++)
		{
			unsigned value = (i + n) % _count;
			if (_q[value].try_push((std::forward<std::function<void()>>(f))))
			{
				return;
			}
		}
		_q[i % _count].push(std::forward<std::function<void()>>(f));
	}
};

class Threading
{
private:
	std::atomic<int> _currentFrame = 0;
	int _numWorkers = std::thread::hardware_concurrency();
	std::vector<std::thread> _threads;
	std::mutex _mx;
	std::condition_variable _event;
	bool _stopping;

	void Start(int wokersAmount);


	void Render();
	void InitialiseQueue();
	std::queue<std::function<void(void)>> _queue; //Queue of functions for the threads to retrieve from
public:
	Threading();
	~Threading();
	void Stop();
	void AddRenderJob(std::function<void(void)>f);
};