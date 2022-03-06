#pragma once
#include "en_def.h"
#include "en_primitive2d_renderer.h"
#include "en_primitive3d_renderer.h"
#include "en_texture_renderer.h"
#include "en_text_renderer.h"

namespace GLEngine
{
	class Renderer final : 
		public virtual Primitive2DRenderer, 
		public virtual Primitive3DRenderer, 
		public virtual TextureRenderer, 
		public virtual TextRenderer
	{
		friend Window;
	public:
		Renderer(Window& window);

	public:
		export void UpdateFramebuffer();
		export void SetInitShaders();
		export void Update();
	};
}

