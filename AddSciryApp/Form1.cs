using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace AddSciryApp
{
    public partial class 文件加解密 : Form
    {

        private string TxtFileName = "";
        private string[] TxtFileNames;


        public 文件加解密()
        {
            InitializeComponent();
        }

        private void AddOrSubWithPath(string path)
        {
            FileStream openfs = new FileStream(path, FileMode.Open);
            byte[] buffer = new byte[openfs.Length];
            byte[] buffer_des = new byte[buffer.Length];
            openfs.Read(buffer, 0, buffer.Length);
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer_des[buffer_des.Length - i - 1] = buffer[i];
            }

            openfs.Close();
            FileStream wirtefs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            wirtefs.Write(buffer_des, 0, buffer_des.Length);
            wirtefs.Close();
        }

        private void AddOrSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFileName))
            {
                AddOrSubWithPath(TxtFileName);
                MessageBox.Show("完成!");
            }
            else
            {
                MessageBox.Show("路径为空!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {
                openfileDialog.RestoreDirectory = true;
                openfileDialog.Filter = "所有文件(*.*)|*.*";
                //openfileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory().Replace("TableConfigurationTool\\TableConfigurationTool\\bin\\Release", "Table");

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openfileDialog.FileName;
                    TxtFileName = Path.GetFullPath(openfileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "选择文件夹";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dialog.SelectedPath;
                TxtFileNames = Directory.GetFiles(dialog.SelectedPath, "*.*", SearchOption.AllDirectories);
            }
        }

        private void AddOrSubs_Click(object sender, EventArgs e)
        {
            if (TxtFileNames.Length > 0)
            {
                for (int i = 0; i < TxtFileNames.Length; i++)
                {
                    AddOrSubWithPath(TxtFileNames[i]);
                }
                MessageBox.Show("完成");
            }
            else
            {
                MessageBox.Show("路径为空");
            }
        }
    }
}
