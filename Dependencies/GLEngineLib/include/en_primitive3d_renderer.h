#include "en_def.h"
#include "en_renderer_base.h"

namespace GLEngine
{
    class Primitive3DRenderer abstract : public virtual RendererBase
    {
    private:
        unsigned int _cubeVAO;
        Shader& _cubeShader;

    public:
        Primitive3DRenderer();

    public:
        export void Draw3DLine(vec3 a, vec3 b);
        export void Draw3DPlane(vec3 a, vec3 b, vec3 c, vec3 d);
        export void Draw3DShape(Shape3D& shape);
        export void Draw3DCube(vec3 pos);

    protected:
        void UpdateShader();
        void InitRenderData();

    private:
        void Draw3DPrimitive(float* vertices, int vertexAmount, GLenum mode = GL_TRIANGLES);
    };
}
