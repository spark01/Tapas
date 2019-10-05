using System;
using System.Windows.Forms;
using StudentUi.Model;
using StudentUi.BLL;

namespace StudentUi
{
    public partial class StudentUi : Form
    {
        ErrorProvider ep = new ErrorProvider();
        StudentManager _studentManager = new StudentManager();
        DistrictManager _districtManager = new DistrictManager();
        Student student = new Student();
        int er = 0;
        
        public StudentUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if ((codeTextBox.Text.Equals("") || codeTextBox.Text.Length != 4))
            {
                er++;
                ep.SetError(codeTextBox, "Enter your Id and Id Must be 4 charecter");
                return;

            }
            if (_studentManager.IsNameExist(student))
            {
                er++;
                ep.SetError(codeTextBox, "Please Inser  Unique Code");
                //ep.SetError(contactTextBox, "Enter your Id and Id Must be 4 charecter");
                //MessageBox.Show(codeTextBox.Text + " Already Exist!!");

                return;
            }

            if ((contactTextBox.Text.Equals("") || contactTextBox.Text.Length != 11))
            {
                er++;
                ep.SetError(contactTextBox, "please insert 11 charecter");
                return;

            }

            if (_studentManager.IsContactExist(student))
            {
                er++;
                
                ep.SetError(contactTextBox, "unique contact need");
                

                return;
            }
            if ((nameTextBox.Text.Equals("")))
            {
                er++;
                ep.SetError(nameTextBox, "insert name");
                return;

            }
            if (districtComboBox.SelectedItem ==null)
            {
                er++;
                ep.SetError(districtComboBox, "insert District Name");
                return;

            }


            student.StudentCode = codeTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Address = addressTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.DistrictId = Convert.ToInt32(districtComboBox.SelectedValue);


            if (addButton.Text == "add")
            {
                
                if (_studentManager.Add(student))
                {
                    MessageBox.Show("added");
                    addDataGridView.DataSource = _studentManager.Display();
                    clear();
                }
            }
            else
            {
                student.Id = Convert.ToInt32(idTextBox.Text);
                if (_studentManager.Update(student))
                {
                    MessageBox.Show("Update");
                    addDataGridView.DataSource = _studentManager.Display();
                    clear();
                }
            }

            

        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            idTextBox.Visible = false;
            addDataGridView.DataSource = _studentManager.Display();
            for (int i = 0; i < addDataGridView.Rows.Count; i++)
            {
                (addDataGridView.Columns[1]).Visible = false;
                (addDataGridView.Columns[6]).Visible = false;
            }
            AllComboLOad();
        }

         public void AllComboLOad()
        {
            districtComboBox.DataSource = _districtManager.loadCombo();
            districtComboBox.DisplayMember = "Name";
            districtComboBox.ValueMember = "Id";
            districtComboBox.SelectedIndex = 0;

        }

        //private void addDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    idTextBox.Text = addDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
        //    codeTextBox.Text = addDataGridView.SelectedRows[0].Cells["StudentCode"].Value.ToString();
        //    nameTextBox.Text = addDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
        //    addressTextBox.Text = addDataGridView.SelectedRows[0].Cells["Address"].Value.ToString();
        //    contactTextBox.Text = addDataGridView.SelectedRows[0].Cells["Contact"].Value.ToString();
        //    districtComboBox.Text = addDataGridView.SelectedRows[0].Cells["DistrictId"].Value.ToString();
        //}

        //private void addDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //    idTextBox.Text = addDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
        //    codeTextBox.Text = addDataGridView.SelectedRows[0].Cells["StudentCode"].Value.ToString();
        //    nameTextBox.Text = addDataGridView.SelectedRows[0].Cells["Student Name"].Value.ToString();
        //    addressTextBox.Text = addDataGridView.SelectedRows[0].Cells["Address"].Value.ToString();
        //    contactTextBox.Text = addDataGridView.SelectedRows[0].Cells["Contact"].Value.ToString();
        //    districtComboBox.SelectedValue =Convert.ToInt32(addDataGridView.SelectedRows[0].Cells["DistrictId"].Value.ToString());

        //    addButton.Text = "Update";
        //}

        private void searchButton_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if ((codeTextBox.Text.Equals("") || codeTextBox.Text.Length != 4))
            {
                er++;
                ep.SetError(codeTextBox, "For Search insert your search code");
                return;

            }
            

            student.StudentCode = codeTextBox.Text;
            addDataGridView.DataSource = _studentManager.Search(student);

        }

        private void addDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = addDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
            codeTextBox.Text = addDataGridView.SelectedRows[0].Cells["StudentCode"].Value.ToString();
            nameTextBox.Text = addDataGridView.SelectedRows[0].Cells["Student Name"].Value.ToString();
            addressTextBox.Text = addDataGridView.SelectedRows[0].Cells["Address"].Value.ToString();
            contactTextBox.Text = addDataGridView.SelectedRows[0].Cells["Contact"].Value.ToString();
            districtComboBox.SelectedValue = Convert.ToInt32(addDataGridView.SelectedRows[0].Cells["DistrictId"].Value.ToString());

            addButton.Text = "Update";
        }
        public void clear()
        {
            codeTextBox.Text = "";
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            contactTextBox.Text = "";
            districtComboBox.Text ="--please Select District--";
        }
    }
}
