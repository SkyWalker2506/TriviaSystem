using UnityEngine;
using TMPro;

namespace TriviaSystem
{
    public class CharacterCollectableWorldUI : MonoBehaviour
    {
        [SerializeField] TMP_Text[] texts;

        public void SetUI(char character)
        {
            foreach (var text in texts)
            {
                text.SetText(character.ToString());
            }
        }
    }


}