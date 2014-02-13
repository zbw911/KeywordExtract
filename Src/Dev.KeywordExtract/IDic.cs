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
        /// 批量更新
        /// </summary>
        /// <param name="words"></param>
        void Update(IEnumerable<string> words);
    }
}
