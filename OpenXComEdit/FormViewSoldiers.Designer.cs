
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
            // 
            // pgSoldiers
            // 
            this.pgSoldiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSoldiers.Location = new System.Drawing.Point(0, 0);
            this.pgSoldiers.Name = "pgSoldiers";
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
            // FormViewSoldiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1324);
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

        }

        #endregion

        private System.Windows.Forms.ListBox lbSoldiers;
        private System.Windows.Forms.PropertyGrid pgSoldiers;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}