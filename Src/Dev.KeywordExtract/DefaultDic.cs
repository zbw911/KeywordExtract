using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dev.KeywordExtract
{
    public class DefaultDic : IDic
    {
        private static List<string> _cachedWords;
        private readonly string _dicPath;

        public DefaultDic(string dicPath)
        {
            _dicPath = dicPath;
        }

        public void Load()
        {
            var allline = File.ReadAllLines(_dicPath);

            _cachedWords = allline.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        }

        public void Add(string word)
        {
            Load();

            AddOrUpdate(word);
        }

        public void Delete(string word)
        {
            Load();

            if (_cachedWords.Exists(x => x == word.Trim()))
            {
                _cachedWords.Remove(word);
                File.WriteAllLines(_dicPath, _cachedWords);
            }
        }

        public List<string> GetDicWord()
        {
            if (_cachedWords == null)
                Load();

            return _cachedWords;
        }

        public void Update(IEnumerable<string> words)
        {
            Load();

            foreach (var word in words)
            {
                AddOrUpdate(word);
            }
        }


        public void AddOrUpdate(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return;

            if (!_cachedWords.Exists(x => x == word.Trim()))
            {
                File.AppendAllLines(_dicPath, new[] { word });
                _cachedWords.Add(word);
            }
        }
    }
}