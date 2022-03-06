#pragma once
#include "en_engine.h"
#include "en_win32_window.h"
#include "rl_coordiate_system_elements.h"

using namespace GLEngine;

namespace RendererLib
{
	public ref class CoordinateSystem
	{
	private:
		Win32Window* _window;
		CoordinateSystemElements* _elements;

	public:
		int HalfWidth;
		int HalfHeight;

	public:
		CoordinateSystem(void* hWnd, int width, int height);

	public:
		void Logic();
		void Resize(int width, int height);

	private:
		void InputLogic();
	};
}


