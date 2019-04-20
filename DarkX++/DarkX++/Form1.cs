using FastColoredTextBoxNS;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DarkX__
{
    public partial class Form1 : MetroForm
    {
        public Form1(string fileName)
        {
            InitializeComponent();
            if (fileName.Length > 0)
            {
                fastColoredTextBox1.Text = File.ReadAllText(fileName);
                metroLabel1.Text = fileName;
                saving = fileName;
            }
        }
        int TabCount = 0; string format = ".txt";
        string saving; bool IsDirected = false; string SaveMainText = "Без имени - DarkX++";

        private void CutClick(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }
        private void CopyClick(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }
        private void PasteClick(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveAsClick(object sender, EventArgs e)
        {
            SaveAs();
        }

        public void SaveAs()
        {
            SaveFileDialog SaveAS = new SaveFileDialog();
            SaveAS.RestoreDirectory = true;
            SaveAS.DefaultExt = "*" + ".txt";
            if (SaveAS.ShowDialog() == DialogResult.OK && SaveAS.FileName.Length > 0)
            {
                using (StreamWriter code = new StreamWriter(SaveAS.FileName, true))
                {
                    code.WriteLine(fastColoredTextBox1.Text);
                    code.Close();
                }
                this.Text = Path.GetFileName(SaveAS.FileName) + " - DarkX++";
                metroLabel1.Text = this.Text;
                SaveMainText = this.Text;
            }
        }

        private void OpenClick(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void OpenFile()
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(Open.FileName);
                saving = Open.FileName;
                this.Text = Path.GetFileName(Open.FileName) + " - DarkX++";
                metroLabel1.Text = this.Text;
                IsDirected = false;
                SaveMainText = this.Text;
            }
        }

        private void текстовыйРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form2 = new Settings();
            form2.Owner = this;
            form2.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOpenedFile();
        }

        public void SaveOpenedFile()
        {
            try
            {
                File.Delete(saving);
                using (StreamWriter save = new StreamWriter(saving))
                {
                    save.WriteLine(fastColoredTextBox1.Text);
                }
            }
            catch
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.DefaultExt = "NoName" + ".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                {
                    using (StreamWriter code = new StreamWriter(saveFileDialog1.FileName, true))
                    {
                        code.WriteLine(fastColoredTextBox1.Text);
                        code.Close();
                    }
                    this.Text = Path.GetFileName(saveFileDialog1.FileName) + " - DarkX++";
                    metroLabel1.Text = this.Text;
                    IsDirected = false;
                    SaveMainText = this.Text;
                }
            }
        }

        private void TextChanging(object sender, TextChangingEventArgs e)
        {
            IsDirected = true;
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Точно выйти?", "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void Change(object sender, EventArgs e)
        {
            if (this.Text == "Lstyle")
            {
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
                menuStrip1.BackColor = Color.FromArgb(250, 250, 250);
                правкаToolStripMenuItem.BackColor = menuStrip1.BackColor;
                правкаToolStripMenuItem.ForeColor = Color.Black;
                видToolStripMenuItem.BackColor = menuStrip1.BackColor;
                видToolStripMenuItem.ForeColor = Color.Black;

                fastColoredTextBox1.ForeColor = Color.Black;
                fastColoredTextBox1.BackColor = Color.White;
                fastColoredTextBox1.CaretColor = Color.Black;
                fastColoredTextBox1.IndentBackColor = Color.White;
                fastColoredTextBox1.ServiceLinesColor = Color.FromArgb(250, 250, 250);
                this.Style = MetroFramework.MetroColorStyle.White;

                this.Text = SaveMainText;
            }
            if (this.Text == "Dstyle")
            {
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                menuStrip1.BackColor = Color.FromArgb(20, 20, 20);
                правкаToolStripMenuItem.BackColor = menuStrip1.BackColor;
                правкаToolStripMenuItem.ForeColor = Color.White;
                видToolStripMenuItem.BackColor = menuStrip1.BackColor;
                видToolStripMenuItem.ForeColor = Color.White;

                fastColoredTextBox1.ForeColor = Color.White;
                fastColoredTextBox1.BackColor = Color.FromArgb(24, 24, 24);
                fastColoredTextBox1.CaretColor = Color.White;
                fastColoredTextBox1.IndentBackColor = Color.FromArgb(17, 17, 17);
                fastColoredTextBox1.ServiceLinesColor = Color.Black;
                this.Style = MetroFramework.MetroColorStyle.Black;


                this.Text = SaveMainText;
            }

            switch(this.Text)
            {
                case "blue":
                    файлToolStripMenuItem.BackColor = Color.DeepSkyBlue;
                    файлToolStripMenuItem.ForeColor = Color.White;
                    fastColoredTextBox1.LineNumberColor = Color.LightBlue;
                    this.Text = SaveMainText;
                    break;
                case "default":
                    файлToolStripMenuItem.BackColor = Color.LightBlue;
                    файлToolStripMenuItem.ForeColor = Color.White;
                    fastColoredTextBox1.LineNumberColor = Color.LightBlue;
                    this.Text = SaveMainText;
                    break;
                case "orange":
                    файлToolStripMenuItem.BackColor = Color.Orange;
                    файлToolStripMenuItem.ForeColor = Color.White;
                    fastColoredTextBox1.LineNumberColor = Color.Orange;
                    this.Text = SaveMainText;
                    break;
                case "white":
                    файлToolStripMenuItem.BackColor = Color.FromArgb(250, 250, 250);
                    файлToolStripMenuItem.ForeColor = Color.Black;
                    fastColoredTextBox1.LineNumberColor = Color.Gray;
                    this.Text = SaveMainText;
                    break;
                case "black":
                    файлToolStripMenuItem.BackColor = Color.Black;
                    файлToolStripMenuItem.ForeColor = Color.White;
                    fastColoredTextBox1.LineNumberColor = Color.Black;
                    this.Text = SaveMainText;
                    break;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            fontDialog1.Font = fastColoredTextBox1.Font;
            fontDialog1.Color = fastColoredTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                fastColoredTextBox1.Font = fontDialog1.Font;
                fastColoredTextBox1.ForeColor = fontDialog1.Color;

            }
        }
    }
}
