#include "rl_coordiate_system_elements.h"
#include "rl_color.h"

namespace RendererLib
{
	CoordinateSystemElements::CoordinateSystemElements(Window& window)
		: window(window), renderer(window.GetRenderer()), modifier(renderer.GetModifier())
	{
	}

	void CoordinateSystemElements::DrawGrid()
	{
		modifier.SetColor(VecColor::FromRGB(48, 48, 48));
		for (float y = -50; y < 50; y++)
		{
			if (y == 0)
			{
				continue;
			}
			renderer.Draw3DLine({ -50, y, 0 }, { 50, y, 0 });
		}
		for (float x = -50; x < 50; x++)
		{
			if (x == 0)
			{
				continue;
			}
			renderer.Draw3DLine({ x, -50, 0 }, { x, 50, 0 });
		}
	}
}