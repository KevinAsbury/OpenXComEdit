using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace OpenXComEdit
{
    public partial class FormViewBase : Form
    {
        private int SelectedBase { get; set; }
        public FormViewBase()
        {
            InitializeComponent();
        }

        private void loadTiles()
        {
            foreach (var facility in State.SaveFile.Bases[SelectedBase].Facilities)
            {
                foreach (var control in this.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        // This is a little extra... but C# is being dumb
                        // about splitting a string reliably... SMH
                        var tileCoords = ((Button)control).Name
                            .Replace("btn", "")
                            .ToCharArray();

                        if (tileCoords[0].ToString() == facility.Y.ToString() &&
                            tileCoords[1].ToString() == facility.X.ToString())
                        {
                            ((Button)control).Text = facility.Type;
                        }
                    }
                }
            }
        }

        private void FormViewBase_Load(object sender, EventArgs e)
        {
            SelectedBase = 0;
            cmbBase.DataSource = State.SaveFile.Bases;
            cmbBase.DisplayMember = "Name";
            loadTiles();
        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBase = cmbBase.SelectedIndex;
        }

        public class BaseTile : Button
        {
            public string Facility { get; set; }
            public EventHandler FacilityChanged { get; set; }

            public BaseTile()
            {
                Click += new EventHandler(on_Click);
            }

            private void on_Click(object sender, EventArgs e)
            {
                this.Text = "Testing";
            }
        }
    }
}
