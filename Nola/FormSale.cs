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
    public partial class FormSale : Form
    {
        public FormSale()
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
            ClsSale cs = new ClsSale();
            dataGridSale.DataSource = null;
            dataGridSale.DataSource = cs.listSale();
        }

        public void limpar()
        {
            textId.Text = "";
            textPrice.Text = "";
            comboBoxCar.SelectedItem = null;
        }

        private void dataGridSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            viewSaleCar e1 = new viewSaleCar();
            e1 = dataGridSale.CurrentRow.DataBoundItem as viewSaleCar;
            textId.Text = e1.idSale.ToString();
            comboBoxCar.SelectedValue = e1.IdCar;
            textPrice.Text = e1.price.ToString();
            dateTimeSale.Text = e1.date.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClsSale cs = new ClsSale();
            Sale s = new Sale();
            s.idCar = int.Parse(comboBoxCar.SelectedValue.ToString());
            s.price = decimal.Parse(textPrice.Text);
            s.date = DateTime.Parse(dateTimeSale.Text);
            cs.addSale(s);
            fillGrid();
            limpar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ClsSale cs = new ClsSale();
            Sale antigo = new Sale();
            antigo.IdSale = int.Parse(textId.Text);

            Sale novo = new Sale();
            novo.idCar = (int)comboBoxCar.SelectedValue;
            novo.price = decimal.Parse(textPrice.Text);
            novo.date = DateTime.Parse(dateTimeSale.Text);
            cs.updateSale(antigo, novo);
            fillGrid();
            limpar();
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonAdd.Visible = true;
        }
    }
}
