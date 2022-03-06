#pragma once
#include "en_def.h"
#include "en_input.h"

namespace GLEngine
{
	class Window abstract
	{
	protected:
		int _width;
		int _height;
		int _windowWidth;
		int _windowHeight;
		Renderer* _renderer = nullptr;
		SoundSystem* _soundSystem = nullptr;
		Time* _time = nullptr;
		Input* _input = nullptr;

	public:
		export Window();
		export Window(int windowWidth, int windowHeight);

	public:
		export virtual void SetLogicalSize(int width, int height) = 0;
		export void Update();
		export int GetWidth();
		export int GetHeight();
		export int GetWindowWidth();
		export int GetWindowHeight();
		export Renderer& GetRenderer();
		export SoundSystem& GetSoundSystem();
		export Time& GetTime();
		export Input& GetInput();

	public:
		export void InitalizeWindowComponents();
		virtual void InternalSwapBuffers() = 0;

	protected:
		virtual void InternalUpdate() = 0;
	};
}
