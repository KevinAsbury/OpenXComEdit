using System;
using System.Windows.Forms;

namespace OpenXComEdit
{
    public partial class FormSaveAs : Form
    {
        public FormSaveAs()
        {
            InitializeComponent();
        }

        private void SaveAs_Load(object sender, EventArgs e)
        {
            txtName.Text = State.SaveFile.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                State.SaveFile.Name = txtName.Text;
                Close();
            }
        }
    }
}
