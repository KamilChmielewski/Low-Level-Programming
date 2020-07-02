#pragma once
#include "Vec3.h"
#include "Struct.h"
#include "HeapFactory.h"
#include <atomic>

#define NEWOPERATOR

class Sphere
{
private:
	static Heap* s_pHeap;

public:
	Vec3f center;            /// position of the sphere
	Vec3f Velocity;
	float radius, radius2;     /// sphere radius and radius^2
	Vec3f surfaceColor, emissionColor;      /// surface color and emission (light)
	float transparency, reflection;         /// surface transparency and reflectivity
	float radiusIncrement;		/// Changes the radius size of the object each frame
	
	
	Sphere(
		const Vec3f& c,
		const float& r,
		const Vec3f& sc,
		const float& refl = 0,
		const float& transp = 0,
		const Vec3f & ec = 0);

	~Sphere();
	//[comment]
	// Compute a ray-sphere intersection using the geometric solution
	//[/comment]
	bool intersect(const Vec3f& rayorig, const Vec3f& raydir, float& t0, float& t1, float itteration) 
	{
		Vec3f Position = center + Velocity * itteration;

		float Radius = radius2 + radiusIncrement * itteration;
		
		Vec3f l = Position - rayorig;
		float tca = l.dot(raydir);
		if (tca < 0) return false;
		float d2 = l.dot(l) - tca * tca;
		if (d2 > Radius) return false;
		float thc = sqrt(Radius - d2);
		t0 = tca - thc;
		t1 = tca + thc;

		return true;
	}


	void* operator new (size_t size);
	void operator delete(void* p, size_t size);

	const char* getName() const { return s_pHeap->getName(); }

	void SetRadius2(float increment);
	void SetVelocity(Vec3f vel) { Velocity = vel; }

	void Update(int frame);
};