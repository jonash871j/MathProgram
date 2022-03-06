#version 410 core
out vec4 color;

uniform vec3 shapeColor;
uniform float alpha;

void main()
{    
    color = vec4(shapeColor, alpha);
}  