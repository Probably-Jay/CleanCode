using System;

namespace OpenClosed
{
#region Initial

    public class Shapes
    {
        private ShapeBase _shapeBase;
    }

    internal abstract class ShapeBase
    {
        public float Height { get; }
        public float Width { get; }
    }

    static class InitialShapeTools
    {
        public static float GetArea(ShapeBase shape)
        {
            return shape.Width * shape.Height;
        }
    }
    
    class Rectangle : ShapeBase 
    {
 
    }

    class Circle : ShapeBase
    {
        public float Radius { get; }
    }
    
    
#endregion

#region Bad
    static class BadShapeTools
    {
        public static float GetArea(ShapeBase shape)
        {
            if (shape is Rectangle)
            {
                return shape.Width * shape.Height;
            }

            if (shape is Circle)
            {
                return ((Circle) shape).Radius * (float)Math.PI;
            }

            throw new Exception();
        }
    }
#endregion

#region Fix

internal abstract class FixedShapeBase
{
    public float Height { get; }
    public float Width { get; }

    public abstract float GetArea();
}

class FixedRectangle :FixedShapeBase 
{
    public override float GetArea()
    {
        return Width * Height;
    }
}

class FixedCircle : FixedShapeBase
{
    public float Radius { get; }
    public override float GetArea()
    {
        return Radius * (float)Math.PI;
    }
}

#endregion
}