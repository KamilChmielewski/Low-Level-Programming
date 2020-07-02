#include "HeapFactory.h"

std::vector<Heap*> HeapFactory::heapVector;
Heap* HeapFactory::defualtHeap;

Heap* HeapFactory::CreateHeap(const char* szName)
{
	Heap* heap = new Heap(szName);
	heapVector.push_back(heap);
	return heap;
}

void HeapFactory::CreateDefualtHeap()
{
	char* heap = (char*)malloc(sizeof(Heap));
	defualtHeap = (Heap*)heap;
	defualtHeap->SetName("defualt");
	heapVector.push_back(defualtHeap);
}

Heap* HeapFactory::GetDefaultHeap()
{
	if (defualtHeap == nullptr)
	{
		CreateDefualtHeap();
	}

	return defualtHeap;
}