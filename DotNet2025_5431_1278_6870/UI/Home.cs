using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            cashRegisterBtn.BackColor = Color.Transparent;
            cashRegisterBtn.FlatAppearance.BorderSize = 0;
            manageBtn.BackColor = Color.Transparent;
            manageBtn.FlatAppearance.BorderSize = 0;
        }
        private void cashRegisterBtn_Click(object sender, EventArgs e)
        {
            Saleman form = new Saleman();
            form.Show();
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            ManagerMenu form = new ManagerMenu();
            form.Show();
        }

        private void cashRegisterBtn_MouseHover(object sender, EventArgs e)
        {
            cashRegisterBtn.BackColor = Color.Blue;
            cashRegisterBtn.FlatStyle = FlatStyle.Flat;
        }

    }
}
