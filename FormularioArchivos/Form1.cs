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
        BinaryReader br;
        BinaryWriter bw;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Texto|*.txt|Binario|*.bin";

            if( ofd.ShowDialog() == DialogResult.OK  )
            {
                if(ofd.Filter.Contains(".bin"))
                {
                    try
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        br = new BinaryReader(fi.OpenRead());
                        string texto = br.ReadString();
                        int entero = br.ReadInt32();
                        double doble = br.ReadDouble();

                        rtbNotas.AppendText(texto);
                        rtbNotas.AppendText(entero.ToString());
                        rtbNotas.AppendText(doble.ToString());

                        

                    }
                    catch (IOException error )
                    {
                        MessageBox.Show("Error: "+ error.Message);
                    }
                    finally
                    {
                        br.Close();
                    }
                }
                else
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
                    catch (IOException error)
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Texto|*.txt|Binario|*.bin";
            if( sfd.ShowDialog() == DialogResult.OK   )
            {
                try
                {
                    FileInfo fi = new FileInfo(sfd.FileName);
                    bw = new BinaryWriter(fi.OpenWrite());
                    string texto = rtbNotas.Text;
                    int entero = int.Parse(txtbEntero.Text);
                    double doble = double.Parse(txtbDouble.Text);

                    bw.Write(texto);
                    bw.Write(entero);
                    bw.Write(doble);
                }
                catch(IOException error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    bw.Close();
                }
            }

        }

        private void limpiarCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotas.Clear();
            txtbDouble.Clear();
            txtbEntero.Clear();
        }
    }
}
