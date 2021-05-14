#include "rl_shader.h"

#include <GL/glew.h>
#include <iostream>

namespace RendererLib
{
	Shader::Shader()
	{
	}
	Shader::Shader(const char* source, const char* name, Shader::Type type, ShaderProgram& program)
	{
		CreateShader(source, name, type, program);
	}
	Shader::Shader(const char* path, Shader::Type type, ShaderProgram& program)
	{
		LoadShader(path, type, program);
	}
	Shader::~Shader()
	{
	
	}

	void Shader::CreateShader(const char* source, const char* name, Shader::Type type, ShaderProgram& program)
	{
		int32_t success = 0;
		uint32_t shader = glCreateShader((int32_t)type);
		glShaderSource(shader, 1, &source, NULL);
		glCompileShader(shader);
		glGetShaderiv(shader, GL_COMPILE_STATUS, &success);

		if (!success)
		{
			char infoLog[1024]{ 0 };
			glGetShaderInfoLog(shader, 1024, NULL, infoLog);
		}
		else
		{
			glAttachShader(program.GetId(), shader);
		}

		// Clear memory
		glDeleteShader(shader);
	}
}
