// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 11:41
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract.Test/UnitTestDefaultParser.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev.KeywordExtract.Test
{
    [TestClass]
    public class UnitTestDefaultParser
    {
        private IParse parse = new DefaultParser();


        [TestMethod]
        public void TestMethod1()
        {
            string source = "我有一个梦想，我们都是共产主义掘墓人，我们一起来努力,来吧，共产主义好，社会主义好，个屁";
            string[] dics = new[] {"我们", "是", "一"};
            var kw = parse.Extract(source, dics);

            foreach (var i in kw)
            {
                Console.WriteLine(i.Key + "=>" + i.Value);
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var html = @"<head>
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8""/>
<title>关键词提取算法 - pangbangb - 博客园</title>
<link type=""text/css"" rel=""stylesheet"" href=""/bundles/blog-common.css?v=gdNkSiQMyBMkpTeO1ex9qW-60UbMszQItnCUpBAT3LQ1""/>
<link id=""MainCss"" type=""text/css"" rel=""stylesheet"" href=""http://common.cnblogs.com/Skins/ThinkInside/style.css?id=20140110""/>
<link title=""RSS"" type=""application/rss+xml"" rel=""alternate"" href=""http://www.cnblogs.com/pangblog/rss""/>
<link title=""RSD"" type=""application/rsd+xml"" rel=""EditURI"" href=""http://www.cnblogs.com/pangblog/rsd.xml""/>
<link type=""application/wlwmanifest+xml"" rel=""wlwmanifest"" href=""http://www.cnblogs.com/pangblog/wlwmanifest.xml""/>
<script src=""http://common.cnblogs.com/script/jquery.js"" type=""text/javascript""></script>  
<script type=""text/javascript"">var currentBlogApp = 'pangblog', cb_enable_mathjax=false;</script>
<script src=""/bundles/blog-common.js?v=VS7ve6HfGvxtuwYyB4SWqTrYP6ZukEwxrePhJmRhqZc1"" type=""text/javascript""></script>
</head>
";

            var txt = parse.FilterSource(html);

            Console.WriteLine(txt);
        }
    }
}