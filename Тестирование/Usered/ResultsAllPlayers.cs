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
    public partial class ResultsAllPlayers : Form
    {
        public ResultsAllPlayers()
        {
            InitializeComponent();
            this.ControlBox = false;
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
      

        private void ResultsAllPlayers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proversDataSet.Registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.proversDataSet.Registration);
        }


        private void txtSearchLog_TextChanged(object sender, EventArgs e)
        {
            using (Context db = new Context()) // поиск в бд по логину
            {
                object reg = db.Registrations.Where(d => d.Login == txtSearchLog.Text).Select(d =>
                   new
                   {
                       d.id,
                       d.Name,
                       d.Login,
                       d.Score
                   }
                    ).ToList();
                datagridSorts.DataSource = reg;
            }

        }
    }
}
