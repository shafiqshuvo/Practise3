using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        Salary salary = new Salary();
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {

            salary.Name = employeeNameTextBox.Text;
            salary.Basic = Convert.ToDouble(basicAmountTextBox.Text);
            salary.Houserent = Convert.ToDouble(homeRentTextBox.Text);
            salary.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(salary.GetSalary());
        }
    }
}
