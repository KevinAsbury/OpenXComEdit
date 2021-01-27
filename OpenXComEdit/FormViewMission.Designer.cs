
namespace OpenXComEdit
{
    partial class FormViewMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbUnits = new System.Windows.Forms.ListBox();
            this.pgUnits = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(31, 137);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbUnits);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pgUnits);
            this.splitContainer1.Size = new System.Drawing.Size(1440, 1217);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 3;
            // 
            // lbUnits
            // 
            this.lbUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUnits.FormattingEnabled = true;
            this.lbUnits.ItemHeight = 48;
            this.lbUnits.Location = new System.Drawing.Point(0, 0);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(600, 1217);
            this.lbUnits.TabIndex = 0;
            this.lbUnits.SelectedIndexChanged += new System.EventHandler(this.lbUnits_SelectedIndexChanged);
            // 
            // pgUnits
            // 
            this.pgUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgUnits.Location = new System.Drawing.Point(0, 0);
            this.pgUnits.Name = "pgUnits";
            this.pgUnits.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgUnits.Size = new System.Drawing.Size(836, 1217);
            this.pgUnits.TabIndex = 1;
            // 
            // FormViewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 1384);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormViewMission";
            this.ShowIcon = false;
            this.Text = "Mission Units";
            this.Load += new System.EventHandler(this.FormViewMission_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbUnits;
        private System.Windows.Forms.PropertyGrid pgUnits;
    }
}