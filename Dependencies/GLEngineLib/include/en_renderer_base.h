#pragma once
#include "en_def.h"
#include "en_shader.h"
#include "en_modifer.h"
#include "en_camera.h"
#include "en_renderer_def.h"

namespace GLEngine
{
	class RendererBase abstract
 	{
	protected:
		Window& _window;
		Modifier _modifier;
		Camera _camera;
		vec3 _backgroundColor = { 0.0f, 0.0f, 0.0f };

	private:
		bool _isDepthEnabled = false;
		unsigned _fbo;
		unsigned _rbo;
		unsigned _screenVAO;
		unsigned _textureColorbuffer;
		Shader _screenShader;

	public:
		export RendererBase(Window& window);

	public:
		export void SetBackgroundColor(vec3 color);
		export Modifier& GetModifier();
		export Camera& GetCamera();

	protected:
		void UpdateFramebuffer();
		void Update();
		mat4 Get3DProjectionMatrix();
	};
}