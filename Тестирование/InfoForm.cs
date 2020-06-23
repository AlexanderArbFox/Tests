using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Тестирование
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите перейти на сайт <<ATG>>?", "Внимание!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Process.Start("http://localhost:61219/home");
            }
            else if (dialog == DialogResult.Cancel)
            {

            }
           }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
