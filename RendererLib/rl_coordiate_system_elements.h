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
	public:
		float zoom = 32.0f;
		float xRel = 1.0f;
		float yRel = 1.0f;

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
		void UpdateGrid();
	};
}
