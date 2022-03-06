#pragma once
#include "en_engine.h"
#include "en_win32_window.h"

using namespace GLEngine;
using namespace MathLib;
using namespace MathLib::Geometry;
using namespace System::Collections::Generic;

namespace RendererLib
{
	ref class CoordinateSystemElements
	{
	private:
		Window& window;
		Renderer& renderer;
		Modifier& modifier;

	public:
		CoordinateSystemElements(Window& window);

	public:
		void DrawGrid();
		void DrawShape(IShape^ shape);
		void DrawPoints(IPoints ^ points);
	};
}
