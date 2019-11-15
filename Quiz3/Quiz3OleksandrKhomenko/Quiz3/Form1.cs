using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            make.Items.Add("Subaru");
            make.Items.Add("Porshe");
            make.Items.Add("Mercedes");

            year.Items.Add("2020");
            year.Items.Add("2019");
            year.Items.Add("2018");
            year.Items.Add("2017");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void car_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            firstName.Text = String.Empty;
            lastName.Text = String.Empty;
            phone.Text = String.Empty;
            make.Text = String.Empty;
            model.Text = String.Empty;
            year.Text = String.Empty;

        }

        private void make_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            if (make.SelectedItem == "Subaru")
            {
                model.Items.Add("Legacy");
                model.Items.Add("WRX");
                model.Items.Add("BRZ");

            }
            else if (make.SelectedItem == "Porshe")
            {
                model.Items.Add("911");
                model.Items.Add("718");
                model.Items.Add("Cayenne");

            }
            else if (make.SelectedItem == "Mercedes")
            {
                model.Items.Add("C-Class");
                model.Items.Add("E-Class");
                model.Items.Add("AMG GT");

            }

        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || phone.Text == "")
            {
                MessageBox.Show("All information must be filled");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Quiz3\text.txt";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                groupBox2.Text = saveFileDialog1.FileName;

            }


            FileStream stream = new FileStream(@"C:\Quiz3\text.txt", FileMode.Append, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("\nFirst name: " + firstName.Text + " " + "Last name: " + 
                    lastName.Text + " " + "Telephone: " + phone.Text + " " + "Make: " +
                    make.Text + " " + "Model: " + model.Text + " " + "Year: " + year.Text +
                    " ", @"C:\Quiz3\text.txt");
            }

            MessageBox.Show("Owner saved successfully");

        }
    }
}
