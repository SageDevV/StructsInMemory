using System;
using System.Collections.Generic;

namespace Structs
{
    class Program
    {
        private const int LISTIZE = 1000000;    
        private static void TestClass()
        {
            List<PointClass> list = new List<PointClass>(LISTIZE);
            for (int i = 0; i < LISTIZE; i++)
            {
                list.Add(new PointClass(i, i));
            }
        }
        private static void TestStruct()
        {
            List<PointStruct> list = new List<PointStruct>(LISTIZE);
            for (int i = 0; i < LISTIZE; i++)
            {
                list.Add(new PointStruct(i, i));
            }
        }
        static void Main(string[] args)
        {
            TestStruct();
            TestStruct();
        }
    }
}
