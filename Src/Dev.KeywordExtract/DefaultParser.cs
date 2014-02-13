// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 12:00
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract/DefaultParser.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Dev.KeywordExtract
{
    public class DefaultParser : IParse
    {
        public string FilterSource(string sourceText)
        {
            var text = Strip_Tags(sourceText);


            return text;
        }

        #region Html 标记

        /// <summary>
        ///     去除HTML标记
        /// </summary>
        /// <param name="AHtml"> </param>
        /// <returns> </returns>
        private static string Strip_Tags(string AHtml)
        {
            if (AHtml == null)
                return null;
            var regex = new Regex(@"<[^>]*>");
            AHtml = regex.Replace(AHtml, "");

            AHtml = ReplaceMarkupChar(AHtml);

            return AHtml;
        }

        private static readonly char[] MarkupChar = { ' ', ' ', ' ', '<', '>', '&', '"', '*', '/' };

        private static readonly string[] ReplaceString =
        {
            "&ensp;", "&emsp;", "&nbsp;", "&lt;", "&gt;", "&amp;",
            "&quot;", "&times;", "&divide;"
        };

        private static string ReplaceMarkupChar(string source)
        {
            for (int i = 0; i < ReplaceString.Length; i++)
                source = source.Replace(ReplaceString[i], MarkupChar[i].ToString());

            return source;
        }

        #endregion

        public Dictionary<string, int> Extract(string sourceText, IEnumerable<string> dicword)
        {

            var dics = new Dictionary<string, int>();

            for (int i = 0; i < sourceText.Length; i++)
            {
                foreach (var word in dicword)
                {
                    if (sourceText.Substring(i).StartsWith(word))
                    {
                        if (!dics.ContainsKey(word))
                            dics[word] = 0;

                        dics[word]++;
                    }
                }
            }

            return dics;
        }
    }
}