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
    public partial class MainForm : Form
    {
        public static BalancerReference.BalancerServiceSoapClient clientReference = new BalancerReference.BalancerServiceSoapClient();
        public BalancerReference.Plane currentPlane = clientReference.NewPlane();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(1);
            form.tbName.Text = currentPlane.Name;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currentPlane.Name = form.tbName.Text.Trim();
                labelName.Text = form.tbName.Text.Trim();
            }
            form.Dispose();
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(2);
            form.cbType.SelectedIndex = currentPlane.PlaneType - 1;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currentPlane.PlaneType = form.cbType.SelectedIndex + 1;
                labelType.Text = getTypeString(currentPlane.PlaneType);
            }
            form.Dispose();
        }

        private void btnTakeOff_Click(object sender, EventArgs e)
        {
            if (currentPlane.State == 0)
            {
                clientReference.
            }
            else
            {
                MessageBox.Show("Вы не находитесь в ангаре!");
            }
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            if (currentPlane.State == -1)
            {

            }
            else
            {
                MessageBox.Show("Вы не находитесь в воздухе!");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelName.Text = currentPlane.Name;
            labelState.Text = getPositionString(currentPlane.State);
            labelType.Text = getTypeString(currentPlane.PlaneType);
        }

        private string getPositionString(int position)
        {
            switch (position)
            {
                case -1:
                    return "Воздух";
                case 0:
                    return "Ангар";
            }

            return "Полоса №" + position;
        }

        private string getTypeString(int type)
        {
            switch (type)
            {
                case 1:
                    return "Большой";
                case 2:
                    return "Маленький";
                default:
                    return "Большой";
            }
        }
    }
}
