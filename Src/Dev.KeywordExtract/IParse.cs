using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev.KeywordExtract
{
    /// <summary>
    /// 文本解析器
    /// </summary>
    public interface IParse
    {
        /// <summary>
        /// 过滤文本
        /// </summary>
        /// <param name="sourceText"></param>
        /// <returns></returns>
        string FilterSource(string sourceText);

        /// <summary>
        /// 通过给定的词典，取得文本中关键字
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="dicword"></param>
        /// <returns></returns>
        Dictionary<string, int> Extract(string sourceText, IEnumerable<string> dicword);
    }
}
