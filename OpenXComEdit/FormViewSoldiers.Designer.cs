
namespace OpenXComEdit
{
    partial class FormViewSoldiers
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
            this.lbSoldiers = new System.Windows.Forms.ListBox();
            this.pgSoldiers = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnMaxAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHealAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSoldiers
            // 
            this.lbSoldiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSoldiers.FormattingEnabled = true;
            this.lbSoldiers.ItemHeight = 48;
            this.lbSoldiers.Location = new System.Drawing.Point(0, 0);
            this.lbSoldiers.Name = "lbSoldiers";
            this.lbSoldiers.Size = new System.Drawing.Size(600, 1155);
            this.lbSoldiers.TabIndex = 0;
            this.lbSoldiers.SelectedIndexChanged += new System.EventHandler(this.lbSoldiers_SelectedIndexChanged);
            // 
            // pgSoldiers
            // 
            this.pgSoldiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSoldiers.Location = new System.Drawing.Point(0, 0);
            this.pgSoldiers.Name = "pgSoldiers";
            this.pgSoldiers.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgSoldiers.Size = new System.Drawing.Size(836, 1155);
            this.pgSoldiers.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 157);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbSoldiers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pgSoldiers);
            this.splitContainer1.Size = new System.Drawing.Size(1440, 1155);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 2;
            // 
            // cmbBase
            // 
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(143, 55);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(469, 56);
            this.cmbBase.TabIndex = 3;
            this.cmbBase.SelectedIndexChanged += new System.EventHandler(this.cmbBase_SelectedIndexChanged);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(36, 55);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(101, 48);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base:";
            // 
            // btnMaxAll
            // 
            this.btnMaxAll.Location = new System.Drawing.Point(984, 42);
            this.btnMaxAll.Name = "btnMaxAll";
            this.btnMaxAll.Size = new System.Drawing.Size(225, 69);
            this.btnMaxAll.TabIndex = 5;
            this.btnMaxAll.Text = "Max All";
            this.btnMaxAll.UseVisualStyleBackColor = true;
            this.btnMaxAll.Click += new System.EventHandler(this.btnMaxAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1227, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 69);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHealAll
            // 
            this.btnHealAll.Location = new System.Drawing.Point(741, 42);
            this.btnHealAll.Name = "btnHealAll";
            this.btnHealAll.Size = new System.Drawing.Size(225, 69);
            this.btnHealAll.TabIndex = 7;
            this.btnHealAll.Text = "Heal All";
            this.btnHealAll.UseVisualStyleBackColor = true;
            this.btnHealAll.Click += new System.EventHandler(this.btnHealAll_Click);
            // 
            // FormViewSoldiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1324);
            this.Controls.Add(this.btnHealAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMaxAll);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormViewSoldiers";
            this.ShowIcon = false;
            this.Text = "Soldier Browser";
            this.Load += new System.EventHandler(this.FormViewSoldiers_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSoldiers;
        private System.Windows.Forms.PropertyGrid pgSoldiers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnMaxAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHealAll;
    }
}