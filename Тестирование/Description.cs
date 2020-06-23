using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnCloser_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы все прочитали и готовы идти проверять свои знания?", "Внимание!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                SelectedAge age = new SelectedAge();
                age.Show();
                this.Close();
            }
            else if (dialog == DialogResult.Cancel)
            {
            }

        }
    }
    }

