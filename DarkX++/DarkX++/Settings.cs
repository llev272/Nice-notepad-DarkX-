using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarkX__
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            /* if (main != null)
            {
                main.Theme = MetroFramework.MetroThemeStyle.Dark;
                main.Text = "Dstyle";
            } */
            switch (metroComboBox2.SelectedItem)
            {
                case "Синий":
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
                    metroComboBox2.Style = MetroFramework.MetroColorStyle.Blue;
                    metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
                    metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
                    if (main != null) main.Text = "blue";
                    break;
                case "Голубой":
                    this.Style = MetroFramework.MetroColorStyle.Default;
                    metroComboBox1.Style = MetroFramework.MetroColorStyle.Default;
                    metroComboBox2.Style = MetroFramework.MetroColorStyle.Default;
                    metroLabel1.Style = MetroFramework.MetroColorStyle.Default;
                    metroLabel2.Style = MetroFramework.MetroColorStyle.Default;
                    if (main != null) main.Text = "default";
                    break;
                case "Оранжевый":
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    metroComboBox1.Style = MetroFramework.MetroColorStyle.Orange;
                    metroComboBox2.Style = MetroFramework.MetroColorStyle.Orange;
                    metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
                    metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
                    if (main != null) main.Text = "orange";
                    break;
                case "Белый":
                    this.Style = MetroFramework.MetroColorStyle.White;
                    metroComboBox1.Style = MetroFramework.MetroColorStyle.White;
                    metroComboBox2.Style = MetroFramework.MetroColorStyle.White;
                    metroLabel1.Style = MetroFramework.MetroColorStyle.White;
                    metroLabel2.Style = MetroFramework.MetroColorStyle.White;
                    if (main != null) main.Text = "white";
                    break;
                case "Чёрный":
                    this.Style = MetroFramework.MetroColorStyle.Black;
                    metroComboBox1.Style = MetroFramework.MetroColorStyle.Black;
                    metroComboBox2.Style = MetroFramework.MetroColorStyle.Black;
                    metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
                    metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
                    if (main != null) main.Text = "black";
                    break;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem == "Тёмная")
                SetDarkTheme();
            else
                SetLightTheme();
        }

        public void SetDarkTheme()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.Theme = MetroFramework.MetroThemeStyle.Dark;
                main.Text = "Dstyle";
            }
            metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        public void SetLightTheme()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.Theme = MetroFramework.MetroThemeStyle.Light;
                main.Text = "Lstyle";
            }
            metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
