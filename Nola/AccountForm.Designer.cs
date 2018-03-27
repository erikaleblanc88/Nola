namespace Nola
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nolaDBDataSet2 = new Nola.NolaDBDataSet2();
            this.viewAccountBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAccountBalanceTableAdapter = new Nola.NolaDBDataSet2TableAdapters.viewAccountBalanceTableAdapter();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccountBalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseDateDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.vinDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.buyerFeeDataGridViewTextBoxColumn,
            this.expensesDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.accountBalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewAccountBalanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // nolaDBDataSet2
            // 
            this.nolaDBDataSet2.DataSetName = "NolaDBDataSet2";
            this.nolaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAccountBalanceBindingSource
            // 
            this.viewAccountBalanceBindingSource.DataMember = "viewAccountBalance";
            this.viewAccountBalanceBindingSource.DataSource = this.nolaDBDataSet2;
            // 
            // viewAccountBalanceTableAdapter
            // 
            this.viewAccountBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Date";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase_Date";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase_Price";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // buyerFeeDataGridViewTextBoxColumn
            // 
            this.buyerFeeDataGridViewTextBoxColumn.DataPropertyName = "Buyer_Fee";
            this.buyerFeeDataGridViewTextBoxColumn.HeaderText = "Buyer_Fee";
            this.buyerFeeDataGridViewTextBoxColumn.Name = "buyerFeeDataGridViewTextBoxColumn";
            // 
            // expensesDataGridViewTextBoxColumn
            // 
            this.expensesDataGridViewTextBoxColumn.DataPropertyName = "Expenses";
            this.expensesDataGridViewTextBoxColumn.HeaderText = "Expenses";
            this.expensesDataGridViewTextBoxColumn.Name = "expensesDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            this.profitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBalanceDataGridViewTextBoxColumn
            // 
            this.accountBalanceDataGridViewTextBoxColumn.DataPropertyName = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.HeaderText = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.Name = "accountBalanceDataGridViewTextBoxColumn";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccountBalanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NolaDBDataSet2 nolaDBDataSet2;
        private System.Windows.Forms.BindingSource viewAccountBalanceBindingSource;
        private NolaDBDataSet2TableAdapters.viewAccountBalanceTableAdapter viewAccountBalanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalanceDataGridViewTextBoxColumn;
    }
}