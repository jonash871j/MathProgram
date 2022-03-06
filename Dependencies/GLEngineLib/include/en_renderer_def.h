#pragma once
#include "en_def.h"

namespace GLEngine
{
	struct Polygon3D abstract
	{
		virtual vector<float> GetVerticies() = 0;
	};

	struct Line3D : public Polygon3D
	{
		vec3 a;
		vec3 b;

		Line3D(vec3 a, vec3 b)
			: a(a), b(b)
		{

		}

		vector<float> GetVerticies() override
		{
			return vector<float>
			{
				a.x, a.y, a.z, b.x, b.y, b.z
			};
		}
	};

	struct Plane3D : public Polygon3D
	{
		vec3 a;
		vec3 b;
		vec3 c;
		vec3 d;

		Plane3D(vec3 a, vec3 b, vec3 c, vec3 d)
			: a(a), b(b), c(c), d(d)
		{

		}

		vector<float> GetVerticies() override
		{
			return vector<float>
			{
				a.x, a.y, a.z, b.x, b.y, b.z, d.x, d.y, d.z,
				d.x, d.y, d.z, c.x, c.y, c.z, b.x, b.y, b.z,
			};
		}
	};

	struct Shape3D
	{
		vector<Polygon3D*> polygons;
		vector<float>* verticies = nullptr;
		bool isCreated = false;

		~Shape3D()
		{
			verticies->clear();
			delete verticies;
		}

		void DefineVerticies()
		{
			vector<float>* verticies = new vector<float>();
			for (size_t i = 0; i < polygons.size(); i++)
			{
				vector<float> polyVerticies = polygons[i]->GetVerticies();
				for (size_t j = 0; j < polyVerticies.size(); j++)
				{
					verticies->push_back(polyVerticies[j]);
				}
				polyVerticies.clear();
				delete polygons[i];
			}

			polygons.clear();
			vector<float>* verticiesOld = this->verticies;

			this->verticies = verticies;

			if (verticiesOld != nullptr)
			{
				verticiesOld->clear();
				delete verticiesOld;
			}

			isCreated = true;
		}
	};
}