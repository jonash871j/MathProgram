#include "rl_coordiate_system_elements.h"
#include "rl_color.h"

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

	void CoordinateSystemElements::DrawShape(IShape^ shape)
	{
		for each (Line^ line in shape->Shape()->Lines)
		{
			modifier.SetDefault()
				.SetColor(VecColor::FromRGB(line->Color.R, line->Color.G, line->Color.B))
				.SetLineWidth(line->LineWidth);
			renderer.Draw3DLine({ line->A->X, line->A->Y, 0 }, { line->B->X, line->B->Y, 0 });

			if (!String::IsNullOrEmpty(line->Text))
			{
				std::string str = "";
				MarshalString(line->Text, str);
				modifier.SetDefault()
					.SetFont(0)
					.SetFontSize(0.01f)
					.SetTextCursorPos({ (line->B->X + line->A->X) / 2, (line->B->Y + line->A->Y) / 2, 0 });
				renderer.Draw3DTextf("%s", str.c_str());
			}
		}
	}
	void CoordinateSystemElements::DrawPoints(IPoints^ points)
	{
		for each (Point2D^ point in points->Points())
		{
			modifier.SetDefault()
				.SetScale({0.049f, 0.049f, 0.049f})
				.SetColor(VecColor::FromRGB(point->Color.R, point->Color.G, point->Color.B));
			renderer.Draw3DCube({ point->X - 0.025, point->Y - 0.025, -0.025 });
			modifier.SetPolygonMode(PolygonMode::Triangle)
				.SetScale({0.05f, 0.05f, 0.05f})
				.SetLineWidth(2)
				.SetColor(VecColor::FromRGB(point->Color.R / 2, point->Color.G / 2, point->Color.B / 2));
			renderer.Draw3DCube({ point->X - 0.025, point->Y - 0.025, -0.025 });

			if (!String::IsNullOrEmpty(point->Text))
			{
				String^ csStr = point->ToString();
				std::string str = "";
				MarshalString(csStr, str);
				modifier.SetDefault()
					.SetFont(0)
					.SetFontSize(0.01f)
					.SetTextCursorPos({ point->X, point->Y, 0.1f });
				renderer.Draw3DTextf("%s", str.c_str());
			}
		}
	}
}