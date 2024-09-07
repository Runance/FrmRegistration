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
    public partial class FrmConfirm : Form
    {
        private StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            this.Load += FrmConfirm_Load;

           
            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }

         private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}