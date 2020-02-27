using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Organizer
{
    public partial class FormGroup : Form
    {

        bool CreateGroup;
        int KeyGroup;
        DataRow ModifiedRow;

        public FormGroup(bool CreateGroup, int KeyGroup)
        {
            InitializeComponent();
            this.CreateGroup = CreateGroup;
            this.KeyGroup = KeyGroup;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SolidColorOnly = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
                buttonColor.ForeColor = FormMain.GetTextColor(colorDialog.Color);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Название группы не может быть пустым.");
                return;
            }

            if (this.CreateGroup == true)
            {
                dbtaskDataSet.ГруппыRow GroupRow;
                GroupRow = dbtaskDataSetGroup.Группы.NewГруппыRow();
                GroupRow.НазваниеГруппы = textBoxName.Text;
                GroupRow.ЦветГруппы = buttonColor.BackColor.ToArgb();
                GroupRow.ПоказыватьЗадачиГруппы = true; // при создании по умолчанию задачи показываются
                dbtaskDataSetGroup.Группы.Rows.Add(GroupRow);
                
            }
            else
            {
                if ((KeyGroup >= 0) && (dbtaskDataSetGroup.Группы.Rows.Count > 0))
                {
                    ModifiedRow["НазваниеГруппы"] = textBoxName.Text;
                    ModifiedRow["ЦветГруппы"] = buttonColor.BackColor.ToArgb();
                }
            }

            try
            {
                группыTableAdapterGroup.Update(dbtaskDataSetGroup.Группы);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Группа не сохранена. Ошибка: " + ex.Message);
            }

            this.Close();
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            if (this.CreateGroup == true)
            {
                textBoxName.Text = "";
                buttonColor.BackColor = Color.White;
                buttonColor.ForeColor = Color.Black;
            }
            else
            {
                if (KeyGroup >= 0)
                {
                    группыTableAdapterGroup.GetGroup(dbtaskDataSetGroup.Группы, KeyGroup);
                    if (dbtaskDataSetGroup.Группы.Rows.Count > 0)
                    {
                        ModifiedRow = dbtaskDataSetGroup.Группы.Rows[0];
                        textBoxName.Text = ModifiedRow["НазваниеГруппы"].ToString();
                        int ColorGroup = (int)ModifiedRow["ЦветГруппы"];
                        buttonColor.BackColor = Color.FromArgb(ColorGroup);
                        buttonColor.ForeColor = FormMain.GetTextColor(buttonColor.BackColor);
                    }
                }
            }
        }

    }
}
