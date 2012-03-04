using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ElfocrashEncDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse the package you want to Encrypt/Decrypt";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "UKX Files (*.ukx)|*.ukx|UTX Files (*.utx)|*.utx|Bitmap files (*.bmp)|*.bmp";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process1;
			process1= new System.Diagnostics.Process();

			process1.EnableRaisingEvents = false;

            if (radioButton1.Checked)
            {
                if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "111")
                {
                    string strCmdLine;
                    strCmdLine = "/C l2encdec -e 121 " + textBox1.Text;
                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                    process1.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "121")
                {
                    string strCmdLine;
                    strCmdLine = "/C l2encdec -e 111 " + textBox1.Text;
                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                    process1.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "413")
                {
                    string strCmdLine;
                    strCmdLine = "/C l2encdec -e 413 " + textBox1.Text;
                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                    process1.Close();
                }
                else
                    return;
            }
            else if (radioButton2.Checked)
            {
                string strCmdLine;
                strCmdLine = "/C l2encdec -s " + textBox1.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process1.Close();
            }
            else 
                return;
        }




        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process2;
            process2 = new System.Diagnostics.Process();

            process2.EnableRaisingEvents = false;

            if (radioButton3.Checked)
            {
                string strCmdLine;
                strCmdLine = "/C umodel " + textBox2.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process2.Close();
            }
            else if (radioButton4.Checked)
            {
                string strCmdLine;
                strCmdLine = "/C umodel -export " + textBox2.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process2.Close();
            }
            else if (radioButton5.Checked)
            {
                string strCmdLine;
                strCmdLine = "/C umodel -export -all " + textBox2.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process2.Close();
            }
            else if (radioButton6.Checked)
            {
                string strCmdLine;
                strCmdLine = "/C umodel -export -md5 " + textBox2.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process2.Close();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Enabled = true;
                button4.Enabled = false;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Enabled = true;
                button4.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button4.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                button4.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                button4.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                button4.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse the package you want to use in umodel";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "UKX Files (*.ukx)|*.ukx|UTX Files (*.utx)|*.utx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdlg.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse the obj you want to make ukx";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "OBJ Files (*.obj)|*.obj";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = fdlg.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process3;
            process3 = new System.Diagnostics.Process();

            process3.EnableRaisingEvents = false;


                string strCmdLine;
                strCmdLine = "/C OAUKX_C6 " + textBox3.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                process3.Close();
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label6.Text = "Encryption/Decryption Part";
            label2.Text = "Browse the file you want to Enc/dec";
            label3.Text = "The path MUST NOT have any space!!!";
            label4.Text = "It is strongly recommended to use the (C:/) path";
            button1.Text = "Browse";
            label1.Text = "Select encryption type";
            label5.Text = "Use 111 for UTX encryption and 121 for UKX";
            radioButton1.Text = "Encrypt";
            radioButton2.Text = "Decrypt";
            button2.Text = "GO!";
            label7.Text = "Umodel Part";
            label8.Text = "Browse the file you wanna use";
            button3.Text = "Browse";
            radioButton3.Text = "View Model";
            radioButton4.Text = "Export psa,psk from ukx files";
            radioButton5.Text = "Export all the resources of a file (psk,psa,tga, etc..)";
            radioButton6.Text = "Export md5mesh and md5anim from a ukx";
            button4.Text = "GO!";
            label9.Text = "OAUKX Part";
            label11.Text = "Browse the .obj file you wanna turn to ukx";
            label12.Text = "In the poped up message type 1 and hit Enter";
            button5.Text = "Browse";
            button6.Text = "Convert";
            label10.Text = "Languages available";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label6.Text = "Parte de Encriptação/Decriptação";
            label2.Text = "Localize o arquivo para encriptar/decriptar";
            label3.Text = "O caminho não deve ter qualquer espaço!";
            label4.Text = "É altamente recomendado usar o caminho C:";
            button1.Text = "Procurar";
            label1.Text = "Tipo de encriptação:";
            label5.Text = "Use encriptação 111 para UTX e 121 para UKX";
            radioButton1.Text = "Encriptar";
            radioButton2.Text = "Decriptar";
            button2.Text = "EXECUTAR!";
            label7.Text = "Parte do Umodel";
            label8.Text = "Localize o arquivo a ser usado";
            button3.Text = "Procurar";
            radioButton3.Text = "Ver Modelo";
            radioButton4.Text = "Exportar psa, psk do arquivo UKX";
            radioButton5.Text = "Exportar todos os recursos de um arquivo(psk,psa,tga,etc..)";
            radioButton6.Text = "Exportar md5mesh e md5anim de um ukx";
            button4.Text = "EXECUTAR!";
            label9.Text = "Parte do OAUKX";
            label11.Text = "Procure um arquivo .obj a ser convertido para ukx";
            label12.Text = "No popup digite 1 e pressione Enter";
            button5.Text = "Procurar";
            button6.Text = "Converter";
            label10.Text = "Idiomas disponíveis:";
        }







        }
    }

