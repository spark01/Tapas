namespace MyWindowsFormsApp
{
    partial class CustomerUi
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addresTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(239, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(239, 104);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // addresTextBox
            // 
            this.addresTextBox.Location = new System.Drawing.Point(239, 67);
            this.addresTextBox.Name = "addresTextBox";
            this.addresTextBox.Size = new System.Drawing.Size(100, 20);
            this.addresTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 165);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(441, 165);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(360, 165);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(279, 165);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.Location = new System.Drawing.Point(187, 165);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(75, 23);
            this.deletButton.TabIndex = 10;
            this.deletButton.Text = "Delete";
            this.deletButton.UseVisualStyleBackColor = true;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(50, 238);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(554, 172);
            this.showDataGridView.TabIndex = 11;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(239, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // CustomerUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.deletButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CustomerUi";
            this.Text = "CustomerUi";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addresTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
    }
}