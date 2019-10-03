namespace MyWindowsFormsApp
{
    partial class OrderUi
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
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(116, 69);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(162, 130);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(252, 9);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(617, 199);
            this.showDataGridView.TabIndex = 9;
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.customerBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(116, 12);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerComboBox.TabIndex = 10;
            this.customerComboBox.ValueMember = "Id";
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MyWindowsFormsApp.Model.Customer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Name";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource1;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(116, 39);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 13;
            this.itemComboBox.ValueMember = "Id";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(MyWindowsFormsApp.Model.Item);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MyWindowsFormsApp.Model.Item);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(116, 95);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            // 
            // OrderUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Name = "OrderUi";
            this.Text = "OrderUi";
            this.Load += new System.EventHandler(this.OrderUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label5;
    }
}