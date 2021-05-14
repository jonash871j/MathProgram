#pragma once

#include <stdint.h>

namespace RendererLib 
{
	static public ref class Draw
	{
	public:
		static void Init();

		static void Setup(int width, int height);
		static void Begin();
		static void End();
		static void Clear();

	public:
		static void Color(uint8_t r, uint8_t g, uint8_t b);
		static void Point(double x, double y, int size);
		static void Line(double x1, double y1, double x2, double y2, int thickness);
		static void Line(double x1, double y1, double x2, double y2, int thickness, bool isDotted);

	};
}
