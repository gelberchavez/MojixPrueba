using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mojix.StudentManagement.Core.Model;
using Mojix.StudentManagement.Core.Model.Data;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Refrescar();

        }
        private void Refrescar()
        {
            using (StudentsConexion db = new StudentsConexion())
            {
                var lst = from d in db.Student
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }

        }
    }
}
