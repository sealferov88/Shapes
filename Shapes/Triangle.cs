using System;

namespace Shapes
{
    public class Triangle
    {
        public String IdentifyTriagleType(double a, double b, double c)
        {
            if ((a + b) > c &&
               (a + c) > b &&
               (b + c) > a)
            {
                double maxSide;
                double secondSide;
                double thirdSide;

                if (a >= b && a >= c)
                {
                    maxSide = a;
                    secondSide = b;
                    thirdSide = c;
                }
                else
                {
                    if (b >= a && b >= c)
                    {
                        maxSide = b;
                        secondSide = a;
                        thirdSide = c;
                    }
                    else
                    {
                        maxSide = c;
                        secondSide = a;
                        thirdSide = b;
                    }
                }

                if (Math.Pow(maxSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) 
                {
                    return "right";
                }
                else
                {
                    if (Math.Pow(maxSide, 2) < Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) 
                    {
                        return "acute";
                    }
                    else
                    {
                        return "obtuse";
                    }
                }
            }
            else
            {
                return "error";
            }
        }
    }
}
