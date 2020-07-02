#include "Threading.h"

Threading::Threading()
{
	_stopping = false;
	//InitialiseQueue();
	Start(_numWorkers);
}

Threading::~Threading()
{
	Stop();
}

void Threading::Start(int wokersAmount)
{
	for (int i = 0; i < wokersAmount; i++)
	{
		_threads.emplace_back([=]
			{
				while (true)
				{
					std::function<void(void)> task;
					{
						std::unique_lock<std::mutex> lock{ _mx };

						_event.wait(lock, [=] {return _stopping || !_queue.empty(); });

						if (_queue.empty() && _stopping)
							break;

						task = std::move(_queue.front()); //_queue.front();
						std::cout << "Queue size: " << _queue.size() << " Current Thread: " << i << std::endl;
						_queue.pop();
					}
					task();
				}
			});
	}
}

void Threading::Stop()
{
	{
		std::unique_lock<std::mutex> lock{ _mx };
		_stopping = true;
	}

	_event.notify_all();

	for (std::thread& thread : _threads)
	{
		thread.join();
	}
}

void Threading::InitialiseQueue()
{
	std::unique_lock<std::mutex> lock{ _mx };
	for (int i = 0; i < FRAMES; i++)
	{
		std::function<void(void)> f = std::bind(&Threading::Render, this);
		_queue.push(f);
	}
	std::cout << "Size of Queue: " << _queue.size() << std::endl;
}

void Threading::AddRenderJob(std::function<void(void)>f)
{
	std::unique_lock<std::mutex> lock{ _mx };
	for (size_t i = 0; i < FRAMES; i++)
	{
		std::cout << "adding job: " << i << std::endl;
		_queue.push(f);
	}
	std::cout << "Finished adding Jobs" << std::endl;
}

void Threading::Render()
{
	_currentFrame++;
	std::cout << "Frame: " << _currentFrame << std::endl;
}