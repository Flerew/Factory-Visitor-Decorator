using UnityEngine;

namespace Assets.Decorator
{
    public class Player : MonoBehaviour
    {
        private Stats _stats;
        private StatProvider _provider;
        private RaceType _race;
        private SpecializationType _specialization;
        private PassiveAbilityType _passiveAbility;

        public void Initialize(RaceType race, SpecializationType specialization, PassiveAbilityType ability)
        {
            _race = race;
            _specialization = specialization;
            _passiveAbility = ability;

            _provider = new StatProvider();
            _stats = _provider.GetModifiedStats(_race, _specialization, _passiveAbility);

            PrintStats();
        }

        public void PrintStats()
        {
            Debug.Log(_race.ToString());
            Debug.Log(_specialization.ToString());
            Debug.Log(_passiveAbility.ToString());
            Debug.Log($"Intelegence: {_stats.Intelegence}");
            Debug.Log($"Power: {_stats.Power}");
            Debug.Log($"Dexterity: {_stats.Dexterity}");
        }
    }
}