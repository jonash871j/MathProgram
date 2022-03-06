#pragma once
#include "en_def.h"

namespace GLEngine
{
	struct Polygon
	{
		virtual vector<float> GetVerticies() = 0;
	};
}

