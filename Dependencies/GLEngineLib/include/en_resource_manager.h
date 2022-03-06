#pragma once
#include "en_def.h"
#include "en_true_type_font.h"
#include "en_bitmap_font.h"

namespace GLEngine
{
	enum class ShaderKey
	{
		Screen,
		Texture2D,
		Texture3D,
		Cube3D,
		Line3D,
		Primitive2D,
		TrueTypeFont,
	};

	class ResourceManager
	{
	public:
		template<typename Enum>
		static void LoadTexture(Enum key, const char* path)
		{
			LoadTexture((int)key, path);
		}
		export static void LoadTexture(int key, const char* path);

		template<typename Enum>
		static Texture& GetTexture(Enum key)
		{
			return GetTexture((int)key);
		}
		export static Texture& GetTexture(int key);

		template<typename Enum>
		static void LoadTrueTypeFont(Enum key, const char* path)
		{
			LoadTrueTypeFont((int)key, path);
		}
		export static void LoadTrueTypeFont(int key, const char* path);

		template<typename Enum>
		static void LoadBitmapFont(Enum key, BitmapFont* bitmapFont)
		{
			LoadBitmapFont((int)key, bitmapFont);
		}
		export static void LoadBitmapFont(int key, BitmapFont* bitmapFont);

		template<typename Enum>
		static Font& GetFont(Enum key)
		{
			return GetFont((int)key);
		}
		export static Font& GetFont(int key);

		template<typename Enum1, typename Enum2>
		static void LoadSound(Enum1 soundKey, Enum2 channelKey, const char* path)
		{
			LoadSound((int)soundKey, (int)channelKey, path);
		}
		export static void LoadSound(int soundKey, int channelKey, const char* path);

		template<typename Enum>
		static Sound& GetSound(Enum soundKey)
		{
			return GetSound((int)soundKey);
		}
		export static Sound& GetSound(int soundKey);

		static void LoadShader(ShaderKey key, const char* vertexPath, const char* fragmentPath);
		static Shader& GetShader(ShaderKey key);
	};
}