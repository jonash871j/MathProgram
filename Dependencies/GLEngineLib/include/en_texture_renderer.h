#pragma once
#include "en_def.h"
#include "en_texture.h"
#include "en_shader.h"
#include "en_renderer_base.h"
#include "en_resource_manager.h"

namespace GLEngine
{
	class TextureRenderer abstract : public virtual RendererBase
	{
    private:
        unsigned int _textureVAO;
        Shader& _texture2DShader;
        Shader& _texture3DShader;

    public:
        TextureRenderer();

    public:
        template<typename Enum>
        void DrawTexSquare(Enum textureKey, vec2 position)
        {
            DrawTexSquare(ResourceManager::GetTexture((int)textureKey), position);
        }
        export void DrawTexSquare(Texture& texture, vec2 position);

        template<typename Enum>
        void Draw3DTexSquare(Enum textureKey, vec3 position)
        {
            Draw3DTexSquare(ResourceManager::GetTexture((int)textureKey), position);
        }
        export void Draw3DTexSquare(Texture& texture, vec3 position);

    protected:
        void UpdateShader();
        void InitRenderData();
	};
}


