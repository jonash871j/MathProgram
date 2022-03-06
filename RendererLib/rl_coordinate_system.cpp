#include "rl_coordinate_system.h"
#include "rl_color.h"


namespace RendererLib
{
	CoordinateSystem::CoordinateSystem(void* hWnd, int width, int height)
	{
		_window = new Win32Window((HWND)hWnd, width, height);
		ResourceManager::LoadBitmapFont(0,
			BitmapFont::Create(8, 16, 93, 1)->LoadAsAsciiFormat("Bitmap Fonts/font.png", 32));
		_elements = new CoordinateSystemElements(*_window);

		Renderer& renderer = _window->GetRenderer();
		Input& input = _window->GetInput();
		Camera& camera = renderer.GetCamera();

		renderer.SetTextFont(ResourceManager::GetFont(0));
		renderer.SetTextSize(2.0f);
		renderer.SetBackgroundColor(VecColor::FromRGB(16, 16, 16));

		camera.SetPosition({ 0, 0, -50 });
		camera.SetYaw(180.0f);
	}

	void CoordinateSystem::Logic()
	{
		Window& window = *_window;
		Renderer& renderer = _window->GetRenderer();
		Modifier& modifier = renderer.GetModifier();
		Camera& camera = renderer.GetCamera();
		Time& time = _window->GetTime();
		CoordinateSystemElements elements = *_elements;

		InputLogic();
		HalfWidth = (window.GetWidth() / camera.GetPosition().z + camera.GetPosition().z);
		HalfHeight = (window.GetHeight() / camera.GetPosition().z + camera.GetPosition().z) / 2.0f;

		modifier.SetColor({ 1.0f, 0.0f, 0.0f });
		renderer.Draw3DLine({ -999990, 0, 0 }, { 99999, 0, 0 });
		modifier.SetColor({ 0.0f, 1.0f, 0.0f });
		renderer.Draw3DLine({ 0, -99999, 0 }, { 0, 99999, 0 });
		modifier.SetColor({ 0.0f, 0.0f, 1.0f });
		renderer.Draw3DLine({ 0, 0, -99999 }, { 0, 0, 99999 });

		//elements.DrawGrid();

		glm::vec3 cameraPos = camera.GetPosition();
		modifier.SetDefault();
		renderer.SetTextCursorPos({ 0.0f, 0.0f });
		renderer.PrintTextf("FPS: %f\n", time.GetFPS());
		renderer.PrintTextf("x: %f, y: %f, z: %f\n", cameraPos.x, cameraPos.y, cameraPos.z);
		renderer.PrintTextf("pitch: %f, yaw: %f\n", camera.GetPitch(), camera.GetYaw());

		window.Update();
	}

	void CoordinateSystem::Resize(int width, int height)
	{
		_window->SetResoulution(width, height);
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
		camera.SetPosition(cameraPos);
	}
}
