#pragma once
#include <vector>
#include "Heap.h"

class HeapFactory
{
private:
	static std::vector<Heap*> heapVector;
	static Heap* defualtHeap;
public:
	static Heap* CreateHeap(const char* szName);
	static void CreateDefualtHeap();
	static Heap* GetDefaultHeap();

};