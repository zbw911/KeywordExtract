using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev.KeywordExtract
{
    public class Document
    {
        private readonly IDic _dic;
        private readonly IParse _parser;

        public Document(IDic dic, IParse parser)
        {
            _dic = dic;
            _parser = parser;
        }

        /// <summary>
        /// 关键字及词频
        /// </summary>
        /// <param name="sourceText"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetKeywordKv(string sourceText)
        {

            string formatedStr = _parser.FilterSource(sourceText);
            _dic.Load();
            var dicword = _dic.GetDicWord();

            return _parser.Extract(sourceText, dicword);

            return null;
        }

        /// <summary>
        /// 取得前几个关键字
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public string[] GetKeyword(string sourceText, int top)
        {

            var kvs = GetKeywordKv(sourceText);

            return kvs.OrderByDescending(x => x.Value).Take(top).Select(x => x.Key).ToArray();

        }

    }
}
