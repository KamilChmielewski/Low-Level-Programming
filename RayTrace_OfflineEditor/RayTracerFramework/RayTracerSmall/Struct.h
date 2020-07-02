#pragma once
#include "Heap.h"

struct AllocHeader
{
	Heap* pHeap = nullptr;
	int iSignature;
	size_t iSize;

	//AllocHeader* pNext;
	//AllocHeader* pPrev;
};

void* operator new(size_t size);

void* operator new(size_t size, Heap* heap);

void operator delete(void* pMem);
