using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterDataGridView
{
    public partial class Form1 : Form
    {
        List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Bakri Alloush", Job = "Engineer" },
                new Employee(){ Id = 2, Name = "Molham Alloush", Job = "Coder" },
                new Employee(){ Id = 3, Name = "Sami Ali", Job = "Teacher" },
                new Employee(){ Id = 4, Name = "Ali Kamel", Job = "Tester" },
            };
            dataGridView1.DataSource = employees;
        }

        private void textBox1_TextChanged(object sender, EventArgs a)
        {
            var filtered = employees
                .Where(e => e.Name.ToLower().Contains(textBox1.Text.ToLower()) || e.Job.ToLower().Contains(textBox1.Text.ToLower()))
                .ToList();

            dataGridView1.DataSource = filtered;
        }
    }

    class Employee // موظف
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
