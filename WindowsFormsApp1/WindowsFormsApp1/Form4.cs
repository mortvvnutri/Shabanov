using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void менюBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.менюBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.база_данных11DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных11DataSet.Меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.база_данных11DataSet.Меню);

        }

        private void единица_измеренияTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void единица_измеренияLabel_Click(object sender, EventArgs e)
        {

        }

        private void ценаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
