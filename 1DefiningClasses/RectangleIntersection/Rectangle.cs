﻿
public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double topLeftX;
    private double topLeftY;

    public string ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
    }

    public bool DoIntersectWith(Rectangle r2)
    {
        if (this.topLeftX > r2.topLeftX + r2.width || r2.topLeftX > this.topLeftX + width)
        {
            return false;
        }

        if (this.topLeftY < r2.topLeftY - height || r2.topLeftY < this.topLeftY - height)
        {
            return false;
        }
        return true;
    }
}

