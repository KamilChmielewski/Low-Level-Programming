#include "Struct.h"
#include "HeapFactory.h"
#include <assert.h>
#include <stdio.h>
#include <iostream>
//#define NDEBUG

void* operator new(size_t size)
{
	Heap* h = HeapFactory::GetDefaultHeap();

	size_t requestedBytes = size + sizeof(AllocHeader) + sizeof(int);
	char* pMem = (char*)malloc(requestedBytes);
	AllocHeader* pHeader = (AllocHeader*)pMem;
	pHeader->iSignature = 0xDEADC0DE;
	pHeader->pHeap = h;
	pHeader->iSize = size;
	h->AddAllocation(size);

	void* pStartMemBlock = pMem + sizeof(AllocHeader);
	int* pEndMarker = (int*)((char*)pStartMemBlock + size);
	*pEndMarker = 0xDEADBEEF;
	return pStartMemBlock;
}

void* operator new(size_t size, Heap* heap)
{
	size_t requestedBytes = size + sizeof(AllocHeader) + sizeof(int);
	char* pMem = (char*)malloc(requestedBytes);
	AllocHeader* pHeader = (AllocHeader*)pMem;
	pHeader->iSignature = 0xDEADC0DE;
	pHeader->pHeap = heap;
	pHeader->iSize = size;
	
	void* pStartMemBlock = pMem + sizeof(AllocHeader);

	int* pEndMarker = (int*)((char*)pStartMemBlock + size);
	*pEndMarker = 0xDEADBEEF;

	heap->AddAllocation(size);


	return pStartMemBlock;
}

void operator delete(void* pMem)
{
	if (pMem != NULL) {

		AllocHeader* pHeader = (AllocHeader*)((char*)pMem - sizeof(AllocHeader));

		pHeader->iSignature;

		assert(pHeader->iSignature == 0xDEADC0DE);
		int* pEndMarker = (int*)((char*)pMem + pHeader->iSize);
		assert(*pEndMarker == 0xDEADBEEF);
		pHeader->pHeap->RemoveAllocation(pHeader->iSize);

		free(pHeader);
	}
}