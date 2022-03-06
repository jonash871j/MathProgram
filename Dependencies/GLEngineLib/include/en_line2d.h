#pragma once
#include "en_polygon.h"

namespace GLEngine
{
	struct Line2D : public Polygon
	{
	public:
		vec2 a;
		vec2 b;

	public:
		Line2D(vec2 a, vec2 b) 
			: a(a), b(b) 
		{
		}

	public:
		vector<float> GetVerticies() override
		{
			return { a.x, a.y, b.x, b.y };
		}
	};
}