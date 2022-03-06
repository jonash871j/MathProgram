#pragma once
#include "en_def.h"

namespace GLEngine
{
	class Shader
	{
	private:
		unsigned _id;

	public:
		Shader(const char* vertexPath, const char* fragmentPath);

	public:
		int GetId();
		void Use();

		void SetBool(const char* name, bool value);
		void SetInt(const char* name, int value);
		void SetFloat(const char* name, float value);
		void SetMat4(const char* name, mat4 value);
		void SetVec2(const char* name, vec2 value);
		void SetVec3(const char* name, vec3 value);
		void SetVec4(const char* name, vec4 value);

	private:
		void CreateShader(char* source, const char* name, int type);
		void CreateShaderProgram();
	};
}