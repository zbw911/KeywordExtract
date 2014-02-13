// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 11:55
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract/IParse.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev.KeywordExtract
{
    /// <summary>
    ///     文本解析器
    /// </summary>
    public interface IParse
    {
        /// <summary>
        ///     过滤文本
        /// </summary>
        /// <param name="sourceText"></param>
        /// <returns></returns>
        string FilterSource(string sourceText);

        /// <summary>
        ///     通过给定的词典，取得文本中关键字
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="dicword"></param>
        /// <returns></returns>
        Dictionary<string, int> Extract(string sourceText, IEnumerable<string> dicword);
    }
}