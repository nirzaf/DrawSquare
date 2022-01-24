// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Hello, World!");

public class Square
{
    private readonly int _x;
    private readonly int _y;
    private readonly int _w;
    private readonly int _h;

    public Square(int x, int y, int w, int h)
    {
        _x = x;
        _y = y;
        _w = w;
        _h = h;
    }

    public void DrawSquare()
    {
        int xw = _x + _w;
        int yh = _y+ _h;

        DrawLine(_x, _y,xw,_y);
        DrawLine(xw, _y,xw,yh);
        DrawLine(xw, yh,_x,yh);
        DrawLine(_x, yh,_x,_y);

    }

    private void DrawLine(int x1, int y1, int x2, int y2)
    {
        //draw line code goes here

    }


}