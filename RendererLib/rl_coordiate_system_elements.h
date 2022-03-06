#pragma once
#include "en_engine.h"
#include "en_win32_window.h"

using namespace GLEngine;

namespace RendererLib
{
	class CoordinateSystemElements
	{
	private:
		Window& window;
		Renderer& renderer;
		Modifier& modifier;

	public:
		CoordinateSystemElements(Window& window);

	public:
		void DrawGrid();
	};
}
