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
        public BalancerReference.Plane currnetPlane = clientReference.NewPlane();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(1);
            form.tbName.Text = currnetPlane.Name;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currnetPlane.Name = form.tbName.Text;
                labelName.Text = form.tbName.Text;
            }
            form.Dispose();
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(2);
            form.cbType.SelectedIndex = currnetPlane.PlaneType - 1;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currnetPlane.PlaneType = form.cbType.SelectedIndex + 1;
                labelType.Text = getTypeString(currnetPlane.PlaneType);
            }
            form.Dispose();
        }

        private void btnTakeOff_Click(object sender, EventArgs e)
        {

        }

        private void btnLand_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelName.Text = currnetPlane.Name;
            labelState.Text = getPositionString(currnetPlane.State);
            labelType.Text = getTypeString(currnetPlane.PlaneType);
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
