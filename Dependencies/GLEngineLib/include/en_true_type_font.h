#pragma once
#include "en_def.h"
#include "en_font.h"

namespace GLEngine
{
	//struct Character {
	//	unsigned int TextureID;  // ID handle of the glyph texture
	//	glm::ivec2   Size;       // Size of glyph
	//	glm::ivec2   Bearing;    // Offset from baseline to left/top of glyph
	//	unsigned int Advance;    // Offset to advance to next glyph
	//};

	class TrueTypeFont : public Font
	{
	private:
		//map<char, Character> Characters;
		int _fontResolution = 0;

	public:
		TrueTypeFont(const char* path);

	//public:
	//	map<char, Character> GetCharacters();
	//	int GetResolution();
	};
}

