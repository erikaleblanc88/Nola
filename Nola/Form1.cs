using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            ClsCar cc = new ClsCar();
            dataGridCar.DataSource = null;
            dataGridCar.DataSource = cc.listCars();
        }

        private void btnAddCar(object sender, EventArgs e)
        {
            ClsCar cc = new ClsCar();
            Car c = new Car();
            c.model = textModel.Text;
            c.color = textColor.Text;
            c.vin = textVin.Text;
            cc.addCar(c);
            limpar();
            fillGrid();
        }

        private void btn_delCar_Click(object sender, EventArgs e)
        {
            ClsCar cc = new ClsCar();
            Car c = new Car();
            c.IdCar = int.Parse(textId.Text);
            c.model = textModel.Text;
            c.color = textColor.Text;
            c.vin = textVin.Text;
            cc.deleteCar(c);
            limpar();
            fillGrid();
        }

        public void limpar()
        {
            textId.Text = "";
            textModel.Text = "";
            textColor.Text = "";
            textVin.Text = "";
        }

        private void dataGridCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            Car c1 = new Car();
            c1 = dataGridCar.CurrentRow.DataBoundItem as Car;
            textId.Text = c1.IdCar.ToString();
            textModel.Text = c1.model;
            textColor.Text = c1.color;
            textVin.Text = c1.vin;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClsCar cc = new ClsCar();
            Car antigo = new Car();
            antigo.IdCar = int.Parse(textId.Text);

            Car novo = new Car();
            novo.model = textModel.Text;
            novo.color = textColor.Text;
            novo.vin = textVin.Text;
            cc.updateCar(antigo, novo);
            limpar();
            fillGrid();
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonAdd.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            limpar();
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonAdd.Visible = true;
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExp formExp = new FormExp();
            formExp.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPurchase formPurchase = new FormPurchase();
            formPurchase.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSale formSale = new FormSale();
            formSale.Show();
        }

        private void accountBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }
    }
}
