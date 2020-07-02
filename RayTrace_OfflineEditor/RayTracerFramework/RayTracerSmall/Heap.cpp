#include "Heap.h"
#include <iostream>

Heap::Heap(const char* name)
{
	strcpy_s(&m_name[0], 20, name);
}

void Heap::AddAllocation(size_t size)
{
	m_allocatedBytes += size;
}

void Heap::RemoveAllocation(size_t size)
{
	m_allocatedBytes -= size;
}