using UnityEngine;

namespace TriviaSystem
{
    [CreateAssetMenu(menuName = "TriviaSystem/TriviaWordData")]
    public class TriviaWordData : ScriptableObject
    {
        public TriviaSubject Subject;
        public string Word;
        public char GetCharByIndex(int index) { return GetWordLength() < index ? ' ' : Word[index]; }
        public int GetWordLength() { return Word.Length; }
    }

}