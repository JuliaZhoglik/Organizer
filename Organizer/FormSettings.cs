using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxNotification.Checked == true) {
                if ((dateTimePickerTimer.Value.Hour == 0) && (dateTimePickerTimer.Value.Minute == 0) && (dateTimePickerTimer.Value.Second == 0))
                {
                    MessageBox.Show("Установите время таймера.");
                    return;
                }
            }

            Properties.Settings.Default.ShowBalloon = checkBoxNotification.Checked;
            Properties.Settings.Default.TimeBalloon = dateTimePickerTimer.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void checkBoxNotification_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerTimer.Enabled = checkBoxNotification.Checked;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

            checkBoxNotification.Checked = Properties.Settings.Default.ShowBalloon;
            dateTimePickerTimer.Value = Properties.Settings.Default.TimeBalloon;
            dateTimePickerTimer.Enabled = checkBoxNotification.Checked;
        }
    }
}
