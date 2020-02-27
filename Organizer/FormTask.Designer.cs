namespace Organizer
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxTimeStart = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTimeStart = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtaskDataSetTask = new Organizer.dbtaskDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxColorGroup = new System.Windows.Forms.CheckBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.dateTimePickerPlan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.задачиTableAdapterTask = new Organizer.dbtaskDataSetTableAdapters.ЗадачиTableAdapter();
            this.группыTableAdapterTask = new Organizer.dbtaskDataSetTableAdapters.ГруппыTableAdapter();
            this.планируемыеЗатратыВремениTableAdapterTask = new Organizer.dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSetTask)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(15, 31);
            this.textBoxName.MaxLength = 255;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(406, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название задачи";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 78);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(164, 78);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата Окончания";
            // 
            // checkBoxTimeStart
            // 
            this.checkBoxTimeStart.AutoSize = true;
            this.checkBoxTimeStart.Location = new System.Drawing.Point(308, 61);
            this.checkBoxTimeStart.Name = "checkBoxTimeStart";
            this.checkBoxTimeStart.Size = new System.Drawing.Size(97, 17);
            this.checkBoxTimeStart.TabIndex = 7;
            this.checkBoxTimeStart.Text = "Время начала";
            this.checkBoxTimeStart.UseVisualStyleBackColor = true;
            this.checkBoxTimeStart.Click += new System.EventHandler(this.checkBoxTimeStart_CheckedChanged);
            // 
            // dateTimePickerTimeStart
            // 
            this.dateTimePickerTimeStart.CustomFormat = "HH:mm";
            this.dateTimePickerTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeStart.Location = new System.Drawing.Point(308, 78);
            this.dateTimePickerTimeStart.Name = "dateTimePickerTimeStart";
            this.dateTimePickerTimeStart.ShowUpDown = true;
            this.dateTimePickerTimeStart.Size = new System.Drawing.Size(113, 20);
            this.dateTimePickerTimeStart.TabIndex = 9;
            this.dateTimePickerTimeStart.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(251, 10);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(121, 17);
            this.checkBoxDone.TabIndex = 12;
            this.checkBoxDone.Text = "Задача выполнена";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.группыBindingSource;
            this.comboBoxGroup.DisplayMember = "НазваниеГруппы";
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(164, 132);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(257, 21);
            this.comboBoxGroup.TabIndex = 13;
            this.comboBoxGroup.ValueMember = "КодГруппы";
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.dbtaskDataSetTask;
            // 
            // dbtaskDataSetTask
            // 
            this.dbtaskDataSetTask.DataSetName = "dbtaskDataSet";
            this.dbtaskDataSetTask.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Группа";
            // 
            // checkBoxColorGroup
            // 
            this.checkBoxColorGroup.AutoSize = true;
            this.checkBoxColorGroup.Location = new System.Drawing.Point(331, 110);
            this.checkBoxColorGroup.Name = "checkBoxColorGroup";
            this.checkBoxColorGroup.Size = new System.Drawing.Size(90, 17);
            this.checkBoxColorGroup.TabIndex = 15;
            this.checkBoxColorGroup.Text = "Цвет группы";
            this.checkBoxColorGroup.UseVisualStyleBackColor = true;
            this.checkBoxColorGroup.Click += new System.EventHandler(this.checkBoxColorGroup_CheckedChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonColor.Location = new System.Drawing.Point(378, 6);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(43, 23);
            this.buttonColor.TabIndex = 16;
            this.buttonColor.Text = "Цвет";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // dateTimePickerPlan
            // 
            this.dateTimePickerPlan.CustomFormat = "HH:mm";
            this.dateTimePickerPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPlan.Location = new System.Drawing.Point(16, 132);
            this.dateTimePickerPlan.Name = "dateTimePickerPlan";
            this.dateTimePickerPlan.ShowUpDown = true;
            this.dateTimePickerPlan.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerPlan.TabIndex = 17;
            this.dateTimePickerPlan.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "План на день";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(68, 159);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Location = new System.Drawing.Point(232, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // задачиTableAdapterTask
            // 
            this.задачиTableAdapterTask.ClearBeforeFill = true;
            // 
            // группыTableAdapterTask
            // 
            this.группыTableAdapterTask.ClearBeforeFill = true;
            // 
            // планируемыеЗатратыВремениTableAdapterTask
            // 
            this.планируемыеЗатратыВремениTableAdapterTask.ClearBeforeFill = true;
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 195);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerPlan);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.checkBoxColorGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.dateTimePickerTimeStart);
            this.Controls.Add(this.checkBoxTimeStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор задачи";
            this.Load += new System.EventHandler(this.FormTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSetTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeStart;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxColorGroup;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private dbtaskDataSet dbtaskDataSetTask;
        private dbtaskDataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapterTask;
        private dbtaskDataSetTableAdapters.ГруппыTableAdapter группыTableAdapterTask;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter планируемыеЗатратыВремениTableAdapterTask;
    }
}