using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenXComEdit
{
    public partial class FormViewMission : Form
    {
        private int selectedUnit { get; set; }

        public FormViewMission()
        {
            InitializeComponent();
        }

        private void loadLb()
        {
            if (State.SaveFile.BattleGame != null)
            {
                lbUnits.DataSource = State.SaveFile.BattleGame.Units;
                lbUnits.DisplayMember = "GenUnitType";
            }
        }

        private void FormViewMission_Load(object sender, EventArgs e)
        {
            loadLb();
        }

        private void lbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUnit = lbUnits.SelectedIndex;
            pgUnits.SelectedObject = State.SaveFile.BattleGame.Units[selectedUnit];
        }
    }
}
