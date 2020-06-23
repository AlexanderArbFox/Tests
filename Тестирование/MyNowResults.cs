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
    public partial class MyNowResults : Form
    {
        public MyNowResults()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SelectedAge selected = new SelectedAge();
            selected.Show();
            this.Close();
        }
    }
}
