#version 410 core
layout (location = 0) in vec3 posCoords;
layout (location = 1) in vec2 texCoords;

out vec2 TexCoords;

uniform mat4 model;
uniform mat4 projection;
uniform mat4 view;

void main()
{
    TexCoords = texCoords.xy;
    gl_Position = projection * view * model * vec4(posCoords, 1.0);
}