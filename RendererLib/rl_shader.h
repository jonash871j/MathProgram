#pragma once
#include "rl_shader_program.h"

namespace RendererLib
{
	class Shader
	{
	public:
		enum class Type
		{
			Vertex = 0x8B31,
			Fragment = 0x8B30,
		};

	public:
		Shader();
		Shader(const char* source, const char* name, Shader::Type type, ShaderProgram& program);
		Shader(const char* path, Shader::Type type, ShaderProgram& program);
		~Shader();

	public:
		void CreateShader(const char* source, const char* name, Shader::Type type, ShaderProgram& program);
		void LoadShader(const char* path, Shader::Type type, ShaderProgram& program);
	};
}
