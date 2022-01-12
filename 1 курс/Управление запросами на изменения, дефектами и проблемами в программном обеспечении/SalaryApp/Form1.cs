using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace SalaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEngineer_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text);
            labelFullName.Text = employee.FullNameOutput();
            Engener engener = new Engener(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text, textBoxPremium.Text);
            labelSalary.Text = $"{engener.PayrollToEngineer()} р.";
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text);
            labelFullName.Text = employee.FullNameOutput();
            Worker worker = new Worker(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text, Convert.ToDouble(textBoxHours.Text));
            labelSalary.Text = $"{worker.PayrollToWorker()} р.";
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text);
            labelFullName.Text = employee.FullNameOutput();
            Manager manager = new Manager(textBoxSurname.Text, textBoxFirstName.Text, textBoxPatronymic.Text, Convert.ToInt32(textBoxBusiness.Text));
            labelSalary.Text = $"{manager.PayrollToManager()} р.";
        }
    }
}