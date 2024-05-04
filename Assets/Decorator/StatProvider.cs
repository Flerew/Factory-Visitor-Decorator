using Assets.Factory;
using System.Collections;
using UnityEngine;

namespace Assets.Decorator
{
    public class StatProvider
    {
        private Stats _stats;

        public Stats GetModifiedStats(RaceType race, SpecializationType specialization, PassiveAbilityType passiveAbility)
        {
            _stats = new Stats();

            ChangeStatsByRace(race);
            ChangeStatsBySpecialization(specialization);
            ChangeStatsByAbility(passiveAbility);

            return _stats;
        }

        private void ChangeStatsByRace(RaceType raceType)
        {
            switch (raceType)
            {
                case RaceType.Elf:
                    _stats.Intelegence = 5;
                    break;

                case RaceType.Ork:
                    _stats.Power = 5;
                    break;

                case RaceType.Human:
                    _stats.Dexterity = 5;
                    break;

                default:
                    throw new System.ArgumentException(nameof(raceType));
            }
        }

        private void ChangeStatsBySpecialization(SpecializationType specializationType)
        {
            switch (specializationType)
            {
                case SpecializationType.Wizard:
                    _stats.Intelegence *= 2;
                    break;

                case SpecializationType.Robber:
                    _stats.Dexterity += 2;
                    break;

                case SpecializationType.Barbarian:
                    _stats.Power *= 2;
                    _stats.Intelegence -= 2;
                    break;

                default:
                    throw new System.ArgumentException(nameof(specializationType));
            }
        }

        private void ChangeStatsByAbility(PassiveAbilityType abilityType)
        {
            switch (abilityType)
            {
                case PassiveAbilityType.IntelegenceMultiply:
                    _stats.Intelegence *= 2;
                    break;

                case PassiveAbilityType.PowerDevide:
                    _stats.Power /= 2;
                    break;

                case PassiveAbilityType.DexterityReduce:
                    _stats.Dexterity -= 2;
                    break;

                 default:
                    throw new System.ArgumentException(nameof(abilityType));
            }
        }
    }
}