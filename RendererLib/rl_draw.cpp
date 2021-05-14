#include "rl_draw.h"

#include <GL/glew.h>
#include <glfw3.h>

namespace RendererLib
{
    void Draw::Init()
    {

    }
    void Draw::Setup(int width, int height)
    {
        glEnable(GL_SCISSOR_TEST);
        glViewport(0, 0, width, height);
        glScissor(0, height, width, height);
        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
        glOrtho(0, width, 0, height, -1, 1);
        glMatrixMode(GL_MODELVIEW);
        glDisable(GL_SCISSOR_TEST);
    }
    void Draw::Begin()
    {
        glBegin(GL_LINES);
    }
    void Draw::End()
    {
        glEnd();
    }
    void Draw::Color(uint8_t r, uint8_t g, uint8_t b)
    {
        glColor3ub(r, g, b);
    }
    void Draw::Color(System::Drawing::Color color)
    {
        glColor3ub(color.R, color.G, color.B);
    }
    void Draw::Clear(System::Drawing::Color color)
    {
        glClearColor((float)color.R / 255.0f, (float)color.G / 255.0f, (float)color.B / 255.0f, 1.0f);
        glClear(GL_COLOR_BUFFER_BIT);
    }
    void Draw::Point(double x, double y, int size)
	{
        for (int i = -size; i < size; i++)
        {
            glVertex2d(x - size, y + i);
            glVertex2d(x + size, y + i);
        }
	}
    void Draw::Line(double x1, double y1, double x2, double y2, int thickness)
    {
        for (int i = 0; i < thickness; i++)
        {
            glVertex2d(x1, y1 + i);
            glVertex2d(x2, y2 + i);
            glVertex2d(x1 + i, y1);
            glVertex2d(x2 + i, y2);
        }
    }
    void Draw::Line(double x1, double y1, double x2, double y2, int thickness, bool isDotted)
    {
        if (isDotted)
        {
            glEnd();
            glPushAttrib(GL_ENABLE_BIT);
            glLineStipple(6, 0xAAAA);
            glEnable(GL_LINE_STIPPLE);
            glBegin(GL_LINES);

            Line(x1, y1, x2, y2, thickness);

            glEnd();
            glPopAttrib();
            glBegin(GL_LINES);
        }
        else
        {
            Line(x1, y1, x2, y2, thickness);
        }
    }
}