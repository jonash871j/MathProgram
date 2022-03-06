#pragma once
#include "en_def.h"

namespace GLEngine
{
	class Camera
	{
	private:
		vec3 _position = { 0.0f, 0.0f, 0.0f };
		vec3 _movementX;
		vec3 _movementY;
		vec3 _movementZ;
		float _pitch = 0.0f;
		float _yaw;

	public:
		export Camera();

	public:
		export void SetPitch(float pitch);
		export float GetPitch();
		export void SetYaw(float yaw);
		export float GetYaw();
		export void SetPosition(vec3 position);
		export vec3 GetPosition();
		export vec3 GetMovementX();
		export vec3 GetMovementY();
		export vec3 GetMovementZ();
		export mat4 GetView();

	private:
		void UpdateMovement();
	};
}


