using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    
    public partial class MainForm : Form
    {
        private Form2 open;
        public MainForm()
        {
            InitializeComponent();
            open = new Form2(this);
            open.ControlBox = false;
            open.MdiParent = this;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTeacher = new Teacher(this);
            newTeacher.MdiParent = this;
            newTeacher.Show();
        }

        private bool IsOpen()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Teacher")
                {
                    return true;
                }
            }
            return false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK 
                && saveFileDialog1.FileName.Length > 0 && IsOpen())
            {
                string[] Info = {newTeacher.getText1(), newTeacher.getText2(), newTeacher.getText3(), 
                                    newTeacher.getText4(), newTeacher.getText5()};
                File.WriteAllLines(saveFileDialog1.FileName, Info);
                MessageBox.Show("File is saved!");
            }
            else
            {
                MessageBox.Show("form is`n open!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*) |*.*";
            openFileDialog1.FilterIndex = 2; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                { if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            open.richTextBox1.LoadFile(openFileDialog1.FileName,
                            RichTextBoxStreamType.PlainText);
                        }
                    } //if
                }  //try
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk:	" + ex.Message);
                }
            }
            open.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                open.richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                open.richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newTeacher = new Teacher(this);
            newTeacher.MdiParent = this;
            newTeacher.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*) |*.*";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            open.richTextBox1.LoadFile(openFileDialog1.FileName,
                            RichTextBoxStreamType.PlainText);
                        }
                    } //if
                }  //try
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk:	" + ex.Message);
                }
            }
            open.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0 && IsOpen())
            {
                string[] Info = {newTeacher.getText1(), newTeacher.getText2(), newTeacher.getText3(), 
                                    newTeacher.getText4(), newTeacher.getText5()};
                File.WriteAllLines(saveFileDialog1.FileName, Info);
                MessageBox.Show("File is saved!");
            }
            else
            {
                MessageBox.Show("form is`n open!");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0 && IsOpen())
            {
                string[] Info = {newTeacher.getText1(), newTeacher.getText2(), newTeacher.getText3(), 
                                    newTeacher.getText4(), newTeacher.getText5()};
                File.WriteAllLines(saveFileDialog1.FileName, Info);
                MessageBox.Show("File is saved!");
            }
            else
            {
                MessageBox.Show("form is`n open!");
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0 && IsOpen())
            {
                string[] Info = {newTeacher.getText1(), newTeacher.getText2(), newTeacher.getText3(), 
                                    newTeacher.getText4(), newTeacher.getText5()};
                File.WriteAllLines(saveFileDialog1.FileName, Info);
                MessageBox.Show("File is saved!");
            }
            else
            {
                MessageBox.Show("form is`n open!");
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                open.richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                open.richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
