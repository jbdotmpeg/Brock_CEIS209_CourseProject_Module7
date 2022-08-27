using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brock_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // add item to the employee listbox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;    //  end the method since the user cancelled the input

                // get user's input and create an Employee object
                string fName = frmInput.firstNameTextBox.Text;
                string lName = frmInput.lastNameTextBox.Text;
                string ssn = frmInput.ssnTextBox.Text;
                string date = frmInput.hireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.healthInsTextBox.Text;
                double lifeIns = Double.Parse(frmInput.lifeInsTextBox.Text);
                int vacation = Int32.Parse(frmInput.vacaDaysTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);

                Employee emp = new Employee(fName, lName, ssn, hireDate, benefits);

                // add the Employee object to the employees listbox
                EmployeesListBox.Items.Add(emp);

                //  write updated employees to file
                WriteEmpsToFile();

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);

                //  write updated employees to file
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            ReadEmpsFromFile();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        public void WriteEmpsToFile()
        {
            string fileName = "Employees.csv";

            StreamWriter writer = new StreamWriter(fileName);

            foreach (Employee emp in EmployeesListBox.Items)
            {
                writer.Write(emp.FirstName + ',');
                writer.Write(emp.LastName + ',');
                writer.Write(emp.SSN + ',');
                writer.WriteLine(emp.HireDate.ToShortDateString());
                writer.Write(emp.BenefitsPackage.Healthinsurance + ',');
                writer.Write(emp.BenefitsPackage.Lifeinsurance + ',');
                writer.Write(emp.BenefitsPackage.Vacation + ',');



            }
            writer.Close();
        }
        //public void ReadEmpsFromFile()
        //{
        //    string fileName = "Employee.csv";

        //    StreamReader reader = new StreamReader(fileName);

        //        while (reader.Peek() > -1)
        //        {
        //            // read  a single line from file
        //            string line = reader.ReadLine();
        //            string[] parts = line.Split(',');

        //            string fName = parts[0];
        //            string lName = parts[1];
        //            string ssn = parts[2];
        //            DateTime hireDate = DateTime.Parse(parts[3]);
        //            string healthIns = parts[4];
        //            double lifeIns = Double.Parse(parts[5]);
        //            int vacation = int.Parse(parts[6]);

        //            Benefits benefits = new Benefits(healthIns, lifeIns, vacation);

        //            Employee emp = new Employee(fName, lName, ssn, hireDate, benefits);

        //            EmployeesListBox.Items.Add(emp);

        //        }
        //    reader.Close();
        //}
        private void ReadEmpsFromFile()
        {
            // read all Employee objects from the file
            string fileName = "Employees.csv";

            StreamReader sr = new StreamReader(fileName);
            using (sr)
            {
                while (sr.Peek() > -1)
                {
                    // read the line and break it into parts based on commas
                    string line = sr.ReadLine();
                    string[] parts = line.Split(',');

                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);
                    string healthIns = parts[4];
                    double lifeIns = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    // create the Employee object and add it to the listbox
                    Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                    Employee emp = new Employee(fName, lName, ssn,
                         hireDate, benefits);
                    EmployeesListBox.Items.Add(emp);
                }
                sr.Close();
            }

            //private void MainForm_Load(object sender, EventArgs  e)
            //{
            //    ReadEmpsFromFile();
            //}
        }

    }// class
}//  namespace
