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
    public partial class SelectedAge : Form
    {
        public SelectedAge()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests();
            tests.Show();
            this.Hide();
        }

        private void btnOverDown_Click(object sender, EventArgs e)
        {
            OverDownForm downForm = new OverDownForm();
            downForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.s.Show();
            this.Close();
        }

        private void btnNumThree_Click(object sender, EventArgs e)
        {
            GoldenMean goldenMean = new GoldenMean();
            goldenMean.Show();
            this.Hide();
        }

        private void btnNumFour_Click(object sender, EventArgs e)
        {
            BasicForms.dHistory experienced = new BasicForms.dHistory();
            experienced.Show();
            this.Hide();
        }

        private void btnLevelOptions_Click(object sender, EventArgs e)
        {
            Description des = new Description();
            des.Show();
            this.Hide();
        }

        private void btnRedactTests_Click(object sender, EventArgs e)
        {
            RedactTests redact = new RedactTests();
            redact.Show();
        }

        private void SelectedAge_Load(object sender, EventArgs e)
        {
            if (RoleClass.type == "U")
            {
                btnRedactTests.Visible = false;
            }
        }

        private void btnNumFive_Click(object sender, EventArgs e)
        {
            ePhisiks ep = new ePhisiks();
            ep.Show();
            this.Hide();
        }
    }
}
