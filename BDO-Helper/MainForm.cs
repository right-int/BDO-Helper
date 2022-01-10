using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BDO_Helper
{
    public partial class MainForm : Form
    {
        UpdateManager manager = null;

        Form comboForm = new Form();
        Font labelFont = null;
        Color fontColor = Color.White;

        string selectedClass = "";
        string selectedFontSize = "";
        string selectedColor = "";
        public MainForm()
        {
            InitializeComponent();
            siticoneShadowForm.SetShadowForm(this);

            loadSettings();
            loadClass();
            applyChanges();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboForm.Close();
            comboForm.Dispose();

            switch (comboBoxClass.SelectedItem)
            {
                case "Nova Succession PvE 1":
                    comboForm = new ComboForm("Shift+F > Shift+LMB > Shift+RMB > Shift+E > ↑+C > ↓+RMB > Shift+C");
                    comboForm.Show();
                    break;

                case "Nova Succession PvE 2":
                    comboForm = new ComboForm("Shift+LMB > Shift+RMB > Shift+E > ↑+C > ↓+RMB > ↓+LMB > Shift+C");
                    comboForm.Show();
                    break;

                case "Nova Succession PvP":
                    comboForm = new ComboForm("W+E > Shift+S > Shift+F > W+RMB > Shift+LMB > Shift+RMB > W+F > Shift+Q");
                    comboForm.Show();
                    break;

                case "Nova Awakening":
                    comboForm = new ComboForm("F > ↓+LMB > ↓+F > ↓+Q > F > ↑+F > Shift+RMB > Shift+LMB > Q > F");
                    comboForm.Show();
                    break;

                case "Corsair Awakening":
                    comboForm = new ComboForm("F > Space > ↓+RMB > Shift+E > [Light Em Up] > Shift+F > ↓ + F > ↓+ RMB(Hold) > Shift+RMB");
                    comboForm.Show();
                    break;

                case "Ninja Awakening":
                    comboForm = new ComboForm("↓+E > Shift+LMB > Space > Shift+F > Reposition > (Shift+LMB) > " +
                        "↓+F > F > Shift+RMB > Shift+LMB > Reposition > [Blade Spin] > Q > Shift+LMB > →+LMB > " +
                        "LMB+RMB > LMB+RMB > ↓+E > Space > Shift+RMB > Shift+Space");
                    comboForm.Show();
                    break;

                case "Sage Awakening":
                    comboForm = new ComboForm("↓+RMB > RMB > ↑+F > Space > RMB > F > ↓+LMB > F > RMB > ↑+F > Shift+RMB > ↑+RMB > RMB > F");
                    comboForm.Show();
                    break;

                default:
                    break;
            }

            UpdateSetting("SelectedClass", comboBoxClass.SelectedItem.ToString());

            if (this.labelFont != null && comboForm.Controls.Count > 0)
            {
                comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font = new Font(
                            this.labelFont.Name,
                            float.Parse(numericUpDownFontSize.Value.ToString()),
                            this.labelFont.Style
                        );
                if (selectedColor != "")
                {
                    comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").ForeColor = Color.FromArgb(int.Parse(selectedColor));
                }
            }
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void loadSettings()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            selectedClass = configuration.AppSettings.Settings["SelectedClass"].Value;
            selectedFontSize = configuration.AppSettings.Settings["SelectedFontSize"].Value;
            selectedColor = configuration.AppSettings.Settings["SelectedColor"].Value;
        }

        private void loadClass()
        {
            if (selectedClass != "null")
            {
                comboBoxClass.Text = selectedClass;
            }
        }

        private void applyChanges()
        {
            if (selectedFontSize != "null")
            {
                this.labelFont = comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font;
                comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font = new Font(
                    this.labelFont.Name,
                    float.Parse(selectedFontSize),
                    this.labelFont.Style
                );

                numericUpDownFontSize.Value = int.Parse(selectedFontSize);
            }

            if (selectedColor != "null")
            {
                comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").ForeColor = Color.FromArgb(int.Parse(selectedColor));
            }
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (comboForm.Controls.Count > 0)
            {
                this.labelFont = comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font;
                comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font = new Font(
                    this.labelFont.Name,
                    float.Parse(numericUpDownFontSize.Value.ToString()),
                    this.labelFont.Style
                );

                UpdateSetting("SelectedFontSize", numericUpDownFontSize.Value.ToString());
            }
        }

        private void siticoneButtonColorPicker_Click(object sender, EventArgs e)
        {
            if (comboForm.Controls.Count > 0)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.labelFont = comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").Font;
                    comboForm.Controls.OfType<Label>().First(s => s.Name == "labelCombo").ForeColor = colorDialog.Color;

                    fontColor = colorDialog.Color;

                    UpdateSetting("SelectedColor", fontColor.ToArgb().ToString());
                }
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            manager = await UpdateManager.GitHubUpdateManager(@"https://github.com/right-int/BDO-Helper");

            labelVersion.Text = "v" + manager.CurrentlyInstalledVersion().ToString();

            CheckForUpdates();

            timerCheckForUpdates.Interval = 5000;
            timerCheckForUpdates.Start();
        }

        private void timerCheckForUpdates_Tick(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private async void CheckForUpdates()
        {
            var updateInfo = await manager.CheckForUpdate();

            if (updateInfo.ReleasesToApply.Count > 0)
            {
                timerCheckForUpdates.Stop();

                MessageBox.Show("New Update Available! Downloading update...");

                await manager.UpdateApp();

                MessageBox.Show("Successfully Updated! Restarting...");

                Application.Restart();
            }
        }
    }
}
