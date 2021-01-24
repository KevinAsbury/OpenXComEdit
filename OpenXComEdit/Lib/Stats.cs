namespace XComIIEdit.Lib
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
            Tu = 0;
            Stamina = 0;
            Health = 0;
            Bravery = 0;
            Reactions = 0;
            Firing = 0;
            Throwing = 0;
            Strength = 0;
            PsiStrength = 0;
            PsiSkill = 0;
            Melee = 0;
        }
    }
}