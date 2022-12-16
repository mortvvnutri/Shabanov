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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.база_данных11DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных11DataSet.Меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.база_данных11DataSet.Меню);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных11DataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.база_данных11DataSet.Заказ);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //double ant, bnt;
            //ant = Convert.ToDouble(цена_)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.база_данных11DataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.менюTableAdapter.Fill(this.база_данных11DataSet.Меню);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ant;
            ant = Convert.ToDouble(comboBox1.Text) + Convert.ToDouble(comboBox6.Text) + Convert.ToDouble(comboBox4.Text);
            textBox1.Text = ant.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
