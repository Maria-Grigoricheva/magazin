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
    public partial class AddEdManagerForm : Form
    {
        public AddEdManagerForm()
        {
            InitializeComponent();
        }

        private void AddEdManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.magazinBDDataSet.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.magazinBDDataSet.Manager);

        }

        private void AddEdManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                managerBindingSource.EndEdit();
            else
                managerBindingSource.CancelEdit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
