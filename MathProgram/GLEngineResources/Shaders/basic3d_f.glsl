#version 410 core
out vec4 color;

uniform vec3 geometryColor;

void main()
{    
    color = vec4(geometryColor, 1.0);
}  