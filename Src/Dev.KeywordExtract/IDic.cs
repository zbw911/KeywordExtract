// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年02月13日 11:43
//  
//  修改于：2014年02月13日 17:00
//  文件名：Dev.KeywordExtract/Dev.KeywordExtract/IDic.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev.KeywordExtract
{
    public interface IDic
    {
        void Load();

        void Add(string word);

        void Delete(string word);
        List<string> GetDicWord();

        /// <summary>
        ///     批量更新
        /// </summary>
        /// <param name="words"></param>
        void Update(IEnumerable<string> words);
    }
}