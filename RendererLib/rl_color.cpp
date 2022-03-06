#include "rl_color.h"

namespace RendererLib
{
	vec3 VecColor::FromRGB(int r, int g, int b)
	{
		float step = 1.0f / 255.0f;
		return { step * r, step * g, step * b };
	}
}

