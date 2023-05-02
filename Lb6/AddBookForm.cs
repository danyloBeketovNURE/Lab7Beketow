using Lb6.EF;
using Lb6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb6
{
    public partial class AddWorkerForm : Form
    {
        private LibraryEntity context = null;
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            context = new LibraryEntity();
            comboBox1.Items.AddRange(context.authors.ToArray());
            comboBox1.DisplayMember = "Name";
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            int salary = default;
            if (textBox1.Text == "")
            {
                MessageBox.Show("WARNING input book name");
                return;
            }
            try
            {
                salary = int.Parse(textBox2.Text);
                if (salary < 0)
                {
                    MessageBox.Show("WARNING price must be more than 0");
                    return;
                }
                Book book = new Book
                {
                    author = (Author)comboBox1.SelectedItem,
                    Name = textBox1.Text,
                    Price = salary
                };
                context.books.Add(book);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                return;
            }
            catch { MessageBox.Show("WARNING wrong data"); }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
