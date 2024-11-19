using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBTitle.TabStop = false;
            TBTitle.ForeColor = Color.LightGray;
            TBTitle.Text = "Enter title";

            Task task = new Task();
            task.Deserialize("Tasks.xml", ref tasks);

            if (tasks.Count > 0)
            {
                foreach (Task t in tasks)
                {
                    CLB.Items.Add(t.Title);
                }
            }

            LTotalTasks.Text = tasks.Count.ToString();
        }

        private void TBTitle_Enter(object sender, EventArgs e)
        {
            if (String.Equals(TBTitle.Text, "Enter title"))
            {
                TBTitle.ForeColor = Color.Black;
                TBTitle.Clear();
            }
        }

        private void TBTitle_Leave(object sender, EventArgs e)
        {
            if (String.Equals(TBTitle.Text, ""))
            {
                TBTitle.ForeColor = Color.LightGray;
                TBTitle.Text = "Enter title";
            }
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            if (TBTitle.Text.Length == 0 || String.Equals(TBTitle.Text, "Enter title"))
            {
                MessageBox.Show("Empty task");
            }
            else
            {
                var data = from c in TBTitle.Text
                           where char.IsDigit(c)
                           select c;

                if (data.ToList().Count == TBTitle.Text.Length)
                {
                    MessageBox.Show("Task cannot contain only numbers");
                }
                else
                {
                    Task newTask = new Task(TBTitle.Text, DateTime.Now);
                    CLB.Items.Add(newTask.Title);
                    tasks.Add(newTask);

                    LTotalTasks.Text = CLB.Items.Count.ToString();
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (CLB.CheckedIndices.Count == 0)
            {
                MessageBox.Show("There is nothing to remove or nothing selected");
            }
            else
            {
                if (CLB.Items.Count > 0)
                {
                    int i = 0;

                    foreach (int index in CLB.CheckedIndices)
                    {
                        CLB.Items.RemoveAt(index - i);
                        tasks.RemoveAt(index - i);

                        i++;
                    }

                    LTotalTasks.Text = CLB.Items.Count.ToString();
                }
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Serialize("Tasks.xml", tasks);
        }
    }
}
