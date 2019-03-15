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
        public BalancerReference.Request currentRequest = clientReference.NewRequest();
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(1);
            form.tbName.Text = currentRequest.Plane.Name;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currentRequest.Plane.Name = form.tbName.Text.Trim();
                labelName.Text = form.tbName.Text.Trim();
            }
            form.Dispose();
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            ChangeNameOrType form = new ChangeNameOrType();

            form.ChangeType(2);
            form.cbType.SelectedIndex = currentRequest.Plane.PlaneType - 1;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                currentRequest.Plane.PlaneType = form.cbType.SelectedIndex + 1;
                labelType.Text = getTypeString(currentRequest.Plane.PlaneType);
            }
            form.Dispose();
        }

        private void btnTakeOff_Click(object sender, EventArgs e)
        {
            if (currentRequest.Plane.State == 0)
            {
                currentRequest = randomizeDifficulty(currentRequest);
                currentRequest.RequestType = 1;
                currentRequest.SenderIP = clientReference.Endpoint.Address.Uri.Authority;
                clientReference.MakeRequest(currentRequest);
            }
            else
            {
                MessageBox.Show("Вы не находитесь в ангаре!");
            }
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            if (currentRequest.Plane.State == -1)
            {
                currentRequest = randomizeDifficulty(currentRequest);
                currentRequest.RequestType = 2;
                currentRequest.SenderIP = clientReference.Endpoint.Address.Uri.Authority;
                clientReference.MakeRequest(currentRequest);
            }
            else
            {
                MessageBox.Show("Вы не находитесь в воздухе!");
            }
        }

        private BalancerReference.Request randomizeDifficulty(BalancerReference.Request request)
        {
            request.RequestDifficulty = random.Next(10, 40);
            request.RequestTime = random.Next(1000, 10000);

            return request;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelName.Text = currentRequest.Plane.Name;
            labelState.Text = getPositionString(currentRequest.Plane.State);
            labelType.Text = getTypeString(currentRequest.Plane.PlaneType);
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
