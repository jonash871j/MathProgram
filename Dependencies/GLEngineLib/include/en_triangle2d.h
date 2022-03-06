#pragma once
#include "en_polygon.h"

namespace GLEngine
{
	struct Triangle2D : public Polygon
	{
	public:
		vec2 a;
		vec2 b;
		vec2 c;

	public:
		Triangle2D(vec2 a, vec2 b, vec2 c)
			: a(a), b(b), c(c)
		{
		}

	public:
		vector<float> GetVerticies() override
		{
			return { a.x, a.y, b.x, b.y, c.x, c.y, };
		}
	};
}