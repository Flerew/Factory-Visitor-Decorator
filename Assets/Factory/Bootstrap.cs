using System.Collections;
using UnityEngine;

namespace Assets.Factory
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private SpawnerMediator _spawnerMediator;
        [SerializeField] private SwitchSpawnerTypeButton _switchSpawnerTypeButton;

        private void Awake()
        {
            _switchSpawnerTypeButton.Initialize(_spawnerMediator);
        }
    }
}