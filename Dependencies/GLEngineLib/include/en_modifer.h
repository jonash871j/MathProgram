#pragma once
#include "en_def.h"
#include "en_resource_manager.h"

namespace GLEngine
{
	enum class export PolygonMode
	{
		Point = 0x1B00,
		Line = 1, 
		Triangle = 0x1B01,
		Fill = 0x1B02,
	};

	class Modifier
	{
	private:
		vec3 _offset;
		vec3 _rotation;
		vec3 _scale;
		vec3 _color;
		vec3 _textCursorPos;
		float _fontSize;
		float _alpha;
		float _lineWidth;
		PolygonMode _polygonMode;
		Font* _font = nullptr;

	public:
		export Modifier();

	public:
		export Modifier& SetDefault();
		export Modifier& SetOffset(vec2 offset);
		export Modifier& SetOffset(vec3 offset);
		export Modifier& SetRotation(float angle);
		export Modifier& SetScale(vec2 scale);
		export Modifier& SetScale(vec3 scale);
		export Modifier& SetColor(vec3 color);
		export Modifier& SetTextCursorPos(vec2 textCursorPos);
		export Modifier& SetTextCursorPos(vec3 textCursorPos);
		export Modifier& SetFontSize(float fontSize);
		export Modifier& SetAlpha(float alpha);
		export Modifier& SetLineWidth(float lineWidth);
		export Modifier& SetPolygonMode(PolygonMode polygonMode);
		export Modifier& SetFont(Font& font);
		export vec3 GetOffset();
		export vec3 GetRotation();
		export vec3 GetScale();
		export vec3 GetColor();
		export vec3 GetTextCursorPos();
		export float GetFontSize();
		export float GetAlpha();
		export PolygonMode GetPolygonMode();
		export float GetLineWidth();
		export Font& GetFont();

	public:
		template<typename Enum>
		Modifier& SetFont(Enum fontKey)
		{
			return SetFont(ResourceManager::GetFont((int)fontKey));
		}
	};
}