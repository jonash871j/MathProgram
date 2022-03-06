#include "rl_coordinate_system.h"
#include "rl_color.h"

namespace RendererLib
{
	template < class T, class U >
	bool isinst(U u) {
		return dynamic_cast<T>(u) != nullptr;
	}

	CoordinateSystem::CoordinateSystem(void* hWnd, int width, int height)
	{
		_window = new Win32Window((HWND)hWnd, width, height);
		ResourceManager::LoadBitmapFont(0,
			BitmapFont::Create(8, 16, 99, 1)->LoadAsAsciiFormat("Bitmap Fonts/font.png", 32));
		_elements = gcnew CoordinateSystemElements(*_window);

		Renderer& renderer = _window->GetRenderer();
		Input& input = _window->GetInput();
		Camera& camera = renderer.GetCamera();

		renderer.SetBackgroundColor(VecColor::FromRGB(16, 16, 16));

		camera.SetPosition({ 0, 0, 50 });
		//camera.SetYaw(180.0f);
	}
	float as = 0.0f;
	void CoordinateSystem::Logic()
	{
		Window& window = *_window;
		Renderer& renderer = _window->GetRenderer();
		Modifier& modifier = renderer.GetModifier();
		Camera& camera = renderer.GetCamera();
		Time& time = _window->GetTime();

		InputLogic();
		HalfWidth = (window.GetWidth() / camera.GetPosition().z + camera.GetPosition().z);
		HalfHeight = (window.GetHeight() / camera.GetPosition().z + camera.GetPosition().z) / 2.0f;

		modifier.SetDefault()
			.SetColor(VecColor::FromRGB(192, 192, 192));
		renderer.Draw3DLine({ -999990, 0, 0 }, { 99999, 0, 0 });
		renderer.Draw3DLine({ 0, -99999, 0 }, { 0, 99999, 0 });
		renderer.Draw3DLine({ 0, 0, -99999 }, { 0, 0, 99999 });

		for each (IGeometry^ geometry in _geometries)
		{
			if (isinst<IShape^>(geometry))
			{
				_elements->DrawShape((IShape^)geometry);
			}
			if (isinst<IPoints^>(geometry))
			{
				_elements->DrawPoints((IPoints^)geometry);
			}
		}

		glm::vec3 cameraPos = camera.GetPosition();
		modifier.SetDefault()
			.SetTextCursorPos({ 0, 0 })
			.SetFontSize(2.0f)
			.SetFont(0);
		renderer.DrawTextf("FPS: %f\n", time.GetFPS());
		renderer.DrawTextf("x: %f, y: %f, z: %f\n", cameraPos.x, cameraPos.y, cameraPos.z);
		renderer.DrawTextf("pitch: %f, yaw: %f\n", camera.GetPitch(), camera.GetYaw());

		modifier.SetDefault()
			.SetTextCursorPos({ 0, 0, 0 })
			.SetFontSize(0.1f)
			.SetFont(0);

		window.Update();
	}

	void CoordinateSystem::Resize(int width, int height)
	{
		_window->SetResoulution(width, height);
	}

	void CoordinateSystem::UpdateGeometries(List<IGeometry^>^ geometries)
	{
		_geometries = geometries;
	}

	void CoordinateSystem::InputLogic()
	{
		Window& window = *_window;
		Renderer& renderer = _window->GetRenderer();
		Modifier& modifier = renderer.GetModifier();
		Camera& camera = renderer.GetCamera();
		Time& time = _window->GetTime();
		Input& input = _window->GetInput();

		if (input.GetIsMouseDeltaMode())
		{
			camera.SetPitch(camera.GetPitch() + input.MouseDelta().y / 10.0f);
			camera.SetYaw(camera.GetYaw() + input.MouseDelta().x / 10.0f);
		}

		glm::vec3 cameraPos = camera.GetPosition();
		float camSpeed = 25.0f * time.GetDeltaTime();
		if (input.KeyState(Key::W))
		{
			cameraPos += camera.GetMovementX() * camSpeed;
		}
		if (input.KeyState(Key::S))
		{
			cameraPos -= camera.GetMovementX() * camSpeed;
		}
		if (input.KeyState(Key::A))
		{
			cameraPos -= camera.GetMovementZ() * camSpeed;
		}
		if (input.KeyState(Key::D))
		{
			cameraPos += camera.GetMovementZ() * camSpeed;
		}
		if (input.KeyState(Key::Space))
		{
			cameraPos += camera.GetMovementY() * camSpeed;
		}
		if (input.KeyState(Key::LeftShift))
		{
			cameraPos -= camera.GetMovementY() * camSpeed;
		}
		if (input.KeyState(Key::R))
		{
			input.SetIsMouseDeltaMode(true);
		}
		if (input.KeyState(Key::T))
		{
			input.SetIsMouseDeltaMode(false);
		}
		if (input.KeyState(Key::Num1))
		{
			as += time.GetDeltaTime() * 32.0f;
		}
		camera.SetPosition(cameraPos);
	}
}
