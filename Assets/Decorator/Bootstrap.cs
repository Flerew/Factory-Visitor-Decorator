using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Decorator
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Awake()
        {
            _player.Initialize(GetRandomRaceType(), GetRandomSpecializationType(), GetRandomPassiveAbilityType());
        }

        private RaceType GetRandomRaceType()
        {
            return (RaceType)Random.Range(0, Enum.GetValues(typeof(RaceType)).Length);
        }
        private SpecializationType GetRandomSpecializationType()
        {
            return (SpecializationType)Random.Range(0, Enum.GetValues(typeof(SpecializationType)).Length);
        }

        private PassiveAbilityType GetRandomPassiveAbilityType()
        {
            return (PassiveAbilityType)Random.Range(0, Enum.GetValues(typeof(PassiveAbilityType)).Length);
        }
    }
}