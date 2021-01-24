
namespace OpenXComEdit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWriteYAML = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWriteYAML
            // 
            this.btnWriteYAML.Location = new System.Drawing.Point(25, 43);
            this.btnWriteYAML.Name = "btnWriteYAML";
            this.btnWriteYAML.Size = new System.Drawing.Size(225, 69);
            this.btnWriteYAML.TabIndex = 0;
            this.btnWriteYAML.Text = "Write YAML";
            this.btnWriteYAML.UseVisualStyleBackColor = true;
            this.btnWriteYAML.Click += new System.EventHandler(this.btnWriteYAML_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(25, 207);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1768, 797);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 1030);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnWriteYAML);
            this.Name = "Form1";
            this.Text = "YAML Testing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWriteYAML;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

