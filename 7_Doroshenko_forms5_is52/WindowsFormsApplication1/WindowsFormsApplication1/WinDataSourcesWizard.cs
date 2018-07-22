using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WinDataSourcesWizard : Form
    {
        public WinDataSourcesWizard()
        {
            InitializeComponent();
        }

        private void coWorkersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coWorkersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.candy_FactoryDataSet2);

        }

        private void WinDataSourcesWizard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'candy_FactoryDataSet2.CoWorkers' table. You can move, or remove it, as needed.
            this.coWorkersTableAdapter.Fill(this.candy_FactoryDataSet2.CoWorkers);

        }
    }
}
