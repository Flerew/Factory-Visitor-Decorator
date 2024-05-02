using System;
using UnityEngine;

namespace Assets.Factory.Elf
{
    [Serializable]
    public class ElfConfig
    {
        [SerializeField] private Enemy _elfPaladinPrefab;
        [SerializeField] private Enemy _elfWizardPrefab;

        public Enemy ElfPaladinPrefab => _elfPaladinPrefab;
        public Enemy ElfWizardPrefab => _elfWizardPrefab;
    }
}