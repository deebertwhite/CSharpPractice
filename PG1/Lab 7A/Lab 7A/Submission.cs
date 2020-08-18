using System;
using System.Text;
using Lab_7A;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string [] names)
        {
            StringBuilder newString = new StringBuilder();
            foreach (string name in names)
            {
                newString.Append(name[0]);
            }
            return newString;
        }

        public static object Test2(float x, float y, float radius)
        {
            Circle c1 = new Circle(x, y, radius);
            return c1;
        }

        public static object Test3(float x, float y, float radius)
        {
            Circle c1 = new Circle(x, y, radius);
            return c1;
        }

        public static object Test4(float x, float y, float radius)
        {
            Circle c1 = new Circle(x, y, radius);
            return c1;
        }

        public static object Test5(float x, float y, float radius)
        {
            Circle c1 = new Circle(x, y, radius);
            return c1;
        }

        public static int Test6(string str1, string str2, bool ignoreCase)
        {
            return String.Compare(str1, str2, ignoreCase);
        }

        public static string Test7(sbyte offset, string message)
        {
            TextCodec codec = new TextCodec(offset);
            return codec.Encode(message);
        }

        public static string Test8(sbyte offset, string message)
        {
            TextCodec codec = new TextCodec(offset);
            return codec.Decode(message);
        }
    }
}
