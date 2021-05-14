#pragma once
#include <stdint.h>

namespace RendererLib
{
	class ShaderProgram
	{
	private:
		uint32_t id;
		bool isLinked = false;

	public:
		ShaderProgram();

	public:
		void Link();

	public:
		uint32_t& GetId();
		bool GetIsLinked();

	public:
		static ShaderProgram CreateSpriteProgram();
	};
}
