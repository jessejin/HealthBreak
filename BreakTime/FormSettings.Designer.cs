namespace BreakTime
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelInstruction = new DevExpress.XtraEditors.LabelControl();
            this.labelSelectOptions = new DevExpress.XtraEditors.LabelControl();
            this.cbDuration3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbDuration2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbDuration1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinBreaks1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinBreaks2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinBreaks3 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControlBreakType = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDuration = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBreaksPerDay = new DevExpress.XtraEditors.LabelControl();
            this.cbDuration4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinBreaks4 = new DevExpress.XtraEditors.SpinEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.txtBreakType1 = new DevExpress.XtraEditors.TextEdit();
            this.txtBreakType2 = new DevExpress.XtraEditors.TextEdit();
            this.txtBreakType4 = new DevExpress.XtraEditors.TextEdit();
            this.txtBreakType3 = new DevExpress.XtraEditors.TextEdit();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblWorkHrs = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.timeEditStart = new DevExpress.XtraEditors.TimeEdit();
            this.timeEditEnd = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Caramel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(252, 448);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.Location = new System.Drawing.Point(84, 21);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(520, 19);
            this.labelInstruction.TabIndex = 2;
            this.labelInstruction.Text = "Health Break will smartly schedule your break reminders in your Calendar";
            // 
            // labelSelectOptions
            // 
            this.labelSelectOptions.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectOptions.Location = new System.Drawing.Point(16, 62);
            this.labelSelectOptions.Name = "labelSelectOptions";
            this.labelSelectOptions.Size = new System.Drawing.Size(222, 19);
            this.labelSelectOptions.TabIndex = 3;
            this.labelSelectOptions.Text = "Please personalize your options";
            // 
            // cbDuration3
            // 
            this.cbDuration3.EditValue = "5 mins";
            this.cbDuration3.Location = new System.Drawing.Point(301, 317);
            this.cbDuration3.Name = "cbDuration3";
            this.cbDuration3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration3.Properties.Appearance.Options.UseFont = true;
            this.cbDuration3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDuration3.Properties.Items.AddRange(new object[] {
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins"});
            this.cbDuration3.Size = new System.Drawing.Size(100, 22);
            this.cbDuration3.TabIndex = 13;
            // 
            // cbDuration2
            // 
            this.cbDuration2.EditValue = "1 min";
            this.cbDuration2.Location = new System.Drawing.Point(301, 273);
            this.cbDuration2.Name = "cbDuration2";
            this.cbDuration2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration2.Properties.Appearance.Options.UseFont = true;
            this.cbDuration2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDuration2.Properties.Items.AddRange(new object[] {
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins"});
            this.cbDuration2.Size = new System.Drawing.Size(100, 22);
            this.cbDuration2.TabIndex = 12;
            // 
            // cbDuration1
            // 
            this.cbDuration1.EditValue = "15 mins";
            this.cbDuration1.Location = new System.Drawing.Point(301, 231);
            this.cbDuration1.Name = "cbDuration1";
            this.cbDuration1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration1.Properties.Appearance.Options.UseFont = true;
            this.cbDuration1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDuration1.Properties.Items.AddRange(new object[] {
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins"});
            this.cbDuration1.Size = new System.Drawing.Size(100, 22);
            this.cbDuration1.TabIndex = 11;
            // 
            // spinBreaks1
            // 
            this.spinBreaks1.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinBreaks1.Location = new System.Drawing.Point(457, 231);
            this.spinBreaks1.Name = "spinBreaks1";
            this.spinBreaks1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBreaks1.Properties.Appearance.Options.UseFont = true;
            this.spinBreaks1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinBreaks1.Size = new System.Drawing.Size(67, 22);
            this.spinBreaks1.TabIndex = 14;
            // 
            // spinBreaks2
            // 
            this.spinBreaks2.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinBreaks2.Location = new System.Drawing.Point(457, 273);
            this.spinBreaks2.Name = "spinBreaks2";
            this.spinBreaks2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBreaks2.Properties.Appearance.Options.UseFont = true;
            this.spinBreaks2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinBreaks2.Size = new System.Drawing.Size(67, 22);
            this.spinBreaks2.TabIndex = 15;
            // 
            // spinBreaks3
            // 
            this.spinBreaks3.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinBreaks3.Location = new System.Drawing.Point(457, 317);
            this.spinBreaks3.Name = "spinBreaks3";
            this.spinBreaks3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBreaks3.Properties.Appearance.Options.UseFont = true;
            this.spinBreaks3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinBreaks3.Size = new System.Drawing.Size(67, 22);
            this.spinBreaks3.TabIndex = 16;
            // 
            // labelControlBreakType
            // 
            this.labelControlBreakType.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBreakType.Location = new System.Drawing.Point(161, 194);
            this.labelControlBreakType.Name = "labelControlBreakType";
            this.labelControlBreakType.Size = new System.Drawing.Size(79, 19);
            this.labelControlBreakType.TabIndex = 17;
            this.labelControlBreakType.Text = "Break Type";
            // 
            // labelControlDuration
            // 
            this.labelControlDuration.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlDuration.Location = new System.Drawing.Point(314, 194);
            this.labelControlDuration.Name = "labelControlDuration";
            this.labelControlDuration.Size = new System.Drawing.Size(61, 19);
            this.labelControlDuration.TabIndex = 18;
            this.labelControlDuration.Text = "Duration";
            // 
            // labelControlBreaksPerDay
            // 
            this.labelControlBreaksPerDay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBreaksPerDay.Location = new System.Drawing.Point(457, 194);
            this.labelControlBreaksPerDay.Name = "labelControlBreaksPerDay";
            this.labelControlBreaksPerDay.Size = new System.Drawing.Size(73, 19);
            this.labelControlBreaksPerDay.TabIndex = 19;
            this.labelControlBreaksPerDay.Text = "Occurance";
            // 
            // cbDuration4
            // 
            this.cbDuration4.EditValue = "5 mins";
            this.cbDuration4.Enabled = false;
            this.cbDuration4.Location = new System.Drawing.Point(301, 365);
            this.cbDuration4.Name = "cbDuration4";
            this.cbDuration4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration4.Properties.Appearance.Options.UseFont = true;
            this.cbDuration4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDuration4.Properties.Items.AddRange(new object[] {
            "1 min",
            "5 mins",
            "10 mins",
            "15 mins"});
            this.cbDuration4.Size = new System.Drawing.Size(100, 22);
            this.cbDuration4.TabIndex = 21;
            // 
            // spinBreaks4
            // 
            this.spinBreaks4.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinBreaks4.Enabled = false;
            this.spinBreaks4.Location = new System.Drawing.Point(457, 365);
            this.spinBreaks4.Name = "spinBreaks4";
            this.spinBreaks4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBreaks4.Properties.Appearance.Options.UseFont = true;
            this.spinBreaks4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinBreaks4.Size = new System.Drawing.Size(67, 22);
            this.spinBreaks4.TabIndex = 22;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(99, 233);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(17, 19);
            this.checkEdit1.TabIndex = 23;
            this.checkEdit1.Tag = "1";
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(99, 275);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Size = new System.Drawing.Size(17, 19);
            this.checkEdit2.TabIndex = 24;
            this.checkEdit2.Tag = "2";
            // 
            // checkEdit3
            // 
            this.checkEdit3.EditValue = true;
            this.checkEdit3.Location = new System.Drawing.Point(99, 317);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "";
            this.checkEdit3.Size = new System.Drawing.Size(17, 19);
            this.checkEdit3.TabIndex = 25;
            this.checkEdit3.Tag = "3";
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(99, 367);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "";
            this.checkEdit4.Size = new System.Drawing.Size(17, 19);
            this.checkEdit4.TabIndex = 26;
            this.checkEdit4.Tag = "4";
            // 
            // txtBreakType1
            // 
            this.txtBreakType1.EditValue = "Walking";
            this.txtBreakType1.Location = new System.Drawing.Point(151, 233);
            this.txtBreakType1.Name = "txtBreakType1";
            this.txtBreakType1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakType1.Properties.Appearance.Options.UseFont = true;
            this.txtBreakType1.Size = new System.Drawing.Size(100, 22);
            this.txtBreakType1.TabIndex = 31;
            // 
            // txtBreakType2
            // 
            this.txtBreakType2.EditValue = "Drinking Water";
            this.txtBreakType2.Location = new System.Drawing.Point(151, 273);
            this.txtBreakType2.Name = "txtBreakType2";
            this.txtBreakType2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakType2.Properties.Appearance.Options.UseFont = true;
            this.txtBreakType2.Size = new System.Drawing.Size(100, 22);
            this.txtBreakType2.TabIndex = 32;
            // 
            // txtBreakType4
            // 
            this.txtBreakType4.EditValue = "Other";
            this.txtBreakType4.Enabled = false;
            this.txtBreakType4.Location = new System.Drawing.Point(151, 364);
            this.txtBreakType4.Name = "txtBreakType4";
            this.txtBreakType4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakType4.Properties.Appearance.Options.UseFont = true;
            this.txtBreakType4.Size = new System.Drawing.Size(100, 22);
            this.txtBreakType4.TabIndex = 34;
            // 
            // txtBreakType3
            // 
            this.txtBreakType3.EditValue = "Stretching";
            this.txtBreakType3.Location = new System.Drawing.Point(151, 317);
            this.txtBreakType3.Name = "txtBreakType3";
            this.txtBreakType3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakType3.Properties.Appearance.Options.UseFont = true;
            this.txtBreakType3.Size = new System.Drawing.Size(100, 22);
            this.txtBreakType3.TabIndex = 33;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // lblWorkHrs
            // 
            this.lblWorkHrs.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkHrs.Location = new System.Drawing.Point(112, 131);
            this.lblWorkHrs.Name = "lblWorkHrs";
            this.lblWorkHrs.Size = new System.Drawing.Size(82, 19);
            this.lblWorkHrs.TabIndex = 35;
            this.lblWorkHrs.Text = "Work hours";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(262, 105);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(61, 16);
            this.lblStart.TabIndex = 38;
            this.lblStart.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(419, 106);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(54, 16);
            this.lblEndTime.TabIndex = 39;
            this.lblEndTime.Text = "End Time";
            // 
            // timeEditStart
            // 
            this.timeEditStart.EditValue = new System.DateTime(2014, 12, 6, 8, 0, 0, 0);
            this.timeEditStart.Location = new System.Drawing.Point(242, 133);
            this.timeEditStart.Name = "timeEditStart";
            this.timeEditStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEditStart.Properties.Appearance.Options.UseFont = true;
            this.timeEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditStart.Size = new System.Drawing.Size(100, 22);
            this.timeEditStart.TabIndex = 40;
            // 
            // timeEditEnd
            // 
            this.timeEditEnd.EditValue = new System.DateTime(2014, 12, 6, 17, 0, 0, 0);
            this.timeEditEnd.Location = new System.Drawing.Point(404, 133);
            this.timeEditEnd.Name = "timeEditEnd";
            this.timeEditEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEditEnd.Properties.Appearance.Options.UseFont = true;
            this.timeEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditEnd.Size = new System.Drawing.Size(100, 22);
            this.timeEditEnd.TabIndex = 41;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 516);
            this.ControlBox = false;
            this.Controls.Add(this.timeEditEnd);
            this.Controls.Add(this.timeEditStart);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblWorkHrs);
            this.Controls.Add(this.txtBreakType4);
            this.Controls.Add(this.txtBreakType3);
            this.Controls.Add(this.txtBreakType2);
            this.Controls.Add(this.txtBreakType1);
            this.Controls.Add(this.checkEdit4);
            this.Controls.Add(this.checkEdit3);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.spinBreaks4);
            this.Controls.Add(this.cbDuration4);
            this.Controls.Add(this.labelControlBreaksPerDay);
            this.Controls.Add(this.labelControlDuration);
            this.Controls.Add(this.labelControlBreakType);
            this.Controls.Add(this.spinBreaks3);
            this.Controls.Add(this.spinBreaks2);
            this.Controls.Add(this.spinBreaks1);
            this.Controls.Add(this.cbDuration3);
            this.Controls.Add(this.cbDuration2);
            this.Controls.Add(this.cbDuration1);
            this.Controls.Add(this.labelSelectOptions);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Health Break - Your Smart Office Break Reminder";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDuration4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBreaks4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreakType3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditEnd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelInstruction;
        private DevExpress.XtraEditors.LabelControl labelSelectOptions;
        private DevExpress.XtraEditors.ComboBoxEdit cbDuration3;
        private DevExpress.XtraEditors.ComboBoxEdit cbDuration2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDuration1;
        private DevExpress.XtraEditors.SpinEdit spinBreaks1;
        private DevExpress.XtraEditors.SpinEdit spinBreaks2;
        private DevExpress.XtraEditors.SpinEdit spinBreaks3;
        private DevExpress.XtraEditors.LabelControl labelControlBreakType;
        private DevExpress.XtraEditors.LabelControl labelControlDuration;
        private DevExpress.XtraEditors.LabelControl labelControlBreaksPerDay;
        private DevExpress.XtraEditors.ComboBoxEdit cbDuration4;
        private DevExpress.XtraEditors.SpinEdit spinBreaks4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.TextEdit txtBreakType1;
        private DevExpress.XtraEditors.TextEdit txtBreakType2;
        private DevExpress.XtraEditors.TextEdit txtBreakType4;
        private DevExpress.XtraEditors.TextEdit txtBreakType3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraEditors.LabelControl lblWorkHrs;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.LabelControl lblEndTime;
        private DevExpress.XtraEditors.TimeEdit timeEditStart;
        private DevExpress.XtraEditors.TimeEdit timeEditEnd;

    }
}

