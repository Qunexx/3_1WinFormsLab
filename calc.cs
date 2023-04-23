using System;

namespace winformlab3_1
{
    public class MyCalc
    {
            private double _a = 0.0;
            private double _b = 0.0;

            public double a
            {
                get { return _a;} 
                set
                {
                    if (value == 0) 
                        throw new Exception("Нулевое значение a недопустимо!");
                    else
                        _a = value;
                }
            }

            public double b
            {
                get { return _b; }
                set
                {
                    if (value == 0) 
                        throw new Exception("Нулевое значение b недопустимо!");
                    else
                        _b = value;
                }
            }

            public double calc()
            {
                return ((a+b)/a+ (a - b)/b);
            }
            
        }
    }
