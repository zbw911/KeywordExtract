// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 12:02
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract.Test/UnitTestDefaultDic.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev.KeywordExtract.Test
{
    [TestClass]
    public class UnitTestDefaultDic
    {
        private IDic dic = new DefaultDic("./dic.txt");

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
        public void MyTestUpdate()
        {
            dic.Update(new[]
            {
                "aaaa",
                "bbb",
                "cccc"
            });
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