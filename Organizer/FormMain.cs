using System;
using System.Collections;
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
    public partial class FormMain : Form
    {


        DateTime TimeClock;
        DateTime DateTimeStart;
        DateTime DateTimeStop;
        int KeyTask;
        bool listViewWeekChange = false;
        bool listViewDayChange = false;

        DateTime SelectDate;
        bool GroupUpdating = false;

        public FormMain()
        {
            InitializeComponent();

        }

        // загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTimeStart = DateTime.Now;
            DateTimeStop = DateTime.Now;


            TimeClock = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            labelClock.Text = TimeClock.ToString("HH:mm:ss");

            buttonStop.Visible = false;
            buttonStart.Visible = true;

            contextMenuStripGroup.Enabled = false;
            buttonGroupModify.Enabled = false;
            buttonGroupDelete.Enabled = false;

            ButtonsUpdate(); // обновление доступности кнопок связанных с задачами

            GroupUpdate(); // Обновляем список групп из базы данных

 
            comboBoxView.SelectedIndex = Properties.Settings.Default.View; // режим просмотра День = 0, Неделя = 1
                                            //  DateUpdate(); // Обновляем дату и задачи
        }

        // меняем цвет текста на белый, если цвет фона темный
        public static Color GetTextColor(Color BkColor)
        {
            Color TxtColor = Color.Black;
            int sum_rgb = (BkColor.R + BkColor.G + BkColor.B);
            if (sum_rgb < 382)
            {
                TxtColor = Color.White;
            }
            return TxtColor;
        }

        // Обновляем дату и задачи
        public void DateUpdate()
        {
            // обновляем дату
            SelectDate = monthCalendar.SelectionRange.Start;
            labelSelectDate.Text = SelectDate.ToString("ddd") + ", " + SelectDate.ToLongDateString();

            if (comboBoxView.SelectedIndex == 0)
            {
                TaskUpdateDay(); // обновляем задачи за день в режиме День
                listViewWeek.Visible = false;
                listViewDay.Visible = true;
            }
            else if (comboBoxView.SelectedIndex == 1)
            {
                TaskUpdateWeek(); // обновляем задачи за неделю в режиме Неделя
                listViewWeek.Visible = true;
                listViewDay.Visible = false;
            }
            
        }

        // Обновляем группы
        private void GroupUpdate()
        {
            GroupUpdating = true; // пока GroupUpdating = true, то при событии listViewGroups_ItemChecked ничего не происходит
            группыTableAdapter.Fill(dbtaskDataSet.Группы); // получаем запросом таблицу групп
            listViewGroups.Items.Clear(); // очищаем список групп
            if (dbtaskDataSet.Группы.Count > 0)
            {
                for (int i = 0; i < dbtaskDataSet.Группы.Rows.Count; i++)
                {
                    // добавляем группу
                    DataRow dr = dbtaskDataSet.Группы.Rows[i];
                    string GroupName = dr["НазваниеГруппы"].ToString();
                    ListViewItem ListItem = new ListViewItem(GroupName);
                    ListItem.Tag = dr["КодГруппы"];
                    ListItem.Checked = (bool)dr["ПоказыватьЗадачиГруппы"];
                    ListItem.UseItemStyleForSubItems = false;
                    ListViewItem.ListViewSubItem ListSubItems = new ListViewItem.ListViewSubItem();
                    ListSubItems.Text = "";
                    int ColorGroup = (int)dr["ЦветГруппы"];
                    ListSubItems.BackColor = Color.FromArgb(ColorGroup);
                    ListItem.SubItems.Add(ListSubItems);
                    listViewGroups.Items.Add(ListItem);
                }
            }
            GroupUpdating = false; // закончилось обновление групп
        }


        private void TaskUpdateDay()
        {
            задачиTableAdapter.FillByDay(dbtaskDataSet.Задачи, SelectDate); // получаем задачи за день
            listViewDay.Items.Clear(); // очищаем список задач

            if (dbtaskDataSet.Задачи.Rows.Count > 0) // есть задачи на день
            {
                int CountShow = 0;
                for (int i = 0; i < dbtaskDataSet.Задачи.Rows.Count; i++)
                {
                    DataRow dr = dbtaskDataSet.Задачи.Rows[i];
                    bool ShowTask = (bool)dr["ПоказыватьЗадачиГруппы"];
                    // если задачи показываются, то добаляем задачу в список
                    if (ShowTask == true)
                    {
                        CountShow += 1;
                        string TaskName = dr["НазваниеЗадачи"].ToString();
                        bool UseStartTime = (bool)dr["ИспользоватьВремяНачала"];
                        bool Done = (bool)dr["ЗадачаВыполнена"];

                        if (UseStartTime == true) // используется время начала задачи
                        {
                            // добавляем время начала в название задачи
                            DateTime StartTime = (DateTime)dr["ВремяНачала"];
                            TaskName = StartTime.ToString("HH:mm") + " " + TaskName;
                        }

                        Font stdfont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
                        if (Done == true) // задача выполнена
                        { // Выполненные задачи зачеркнуты
                            stdfont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout);
                        }

                        ListViewItem ListItem = new ListViewItem(TaskName);
                        ListItem.Tag = dr["КодЗадачи"];
                        ListItem.Font = stdfont;

                        // цвет задачи
                        int ColorTask = (int)dr["ЦветЗадачи"];

                        bool UseColorGroup = (bool)dr["ИспользоватьЦветГруппы"];
                        if (UseColorGroup == true) // если выбрано использовать цвет группы
                        {
                            ColorTask = (int)dr["ЦветГруппы"];
                        }

                        ListItem.BackColor = Color.FromArgb(ColorTask);
                        ListItem.ForeColor = GetTextColor(ListItem.BackColor);

                        listViewDay.Items.Add(ListItem);
                    }
                }

                if (CountShow == 0) // если все группы задач скрыты
                {
                    ListViewItem ListItem = new ListViewItem("Задач нет.");
                    ListItem.Tag = -1;
                    listViewDay.Items.Add(ListItem);
                }
            }
            else
            {
                // если задач на день нету
                ListViewItem ListItem = new ListViewItem("Задач нет.");
                ListItem.Tag = -1;
                listViewDay.Items.Add(ListItem);
            }

        }



        private void TaskUpdateWeek()
        {

            int dw = (int)SelectDate.DayOfWeek; // день недели
            if (dw == 0) { dw = 7; } // если это воскресенье, то это будет 7 день недели
            int dw_before = dw - 1; // количество дней до выбранной даты на неделе
            int dw_after = 6 - dw + 1; // количество дней после выбранной даты на неделе

            DateTime DtStart = SelectDate.Date - new TimeSpan(dw_before, 0, 0, 0); // первый день недели (пн)
            DateTime DtEnd = SelectDate.Date + new TimeSpan(dw_after, 0, 0, 0); // последний день недели (вс)

            задачиTableAdapter.FillBy(dbtaskDataSet.Задачи, DtStart.Date, DtEnd.Date); // получаем список задач за неделю
            listViewWeek.Items.Clear(); // очищаем список задач


            if (dbtaskDataSet.Задачи.Rows.Count > 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    DateTime CurrDate = DtStart + new TimeSpan(i, 0, 0, 0);
                    string NameGroup = CurrDate.ToString("ddd") + ", " + CurrDate.ToLongDateString();
                    if (CurrDate.Date == SelectDate.Date)
                    {
                        NameGroup = "[" + NameGroup + "]";
                    }
                    ListViewGroup ListGroup = new ListViewGroup(NameGroup);
                    ListGroup.Tag = CurrDate; // тут храним дату
                    listViewWeek.Groups.Add(ListGroup);
                    int CountTask = 0;
                    for (int j = 0; j < dbtaskDataSet.Задачи.Rows.Count; j++)
                    {
                        DataRow dr = dbtaskDataSet.Задачи.Rows[j]; // получаем задачу
                        bool ShowTask = (bool)dr["ПоказыватьЗадачиГруппы"];

                        // если задачи показываются, то добаляем задачу в список
                        if (ShowTask == true)
                        {
                            DateTime DateStart = (DateTime)dr["ДатаНачала"];
                            DateTime DateEnd = (DateTime)dr["ДатаОкончания"];
                            if ((DateStart.Date <= CurrDate.Date) && (DateEnd.Date >= CurrDate.Date))
                            {
                                CountTask += 1;
                                string TaskName = dr["НазваниеЗадачи"].ToString();
                                bool UseStartTime = (bool)dr["ИспользоватьВремяНачала"];
                                bool Done = (bool)dr["ЗадачаВыполнена"];

                                if (UseStartTime == true)
                                {
                                    // добавляем время начала в название задачи
                                    DateTime StartTime = (DateTime)dr["ВремяНачала"];
                                    TaskName = StartTime.ToString("HH:mm") + " " + TaskName;
                                }

                                Font stdfont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
                                if (Done == true)
                                { // Выполненные задачи зачеркнуты
                                    stdfont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout);
                                }

                                ListViewItem ListItem = new ListViewItem(TaskName);
                                ListItem.Tag = dr["КодЗадачи"];
                                ListItem.Font = stdfont;
                                // цвет задачи
                                int ColorTask = (int)dr["ЦветЗадачи"];

                                bool UseColorGroup = (bool)dr["ИспользоватьЦветГруппы"];
                                if (UseColorGroup == true)
                                {
                                    ColorTask = (int)dr["ЦветГруппы"];
                                }

                                ListItem.BackColor = Color.FromArgb(ColorTask);
                                ListItem.ForeColor = GetTextColor(ListItem.BackColor);

                                ListItem.Group = ListGroup;
                                listViewWeek.Items.Add(ListItem);
                            }
                        }
                    }

                    if (CountTask == 0) // задач на день нету
                    {
                        ListViewItem ListItem = new ListViewItem("Задач нет.");
                        ListItem.Tag = -1;
                        ListItem.Group = ListGroup;
                        listViewWeek.Items.Add(ListItem);
                    }
                }
            }
            else
            { // если за неделю нет задач
                for (int i = 0; i < 7; i++)
                {
                    DateTime CurrDate = DtStart + new TimeSpan(i, 0, 0, 0);
                    string NameGroup = CurrDate.ToString("ddd") + ", " + CurrDate.ToLongDateString();
                    if (CurrDate.Date == SelectDate.Date)
                    {
                        NameGroup = "[" + NameGroup + "]";
                    }
                    ListViewGroup ListGroup = new ListViewGroup(NameGroup);
                    ListGroup.Tag = CurrDate; // тут храним дату
                    listViewWeek.Groups.Add(ListGroup);
                    ListViewItem ListItem = new ListViewItem("Задач нет.");
                    ListItem.Tag = -1;
                    ListItem.Group = ListGroup;
                    listViewWeek.Items.Add(ListItem);
                }
            }
        }




        private void buttonLastDate_Click(object sender, EventArgs e)
        {
            SelectDate -= new TimeSpan(1, 0, 0, 0);
            monthCalendar.SetDate(SelectDate);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateUpdate();
            TextBoxTaskUpdateDayOrWeek();
        }

        private void buttonNextDate_Click(object sender, EventArgs e)
        {
            SelectDate += new TimeSpan(1, 0, 0, 0);
            monthCalendar.SetDate(SelectDate);
        }

        private void добавитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTask AddTask = new FormTask(true, -1);
            AddTask.Owner = this;
            AddTask.ShowDialog();
            DateUpdate();
            TextBoxTaskUpdateDayOrWeek();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckModify()
        {
            KeyTask = -1;
            if ((listViewDay.SelectedItems.Count > 0) || (listViewWeek.SelectedItems.Count > 0))
            {
                if ((listViewDay.SelectedItems.Count > 0) && ((int)listViewDay.SelectedItems[0].Tag >= 0))
                {
                    KeyTask = (int)listViewDay.SelectedItems[0].Tag;
                }
                if ((listViewWeek.SelectedItems.Count > 0) && ((int)listViewWeek.SelectedItems[0].Tag >= 0))
                {
                    KeyTask = (int)listViewWeek.SelectedItems[0].Tag;
                }
            }

        }

        private void редактироватьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KeyTask >= 0)
            {
                FormTask AddTask = new FormTask(false, KeyTask);
                AddTask.Owner = this;
                AddTask.ShowDialog();
                DateUpdate();
                TextBoxTaskUpdateDayOrWeek();
            }

        }

        private void удалитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KeyTask >= 0)
            {
                var result = MessageBox.Show("Удалить задачу?", "Подтверждение", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            задачиTableAdapter.GetTask(dbtaskDataSet.Задачи, KeyTask);
                            if (dbtaskDataSet.Задачи.Rows.Count > 0)
                            {
                                DataRow DeletedRow = dbtaskDataSet.Задачи.Rows[0];
                                DeletedRow.Delete();
                                try
                                {
                                    задачиTableAdapter.Update(dbtaskDataSet.Задачи);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("Задача не удалена. Ошибка: " + ex.Message);
                                }
                            }
                            DateUpdate();
                            CheckModify();
                            TextBoxTaskUpdateDayOrWeek();
                            ButtonsUpdate();
                            break;
                        }
                    case DialogResult.No: return;
                }
            }
        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGroup AddGroup = new FormGroup(true, -1);
            AddGroup.Owner = this;
            AddGroup.ShowDialog();
            GroupUpdate();
        }

        private void редактироватьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int KeyGroup = -1;
            if ((listViewGroups.SelectedItems.Count > 0) && ((int)listViewGroups.SelectedItems[0].Tag >= 0))
            {
                KeyGroup = (int)listViewGroups.SelectedItems[0].Tag;
            }

            if (KeyGroup >= 0)
            {
                FormGroup AddGroup = new FormGroup(false, KeyGroup);
                AddGroup.Owner = this;
                AddGroup.ShowDialog();
                GroupUpdate();
                DateUpdate();
            }
        }

        private void удалитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int KeyGroup = -1;
            if ((listViewGroups.SelectedItems.Count > 0) && ((int)listViewGroups.SelectedItems[0].Tag >= 0))
            {
                KeyGroup = (int)listViewGroups.SelectedItems[0].Tag;
            }

            if (KeyGroup >= 0)
            {
                var result = MessageBox.Show("Удалить группу? Будут удалены все задачи из этой группы.", "Подтверждение", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            группыTableAdapter.GetGroup(dbtaskDataSet.Группы, KeyGroup);
                            if (dbtaskDataSet.Группы.Rows.Count > 0)
                            {
                                DataRow RowGroup = dbtaskDataSet.Группы.Rows[0];
                                if (KeyGroup != 1)
                                {
                                    RowGroup.Delete();
                                }
                                else
                                {

                                    RowGroup["НазваниеГруппы"] = "Общая";
                                    RowGroup["ЦветГруппы"] = Color.LightGray.ToArgb();


                                    задачиTableAdapter.GetTaskFromGroup(dbtaskDataSet.Задачи, KeyGroup);

                                    if (dbtaskDataSet.Задачи.Rows.Count > 0)
                                    {
                                        for (int i = 0; i < dbtaskDataSet.Задачи.Rows.Count; i++) {
                                            DataRow DeletedRow = dbtaskDataSet.Задачи.Rows[i];
                                            DeletedRow.Delete();
                                        }
                                        try
                                        {
                                            задачиTableAdapter.Update(dbtaskDataSet.Задачи);
                                        }
                                        catch (System.Exception ex)
                                        {
                                            MessageBox.Show("Задачи из группы не удалены. Ошибка: " + ex.Message);
                                        }
                                    }
                                }


                                try
                                {
                                    группыTableAdapter.Update(dbtaskDataSet.Группы);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("Группа не удалена. Ошибка: " + ex.Message);
                                }
                            }
                            GroupUpdate();
                            DateUpdate();

                            break;
                        }
                    case DialogResult.No: return;
                }
            }
        }

        private void listViewGroups_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (GroupUpdating == false) // если группы не обновлются
            {

                int KeyGroup = (int)e.Item.Tag; // получаем код группы
                if (KeyGroup >= 0)
                {
                    группыTableAdapter.GetGroup(dbtaskDataSet.Группы, KeyGroup); // получаем группу
                    if (dbtaskDataSet.Группы.Rows.Count > 0)
                    {
                        DataRow ModifiedRow = dbtaskDataSet.Группы.Rows[0];
                        ModifiedRow["ПоказыватьЗадачиГруппы"] = e.Item.Checked; // заносим новое значение Checked
                    }
                    try
                    {
                        // сохраняем данные в таблицу группы
                        группыTableAdapter.Update(dbtaskDataSet.Группы);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Группа не сохранена. Ошибка: " + ex.Message);
                    }
                }
                // обновляем задачи
                DateUpdate();
            }
        }

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.View = comboBoxView.SelectedIndex;
            Properties.Settings.Default.Save();
            DateUpdate();
        }

        public static string GetPeriod(double PeriodSeconds) 
        {
            string PeriodStr = "";

            int OneDay = 60 * 60 * 24;
            int OneHour = 60 * 60;
            int OneMinute = 60;
            // считаем количество дней из полученных секунд
            int Days = (int)(PeriodSeconds / OneDay);
            // вычисляем остаток от деления: в остатке часы минуты секунды
            PeriodSeconds = (PeriodSeconds % OneDay);
            // считаем количество часов из полученных секунд
            int Hours = (int)(PeriodSeconds / OneHour);
            // вычисляем остаток от деления: в остатке минуты секунды
            PeriodSeconds = (PeriodSeconds % OneHour);
            // считаем количество минут из полученных секунд
            int Minutes = (int)(PeriodSeconds / OneMinute);
            // вычисляем остаток от деления: в остатке секунды
            PeriodSeconds = (PeriodSeconds % OneMinute);
            int Seconds = (int)(PeriodSeconds);

            TimeSpan TS = new TimeSpan(Days, Hours, Minutes, Seconds);
            if (Days > 0)
            {
                PeriodStr += TS.Days + " дн. ";
            }
            PeriodStr += TS.ToString(@"hh\:mm\:ss");

            return PeriodStr;
        }

        private void textBoxTaskUpdate(DateTime DateDay)
        {
            if (KeyTask >= 0)
            {
                задачиTableAdapter.GetTask(dbtaskDataSet.Задачи, KeyTask);
                if (dbtaskDataSet.Задачи.Rows.Count > 0)
                {
                    DataRow dr = dbtaskDataSet.Задачи.Rows[0];

                    string GroupName = "Группа: " + dr["НазваниеГруппы"].ToString();
                    string TaskName = "Задача: " + dr["НазваниеЗадачи"].ToString();

                    DateTime DateStart = (DateTime)dr["ДатаНачала"];
                    DateTime DateEnd = (DateTime)dr["ДатаОкончания"];

                    string DateTask = "";
                    if (DateStart.Date == DateEnd.Date)
                    {
                        DateTask = "Дата выполнения: " + DateStart.ToShortDateString();
                    }
                    else
                    {
                        DateTask = "Период выполнения: " + DateStart.ToShortDateString() + " - " + DateEnd.ToShortDateString();
                    }

                    string TimeStartTask = "";
                    bool UseStartTime = (bool)dr["ИспользоватьВремяНачала"];
                    if (UseStartTime == true)
                    {
                        DateTime StartTime = (DateTime)dr["ВремяНачала"];
                        TimeStartTask = "Время начала: " + StartTime.ToString("HH:mm");
                    }

                    string Status = "Статус: ";
                    bool Done = (bool)dr["ЗадачаВыполнена"];
                    if (Done == true)
                    { 
                        Status = Status + "Выполнено";
                    }
                    else
                    {
                        Status = Status + "В работе";
                    }

                    textBoxTask.Text += GroupName + "\r\n";
                    textBoxTask.Text += TaskName + "\r\n";
                    if (UseStartTime == true)
                    {
                        textBoxTask.Text += TimeStartTask + "\r\n";
                    }
                    textBoxTask.Text += DateTask + "\r\n"; ;
                    textBoxTask.Text += Status + "\r\n";

                    textBoxTask.Text += "Статистика выполнения (" + DateDay.ToShortDateString() + "):\r\n";

                    // начало дня
                    DateTime DateStartDay = new DateTime(DateDay.Year, DateDay.Month, DateDay.Day, 0, 0, 0);
                    // конец дня
                    DateTime DateEndDay = new DateTime(DateDay.Year, DateDay.Month, DateDay.Day, 23, 59, 59);

                    // Получаем сумму планируемого времени
                    var Plan = планируемыеЗатратыВремениTableAdapter.ScalarQuery(DateStartDay, DateEndDay, KeyTask);
                    double PlanSecond = 0;
                    if (Plan != null)
                    {
                        PlanSecond = (double)Plan;
                    }
                    string PlanStr = "Планируемое время: " + GetPeriod(PlanSecond);
                    textBoxTask.Text += PlanStr.ToString() + "\r\n";


                    // Получаем сумму фактического времени
                    var Fakt = фактическиеЗатратыВремениTableAdapter.ScalarQuery(DateStartDay, DateEndDay, KeyTask);
                    double FaktSecond = 0;
                    if (Fakt != null)
                    {
                        FaktSecond = (double)Fakt;
                    }
                    string FaktStr = "Фактическое время: " + GetPeriod(FaktSecond);
                    textBoxTask.Text += FaktStr.ToString() + "\r\n";

                    // Процент выполнения
                    int Procent = 0;
                    if (PlanSecond > 0)
                    {
                        Procent = (int)((FaktSecond * 100) / PlanSecond);
                    }
                    else
                    {
                        if (FaktSecond > 0)
                        {
                            Procent = 100;
                        }
                    }
                    textBoxTask.Text += "Процент выполнения: " + Procent.ToString() + " %";

                }
            }
        }

        private void ButtonsUpdate()
        {
            bool ChooseTask = false;
            if ((listViewDay.SelectedItems.Count > 0) || (listViewWeek.SelectedItems.Count > 0))
            {
                if ((listViewDay.SelectedItems.Count > 0) && ((int)listViewDay.SelectedItems[0].Tag >= 0))
                {
                    ChooseTask = true;
                }
                if ((listViewWeek.SelectedItems.Count > 0) && ((int)listViewWeek.SelectedItems[0].Tag >= 0))
                {
                    ChooseTask = true;
                }
            }

            if (ChooseTask == true)
            {
                contextMenuStripTask.Enabled = true;
                buttonTaskModify.Enabled = true;
                buttonTaskDelete.Enabled = true;
                buttonDone.Enabled = true;
                buttonStart.Enabled = true;
            }
            else
            {
                contextMenuStripTask.Enabled = false;
                buttonTaskModify.Enabled = false;
                buttonTaskDelete.Enabled = false;
                buttonDone.Enabled = false;
                buttonStart.Enabled = false;
            }
        }

        private void TextBoxTaskUpdateDayOrWeek()
        {
            textBoxTask.Text = "";

            if (comboBoxView.SelectedIndex == 0)
            {
                textBoxTaskUpdate(SelectDate);
            }
            else if (comboBoxView.SelectedIndex == 1)
            {
                if ((listViewWeek.SelectedItems.Count > 0) && ((int)listViewWeek.SelectedItems[0].Tag >= 0))
                {
                    var DateDayObj = listViewWeek.SelectedItems[0].Group.Tag;
                    DateTime DateDay = new DateTime();
                    DateDay = (DateTime)DateDayObj;
                    textBoxTaskUpdate(DateDay);
                }
            }
        }

        private void listViewWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDayChange == false)
            {
                listViewWeekChange = true;
                listViewDay.SelectedItems.Clear();
                CheckModify();
                TextBoxTaskUpdateDayOrWeek();
                ButtonsUpdate();
                listViewWeekChange = false;
            }
        }

        private void listViewDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWeekChange == false)
            {
                listViewDayChange = true;
                listViewWeek.SelectedItems.Clear();
                CheckModify();
                TextBoxTaskUpdateDayOrWeek();
                ButtonsUpdate();
                listViewDayChange = false;
            }
        }

        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGroups.SelectedItems.Count > 0) 
            {
                contextMenuStripGroup.Enabled = true;
                buttonGroupModify.Enabled = true;
                buttonGroupDelete.Enabled = true;
            }
            else
            {
                contextMenuStripGroup.Enabled = false;
                buttonGroupModify.Enabled = false;
                buttonGroupDelete.Enabled = false;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (KeyTask >= 0)
            {
                задачиTableAdapter.GetTask(dbtaskDataSet.Задачи, KeyTask);
                DataRow ModifiedRow = dbtaskDataSet.Задачи.Rows[0];

                bool Done = (bool)ModifiedRow["ЗадачаВыполнена"];
                ModifiedRow["ЗадачаВыполнена"] = !Done;

                try
                {
                    задачиTableAdapter.Update(dbtaskDataSet.Задачи);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Статус задачи не сохранен. Ошибка: " + ex.Message);
                }

                DateUpdate();
                TextBoxTaskUpdateDayOrWeek();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (KeyTask >= 0)
            {
                contextMenuStripTask.Enabled = false;
                buttonTaskAdd.Enabled = false;
                buttonTaskModify.Enabled = false;
                buttonTaskDelete.Enabled = false;
                buttonDone.Enabled = false;
                listViewDay.Enabled = false;
                listViewWeek.Enabled = false;


                buttonStop.Visible = true;
                buttonStart.Visible = false;
                TimeClock = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
                labelClock.Text = TimeClock.ToString("HH:mm:ss");

                DateTimeStart = DateTime.Now;
                timerClock.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (KeyTask >= 0)
            {
                contextMenuStripTask.Enabled = true;
                buttonTaskAdd.Enabled = true;
                buttonTaskModify.Enabled = true;
                buttonTaskDelete.Enabled = true;
                buttonDone.Enabled = true;
                listViewDay.Enabled = true;
                listViewWeek.Enabled = true;

                buttonStop.Visible = false;
                buttonStart.Visible = true;
                timerClock.Stop();
                DateTimeStop = DateTime.Now;
                labelClock.Text = TimeClock.ToString("HH:mm:ss");

                // добавляем данные в таблицу фактические затраты
                DataRow FaktRow = dbtaskDataSet.ФактическиеЗатратыВремени.NewRow();
                FaktRow["КодЗадачи"] = KeyTask;
                FaktRow["ДатаВремяНачала"] = DateTimeStart;
                FaktRow["ДатаВремяОкончания"] = DateTimeStop;
                dbtaskDataSet.ФактическиеЗатратыВремени.Rows.Add(FaktRow);

                try
                {
                    фактическиеЗатратыВремениTableAdapter.Update(dbtaskDataSet.ФактическиеЗатратыВремени);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Фактические затраты не сохранены. Ошибка: " + ex.Message);
                }
                TextBoxTaskUpdateDayOrWeek();
            }

        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            TimeClock = TimeClock + new TimeSpan(0, 0, 0, 1);
            labelClock.Text = TimeClock.ToString("HH:mm:ss");

            if (Properties.Settings.Default.ShowBalloon == true)
            {
                int hoursBalloon = Properties.Settings.Default.TimeBalloon.Hour;
                int minuteBalloon = Properties.Settings.Default.TimeBalloon.Minute;
                int secondBalloon = Properties.Settings.Default.TimeBalloon.Second;

                int hoursClock = TimeClock.Hour;
                int minuteClock = TimeClock.Minute;
                int secondClock = TimeClock.Second;


                int totalsecondBalloon = hoursBalloon * 60 * 60 + minuteBalloon * 60 + secondBalloon;
                int totalsecondClock = hoursClock * 60 * 60 + minuteClock * 60 + secondClock;

                int modClockBalloon = totalsecondClock % totalsecondBalloon;

                if (modClockBalloon == 0)
                {
                    // задаем иконку всплывающей подсказки
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    // задаем текст подсказки
                    notifyIcon.BalloonTipText = "Вы достигли установленного времени. Сделайте перерыв. Вы работаете над задачей уже " + TimeClock.ToString("HH:mm:ss");
                    // устанавливаем заголовок
                    notifyIcon.BalloonTipTitle = "Оповещение";
                    // отображаем подсказку 5 секунд
                    notifyIcon.ShowBalloonTip(5);
                }

            }

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings Settings = new FormSettings();
            Settings.Owner = this;
            Settings.ShowDialog();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics Statistics = new FormStatistics();
            Statistics.Owner = this;
            Statistics.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox About = new AboutBox();
            About.Owner = this;
            About.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon.Visible = false;
        }
    }
}