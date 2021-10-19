using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TriviaSystem
{
    public class TriviaLevelManager : MonoBehaviour
    {
        [SerializeField] TriviaSubject subject;
        [SerializeField] TriviaWordData[] wordDatas;

        private void OnValidate()
        {
            SetLegitWords();
        }

        void SetLegitWords()
        {
            List<TriviaWordData> legitWords = new List<TriviaWordData>();
            foreach (var data in wordDatas)
            {
                if (data.Subject == subject)
                    legitWords.Add(data);
            }
            wordDatas = legitWords.ToArray();
        }

        bool IsLegit(string word) { return true; }
        bool IsWholeWord(string word) { return true; }
    }

}