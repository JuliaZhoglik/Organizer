namespace Organizer
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStripTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.statusStripNotification = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonTaskAdd = new System.Windows.Forms.Button();
            this.buttonTaskModify = new System.Windows.Forms.Button();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.buttonGroupModify = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonTaskDelete = new System.Windows.Forms.Button();
            this.buttonLastDate = new System.Windows.Forms.Button();
            this.buttonNextDate = new System.Windows.Forms.Button();
            this.buttonGroupDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDay = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.columnHeaderGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewWeek = new System.Windows.Forms.ListView();
            this.columnHeaderNameWeek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.dbtaskDataSet = new Organizer.dbtaskDataSet();
            this.задачиTableAdapter = new Organizer.dbtaskDataSetTableAdapters.ЗадачиTableAdapter();
            this.группыTableAdapter = new Organizer.dbtaskDataSetTableAdapters.ГруппыTableAdapter();
            this.фактическиеЗатратыВремениTableAdapter = new Organizer.dbtaskDataSetTableAdapters.ФактическиеЗатратыВремениTableAdapter();
            this.планируемыеЗатратыВремениTableAdapter = new Organizer.dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter();
            this.задачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStripTask.SuspendLayout();
            this.statusStripNotification.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripTask
            // 
            this.contextMenuStripTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьЗадачуToolStripMenuItem,
            this.удалитьЗадачуToolStripMenuItem});
            this.contextMenuStripTask.Name = "contextMenuStripTaskDay";
            this.contextMenuStripTask.Size = new System.Drawing.Size(194, 48);
            // 
            // редактироватьЗадачуToolStripMenuItem
            // 
            this.редактироватьЗадачуToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_редактировать_30;
            this.редактироватьЗадачуToolStripMenuItem.Name = "редактироватьЗадачуToolStripMenuItem";
            this.редактироватьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.редактироватьЗадачуToolStripMenuItem.Text = "Редактировать задачу";
            this.редактироватьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗадачуToolStripMenuItem_Click);
            // 
            // удалитьЗадачуToolStripMenuItem
            // 
            this.удалитьЗадачуToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_удалить_30;
            this.удалитьЗадачуToolStripMenuItem.Name = "удалитьЗадачуToolStripMenuItem";
            this.удалитьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.удалитьЗадачуToolStripMenuItem.Text = "Удалить задачу";
            this.удалитьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗадачуToolStripMenuItem_Click);
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectDate.Location = new System.Drawing.Point(97, 38);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(206, 32);
            this.labelSelectDate.TabIndex = 5;
            this.labelSelectDate.Text = "labelSelectDate";
            // 
            // statusStripNotification
            // 
            this.statusStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNotification});
            this.statusStripNotification.Location = new System.Drawing.Point(0, 540);
            this.statusStripNotification.Name = "statusStripNotification";
            this.statusStripNotification.Size = new System.Drawing.Size(784, 22);
            this.statusStripNotification.TabIndex = 4;
            // 
            // toolStripStatusLabelNotification
            // 
            this.toolStripStatusLabelNotification.Name = "toolStripStatusLabelNotification";
            this.toolStripStatusLabelNotification.Size = new System.Drawing.Size(0, 17);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(617, 33);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStripMain";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_статистика_32;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика по задачам";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.настройкиToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_настройки_filled_32;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_выход_48;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_информация_64;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // comboBoxView
            // 
            this.comboBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "День",
            "Неделя"});
            this.comboBoxView.Location = new System.Drawing.Point(504, 96);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(101, 21);
            this.comboBoxView.TabIndex = 8;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // buttonTaskAdd
            // 
            this.buttonTaskAdd.BackgroundImage = global::Organizer.Properties.Resources.icons8_сложение_30;
            this.buttonTaskAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTaskAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaskAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaskAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTaskAdd.Location = new System.Drawing.Point(442, 33);
            this.buttonTaskAdd.Name = "buttonTaskAdd";
            this.buttonTaskAdd.Size = new System.Drawing.Size(41, 37);
            this.buttonTaskAdd.TabIndex = 26;
            this.toolTip.SetToolTip(this.buttonTaskAdd, "Добавить задачу");
            this.buttonTaskAdd.UseVisualStyleBackColor = true;
            this.buttonTaskAdd.Click += new System.EventHandler(this.добавитьЗадачуToolStripMenuItem_Click);
            // 
            // buttonTaskModify
            // 
            this.buttonTaskModify.BackgroundImage = global::Organizer.Properties.Resources.icons8_редактировать_30;
            this.buttonTaskModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTaskModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaskModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaskModify.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTaskModify.Location = new System.Drawing.Point(504, 33);
            this.buttonTaskModify.Name = "buttonTaskModify";
            this.buttonTaskModify.Size = new System.Drawing.Size(41, 37);
            this.buttonTaskModify.TabIndex = 25;
            this.toolTip.SetToolTip(this.buttonTaskModify, "Редактировать задачу");
            this.buttonTaskModify.UseVisualStyleBackColor = true;
            this.buttonTaskModify.Click += new System.EventHandler(this.редактироватьЗадачуToolStripMenuItem_Click);
            // 
            // buttonGroupAdd
            // 
            this.buttonGroupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroupAdd.BackgroundImage = global::Organizer.Properties.Resources.icons8_сложение_30;
            this.buttonGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGroupAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupAdd.Location = new System.Drawing.Point(685, 373);
            this.buttonGroupAdd.Name = "buttonGroupAdd";
            this.buttonGroupAdd.Size = new System.Drawing.Size(27, 25);
            this.buttonGroupAdd.TabIndex = 24;
            this.toolTip.SetToolTip(this.buttonGroupAdd, "Добавить группу");
            this.buttonGroupAdd.UseVisualStyleBackColor = true;
            this.buttonGroupAdd.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // buttonGroupModify
            // 
            this.buttonGroupModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroupModify.BackgroundImage = global::Organizer.Properties.Resources.icons8_редактировать_30;
            this.buttonGroupModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGroupModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroupModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupModify.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupModify.Location = new System.Drawing.Point(718, 373);
            this.buttonGroupModify.Name = "buttonGroupModify";
            this.buttonGroupModify.Size = new System.Drawing.Size(27, 25);
            this.buttonGroupModify.TabIndex = 23;
            this.toolTip.SetToolTip(this.buttonGroupModify, "Редактировать группу");
            this.buttonGroupModify.UseVisualStyleBackColor = true;
            this.buttonGroupModify.Click += new System.EventHandler(this.редактироватьГруппуToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackgroundImage = global::Organizer.Properties.Resources.icons8_стоп_30;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(561, 123);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(44, 37);
            this.buttonStop.TabIndex = 22;
            this.toolTip.SetToolTip(this.buttonStop, "Стоп таймера");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::Organizer.Properties.Resources.icons8_воспроизведение_30;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(561, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(44, 37);
            this.buttonStart.TabIndex = 21;
            this.toolTip.SetToolTip(this.buttonStart, "Старт таймера");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.BackgroundImage = global::Organizer.Properties.Resources.icons8_галочка_26;
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(504, 123);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(44, 37);
            this.buttonDone.TabIndex = 20;
            this.toolTip.SetToolTip(this.buttonDone, "Задача выполнена");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonTaskDelete
            // 
            this.buttonTaskDelete.BackgroundImage = global::Organizer.Properties.Resources.icons8_удалить_30;
            this.buttonTaskDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTaskDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaskDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaskDelete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTaskDelete.Location = new System.Drawing.Point(564, 33);
            this.buttonTaskDelete.Name = "buttonTaskDelete";
            this.buttonTaskDelete.Size = new System.Drawing.Size(41, 37);
            this.buttonTaskDelete.TabIndex = 9;
            this.toolTip.SetToolTip(this.buttonTaskDelete, "Удалить задачу");
            this.buttonTaskDelete.UseVisualStyleBackColor = true;
            this.buttonTaskDelete.Click += new System.EventHandler(this.удалитьЗадачуToolStripMenuItem_Click);
            // 
            // buttonLastDate
            // 
            this.buttonLastDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLastDate.BackgroundImage = global::Organizer.Properties.Resources.icons8_меньше_чем_30;
            this.buttonLastDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLastDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLastDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastDate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLastDate.Location = new System.Drawing.Point(3, 33);
            this.buttonLastDate.Name = "buttonLastDate";
            this.buttonLastDate.Size = new System.Drawing.Size(41, 37);
            this.buttonLastDate.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonLastDate, "Предыдущий день");
            this.buttonLastDate.UseVisualStyleBackColor = true;
            this.buttonLastDate.Click += new System.EventHandler(this.buttonLastDate_Click);
            // 
            // buttonNextDate
            // 
            this.buttonNextDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNextDate.BackgroundImage = global::Organizer.Properties.Resources.icons8_больше_чем_30;
            this.buttonNextDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNextDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextDate.Location = new System.Drawing.Point(50, 33);
            this.buttonNextDate.Name = "buttonNextDate";
            this.buttonNextDate.Size = new System.Drawing.Size(41, 37);
            this.buttonNextDate.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonNextDate, "Следующий день");
            this.buttonNextDate.UseVisualStyleBackColor = true;
            this.buttonNextDate.Click += new System.EventHandler(this.buttonNextDate_Click);
            // 
            // buttonGroupDelete
            // 
            this.buttonGroupDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroupDelete.BackgroundImage = global::Organizer.Properties.Resources.icons8_удалить_30;
            this.buttonGroupDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGroupDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupDelete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupDelete.Location = new System.Drawing.Point(751, 373);
            this.buttonGroupDelete.Name = "buttonGroupDelete";
            this.buttonGroupDelete.Size = new System.Drawing.Size(27, 25);
            this.buttonGroupDelete.TabIndex = 15;
            this.toolTip.SetToolTip(this.buttonGroupDelete, "Удалить группу");
            this.buttonGroupDelete.UseVisualStyleBackColor = true;
            this.buttonGroupDelete.Click += new System.EventHandler(this.удалитьГруппуToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Просмотр";
            // 
            // contextMenuStripGroup
            // 
            this.contextMenuStripGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьГруппуToolStripMenuItem,
            this.удалитьГруппуToolStripMenuItem});
            this.contextMenuStripGroup.Name = "contextMenuStripGroup";
            this.contextMenuStripGroup.Size = new System.Drawing.Size(196, 48);
            // 
            // редактироватьГруппуToolStripMenuItem
            // 
            this.редактироватьГруппуToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_редактировать_30;
            this.редактироватьГруппуToolStripMenuItem.Name = "редактироватьГруппуToolStripMenuItem";
            this.редактироватьГруппуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.редактироватьГруппуToolStripMenuItem.Text = "Редактировать группу";
            this.редактироватьГруппуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьГруппуToolStripMenuItem_Click);
            // 
            // удалитьГруппуToolStripMenuItem
            // 
            this.удалитьГруппуToolStripMenuItem.Image = global::Organizer.Properties.Resources.icons8_удалить_30;
            this.удалитьГруппуToolStripMenuItem.Name = "удалитьГруппуToolStripMenuItem";
            this.удалитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.удалитьГруппуToolStripMenuItem.Text = "Удалить группу";
            this.удалитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.удалитьГруппуToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Группы";
            // 
            // listViewDay
            // 
            this.listViewDay.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewDay.ContextMenuStrip = this.contextMenuStripTask;
            this.listViewDay.FullRowSelect = true;
            this.listViewDay.GridLines = true;
            this.listViewDay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDay.Location = new System.Drawing.Point(3, 80);
            this.listViewDay.MultiSelect = false;
            this.listViewDay.Name = "listViewDay";
            this.listViewDay.ShowGroups = false;
            this.listViewDay.Size = new System.Drawing.Size(480, 460);
            this.listViewDay.TabIndex = 0;
            this.listViewDay.UseCompatibleStateImageBehavior = false;
            this.listViewDay.View = System.Windows.Forms.View.Details;
            this.listViewDay.SelectedIndexChanged += new System.EventHandler(this.listViewDay_SelectedIndexChanged);
            this.listViewDay.DoubleClick += new System.EventHandler(this.редактироватьЗадачуToolStripMenuItem_Click);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Задачи на день";
            this.columnHeaderName.Width = 480;
            // 
            // listViewGroups
            // 
            this.listViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewGroups.CheckBoxes = true;
            this.listViewGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGroup,
            this.columnHeaderColor});
            this.listViewGroups.ContextMenuStrip = this.contextMenuStripGroup;
            this.listViewGroups.FullRowSelect = true;
            this.listViewGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewGroups.Location = new System.Drawing.Point(489, 401);
            this.listViewGroups.MultiSelect = false;
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.ShowGroups = false;
            this.listViewGroups.Size = new System.Drawing.Size(289, 139);
            this.listViewGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewGroups.TabIndex = 13;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.View = System.Windows.Forms.View.Details;
            this.listViewGroups.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewGroups_ItemChecked);
            this.listViewGroups.SelectedIndexChanged += new System.EventHandler(this.listViewGroups_SelectedIndexChanged);
            // 
            // columnHeaderGroup
            // 
            this.columnHeaderGroup.DisplayIndex = 1;
            this.columnHeaderGroup.Text = "Группа";
            this.columnHeaderGroup.Width = 135;
            // 
            // columnHeaderColor
            // 
            this.columnHeaderColor.DisplayIndex = 0;
            this.columnHeaderColor.Text = "Цвет";
            this.columnHeaderColor.Width = 22;
            // 
            // listViewWeek
            // 
            this.listViewWeek.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewWeek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNameWeek});
            this.listViewWeek.ContextMenuStrip = this.contextMenuStripTask;
            this.listViewWeek.FullRowSelect = true;
            this.listViewWeek.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewWeek.Location = new System.Drawing.Point(3, 80);
            this.listViewWeek.MultiSelect = false;
            this.listViewWeek.Name = "listViewWeek";
            this.listViewWeek.Size = new System.Drawing.Size(480, 460);
            this.listViewWeek.TabIndex = 17;
            this.listViewWeek.UseCompatibleStateImageBehavior = false;
            this.listViewWeek.View = System.Windows.Forms.View.Details;
            this.listViewWeek.SelectedIndexChanged += new System.EventHandler(this.listViewWeek_SelectedIndexChanged);
            this.listViewWeek.DoubleClick += new System.EventHandler(this.редактироватьЗадачуToolStripMenuItem_Click);
            // 
            // columnHeaderNameWeek
            // 
            this.columnHeaderNameWeek.Text = "Задачи на неделю";
            this.columnHeaderNameWeek.Width = 480;
            // 
            // labelClock
            // 
            this.labelClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClock.Location = new System.Drawing.Point(498, 163);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(121, 32);
            this.labelClock.TabIndex = 19;
            this.labelClock.Text = "00:00:00";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Оповещение";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Органайзер";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.AcceptsReturn = true;
            this.textBoxTask.AcceptsTab = true;
            this.textBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTask.Location = new System.Drawing.Point(489, 198);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTask.ShortcutsEnabled = false;
            this.textBoxTask.Size = new System.Drawing.Size(289, 169);
            this.textBoxTask.TabIndex = 27;
            // 
            // dbtaskDataSet
            // 
            this.dbtaskDataSet.DataSetName = "dbtaskDataSet";
            this.dbtaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // задачиTableAdapter
            // 
            this.задачиTableAdapter.ClearBeforeFill = true;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // фактическиеЗатратыВремениTableAdapter
            // 
            this.фактическиеЗатратыВремениTableAdapter.ClearBeforeFill = true;
            // 
            // планируемыеЗатратыВремениTableAdapter
            // 
            this.планируемыеЗатратыВремениTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.buttonTaskAdd);
            this.Controls.Add(this.buttonTaskModify);
            this.Controls.Add(this.buttonGroupAdd);
            this.Controls.Add(this.buttonGroupModify);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.buttonTaskDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewGroups);
            this.Controls.Add(this.buttonLastDate);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.buttonNextDate);
            this.Controls.Add(this.buttonGroupDelete);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.statusStripNotification);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.listViewDay);
            this.Controls.Add(this.listViewWeek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripTask.ResumeLayout(false);
            this.statusStripNotification.ResumeLayout(false);
            this.statusStripNotification.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripNotification;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNotification;
        private dbtaskDataSet dbtaskDataSet;
        private System.Windows.Forms.BindingSource задачиBindingSource;
        private dbtaskDataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonNextDate;
        private System.Windows.Forms.Button buttonLastDate;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTask;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonTaskDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDay;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ListView listViewWeek;
        private System.Windows.Forms.ColumnHeader columnHeaderNameWeek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGroup;
        private System.Windows.Forms.ToolStripMenuItem редактироватьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ListView listViewGroups;
        private System.Windows.Forms.ColumnHeader columnHeaderGroup;
        private System.Windows.Forms.ColumnHeader columnHeaderColor;
        private dbtaskDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.Button buttonGroupDelete;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGroupModify;
        private System.Windows.Forms.Button buttonGroupAdd;
        private System.Windows.Forms.Button buttonTaskModify;
        private System.Windows.Forms.Button buttonTaskAdd;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private dbtaskDataSetTableAdapters.ФактическиеЗатратыВремениTableAdapter фактическиеЗатратыВремениTableAdapter;
        private System.Windows.Forms.TextBox textBoxTask;
        private dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter планируемыеЗатратыВремениTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
    }
}

