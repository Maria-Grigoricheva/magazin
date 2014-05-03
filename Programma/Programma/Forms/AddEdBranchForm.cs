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
    public partial class AddEdBranchForm : Form
    {
        public AddEdBranchForm()
        {
            InitializeComponent();
        }

        private void AddEdBranchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.magazinBDDataSet.Branch);

        }

        private void AddEdBranchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                branchBindingSource.EndEdit();
                else
                branchBindingSource.CancelEdit();
        }
    }
}
