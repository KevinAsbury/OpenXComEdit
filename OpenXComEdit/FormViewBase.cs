using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace OpenXComEdit
{
    public partial class FormViewBase : Form
    {
        private int selectedBase { get; set; }
        private BaseTile token { get; set; }
        private bool shown = false;

        public FormViewBase()
        {
            InitializeComponent();
        }

        private void loadControls()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(BaseTile))
                {
                    ((BaseTile) control).Facility = "";
                }
            }

            foreach (var facility in State.SaveFile.Bases[selectedBase].Facilities)
            {
                foreach (var control in this.Controls)
                {
                    if (control.GetType() == typeof(BaseTile))
                    {
                        var baseTile = ((BaseTile) control);
                        // This is a little extra... but C# is being dumb
                        // about splitting a string reliably... SMH
                        var tileCoords = baseTile.Name
                            .Replace("btn", "")
                            .ToCharArray();

                        baseTile.Y = Convert.ToInt32(tileCoords[0].ToString());
                        baseTile.X = Convert.ToInt32(tileCoords[1].ToString());

                        if (tileCoords[0].ToString() == facility.Y.ToString() &&
                            tileCoords[1].ToString() == facility.X.ToString())
                        {
                            baseTile.Facility = facility.Type;

                            if (facility.Type == "STR_HANGAR")
                                placeHangars(baseTile.X, baseTile.Y);
                        }
                    }
                }
            }

            txtName.Text = State.SaveFile.Bases[selectedBase].Name;
            txtScientists.Text = State.SaveFile.Bases[selectedBase].Scientists.ToString();
            txtEngineers.Text = State.SaveFile.Bases[selectedBase].Engineers.ToString();
            txtLon.Text = State.SaveFile.Bases[selectedBase].Lon.ToString();
            txtLat.Text = State.SaveFile.Bases[selectedBase].Lat.ToString();
        }

        private void FormViewBase_Load(object sender, EventArgs e)
        {
            selectedBase = 0;
            cmbBase.DataSource = State.SaveFile.Bases;
            cmbBase.DisplayMember = "Name";

            cmbBuild.Items.Add("");
            cmbBuild.Items.Add("STR_ACCESS_LIFT");
            cmbBuild.Items.Add("STR_HANGAR");
            cmbBuild.Items.Add("STR_LIVING_QUARTERS");
            cmbBuild.Items.Add("STR_GENERAL_STORES");
            cmbBuild.Items.Add("STR_LABORATORY");
            cmbBuild.Items.Add("STR_WORKSHOP");
            cmbBuild.Items.Add("STR_SMALL_RADAR_SYSTEM");
            cmbBuild.Items.Add("STR_LARGE_RADAR_SYSTEM");
            cmbBuild.Items.Add("STR_ALIEN_CONTAINMENT");
            cmbBuild.Items.Add("STR_MISSILE_DEFENSES");
            cmbBuild.Items.Add("STR_LASER_DEFENSES");
            cmbBuild.Items.Add("STR_PLASMA_DEFENSES");
            cmbBuild.Items.Add("STR_FUSION_BALL_DEFENSES");
            cmbBuild.Items.Add("STR_PSIONIC_LABORATORY");
            cmbBuild.Items.Add("STR_HYPER_WAVE_DECODER");
            cmbBuild.Items.Add("STR_GRAV_SHIELD");
            cmbBuild.Items.Add("STR_MIND_SHIELD");

            token = new BaseTile();
            token.Facility = "";
            token.Location = new System.Drawing.Point(1280, 205);
            token.Name = "token";
            token.Text = "";
            token.Size = new System.Drawing.Size(200, 200);
            token.TabIndex = 0;
            token.UseVisualStyleBackColor = true;
            token.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.base_dirt));
            token.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            token.Visible = false;
            token.MouseDown += new MouseEventHandler(token_MouseDown);

            loadControls();
            Controls.Add(token);
            
            rtbInstructions.Text = "WARNING - EDIT BASE FACILITIES AT YOUR OWN RISK! " + 
                                   "ALWAYS HAVE ONLY ONE ACCESS LIFT! HANGERS TAKE 4 TILES." + 
                                   "Right click to clear " +
                                   "a tile (make it dirt). Select a facility in the drop down " +
                                   "and drag the tile beneath it to the desired spot and drop it.";

            btn00.HangarPlaced += new EventHandler(hangarPlaced);
            btn01.HangarPlaced += new EventHandler(hangarPlaced);
            btn02.HangarPlaced += new EventHandler(hangarPlaced);
            btn03.HangarPlaced += new EventHandler(hangarPlaced);
            btn04.HangarPlaced += new EventHandler(hangarPlaced);
            btn05.HangarPlaced += new EventHandler(hangarPlaced);
            btn10.HangarPlaced += new EventHandler(hangarPlaced);
            btn11.HangarPlaced += new EventHandler(hangarPlaced);
            btn12.HangarPlaced += new EventHandler(hangarPlaced);
            btn13.HangarPlaced += new EventHandler(hangarPlaced);
            btn14.HangarPlaced += new EventHandler(hangarPlaced);
            btn15.HangarPlaced += new EventHandler(hangarPlaced);
            btn20.HangarPlaced += new EventHandler(hangarPlaced);
            btn21.HangarPlaced += new EventHandler(hangarPlaced);
            btn22.HangarPlaced += new EventHandler(hangarPlaced);
            btn23.HangarPlaced += new EventHandler(hangarPlaced);
            btn24.HangarPlaced += new EventHandler(hangarPlaced);
            btn25.HangarPlaced += new EventHandler(hangarPlaced);
            btn30.HangarPlaced += new EventHandler(hangarPlaced);
            btn31.HangarPlaced += new EventHandler(hangarPlaced);
            btn32.HangarPlaced += new EventHandler(hangarPlaced);
            btn33.HangarPlaced += new EventHandler(hangarPlaced);
            btn34.HangarPlaced += new EventHandler(hangarPlaced);
            btn35.HangarPlaced += new EventHandler(hangarPlaced);
            btn40.HangarPlaced += new EventHandler(hangarPlaced);
            btn41.HangarPlaced += new EventHandler(hangarPlaced);
            btn42.HangarPlaced += new EventHandler(hangarPlaced);
            btn43.HangarPlaced += new EventHandler(hangarPlaced);
            btn44.HangarPlaced += new EventHandler(hangarPlaced);
            btn45.HangarPlaced += new EventHandler(hangarPlaced);
            btn50.HangarPlaced += new EventHandler(hangarPlaced);
            btn51.HangarPlaced += new EventHandler(hangarPlaced);
            btn52.HangarPlaced += new EventHandler(hangarPlaced);
            btn53.HangarPlaced += new EventHandler(hangarPlaced);
            btn54.HangarPlaced += new EventHandler(hangarPlaced);
            btn55.HangarPlaced += new EventHandler(hangarPlaced);
        }

        private void hangarPlaced(object sender, EventArgs e)
        {
            var x = ((BaseTile)sender).X;
            var y = ((BaseTile)sender).Y;
            placeHangars(x, y);
        }

        private void placeHangars(int x, int y)
        {
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(BaseTile))
                {
                    var bTile = ((BaseTile)control);

                    if (bTile.Y == y + 0 && bTile.X == x + 1)
                        bTile.BackgroundImage = Properties.Resources.base_hangar2;

                    if (bTile.Y == y + 1 && bTile.X == x + 0)
                        bTile.BackgroundImage = Properties.Resources.base_hangar3;

                    if (bTile.Y == y + 1 && bTile.X == x + 1)
                        bTile.BackgroundImage = Properties.Resources.base_hangar4;
                }
            }
        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBase = cmbBase.SelectedIndex;
            loadControls();
        }

        private void FormViewBase_Shown(object sender, EventArgs e)
        {
            shown = true;
        }

        private void cmbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shown)
            {
                token.Visible = true;
                token.Facility = cmbBuild.Text;
            }
        }

        private void token_MouseDown(object sender, MouseEventArgs e)
        {
            token.DoDragDrop(token.Facility, DragDropEffects.Copy |
                                         DragDropEffects.Move);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.cmbBuild.SelectedIndex = 0;
            this.token.Facility = "";
            this.token.Visible = false;

            var facilities = new List<Lib.Facility>();

            foreach (var control in Controls)
            if (control.GetType() == typeof(BaseTile))
            {
                var baseTile = (BaseTile) control;
                var facility = new Lib.Facility();

                if (!String.IsNullOrEmpty(baseTile.Facility))
                {
                    //MessageBox.Show($"{baseTile.Facility} {baseTile.X} {baseTile.Y}");
                    facility.Type = baseTile.Facility;
                    facility.X = baseTile.X;
                    facility.Y = baseTile.Y;
                    facilities.Add(facility);
                }
            }
    

            if (facilities.Count > 0)
            {
                State.SaveFile.Bases[selectedBase].Facilities = facilities;
            }
        }

        public class BaseTile : Button
        {
            private string _facility = "";
            public string Facility
            {
                get { return _facility; }
                set { _facility = _FacilityChanged(value); }
            }

            public int X { get; set; }
            public int Y { get; set; }

            public event EventHandler HangarPlaced;

            public BaseTile()
            {
                AllowDrop = true;
                DragEnter += new DragEventHandler(_DragEnter);
                DragDrop += new DragEventHandler(_DragDrop);
                MouseUp += new MouseEventHandler(_MouseUp);
                BackgroundImage = Properties.Resources.base_dirt;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

            private string _FacilityChanged(string value)
            {
                switch (value)
                {
                    case "":
                        BackgroundImage = Properties.Resources.base_dirt;
                        break;
                    case "STR_ACCESS_LIFT":
                        BackgroundImage = Properties.Resources.base_access;
                        break;
                    case "STR_LIVING_QUARTERS":
                        BackgroundImage = Properties.Resources.base_living;
                        break;
                    case "STR_GENERAL_STORES":
                        BackgroundImage = Properties.Resources.base_stores;
                        break;
                    case "STR_LABORATORY":
                        BackgroundImage = Properties.Resources.base_lab;
                        break;
                    case "STR_WORKSHOP":
                        BackgroundImage = Properties.Resources.base_workshop;
                        break;
                    case "STR_SMALL_RADAR_SYSTEM":
                        BackgroundImage = Properties.Resources.base_smradar;
                        break;
                    case "STR_LARGE_RADAR_SYSTEM":
                        BackgroundImage = Properties.Resources.base_lgradar;
                        break;
                    case "STR_ALIEN_CONTAINMENT":
                        BackgroundImage = Properties.Resources.base_containment;
                        break;
                    case "STR_MISSILE_DEFENSES":
                        BackgroundImage = Properties.Resources.base_missile;
                        break;
                    case "STR_LASER_DEFENSES":
                        BackgroundImage = Properties.Resources.base_laser;
                        break;
                    case "STR_PLASMA_DEFENSES":
                        BackgroundImage = Properties.Resources.base_plasma;
                        break;
                    case "STR_FUSION_BALL_DEFENSES":
                        BackgroundImage = Properties.Resources.base_fusion;
                        break;
                    case "STR_PSIONIC_LABORATORY":
                        BackgroundImage = Properties.Resources.base_psi;
                        break;
                    case "STR_HYPER_WAVE_DECODER":
                        BackgroundImage = Properties.Resources.base_hyper;
                        break;
                    case "STR_GRAV_SHIELD":
                        BackgroundImage = Properties.Resources.base_grav;
                        break;
                    case "STR_MIND_SHIELD":
                        BackgroundImage = Properties.Resources.base_mind;
                        break;
                    case "STR_HANGAR":
                        BackgroundImage = Properties.Resources.base_hangar1;
                        HangarPlaced?.Invoke(this, EventArgs.Empty);
                        break;
                    default:
                        BackgroundImage = Properties.Resources.base_hangar1;
                        break;
                }

                return value;
            }
            
            // IDK why MouseUp works and MouseClick does not for right clicks
            // .Net is being so... "extra"...today SMH
            private void _MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right) Facility = "";
            }

            private void _DragDrop(object sender, DragEventArgs e)
            {
                Facility = e.Data.GetData(DataFormats.Text).ToString();
            }

            private void _DragEnter(object sender, DragEventArgs e)
            {
                if (e.Data.GetDataPresent(DataFormats.Text))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }
    }
}
