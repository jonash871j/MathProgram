#pragma once
#include "en_def.h"

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
		float _alpha;
		float _lineWidth;
		PolygonMode _polygonMode;

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
		export Modifier& SetAlpha(float alpha);
		export Modifier& SetLineWidth(float lineWidth);
		export Modifier& SetPolygonMode(PolygonMode polygonMode);
		export vec3 GetOffset();
		export vec3 GetRotation();
		export vec3 GetScale();
		export vec3 GetColor();
		export float GetAlpha();
		export PolygonMode GetPolygonMode();
		export float GetLineWidth();
	};
}