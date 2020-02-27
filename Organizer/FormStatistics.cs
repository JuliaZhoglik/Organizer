using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Organizer
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value.Date > dateTimePickerEnd.Value.Date)
            {
                MessageBox.Show("Дата начала периода не может быть больше даты окончания периода.");
                return;
            }

            // начало дня
            DateTime DateStartDay = new DateTime(dateTimePickerStart.Value.Year, dateTimePickerStart.Value.Month, dateTimePickerStart.Value.Day, 0, 0, 0);
            // конец дня
            DateTime DateEndDay = new DateTime(dateTimePickerEnd.Value.Year, dateTimePickerEnd.Value.Month, dateTimePickerEnd.Value.Day, 23, 59, 59);

            фактическиеЗатратыВремениTableAdapterStatistic.FillBy(dbtaskDataSetStatistic.ФактическиеЗатратыВремени, DateStartDay, DateEndDay);

            double SumFakt = 0;
            double SumPlan = 0;
            chartTask.Series["SeriesFakt"].Points.Clear();
            chartTask.Series["SeriesPlan"].Points.Clear();
            if (dbtaskDataSetStatistic.ФактическиеЗатратыВремени.Rows.Count > 0)
            {
                chartTask.Titles["TitleChart"].Text = "Статистика времени по видам задач";
                for (int i = 0; i < dbtaskDataSetStatistic.ФактическиеЗатратыВремени.Rows.Count; i++)
                {
                    DataRow dr = dbtaskDataSetStatistic.ФактическиеЗатратыВремени.Rows[i];

                    double fakt = (double)dr["ФактСумм"];
                    double plan = (double)dr["ПланСумм"];

                    chartTask.Series["SeriesFakt"].Points.AddXY(dr["НазваниеЗадачи"], fakt);
                    chartTask.Series["SeriesPlan"].Points.AddXY(dr["НазваниеЗадачи"], plan);

                    chartTask.Series["SeriesFakt"].Points[i].Label = "Факт: " + FormMain.GetPeriod(fakt);
                    chartTask.Series["SeriesPlan"].Points[i].Label = "План: " + FormMain.GetPeriod(plan);

                    SumFakt += fakt;
                    SumPlan += plan;
                }
            }
            else
            {
                chartTask.Titles["TitleChart"].Text = "Статистики времени по видам задач за выбранный период нету";
            }
            textBoxTimes.Text = "Общие временные затраты\r\n";
            textBoxTimes.Text += "План: " + FormMain.GetPeriod(SumPlan) + "\r\n";
            textBoxTimes.Text += "Факт: " + FormMain.GetPeriod(SumFakt) + "\r\n";

            int Procent = 0;
            if (SumPlan > 0)
            {
                Procent = (int)((SumFakt * 100) / SumPlan);
            } else
            {
                if (SumFakt > 0)
                {
                    Procent = 100;
                }
            }
            textBoxTimes.Text += "Процент выполнения: " + Procent.ToString() + " %";

        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }


    }
}
