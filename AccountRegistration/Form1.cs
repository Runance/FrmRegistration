using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            this.Load += FrmRegistration_Load;
        }
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            Program.Items.Add("BS in Information Technology");
            Program.Items.Add("BS in Computer Science");
            Program.Items.Add("BS in Information Systems");
            Program.Items.Add("BS in Computer Engineer");
            Program.Items.Add("BS in Cybersecurity");
            Program.Items.Add("BS in Multimedia Arts");

            Program.SelectedIndex = -1; 
        }
        private void Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Convert.ToInt64(StudentNo.Text);
            StudentInfoClass.LastName = LastName.Text;
            StudentInfoClass.FirstName = FirstName.Text;
            StudentInfoClass.MiddleName = MiddleName.Text;
            StudentInfoClass.Age = Convert.ToInt64(Age.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(ContactNo.Text);
            StudentInfoClass.Address = Address.Text;
            StudentInfoClass.Program = Program.Text;

            FrmConfirm confirmForm = new FrmConfirm();
            
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
            
                StudentNo.Clear();
                LastName.Clear();
                FirstName.Clear();
                MiddleName.Clear();
                Age.Clear();
                ContactNo.Clear();
                Address.Clear();
                Program.SelectedIndex = -1;
            }
        }

    }
}
