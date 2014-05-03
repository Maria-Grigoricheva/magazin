using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchFormcs branchForm = new BranchFormcs();
            branchForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

    }
}
