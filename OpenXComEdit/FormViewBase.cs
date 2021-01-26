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
        private BaseTile token { get; set; }

        public FormViewBase()
        {
            InitializeComponent();
        }

        private void loadControls()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    ((Button) control).Text = "";
                }
            }

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

            txtName.Text = State.SaveFile.Bases[SelectedBase].Name;
            txtScientists.Text = State.SaveFile.Bases[SelectedBase].Scientists.ToString();
            txtEngineers.Text = State.SaveFile.Bases[SelectedBase].Engineers.ToString();
            txtLon.Text = State.SaveFile.Bases[SelectedBase].Lon.ToString();
            txtLat.Text = State.SaveFile.Bases[SelectedBase].Lat.ToString();


        }

        private void FormViewBase_Load(object sender, EventArgs e)
        {
            SelectedBase = 0;
            cmbBase.DataSource = State.SaveFile.Bases;
            cmbBase.DisplayMember = "Name";

            cmbBuild.Items.Add("None");
            cmbBuild.Items.Add("XFacility");

            token = new BaseTile();
            token.Location = new System.Drawing.Point(1280, 205);
            token.Name = "token";
            token.Text = "token";
            token.Size = new System.Drawing.Size(200, 200);
            token.TabIndex = 0;
            token.UseVisualStyleBackColor = true;
            token.Visible = true;
            token.BringToFront();
            token.MouseMove += new MouseEventHandler(token_onMouseMove);

            Controls.Add(token);

            loadControls();
        }
        
        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBase = cmbBase.SelectedIndex;
            loadControls();
        }

        private void cmbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private Point MouseDownLocation { get; set; }

        private void token_onMouseDown(object senter, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void token_onMouseMove(object senter, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                token.Left = e.X + token.Left - MouseDownLocation.X;
                token.Top = e.Y + token.Top - MouseDownLocation.Y;
            }
        }

        public class BaseTile : Button
        {

            public BaseTile()
            {

            }

        }
    }
}
