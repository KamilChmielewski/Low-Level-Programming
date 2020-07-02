#pragma once
#include <cstdlib>
#include <string.h>


class Heap
{
private:
	char m_name[128];
	size_t m_allocatedBytes = 0;

public:
	Heap(const char* name);
	void AddAllocation(size_t size);
	void RemoveAllocation(size_t size);
	void SetName(const char* name) { strcpy_s(&m_name[0], 128, name); m_allocatedBytes = 0; }
	size_t TotalAllocation() { return m_allocatedBytes; }
	const char* getName() const { return m_name; }

};