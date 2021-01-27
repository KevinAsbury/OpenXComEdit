using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
                foreach (var control in this.Controls) // loop through each control on this form
                {
                    if (control.GetType() == typeof(BaseTile)) // if a BaseTile...
                    {
                        var baseTile = ((BaseTile) control);
                        
                        // Each tile is named for it's x and y coords.
                        // Convert the name, 'btn03' for example, into the coordinates (0, 3)
                        // .Net gave me sketchy results string splitting so...
                        // we have to do it another way, with char arrays
                        var tileCoords = baseTile.Name
                            .Replace("btn", "") // remove "btn"
                            .ToCharArray(); // split two numbers into a char array

                        // make sure coord chars are numberic to avoid amy conversion errors
                        if (char.IsNumber(tileCoords[0]) && char.IsNumber(tileCoords[1]))
                        {
                            // converts char to string representation of a number
                            var y = Convert.ToInt32(tileCoords[0].ToString());
                            var x = Convert.ToInt32(tileCoords[1].ToString());

                            baseTile.Y = y;
                            baseTile.X = x;

                            if (x == facility.X && y == facility.Y)
                            {
                                baseTile.Facility = facility.Type;

                                if (facility.BuildTime.HasValue)
                                {
                                    baseTile.ForeColor = System.Drawing.Color.Yellow;
                                    var font = new Font(FontFamily.GenericSerif, 25, FontStyle.Bold);
                                    baseTile.Font = font;
                                    baseTile.Text = facility.BuildTime.ToString();
                                }

                                if (facility.Type == "STR_HANGAR") // Hangars take up 4 tiles
                                    placeHangars(baseTile.X, baseTile.Y);
                            }
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

            rtbInstructions.Text = "WARNING - EDIT BASE FACILITIES AT YOUR OWN RISK!\n\n" +
                                   "Right click a tile to make it dirt.\n\n" +
                                   "To place a facility select the facility in the drop down " +
                                   "and a tile will appear beneath it then drag this tile to the desired spot and drop it.\n\n" +
                                   "Click the 'Save Changes' button below to write your changes to memory.\n\n" +
                                   "Don't forget to use File/Save to write changes to disk.\n\n" +
                                   "FYI - save any changes before switching bases.\n\n" +
                                   "Enjoy!";

            // Designer kept deleting these so I moved them here
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

        private void placeHangars(int? x, int? y)
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

                if (!String.IsNullOrEmpty(baseTile.Facility)) // weed out dirt tiles
                {
                    facility.Type = baseTile.Facility;
                    facility.X = baseTile.X ?? default;
                    facility.Y = baseTile.Y ?? default;
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

            public int? X { get; set; }
            public int? Y { get; set; }

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
                if (e.Button == MouseButtons.Right)
                {
                    Facility = "";
                    Text = "";
                    Font = null;
                    ForeColor = Color.Black;
                }

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
