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
    public partial class ProvForm : Form
    {
        public ProvForm()
        {
            InitializeComponent();
        }

        private void ProvForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Provisioner". При необходимости она может быть перемещена или удалена.
            this.provisionerTableAdapter.Fill(this.magazinBDDataSet.Provisioner);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdProvForm form = new AddEdProvForm();
            provisionerBindingSource.AddNew();

            form.provisionerBindingSource.DataSource = provisionerBindingSource;
            form.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter.Update(this.magazinBDDataSet.Provisioner);
                this.provisionerTableAdapter.Fill(this.magazinBDDataSet.Provisioner);
                dgvProv.CurrentCell = dgvProv.Rows[provisionerBindingSource.Count - 1].Cells[2];
            }
        }

        private void btnEdition_Click(object sender, EventArgs e)
        {
            AddEdProvForm form = new AddEdProvForm();

            form.provisionerBindingSource.DataSource = provisionerBindingSource;
            form.provisionerBindingSource.Position = provisionerBindingSource.Position;

            if (form.ShowDialog() == DialogResult.OK)
            {
                provisionerTableAdapter.Update(this.magazinBDDataSet.Provisioner);
                int index = dgvProv.CurrentRow.Index;
                this.provisionerTableAdapter.Fill(this.magazinBDDataSet.Provisioner);
                dgvProv.CurrentCell = dgvProv.Rows[index].Cells[2];
            }
        }
    }
}
