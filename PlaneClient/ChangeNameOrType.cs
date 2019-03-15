using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneClient
{
    public partial class ChangeNameOrType : Form
    {
        private int askType = 1;

        public ChangeNameOrType()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool checkInput()
        {
            if (askType == 1)
            {
                if (tbName.Text.Trim().Length != 0)
                    return true;
                MessageBox.Show("Введите название!");
                return false;
            }
            return true;
        }

        public void ChangeType(int nextType)
        {
            askType = nextType;

            DrawForm();
        }

        private void DrawForm()
        {
            switch (askType)
            {
                case 1:
                    tbName.Visible = true;
                    cbType.Visible = false;
                    labelQuestion.Text = "Введите новое название";
                    break;
                case 2:
                    tbName.Visible = false;
                    cbType.Visible = true;
                    labelQuestion.Text = "Выберите тип самолёта";
                    break;
            }
        }
    }
}
