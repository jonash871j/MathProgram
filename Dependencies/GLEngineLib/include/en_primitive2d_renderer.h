#pragma once
#include "en_def.h"
#include "en_shader.h"
#include "en_renderer_base.h"

namespace GLEngine
{
	class Primitive2DRenderer abstract : public virtual RendererBase
	{
    private:
        Shader& _primitiveShader;

    public:
        Primitive2DRenderer();

    public:
        export void DrawLine(vec2 a, vec2 b);
        export void DrawTriangle(vec2 a, vec2 b, vec2 c);
        export void DrawRectangle(vec2 pos, vec2 size);
        export void DrawRectangle(vec2 a, vec2 b, vec2 c, vec2 d);
        export void DrawCircle(vec2 pos, float radius, int edges = 32);
        export void DrawCircle(vec2 pos, float xRadius, float yRadius, int edges = 32);

    protected:
        void UpdateShader();

    private:
        void DrawPrimitive(float* vertices, size_t vertexAmount, GLenum mode = GL_TRIANGLES);
	};
}

