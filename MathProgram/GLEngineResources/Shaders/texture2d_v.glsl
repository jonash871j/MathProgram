#version 410 core
layout (location = 0) in vec3 posCoords;
layout (location = 1) in vec2 texCoords;

out vec2 TexCoords;

uniform mat4 model;
uniform mat4 projection;

void main()
{
    TexCoords = texCoords.xy;
    gl_Position = projection * model * vec4(posCoords.xy, 0.0, 1.0);
}