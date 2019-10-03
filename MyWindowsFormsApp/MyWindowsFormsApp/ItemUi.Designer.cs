namespace MyWindowsFormsApp
{
    partial class ItemUi
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
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(44, 122);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(136, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(136, 86);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Price});
            this.showDataGridView.Location = new System.Drawing.Point(35, 176);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(434, 150);
            this.showDataGridView.TabIndex = 3;
            //this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick);
            this.showDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showDataGridView_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(136, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(136, 122);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MyWindowsFormsApp.Model.Item);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MyWindowsFormsApp.Model.Customer);
            // 
            // ItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 339);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            
            this.Text = "Item Information";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}