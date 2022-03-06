#pragma once
#include "en_def.h"
#include "en_shader.h"
#include "en_font.h"
#include "en_texture_renderer.h"

namespace GLEngine
{
	class TextRenderer abstract : public virtual TextureRenderer
	{
	private:
		Shader& _trueTypeShader;
		Font* _font = nullptr;
		vec2 _cursorPos = { 0, 0 };
		float _textSize = 1.0f;
		unsigned _trueTypeVAO;
		unsigned _trueTypeVBO;

	public:
		TextRenderer();

	public:
		template<typename Enum>
		void SetTextFont(Enum fontKey)
		{
			SetTextFont(ResourceManager::GetFont((int)fontKey));
		}
		export void SetTextFont(Font& font);
		export void SetTextCursorPos(vec2 cursorPos);
		export void SetTextSize(float textSize);
		export void PrintTextf(const char* format, ...);

	protected:
		void UpdateShader();

	private:
		void PrintBitmapText(const char* text);
		void PrintTrueTypeText(const char* text);
		void InitRenderData();
	};
}