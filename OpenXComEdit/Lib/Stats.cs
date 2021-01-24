using System;

namespace OpenXComEdit.Lib
{
    public class Stats
    {
        public int Tu { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Bravery { get; set; }
        public int Reactions { get; set; }
        public int Firing { get; set; }
        public int Throwing { get; set; }
        public int Strength { get; set; }
        public int PsiStrength { get; set; }
        public int PsiSkill { get; set; }
        public int Melee { get; set; }

        public Stats(int tu, int stamina, int health, int bravery, int reactions, int firing, int throwing, int strength, int psiStrength, int psiSkill, int melee)
        {
            Tu = tu;
            Stamina = stamina;
            Health = health;
            Bravery = bravery;
            Reactions = reactions;
            Firing = firing;
            Throwing = throwing;
            Strength = strength;
            PsiStrength = psiStrength;
            PsiSkill = psiSkill;
            Melee = melee;
        }

        public Stats()
        {
            var rng = new Random();

            Tu = rng.Next(50, 60);
            Stamina = rng.Next(40, 70);
            Health = rng.Next(25, 40);
            Bravery = rng.Next(10, 60);
            Reactions = rng.Next(30, 60);
            Firing = rng.Next(40, 70);
            Throwing = rng.Next(50, 80);
            Strength = rng.Next(20, 40);
            PsiStrength = rng.Next(0, 100);
            PsiSkill = 0;
            Melee = rng.Next(20, 40);
        }
    }
}