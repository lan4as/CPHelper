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
    }
}
