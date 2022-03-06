#pragma once
#include "en_def.h"

namespace GLEngine
{
	struct ImageData
	{
		const char* path = nullptr;
		int width = 0;
		int height = 0;
		unsigned* data;

		~ImageData()
		{
			delete data;
		}
	};

	class FileReader
	{
	public:
		static ImageData* LoadImage(const char* path);
	};
}

