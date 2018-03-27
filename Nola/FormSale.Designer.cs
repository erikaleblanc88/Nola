namespace Nola
{
    partial class FormSale
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
            this.dataGridSale = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeSale = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSale
            // 
            this.dataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSale.Location = new System.Drawing.Point(14, 155);
            this.dataGridSale.Name = "dataGridSale";
            this.dataGridSale.Size = new System.Drawing.Size(541, 224);
            this.dataGridSale.TabIndex = 80;
            this.dataGridSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSale_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Date";
            // 
            // dateTimeSale
            // 
            this.dateTimeSale.Location = new System.Drawing.Point(152, 99);
            this.dateTimeSale.Name = "dateTimeSale";
            this.dateTimeSale.Size = new System.Drawing.Size(167, 20);
            this.dateTimeSale.TabIndex = 78;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(152, 37);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCar.TabIndex = 77;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(431, 95);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 76;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(431, 36);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 75;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(152, 5);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(431, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 72;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(431, 36);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 71;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(152, 64);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Car";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.dataGridSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeSale);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormSale";
            this.Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeSale;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}