using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev.KeywordExtract.Test
{
    [TestClass]
    public class UnitTestDefaultDic
    {
        IDic dic = new DefaultDic("./dic.txt");

        [TestMethod]
        public void TestMethod1()
        {


            var list = dic.GetDicWord();

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(list.Count);
        }

        [TestMethod]
        public void TestAddLine()
        {
            dic.Add("newdic");

            var list = dic.GetDicWord();

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(list.Count);
        }


        [TestMethod]
        public void TestDelLine()
        {
            dic.Delete("newdic");

            var list = dic.GetDicWord();

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(list.Count);
        }



        [TestMethod]
        public void AddandDel()
        {
            TestAddLine();
            TestDelLine();
            TestAddLine();
        }



    }
}
