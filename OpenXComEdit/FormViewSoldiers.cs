using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenXComEdit
{
    public partial class FormViewSoldiers : Form
    {
        private int selectedSoldier = 0;
        private int selectedBase = 0;

        public FormViewSoldiers()
        {
            InitializeComponent();
        }

        private void loadLb()
        {
            lbSoldiers.DataSource = State.SaveFile.Bases[selectedBase].Soldiers;
            lbSoldiers.DisplayMember = "Name";
        }

        private void FormViewSoldiers_Load(object sender, EventArgs e)
        {
            cmbBase.DataSource = State.SaveFile.Bases;
            cmbBase.DisplayMember = "Name";

            loadLb();
        }

        private void lbSoldiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSoldier = lbSoldiers.SelectedIndex;
            pgSoldiers.SelectedObject = new Soldier(State.SaveFile.Bases[selectedBase].Soldiers[selectedSoldier]);
        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBase = cmbBase.SelectedIndex;
            loadLb();
        }

        private void btnMaxAll_Click(object sender, EventArgs e)
        {
            foreach (var b in State.SaveFile.Bases)
            foreach (var soldier in b.Soldiers)
            {
                soldier.MaxAll();
            }
        }

        private void btnHealAll_Click(object sender, EventArgs e)
        {
            foreach (var b in State.SaveFile.Bases)
            foreach (var soldier in b.Soldiers)
            {
                soldier.Recovery = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            var edit = (Soldier)pgSoldiers.SelectedObject;

            if (edit != null)
                State.SaveFile.Bases[selectedBase].Soldiers[selectedSoldier].Edit(
                    edit.Name, edit.Rank, edit.Gender, edit.Look, edit.Recovery,
                    edit.Tu, edit.Stamina, edit.Health, edit.Bravery, edit.Reactions,
                    edit.Firing, edit.Throwing, edit.Strength, edit.PsiStrength,
                    edit.PsiSkill, edit.Melee);
        }

        private class Soldier
        {
            [CategoryAttribute("Information"), DescriptionAttribute("Name")]
            public string Name { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Rank")]
            public int Rank { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Gender")]
            public int Gender { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Look")]
            public int Look { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Days recovery")]
            public int? Recovery { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Time Units")]
            public int Tu { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Stamina")]
            public int Stamina { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Health")]
            public int Health { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Bravery")]
            public int Bravery { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Reactions")]
            public int Reactions { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Firing")]
            public int Firing { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Throwing")]
            public int Throwing { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Strength")]
            public int Strength { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("PsiStrength")]
            public int PsiStrength { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("PsiSkill")]
            public int PsiSkill { get; set; }
            [CategoryAttribute("Stats"), DescriptionAttribute("Melee Accuracy")]
            public int Melee { get; set; }

            public Soldier(Lib.Soldier soldier)
            {
                Name = soldier.Name;
                Rank = soldier.Rank;
                Gender = soldier.Gender;
                Look = soldier.Look;
                Recovery = soldier.Recovery;
                Tu = soldier.CurrentStats.Tu;
                Stamina = soldier.CurrentStats.Stamina;
                Health = soldier.CurrentStats.Health;
                Bravery = soldier.CurrentStats.Bravery;
                Reactions = soldier.CurrentStats.Reactions;
                Firing = soldier.CurrentStats.Firing;
                Throwing = soldier.CurrentStats.Throwing;
                Strength = soldier.CurrentStats.Strength;
                PsiStrength = soldier.CurrentStats.PsiStrength;
                PsiSkill = soldier.CurrentStats.PsiSkill;
                Melee = soldier.CurrentStats.Melee;
            }
        }
    }
}
