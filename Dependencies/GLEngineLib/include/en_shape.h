#pragma once
#include "en_def.h"
#include "en_polygon.h"

#include "en_line2d.h"
#include "en_triangle2d.h"

namespace GLEngine
{
	class Shape
	{
	private:
		vector<Polygon*> _polygons;
		vector<float>* _verticies = nullptr;
		bool _isDefined = false;

	public:
		void DefineVerticies();

	public:
		void AddPolygon(Polygon* polygon);
	};
}

