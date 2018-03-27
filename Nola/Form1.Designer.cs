namespace Nola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.textVin = new System.Windows.Forms.TextBox();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vin";
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(140, 71);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(100, 20);
            this.textModel.TabIndex = 6;
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(140, 98);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 20);
            this.textColor.TabIndex = 7;
            // 
            // textVin
            // 
            this.textVin.Location = new System.Drawing.Point(140, 125);
            this.textVin.Name = "textVin";
            this.textVin.Size = new System.Drawing.Size(100, 20);
            this.textVin.TabIndex = 8;
            // 
            // dataGridCar
            // 
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCar.Location = new System.Drawing.Point(293, 38);
            this.dataGridCar.Name = "dataGridCar";
            this.dataGridCar.ReadOnly = true;
            this.dataGridCar.Size = new System.Drawing.Size(441, 215);
            this.dataGridCar.TabIndex = 10;
            this.dataGridCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCar_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 198);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.btnAddCar);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(102, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(140, 42);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 14;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(9, 198);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(9, 227);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.btn_delCar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carToolStripMenuItem,
            this.expenseToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.expenseToolStripMenuItem.Text = "Expense";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountBalanceToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // accountBalanceToolStripMenuItem
            // 
            this.accountBalanceToolStripMenuItem.Name = "accountBalanceToolStripMenuItem";
            this.accountBalanceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.accountBalanceToolStripMenuItem.Text = "Account Balance";
            this.accountBalanceToolStripMenuItem.Click += new System.EventHandler(this.accountBalanceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 297);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridCar);
            this.Controls.Add(this.textVin);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.TextBox textVin;
        private System.Windows.Forms.DataGridView dataGridCar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountBalanceToolStripMenuItem;
    }
}

