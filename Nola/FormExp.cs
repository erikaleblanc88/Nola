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
    public partial class FormExp : Form
    {
        public FormExp()
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
            ClsExpense ce = new ClsExpense();
            dataGridExpense.DataSource = null;
            dataGridExpense.DataSource = ce.listExpense();
        }

        public void limpar()
        {
            textId.Text = "";
            textDescription.Text = "";
            textPrice.Text = "";
            comboBoxCar.SelectedItem = null;
        }

        private void dataGridExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            viewExpenseCar e1 = new viewExpenseCar();
            e1 = dataGridExpense.CurrentRow.DataBoundItem as viewExpenseCar;
            textId.Text = e1.idExpense.ToString();
            comboBoxCar.SelectedValue = e1.IdCar;
            textPrice.Text = e1.price.ToString();
            textDescription.Text = e1.description;
            dateTimeExpense.Text = e1.date.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClsExpense ce = new ClsExpense();
            Expense exp = new Expense();
            exp.description = textDescription.Text;
            exp.idCar = int.Parse(comboBoxCar.SelectedValue.ToString());
            exp.price = decimal.Parse(textPrice.Text);
            exp.date = DateTime.Parse(dateTimeExpense.Text);
            ce.addExpense(exp);
            fillGrid();
            limpar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClsExpense ce = new ClsExpense();
            Expense antigo = new Expense();
            antigo.IdExpense = int.Parse(textId.Text);

            Expense novo = new Expense();
            novo.description = textDescription.Text;
            novo.idCar = (int)comboBoxCar.SelectedValue;
            novo.price = decimal.Parse(textPrice.Text);
            novo.date = DateTime.Parse(dateTimeExpense.Text);
            ce.updateExpense(antigo, novo);
            fillGrid();
            limpar();
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonAdd.Visible = true;
        }

        private void btn_delExp_Click(object sender, EventArgs e)
        {
            ClsExpense ce = new ClsExpense();
            Expense exp = new Expense();
            exp.IdExpense = int.Parse(textId.Text);
            exp.description = textDescription.Text;
            exp.price = decimal.Parse(textPrice.Text);
            ce.deleteExpense(exp);
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
