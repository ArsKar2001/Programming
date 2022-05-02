﻿using System;
using Programming.Model;

namespace Programming.Service
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            var dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            return dX < (rectangle1.Width + rectangle2.Width) / 2d
                   && dY < (rectangle1.Height + rectangle2.Height) / 2d;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}