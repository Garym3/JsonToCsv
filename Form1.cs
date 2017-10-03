using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_convertFile_Click(object sender, EventArgs e)
        {
            FileConvert fileConvert = new FileConvert();

            openFileDialog1.InitialDirectory = @"C:\\Windows\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string parentPath = Path.GetDirectoryName(openFileDialog1.FileName);
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string newFileName = fileConvert.HorodateFileName(fileName);
                string content;

                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    content = sr.ReadToEnd();                    
                }

                using(var streamWriter = File.CreateText("C:\\Windows\\" + newFileName))
                {
                    // Ne parse pas correctement le JSON
                    ParametersList data = JsonConvert.DeserializeObject<ParametersList>(content);

                    foreach(var obj in data.list)
                    {
                        streamWriter.WriteLine(new StringBuilder().Append(obj.code + ";").Append(obj.host + ";").Append(obj.path + ";").Append(obj.durationMs));
                    }
                }
            }
        }
    }
}
