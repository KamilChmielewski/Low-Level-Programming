#include "ObjectJsonParse.h"
#include <iostream>
#include <fstream>
#include <cstdlib>
#include "rapidjson/filereadstream.h"
#include "rapidjson/writer.h"
#include "rapidjson/stringbuffer.h"
#include "rapidjson/istreamwrapper.h"
#include "Vec3.h"


using namespace rapidjson;

std::vector<Sphere*> SceneLoader::LoadAndCreateSphere(const char* filepath)
{
	std::vector<Sphere*> objects;

	FILE* fp = fopen(filepath, "r"); // non-Windows use "r"
	if (fp == NULL) perror("Error opening file");

	char readBuffer[16384];
	FileReadStream is(fp, readBuffer, sizeof(readBuffer));

	Document document;

	document.ParseStream(is);
	   	  
	if (document.HasMember("Spheres"))
	{
		const Value& spheresArray = document["Spheres"];
		assert(spheresArray.IsArray());
		float PosX = 0.0f, PosY = 0.0f, PosZ = 0.0f;
		float CenterX = 0.0f, CenterY = 0.0f, CenterZ = 0.0f;
		float Radius = 0.0f, Radius2 = 0.0f;
		float SurfaceColorX = 0.0f, SurfaceColorY = 0.0f, SurfaceColorZ = 0.0f;
		float EmissionX = 0.0f, EmissionY = 0.0f, EmissionZ = 0.0f;
		float Transparency = 0.0f;
		float Reflection = 0.0f;
		float RadiusIncrement = 0.0f;
		float VelocityX = 0.0f, VelocityY = 0.0f, VelocityZ = 0.0f;

		for (SizeType i = 0; i < spheresArray.Size(); i++)
		{
			const Value& element = spheresArray[i];
			//assert(element.IsArray());

			if (element.HasMember("Center"))
			{
				const Value& centerPos = element["Center"];
				assert(centerPos.IsArray());
				const Value& centerX = centerPos[0];
				const Value& centerY = centerPos[1];
				const Value& centerZ = centerPos[2];

				CenterX = centerX.GetFloat();
				CenterY = centerY.GetFloat();
				CenterZ = centerZ.GetFloat();
			}

			if (element.HasMember("Radius"))
					Radius = element["Radius"].GetFloat();
			if (element.HasMember("Radius2"))
					Radius2 = element["Radius2"].GetFloat();

			if (element.HasMember("SurfaceColor"))
			{
				const Value& SurfacePos = element["SurfaceColor"];
				assert(SurfacePos.IsArray());
				const Value& SurfacePosX = SurfacePos[0];
				const Value& SurfacePosY = SurfacePos[1];
				const Value& SurfacePosZ = SurfacePos[2];

				SurfaceColorX = SurfacePosX.GetFloat();
				SurfaceColorY = SurfacePosY.GetFloat();
				SurfaceColorZ = SurfacePosZ.GetFloat();
			}
			
			if (element.HasMember("EmissionColor"))
			{
				const Value& EmissionPos = element["EmissionColor"];
				assert(EmissionPos.IsArray());
				const Value& emissionX = EmissionPos[0];
				const Value& emissionY = EmissionPos[1];
				const Value& emissionZ = EmissionPos[2];

				EmissionX = emissionX.GetFloat();
				EmissionY = emissionY.GetFloat();
				EmissionZ = emissionZ.GetFloat();
			}

			if (element.HasMember("Velocity"))
			{
				const Value& Vel = element["Velocity"];
				assert(Vel.IsArray());
				const Value& VelX = Vel[0];
				const Value& VelY = Vel[1];
				const Value& VelZ = Vel[2];

				VelocityX = VelX.GetFloat();
				VelocityY = VelY.GetFloat();
				VelocityZ = VelZ.GetFloat();
			}

			if (element.HasMember("Transparency"))
					Transparency = element["Transparency"].GetFloat();
			if (element.HasMember("Reflection"))
					Reflection = element["Reflection"].GetFloat();

			if (element.HasMember("RadiusIncrement"))
				RadiusIncrement = element["RadiusIncrement"].GetFloat();

			Sphere* temp = new Sphere(Vec3f(CenterX, CenterY, CenterZ), Radius, Vec3f(SurfaceColorX, SurfaceColorY, SurfaceColorZ),
				Reflection, Transparency, Vec3f(EmissionX, EmissionY, EmissionZ));
			temp->SetRadius2(RadiusIncrement);
			temp->SetVelocity(Vec3f(VelocityX, VelocityY, VelocityZ));
			objects.push_back(temp);

		}
	}

	return objects; 
}