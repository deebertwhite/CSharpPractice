using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class Circle
    {
        private float mX;
        private float mY;
        private float mRadius;

        public Circle(float x, float y, float radius)
        {
            mX = x;
            mY = y;
            mRadius = radius;
        }

        public float GetX()
        {
            return mX;
        }

        public float GetY()
        {
            return mY;
        }

        public float GetRadius()
        {
            return mRadius;
        }

        public float GetArea()
        {
            return (float) ((float) Math.PI * Math.Pow(mRadius, 2));
        }

        public bool Contains(float px, float py)
        {
            bool Contain = false;
            if ((Math.Pow(px - mX, 2)) + (Math.Pow(py - mY, 2)) <= (Math.Pow(mRadius, 2) ))
            {
                Contain = true;
            }
            return Contain;
        }

        public float GetCircumference()
        {
            return (2 * (float)Math.PI * mRadius); 
        }

    }
}
