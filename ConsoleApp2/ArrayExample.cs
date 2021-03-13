using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArrayExample
    {
        public void Demo()
        {
            string[] studentCollection = new string[5];
            studentCollection[0] = "Matthew";
            studentCollection[1] = "Jianshu";
            studentCollection[2] = "Seo Ho";
            studentCollection[3] = "Shuang";
            studentCollection[4] = "Wenqiang";

            Array.Sort(studentCollection);
            Array.Reverse(studentCollection);

            int length = studentCollection.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(studentCollection[i]);
            }
        }
    }
}
