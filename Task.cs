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

namespace TestTask
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbSourcePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnReplica_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbReplicaPath.Text = folderBrowserDialog1.SelectedPath;
        }


        public void Update(string sourse, string replica)
        {
            Directory.CreateDirectory(replica);
            foreach (string s1 in Directory.GetFiles(sourse))
            {
                string s2 = replica + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
            }

            foreach (string s in Directory.GetDirectories(sourse))
            {
                Update(s, replica + "\\" + Path.GetFileName(s));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int timer = Int32.Parse(tbTick.Text);
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = timer;
                timer1.Start();
            } else
            {
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(tbReplicaPath.Text);
            foreach (FileInfo f in di.GetFiles())
            {
                f.Delete();
            }
            Update(tbSourcePath.Text, tbReplicaPath.Text);
        }
    }
}
