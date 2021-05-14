#include "rl_shader_program.h"
#include "rl_shader.h"

#include <GL/glew.h>
#include <stdlib.h>

namespace RendererLib
{
	ShaderProgram::ShaderProgram()
	{

		id = glCreateProgram();
	}
	void ShaderProgram::Link()
	{
		int32_t success;

		glLinkProgram(id);
		glGetProgramiv(id, GL_LINK_STATUS, &success);

		isLinked = true;

		glUseProgram(NULL);
	}
	uint32_t& ShaderProgram::GetId()
	{
		return id;
	}

	bool ShaderProgram::GetIsLinked()
	{
		return isLinked;
	}
}
