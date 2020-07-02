#pragma once
#include "Sphere.h"
#include "Vec3.h"
#include <vector>
#include "rapidjson/document.h"
#include <string>

class SceneLoader
{
private:

public:
	std::vector<Sphere*> LoadAndCreateSphere(const char* filePath);

};

/*
	JSONParse
	SceneLoader

*/