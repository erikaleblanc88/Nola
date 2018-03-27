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
    public partial class FormPurchase : Form
    {
        public FormPurchase()
        {
            InitializeComponent();
            fillGrid();
            ClsCar clsCar = new ClsCar();
            comboBoxCar.DataSource = clsCar.listCars();
            comboBoxCar.DisplayMember = "model";
            comboBoxCar.ValueMember = "idCar";
            limpar();
        }

        private void fillGrid()
        {
            ClsPurchase cp = new ClsPurchase();
            dataGridPurchase.DataSource = null;
            dataGridPurchase.DataSource = cp.listPurchase();
        }

        public void limpar()
        {
            textId.Text = "";
            textFee.Text = "";
            textPrice.Text = "";
            comboBoxCar.SelectedItem = null;
        }

        private void dataGridExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            viewPurchaseCar e1 = new viewPurchaseCar();
            e1 = dataGridPurchase.CurrentRow.DataBoundItem as viewPurchaseCar;
            textId.Text = e1.idPurchase.ToString();
            comboBoxCar.SelectedValue = e1.IdCar;
            textPrice.Text = e1.price.ToString();
            textFee.Text = e1.fee.ToString();
            dateTimePurchase.Text = e1.date.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClsPurchase cp = new ClsPurchase();
            Purchase p = new Purchase();
            p.idCar = int.Parse(comboBoxCar.SelectedValue.ToString());
            p.price = decimal.Parse(textPrice.Text);
            p.fee = decimal.Parse(textFee.Text);
            p.date = DateTime.Parse(dateTimePurchase.Text);
            cp.addPurchase(p);
            fillGrid();
            limpar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClsPurchase cp = new ClsPurchase();
            Purchase antigo = new Purchase();
            antigo.IdPurchase = int.Parse(textId.Text);

            Purchase novo = new Purchase();
            novo.fee = decimal.Parse(textFee.Text);
            novo.idCar = (int)comboBoxCar.SelectedValue;
            novo.price = decimal.Parse(textPrice.Text);
            novo.date = DateTime.Parse(dateTimePurchase.Text);
            cp.updatePurchase(antigo, novo);
            fillGrid();
            limpar();
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonAdd.Visible = true;
        }

        private void btn_delPurchase_Click(object sender, EventArgs e)
        {
            ClsPurchase cp = new ClsPurchase();
            Purchase p = new Purchase();
            p.IdPurchase = int.Parse(textId.Text);
            cp.deletePurchase(p);
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

    }
}
