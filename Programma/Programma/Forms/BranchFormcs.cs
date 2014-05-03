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
    public partial class BranchFormcs : Form
    {
        public BranchFormcs()
        {
            InitializeComponent();
        }

        private void BranchFormcs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.magazinBDDataSet.Branch);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form=new AddEdBranchForm();
            branchBindingSource.AddNew();
            form.branchBindingSource.DataSource = branchBindingSource;
            form.branchBindingSource.Position = branchBindingSource.Position;
            if (form.ShowDialog() == DialogResult.OK)
            {
                branchTableAdapter.Update(this.magazinBDDataSet.Branch);
                this.branchTableAdapter.Fill(this.magazinBDDataSet.Branch);
                dgvBranch.CurrentCell = dgvBranch.Rows[branchBindingSource.Count - 1].Cells[2];
            }
                
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdBranchForm form = new AddEdBranchForm();
            form.branchBindingSource.DataSource = branchBindingSource;
            form.branchBindingSource.Position = branchBindingSource.Position;
            if (form.ShowDialog() == DialogResult.OK)
            {
                branchTableAdapter.Update(magazinBDDataSet.Branch);
                int index = dgvBranch.CurrentRow.Index;
                this.branchTableAdapter.Fill(this.magazinBDDataSet.Branch);
                dgvBranch.CurrentCell = dgvBranch.Rows[index].Cells[2];
            }

        }
    }
}
