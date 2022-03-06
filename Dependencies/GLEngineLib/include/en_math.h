#pragma once
#include "en_def.h"

namespace GLEngine::Math
{
	const float PI = 3.14159265358979323846f;

	export float Pow(float x, float y);
	export float Sqrt(float x);
		   
	export float Sin(float x);
	export float SinDeg(float x);
	export float Cos(float x);
	export float CosDeg(float x);
	export float Tan(float x);
	export float Sec(float x);
	export float Cot(float x);
	export float Csc(float x);
		   
	export float ASin(float x);
	export float ACos(float x);
	export float ATan(float x);
		   
	export float Log(float x);
		   
	export float Abs(float x);
	export float Floor(float x);
	export float Ceil(float x);
	export float Sign(float x);

	export float DistanceToPoint(vec2 p1, vec2 p2);
	export float DistanceToPoint(vec3 p1, vec3 p2);
		   
	export float Random(float min, float max);
	export int Random(int min, int max);

	template<typename T>
	static void Limit(T& value, T min, T max)
	{
		if (value < min)
		{
			value = min;
		}
		else if (value > max)
		{
			value = max;
		}
	}
}