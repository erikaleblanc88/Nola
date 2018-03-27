namespace Nola
{
    partial class FormExp
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
            this.dataGridExpense = new System.Windows.Forms.DataGridView();
            this.viewExpenseCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nolaDBDataSet1 = new Nola.NolaDBDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeExpense = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewExpenseCarTableAdapter = new Nola.NolaDBDataSet1TableAdapters.viewExpenseCarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExpenseCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExpense
            // 
            this.dataGridExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpense.Location = new System.Drawing.Point(2, 153);
            this.dataGridExpense.Name = "dataGridExpense";
            this.dataGridExpense.Size = new System.Drawing.Size(541, 224);
            this.dataGridExpense.TabIndex = 50;
            this.dataGridExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridExpense_CellClick);
            // 
            // viewExpenseCarBindingSource
            // 
            this.viewExpenseCarBindingSource.DataMember = "viewExpenseCar";
            this.viewExpenseCarBindingSource.DataSource = this.nolaDBDataSet1;
            // 
            // nolaDBDataSet1
            // 
            this.nolaDBDataSet1.DataSetName = "NolaDBDataSet1";
            this.nolaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Date";
            // 
            // dateTimeExpense
            // 
            this.dateTimeExpense.Location = new System.Drawing.Point(140, 112);
            this.dateTimeExpense.Name = "dateTimeExpense";
            this.dateTimeExpense.Size = new System.Drawing.Size(167, 20);
            this.dateTimeExpense.TabIndex = 48;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(140, 59);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCar.TabIndex = 47;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(419, 93);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 46;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.btn_delExp_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(419, 35);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 45;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(140, 3);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(419, 64);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(419, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(140, 86);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 40;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(140, 32);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 20);
            this.textDescription.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Description";
            // 
            // viewExpenseCarTableAdapter
            // 
            this.viewExpenseCarTableAdapter.ClearBeforeFill = true;
            // 
            // FormExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 377);
            this.Controls.Add(this.dataGridExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeExpense);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormExp";
            this.Text = "FormExp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExpenseCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeExpense;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private NolaDBDataSet1 nolaDBDataSet1;
        private System.Windows.Forms.BindingSource viewExpenseCarBindingSource;
        private NolaDBDataSet1TableAdapters.viewExpenseCarTableAdapter viewExpenseCarTableAdapter;
    }
}