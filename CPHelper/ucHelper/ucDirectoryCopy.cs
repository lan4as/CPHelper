using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace CPHelper.ucHelper
{
    public partial class ucDirectoryCopy : UserControl
    {
        public ucDirectoryCopy()
        {
            InitializeComponent();
        }

        private void ucDirectoryCopy_Load(object sender, EventArgs e)
        {
            textBox1.Text = ConfigurationManager.AppSettings["1"];
            textBox2.Text = ConfigurationManager.AppSettings["1P"];
            textBox3.Text = ConfigurationManager.AppSettings["2"];
            textBox4.Text = ConfigurationManager.AppSettings["2P"];
            textBox5.Text = ConfigurationManager.AppSettings["3"];
            textBox6.Text = ConfigurationManager.AppSettings["3P"];
            textBox7.Text = ConfigurationManager.AppSettings["4"];
            textBox8.Text = ConfigurationManager.AppSettings["4P"];
            textBox9.Text = ConfigurationManager.AppSettings["5"];
            textBox10.Text = ConfigurationManager.AppSettings["5P"];
            textBox11.Text = ConfigurationManager.AppSettings["6"];
            textBox12.Text = ConfigurationManager.AppSettings["6P"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Directory.GetFiles(textBox1.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox2.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox2.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //"CPHelper.exe.config"
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["1"].Value = textBox1.Text;
            config.AppSettings.Settings["1P"].Value = textBox2.Text;
            config.AppSettings.Settings["2"].Value = textBox3.Text;
            config.AppSettings.Settings["2P"].Value = textBox4.Text;
            config.AppSettings.Settings["3"].Value = textBox5.Text;
            config.AppSettings.Settings["3P"].Value = textBox6.Text;
            config.AppSettings.Settings["4"].Value = textBox7.Text;
            config.AppSettings.Settings["4P"].Value = textBox8.Text;
            config.AppSettings.Settings["5"].Value = textBox9.Text;
            config.AppSettings.Settings["5P"].Value = textBox10.Text;
            config.AppSettings.Settings["6"].Value = textBox11.Text;
            config.AppSettings.Settings["6P"].Value = textBox12.Text;


            config.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(textBox3.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox4.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox4.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(textBox5.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox6.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox6.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(textBox7.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox8.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox8.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(textBox9.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox10.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox10.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Directory.GetFiles(textBox11.Text).ToList().ForEach(sourceFile => {
                string targetFileName = textBox12.Text + "\\" + Path.GetFileName(sourceFile);
                if (File.Exists(targetFileName))
                {
                    File.Delete(targetFileName);
                }

                File.Copy(sourceFile, textBox12.Text + "\\" + Path.GetFileName(sourceFile));
            });
        }
    }
}
