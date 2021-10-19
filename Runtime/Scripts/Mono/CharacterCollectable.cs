using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;

namespace TriviaSystem
{
    public class CharacterCollectable : MonoBehaviour
    {
        [SerializeField] UnityEvent<char> onCharacterSet;
        [SerializeField] UnityEvent onCharacterCollected;
        public Action OnCharacterCollected;
        [SerializeField] char character;
        public char Character { get { return character; } }

        private void Start()
        {
            SetCharacter(Character);
        }

        void Collect()
        {
            OnCharacterCollected?.Invoke();
            onCharacterCollected?.Invoke();
        }
        void Drop() { }

        public void SetCharacter(char character)
        {
            var str = character.ToString();
            if (string.IsNullOrEmpty(str)) return;
            this.character = str.ToUpper()[0];
            onCharacterSet?.Invoke(Character);
        }
    }
}