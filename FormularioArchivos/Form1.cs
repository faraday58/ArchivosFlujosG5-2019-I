using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormularioArchivos
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if( ofd.ShowDialog() == DialogResult.OK  )
            {
                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string aux = sr.ReadLine();
                    while (aux != null)
                    {

                        rtbNotas.AppendText(aux + "\n");
                        aux = sr.ReadLine();
                    }
                }
                catch(IOException error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }

        }
    }
}
