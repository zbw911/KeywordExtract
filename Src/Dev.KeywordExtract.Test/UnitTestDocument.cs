// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 14:58
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract.Test/UnitTestDocument.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev.KeywordExtract.Test
{
    [TestClass]
    public class UnitTestDocument
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDic dic = new DefaultDic("./dic.txt");
            IParse parse = new DefaultParser();

            Document d = new Document(dic, parse);
            string source = "我有一个梦想，我们都是共产主义掘墓人，我们一起来努力,来吧，共产主义好，社会主义好，个屁";
            var topwords = d.GetKeyword(source, 2);

            foreach (var topword in topwords)
            {
                Console.WriteLine(topword);
            }

            Console.WriteLine("****************************************************");
            var kvs = d.GetKeywordKv(source);

            foreach (var kv in kvs)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
        }
    }
}