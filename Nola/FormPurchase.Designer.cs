namespace Nola
{
    partial class FormPurchase
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
            this.dataGridPurchase = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePurchase = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.viewCheckPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nolaDBDataSet3 = new Nola.NolaDBDataSet3();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nolaDBDataSet2 = new Nola.NolaDBDataSet2();
            this.viewAccountBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAccountBalanceTableAdapter = new Nola.NolaDBDataSet2TableAdapters.viewAccountBalanceTableAdapter();
            this.viewCheckPurchaseTableAdapter = new Nola.NolaDBDataSet3TableAdapters.viewCheckPurchaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccountBalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPurchase
            // 
            this.dataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPurchase.Location = new System.Drawing.Point(-4, 164);
            this.dataGridPurchase.Name = "dataGridPurchase";
            this.dataGridPurchase.Size = new System.Drawing.Size(541, 224);
            this.dataGridPurchase.TabIndex = 65;
            this.dataGridPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridExpense_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Date";
            // 
            // dateTimePurchase
            // 
            this.dateTimePurchase.Location = new System.Drawing.Point(134, 132);
            this.dateTimePurchase.Name = "dateTimePurchase";
            this.dateTimePurchase.Size = new System.Drawing.Size(167, 20);
            this.dateTimePurchase.TabIndex = 63;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(134, 46);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCar.TabIndex = 62;
            // 
            // viewCheckPurchaseBindingSource
            // 
            this.viewCheckPurchaseBindingSource.DataMember = "viewCheckPurchase";
            this.viewCheckPurchaseBindingSource.DataSource = this.nolaDBDataSet3;
            // 
            // nolaDBDataSet3
            // 
            this.nolaDBDataSet3.DataSetName = "NolaDBDataSet3";
            this.nolaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(413, 104);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 61;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.btn_delPurchase_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(413, 44);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 60;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(134, 14);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(413, 75);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 57;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 45);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(134, 73);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 55;
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(134, 103);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(100, 20);
            this.textFee.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buyer Fee";
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
            // viewCheckPurchaseTableAdapter
            // 
            this.viewCheckPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.dataGridPurchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePurchase);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormPurchase";
            this.Text = "FormPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nolaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccountBalanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePurchase;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private NolaDBDataSet2 nolaDBDataSet2;
        private System.Windows.Forms.BindingSource viewAccountBalanceBindingSource;
        private NolaDBDataSet2TableAdapters.viewAccountBalanceTableAdapter viewAccountBalanceTableAdapter;
        private NolaDBDataSet3 nolaDBDataSet3;
        private System.Windows.Forms.BindingSource viewCheckPurchaseBindingSource;
        private NolaDBDataSet3TableAdapters.viewCheckPurchaseTableAdapter viewCheckPurchaseTableAdapter;
    }
}