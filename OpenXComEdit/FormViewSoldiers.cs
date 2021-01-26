using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenXComEdit.Lib;

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

        private class Soldier
        {
            [CategoryAttribute("Information"), DescriptionAttribute("Name")]
            public string Name { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("ID")]
            public int Id { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Rank")]
            public int Rank { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Gender")]
            public int Gender { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Look")]
            public int Look { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Mission count")]
            public int Missions { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Kill count")]
            public int Kills { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Days recovery")]
            public int? Recovery { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Armor")]
            public string Armor { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Improvement")]
            public int Improvement { get; set; }
            [CategoryAttribute("Information"), DescriptionAttribute("Psi Strength Improvement")]
            public int PsiStrImprovement { get; set; }
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
            [CategoryAttribute("Equipment"), DescriptionAttribute("Equipment Layout")]
            public List<Equipment>? EquipmentLayout { get; set; }

            public Soldier(Lib.Soldier soldier)
            {
                Name = soldier.Name;
                Id = soldier.Id;
                Rank = soldier.Rank;
                Gender = soldier.Gender;
                Look = soldier.Look;
                Missions = soldier.Missions;
                Kills = soldier.Kills;
                Recovery = soldier.Recovery;
                Armor = soldier.Armor;
                Improvement = soldier.Improvement;
                PsiStrImprovement = soldier.PsiStrImprovement;
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
                EquipmentLayout = soldier.EquipmentLayout;
            }

        }
    }
}
