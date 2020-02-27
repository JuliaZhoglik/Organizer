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
    public partial class FormTask : Form
    {
        bool CreateTask;
        int KeyTask;
        DataRow ModifiedRow;

        public FormTask(bool CreateTask, int KeyTask)
        {
            InitializeComponent();
            this.CreateTask = CreateTask;
            this.KeyTask = KeyTask;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }


        private void GroupUpdateTask()
        {
             группыTableAdapterTask.Fill(dbtaskDataSetTask.Группы);
        }

        private void FormTask_Load(object sender, EventArgs e)
        {
            GroupUpdateTask();
            if (this.CreateTask == true)
            {
                textBoxName.Text = "";
                dateTimePickerStart.Value = DateTime.Today;
                dateTimePickerEnd.Value = dateTimePickerStart.Value;
                checkBoxTimeStart.Checked = false;
                dateTimePickerTimeStart.Enabled = checkBoxTimeStart.Checked;
                dateTimePickerTimeStart.Value = dateTimePickerStart.Value;
                checkBoxDone.Checked = false;
                comboBoxGroup.SelectedValue = 1;
                checkBoxColorGroup.Checked = false;
                buttonColor.Visible = !checkBoxColorGroup.Checked;
                buttonColor.BackColor = Color.White;
                buttonColor.ForeColor = Color.Black;

                // планируемое время при создании задачи
                dateTimePickerPlan.Value = dateTimePickerStart.Value + new TimeSpan(1, 0, 0);

            } else
            {
                if (KeyTask >= 0)
                {
                    задачиTableAdapterTask.GetTask(dbtaskDataSetTask.Задачи, KeyTask);
                    if (dbtaskDataSetTask.Задачи.Rows.Count > 0) {
                        ModifiedRow = dbtaskDataSetTask.Задачи.Rows[0];
                        textBoxName.Text = ModifiedRow["НазваниеЗадачи"].ToString();
                        dateTimePickerStart.Value = (DateTime)ModifiedRow["ДатаНачала"];
                        dateTimePickerEnd.Value = (DateTime)ModifiedRow["ДатаОкончания"];
                        checkBoxTimeStart.Checked = (bool)ModifiedRow["ИспользоватьВремяНачала"];
                        dateTimePickerTimeStart.Enabled = checkBoxTimeStart.Checked;
                        if (checkBoxTimeStart.Checked == true)
                        {
                            dateTimePickerTimeStart.Value = (DateTime)ModifiedRow["ВремяНачала"];
                        }
                        else
                        {
                            dateTimePickerTimeStart.Value = DateTime.Today.Date;
                        }
                        checkBoxDone.Checked = (bool)ModifiedRow["ЗадачаВыполнена"];
                        comboBoxGroup.SelectedValue = ModifiedRow["КодГруппы"];
                        checkBoxColorGroup.Checked = (bool)ModifiedRow["ИспользоватьЦветГруппы"];
                        buttonColor.Visible = !checkBoxColorGroup.Checked;

                        int ColorTask = (int)ModifiedRow["ЦветЗадачи"];
                        buttonColor.BackColor = Color.FromArgb(ColorTask);
                        buttonColor.ForeColor = FormMain.GetTextColor(buttonColor.BackColor);
                    }

                    // получаем планируемые затраты и заполняем поле планируемое время на день
                    планируемыеЗатратыВремениTableAdapterTask.GetPlan(dbtaskDataSetTask.ПланируемыеЗатратыВремени, KeyTask);
                    if (dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows.Count > 0)
                    {
                        DataRow ModifiedPlan = dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows[0];
                        dateTimePickerPlan.Value = (DateTime)ModifiedPlan["ДатаВремяОкончания"];
                    }

                }
            }
        }


        private void checkBoxTimeStart_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerTimeStart.Enabled = checkBoxTimeStart.Checked;
        }

        private void checkBoxColorGroup_CheckedChanged(object sender, EventArgs e)
        {
            buttonColor.Visible = !checkBoxColorGroup.Checked;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Название задачи не может быть пустым.");
                return;
            }

            if (dateTimePickerStart.Value.Date > dateTimePickerEnd.Value.Date)
            {
                MessageBox.Show("Дата начала задачи не может быть больше даты окончания задачи.");
                return;
            }

            if ((dateTimePickerPlan.Value.Hour == 0) && (dateTimePickerPlan.Value.Minute == 0) && (dateTimePickerPlan.Value.Second == 0))
            {
                MessageBox.Show("Установите планируемое время на выполнение задачи.");
                return;
            }

            if (this.CreateTask == true)
            {
                DataRow TaskRow = dbtaskDataSetTask.Задачи.NewRow();
                TaskRow["НазваниеЗадачи"] = textBoxName.Text;
                TaskRow["ДатаНачала"] = dateTimePickerStart.Value;
                TaskRow["ДатаОкончания"] = dateTimePickerEnd.Value;
                TaskRow["ИспользоватьВремяНачала"] = checkBoxTimeStart.Checked;
                TaskRow["ВремяНачала"] = dateTimePickerTimeStart.Value;
                TaskRow["ЗадачаВыполнена"] = checkBoxDone.Checked;
                TaskRow["КодГруппы"] = (int)comboBoxGroup.SelectedValue;
                TaskRow["ИспользоватьЦветГруппы"] = checkBoxColorGroup.Checked;
                TaskRow["ЦветЗадачи"] = buttonColor.BackColor.ToArgb();
                dbtaskDataSetTask.Задачи.Rows.Add(TaskRow);

            }
            else
            {
                if ((KeyTask >= 0) && (dbtaskDataSetTask.Задачи.Rows.Count > 0))
                {
                    ModifiedRow["НазваниеЗадачи"] = textBoxName.Text;
                    ModifiedRow["ДатаНачала"] = dateTimePickerStart.Value;
                    ModifiedRow["ДатаОкончания"] = dateTimePickerEnd.Value;
                    ModifiedRow["ИспользоватьВремяНачала"] = checkBoxTimeStart.Checked;
                    ModifiedRow["ВремяНачала"] = dateTimePickerTimeStart.Value;
                    ModifiedRow["ЗадачаВыполнена"] = checkBoxDone.Checked;
                    ModifiedRow["КодГруппы"] = (int)comboBoxGroup.SelectedValue;
                    ModifiedRow["ИспользоватьЦветГруппы"] = checkBoxColorGroup.Checked;
                    ModifiedRow["ЦветЗадачи"] = buttonColor.BackColor.ToArgb();

                }
            }

            try
            {
                задачиTableAdapterTask.Update(dbtaskDataSetTask.Задачи);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Задача не сохранена. Ошибка: "+ ex.Message);
            }


            if (this.CreateTask == true)
            {
                // получаем код созданной задачи и заполняем таблицу планируемое время
                задачиTableAdapterTask.FillByMax(dbtaskDataSetTask.Задачи);
                TimeSpan nday = dateTimePickerEnd.Value.Date - dateTimePickerStart.Value.Date;
                int days = nday.Days;

                for (int i = 0; i <= days; i++)
                {
                    DataRow PlanRow = dbtaskDataSetTask.ПланируемыеЗатратыВремени.NewRow();
                    PlanRow["КодЗадачи"] = dbtaskDataSetTask.Задачи.Rows[0]["КодЗадачи"];
                    DateTime Dt = dateTimePickerStart.Value + new TimeSpan(i, 0, 0, 0);
                    DateTime Plan = dateTimePickerPlan.Value;
                    DateTime DtStart = new DateTime(Dt.Year, Dt.Month, Dt.Day, 0, 0, 0);
                    DateTime DtEnd = new DateTime(Dt.Year, Dt.Month, Dt.Day, Plan.Hour, Plan.Minute, Plan.Second);
                    PlanRow["ДатаВремяНачала"] = DtStart;
                    PlanRow["ДатаВремяОкончания"] = DtEnd;
                    dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows.Add(PlanRow);
                }
            }
            else
            {
                if ((KeyTask >= 0) && (dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows.Count > 0))
                {
                    int n = dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows[i].Delete();
                    }

                    TimeSpan nday = dateTimePickerEnd.Value.Date - dateTimePickerStart.Value.Date;
                    int days = nday.Days;

                    for (int i = 0; i <= days; i++)
                    {
                        DataRow PlanRow = dbtaskDataSetTask.ПланируемыеЗатратыВремени.NewRow();
                        PlanRow["КодЗадачи"] = KeyTask;
                        DateTime Dt = dateTimePickerStart.Value + new TimeSpan(i, 0, 0, 0);
                        DateTime Plan = dateTimePickerPlan.Value;
                        DateTime DtStart = new DateTime(Dt.Year, Dt.Month, Dt.Day, 0, 0, 0);
                        DateTime DtEnd = new DateTime(Dt.Year, Dt.Month, Dt.Day, Plan.Hour, Plan.Minute, Plan.Second);
                        PlanRow["ДатаВремяНачала"] = DtStart;
                        PlanRow["ДатаВремяОкончания"] = DtEnd;
                        dbtaskDataSetTask.ПланируемыеЗатратыВремени.Rows.Add(PlanRow);
                    }

                }


            }

            try
            {
                планируемыеЗатратыВремениTableAdapterTask.Update(dbtaskDataSetTask.ПланируемыеЗатратыВремени);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Планируемые затраты не сохранены. Ошибка: " + ex.Message);
            }


            this.Close();

        }


    }
}
