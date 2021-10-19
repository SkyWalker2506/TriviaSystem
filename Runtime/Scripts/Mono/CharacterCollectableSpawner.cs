using UnityEngine;

namespace TriviaSystem
{
    public class CharacterCollectableSpawner : MonoBehaviour
    {
        [SerializeField] CharacterCollectable characterCollectablePrefab;
        CharacterCollectable currentCharacterCollectable;
        [SerializeField] char character;
        [SerializeField] bool spawnOnStart;


        private void Start()
        {
            if (spawnOnStart)
                Spawn();
        }

        public void SetCharacter(char character)
        {
            this.character = character;
        }

        public void Spawn(float delay)
        {
            Invoke(nameof(Spawn), delay);
        }

        void Spawn()
        {
            if(currentCharacterCollectable)
                currentCharacterCollectable.OnCharacterCollected -= Spawn;
            currentCharacterCollectable = Instantiate(characterCollectablePrefab, transform.position, transform.rotation);
            currentCharacterCollectable.SetCharacter(character);
            currentCharacterCollectable.OnCharacterCollected += Spawn;
        }

        void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 0, 1, 0.5f);
            Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
        }
    }

}