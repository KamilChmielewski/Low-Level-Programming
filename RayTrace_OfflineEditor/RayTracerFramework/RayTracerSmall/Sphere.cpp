#include "Sphere.h"
#include <iostream>

Heap* Sphere::s_pHeap = nullptr;

Sphere::Sphere(const Vec3f& c,
	const float& r,
	const Vec3f& sc,
	const float& refl ,
	const float& transp ,
	const Vec3f & ec) : center(c), radius(r), radius2(r* r), surfaceColor(sc), emissionColor(ec),
	transparency(transp), reflection(refl)
{
	//std::cout << "Sphere created" << std::endl;#
}

Sphere::~Sphere()
{
	//std::cout << "Sphere deleted" << std::endl;
}

void Sphere::SetRadius2(float increment)
{
	radiusIncrement = increment;
}

void Sphere::Update(int frame)
{

}

void* Sphere::operator new(size_t size)
{
	std::cout << "new being called" << std::endl;
	if (s_pHeap == nullptr)
	{
		s_pHeap = HeapFactory::CreateHeap("Sphere Object");
	}
	return ::operator new(size, s_pHeap);
}

void Sphere::operator delete(void* p, size_t size)
{
	::operator delete(p);
}