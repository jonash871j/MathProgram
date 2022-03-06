
#pragma once
#include "en_def.h"

namespace GLEngine
{
	class Core
	{
	public:
		export static void Terminate();
		export static void InitGlew();
		export static void LoadShaders();

	public:
		static void GLLogClearError();
		static bool GLLogCall(const char* function, const char* file, int line);
	};
}