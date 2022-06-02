#include "rl_coordiate_system_elements.h"
#include "rl_color.h"
#include "en_drawing.h"

using namespace std;
using namespace System;

namespace RendererLib
{
	static void MarshalString(String^ s, string& os) {
		using namespace Runtime::InteropServices;
		const char* chars =
			(const char*)(Marshal::StringToHGlobalAnsi(s)).ToPointer();
		os = chars;
		Marshal::FreeHGlobal(IntPtr((void*)chars));
	}

	CoordinateSystemElements::CoordinateSystemElements(Window& window)
		: window(window), renderer(window.GetRenderer()), modifier(renderer.GetModifier())
	{
	}

	static GLEngine::Drawing::Grid grid;

	void CoordinateSystemElements::DrawGrid()
	{
		modifier.SetDefault()
			.SetColor(VecColor::FromRGB(48, 48, 48));
		renderer.DrawGeometry(grid);
	}

	void CoordinateSystemElements::DrawShape(IShape^ shape)
	{
		for each (Line^ line in shape->Shape()->Lines)
		{
			modifier.SetDefault()
				.SetOffset({window.GetWidth() / 2, window.GetHeight() / 2 })
				.SetColor(VecColor::FromRGB(line->Color.R, line->Color.G, line->Color.B))
				.SetLineWidth(line->LineWidth);
			renderer.DrawLine(vec2(zoom * line->A->X, zoom * -line->A->Y), vec2(zoom * line->B->X, zoom * -line->B->Y));

			if (!String::IsNullOrEmpty(line->Text))
			{
				std::string str = "";
				MarshalString(line->Text, str);
				modifier.SetDefault()
					.SetFont(0)
					.SetOffset({ window.GetWidth() / 2, window.GetHeight() / 2 })
					.SetFontSize(0.25f)
					.SetTextCursorPos({ (line->B->X + line->A->X) / 2, (line->B->Y + line->A->Y) / 2 });
				renderer.DrawTextf("%s", str.c_str());
			}
		}
	}
	void CoordinateSystemElements::DrawPoints(IPoints^ points)
	{
		for each (Point2D^ point in points->Points())
		{
			modifier.SetDefault()
				.SetOffset({ window.GetWidth() / 2, window.GetHeight() / 2 })
				.SetColor(VecColor::FromRGB(point->Color.R, point->Color.G, point->Color.B));
			renderer.DrawCircle(vec2(zoom * point->X - 4, zoom * -point->Y + 4), { 8, 8 }, 12);

		/*	if (!String::IsNullOrEmpty(point->Text))
			{
				String^ csStr = point->ToString();
				std::string str = "";
				MarshalString(csStr, str);
				modifier.SetDefault()
					.SetFont(0)
					.SetFontSize(0.25f)
					.SetTextCursorPos({ point->X, point->Y });
				renderer.DrawTextf("%s", str.c_str());
			}*/
		}
	}

	void CoordinateSystemElements::UpdateGrid()
	{
		grid.size = { zoom, zoom };
		grid.startPos = { (window.GetWidth() / 2) % (int)grid.size.x,  (window.GetHeight() / 2) % (int)grid.size.y};
		grid.endPos = { window.GetWidth(), window.GetHeight() };
		grid.isBinded = false;
	}
}