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
		unsigned _trueTypeVAO;
		unsigned _trueTypeVBO;

	public:
		TextRenderer();

	public:
		export void DrawTextf(const char* format, ...);
		export void Draw3DTextf(const char* format, ...);

	protected:
		void UpdateShader();

	private:
		void DrawBitmapText(const char* text, bool is3D);
		void DrawTrueTypeText(const char* text);
		void InitRenderData();
	};
}