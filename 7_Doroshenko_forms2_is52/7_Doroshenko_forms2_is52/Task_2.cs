using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Doroshenko_forms2_is52
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void TestList_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Виберіть елемент із списку або введіть новий");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0) memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void peopleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
