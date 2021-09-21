﻿
namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_open = new System.Windows.Forms.Button();
            this.groupBox_connect = new System.Windows.Forms.GroupBox();
            this.button_connection_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_shift = new System.Windows.Forms.Button();
            this.btn_ctrl = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_space = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_W = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.groupBox_control = new System.Windows.Forms.GroupBox();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_Z = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Q = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar_rotateArm = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_rotateArm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_cargo = new System.Windows.Forms.TextBox();
            this.trackBar_cargo = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_hand = new System.Windows.Forms.TextBox();
            this.textBox_3rdArm = new System.Windows.Forms.TextBox();
            this.textBox_2ndArm = new System.Windows.Forms.TextBox();
            this.textBox_1stArm = new System.Windows.Forms.TextBox();
            this.trackBar_3rdArm = new System.Windows.Forms.TrackBar();
            this.trackBar_2ndArm = new System.Windows.Forms.TrackBar();
            this.trackBar_1stArm = new System.Windows.Forms.TrackBar();
            this.trackBar_hand = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.glControl_sideView = new OpenTK.GLControl();
            this.glControl_topView = new OpenTK.GLControl();
            this.Sensor_right_behind = new System.Windows.Forms.Button();
            this.Sensor_left_behind = new System.Windows.Forms.Button();
            this.Sensor_left_front = new System.Windows.Forms.Button();
            this.Sensor_right_front = new System.Windows.Forms.Button();
            this.Sensor_left = new System.Windows.Forms.Button();
            this.Sensor_right = new System.Windows.Forms.Button();
            this.btn_ResetArm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_choseSaveFile = new System.Windows.Forms.Button();
            this.textBox_createFileName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_saveData = new System.Windows.Forms.Button();
            this.btn_delData = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_data_num = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Example_Red = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.Example_Green = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.listView_ActionList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ActionList_play = new System.Windows.Forms.Button();
            this.btn_ActionList_refresh = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btn_chooseActionListFolder = new System.Windows.Forms.Button();
            this.textBox_ActionListFolder = new System.Windows.Forms.TextBox();
            this.groupBox_connect.SuspendLayout();
            this.groupBox_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rotateArm)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_3rdArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_2ndArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_1stArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hand)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(32, 211);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(139, 81);
            this.btn_open.TabIndex = 5;
            this.btn_open.TabStop = false;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // groupBox_connect
            // 
            this.groupBox_connect.Controls.Add(this.button_connection_refresh);
            this.groupBox_connect.Controls.Add(this.label1);
            this.groupBox_connect.Controls.Add(this.comboBox_port);
            this.groupBox_connect.Controls.Add(this.btn_close);
            this.groupBox_connect.Controls.Add(this.btn_open);
            this.groupBox_connect.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_connect.Location = new System.Drawing.Point(44, 52);
            this.groupBox_connect.Name = "groupBox_connect";
            this.groupBox_connect.Size = new System.Drawing.Size(567, 322);
            this.groupBox_connect.TabIndex = 6;
            this.groupBox_connect.TabStop = false;
            this.groupBox_connect.Text = "Bluetooth Connection";
            // 
            // button_connection_refresh
            // 
            this.button_connection_refresh.Location = new System.Drawing.Point(372, 211);
            this.button_connection_refresh.Name = "button_connection_refresh";
            this.button_connection_refresh.Size = new System.Drawing.Size(164, 81);
            this.button_connection_refresh.TabIndex = 9;
            this.button_connection_refresh.TabStop = false;
            this.button_connection_refresh.Text = "Refresh";
            this.button_connection_refresh.UseVisualStyleBackColor = true;
            this.button_connection_refresh.Click += new System.EventHandler(this.button_connection_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM port";
            // 
            // comboBox_port
            // 
            this.comboBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_port.Location = new System.Drawing.Point(32, 127);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(504, 46);
            this.comboBox_port.Sorted = true;
            this.comboBox_port.TabIndex = 7;
            this.comboBox_port.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(202, 211);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(139, 81);
            this.btn_close.TabIndex = 6;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_shift
            // 
            this.btn_shift.BackColor = System.Drawing.Color.Black;
            this.btn_shift.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shift.ForeColor = System.Drawing.Color.White;
            this.btn_shift.Location = new System.Drawing.Point(962, 169);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(327, 90);
            this.btn_shift.TabIndex = 30;
            this.btn_shift.TabStop = false;
            this.btn_shift.Text = "shift";
            this.btn_shift.UseVisualStyleBackColor = false;
            // 
            // btn_ctrl
            // 
            this.btn_ctrl.BackColor = System.Drawing.Color.Black;
            this.btn_ctrl.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ctrl.ForeColor = System.Drawing.Color.White;
            this.btn_ctrl.Location = new System.Drawing.Point(777, 280);
            this.btn_ctrl.Name = "btn_ctrl";
            this.btn_ctrl.Size = new System.Drawing.Size(141, 116);
            this.btn_ctrl.TabIndex = 29;
            this.btn_ctrl.TabStop = false;
            this.btn_ctrl.Text = "ctrl";
            this.btn_ctrl.UseVisualStyleBackColor = false;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.Black;
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(962, 46);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(327, 90);
            this.btn_enter.TabIndex = 28;
            this.btn_enter.TabStop = false;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Black;
            this.btn_down.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_down.ForeColor = System.Drawing.Color.White;
            this.btn_down.Location = new System.Drawing.Point(1080, 341);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(97, 55);
            this.btn_down.TabIndex = 27;
            this.btn_down.TabStop = false;
            this.btn_down.Text = "↓";
            this.btn_down.UseVisualStyleBackColor = false;
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Black;
            this.btn_up.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_up.ForeColor = System.Drawing.Color.White;
            this.btn_up.Location = new System.Drawing.Point(1080, 280);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(97, 55);
            this.btn_up.TabIndex = 26;
            this.btn_up.TabStop = false;
            this.btn_up.Text = "↑";
            this.btn_up.UseVisualStyleBackColor = false;
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.Black;
            this.btn_left.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left.ForeColor = System.Drawing.Color.White;
            this.btn_left.Location = new System.Drawing.Point(962, 280);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(97, 116);
            this.btn_left.TabIndex = 25;
            this.btn_left.TabStop = false;
            this.btn_left.Text = "←";
            this.btn_left.UseVisualStyleBackColor = false;
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.Black;
            this.btn_right.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right.ForeColor = System.Drawing.Color.White;
            this.btn_right.Location = new System.Drawing.Point(1192, 280);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(97, 116);
            this.btn_right.TabIndex = 24;
            this.btn_right.TabStop = false;
            this.btn_right.Text = "→";
            this.btn_right.UseVisualStyleBackColor = false;
            // 
            // btn_space
            // 
            this.btn_space.BackColor = System.Drawing.Color.Black;
            this.btn_space.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_space.ForeColor = System.Drawing.Color.White;
            this.btn_space.Location = new System.Drawing.Point(430, 306);
            this.btn_space.Name = "btn_space";
            this.btn_space.Size = new System.Drawing.Size(318, 90);
            this.btn_space.TabIndex = 23;
            this.btn_space.TabStop = false;
            this.btn_space.Text = "︺";
            this.btn_space.UseVisualStyleBackColor = false;
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.Black;
            this.btn_A.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_A.ForeColor = System.Drawing.Color.White;
            this.btn_A.Location = new System.Drawing.Point(46, 190);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(97, 90);
            this.btn_A.TabIndex = 20;
            this.btn_A.TabStop = false;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            // 
            // btn_W
            // 
            this.btn_W.BackColor = System.Drawing.Color.Black;
            this.btn_W.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_W.ForeColor = System.Drawing.Color.White;
            this.btn_W.Location = new System.Drawing.Point(167, 77);
            this.btn_W.Name = "btn_W";
            this.btn_W.Size = new System.Drawing.Size(97, 90);
            this.btn_W.TabIndex = 19;
            this.btn_W.TabStop = false;
            this.btn_W.Text = "W";
            this.btn_W.UseVisualStyleBackColor = false;
            // 
            // btn_S
            // 
            this.btn_S.BackColor = System.Drawing.Color.Black;
            this.btn_S.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_S.ForeColor = System.Drawing.Color.White;
            this.btn_S.Location = new System.Drawing.Point(167, 190);
            this.btn_S.Name = "btn_S";
            this.btn_S.Size = new System.Drawing.Size(97, 90);
            this.btn_S.TabIndex = 21;
            this.btn_S.TabStop = false;
            this.btn_S.Text = "S";
            this.btn_S.UseVisualStyleBackColor = false;
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.Black;
            this.btn_D.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_D.ForeColor = System.Drawing.Color.White;
            this.btn_D.Location = new System.Drawing.Point(289, 190);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(97, 90);
            this.btn_D.TabIndex = 22;
            this.btn_D.TabStop = false;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            // 
            // groupBox_control
            // 
            this.groupBox_control.Controls.Add(this.btn_R);
            this.groupBox_control.Controls.Add(this.btn_Z);
            this.groupBox_control.Controls.Add(this.btn_C);
            this.groupBox_control.Controls.Add(this.btn_Q);
            this.groupBox_control.Controls.Add(this.btn_E);
            this.groupBox_control.Controls.Add(this.btn_shift);
            this.groupBox_control.Controls.Add(this.btn_right);
            this.groupBox_control.Controls.Add(this.btn_ctrl);
            this.groupBox_control.Controls.Add(this.btn_D);
            this.groupBox_control.Controls.Add(this.btn_enter);
            this.groupBox_control.Controls.Add(this.btn_S);
            this.groupBox_control.Controls.Add(this.btn_down);
            this.groupBox_control.Controls.Add(this.btn_W);
            this.groupBox_control.Controls.Add(this.btn_up);
            this.groupBox_control.Controls.Add(this.btn_A);
            this.groupBox_control.Controls.Add(this.btn_left);
            this.groupBox_control.Controls.Add(this.btn_space);
            this.groupBox_control.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_control.Location = new System.Drawing.Point(44, 1258);
            this.groupBox_control.Name = "groupBox_control";
            this.groupBox_control.Size = new System.Drawing.Size(1311, 428);
            this.groupBox_control.TabIndex = 31;
            this.groupBox_control.TabStop = false;
            this.groupBox_control.Text = "Keyboard";
            // 
            // btn_R
            // 
            this.btn_R.BackColor = System.Drawing.Color.Black;
            this.btn_R.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_R.ForeColor = System.Drawing.Color.White;
            this.btn_R.Location = new System.Drawing.Point(430, 77);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(97, 90);
            this.btn_R.TabIndex = 36;
            this.btn_R.TabStop = false;
            this.btn_R.Text = "R";
            this.btn_R.UseVisualStyleBackColor = false;
            // 
            // btn_Z
            // 
            this.btn_Z.BackColor = System.Drawing.Color.Black;
            this.btn_Z.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Z.ForeColor = System.Drawing.Color.White;
            this.btn_Z.Location = new System.Drawing.Point(46, 306);
            this.btn_Z.Name = "btn_Z";
            this.btn_Z.Size = new System.Drawing.Size(97, 90);
            this.btn_Z.TabIndex = 35;
            this.btn_Z.TabStop = false;
            this.btn_Z.Text = "Z";
            this.btn_Z.UseVisualStyleBackColor = false;
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Black;
            this.btn_C.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_C.ForeColor = System.Drawing.Color.White;
            this.btn_C.Location = new System.Drawing.Point(289, 306);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(97, 90);
            this.btn_C.TabIndex = 34;
            this.btn_C.TabStop = false;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            // 
            // btn_Q
            // 
            this.btn_Q.BackColor = System.Drawing.Color.Black;
            this.btn_Q.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Q.ForeColor = System.Drawing.Color.White;
            this.btn_Q.Location = new System.Drawing.Point(46, 77);
            this.btn_Q.Name = "btn_Q";
            this.btn_Q.Size = new System.Drawing.Size(97, 90);
            this.btn_Q.TabIndex = 32;
            this.btn_Q.TabStop = false;
            this.btn_Q.Text = "Q";
            this.btn_Q.UseVisualStyleBackColor = false;
            // 
            // btn_E
            // 
            this.btn_E.BackColor = System.Drawing.Color.Black;
            this.btn_E.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_E.ForeColor = System.Drawing.Color.White;
            this.btn_E.Location = new System.Drawing.Point(289, 77);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(97, 90);
            this.btn_E.TabIndex = 31;
            this.btn_E.TabStop = false;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar_rotateArm
            // 
            this.trackBar_rotateArm.AutoSize = false;
            this.trackBar_rotateArm.Location = new System.Drawing.Point(200, 173);
            this.trackBar_rotateArm.Maximum = 90;
            this.trackBar_rotateArm.Minimum = -90;
            this.trackBar_rotateArm.Name = "trackBar_rotateArm";
            this.trackBar_rotateArm.Size = new System.Drawing.Size(487, 60);
            this.trackBar_rotateArm.TabIndex = 32;
            this.trackBar_rotateArm.TabStop = false;
            this.trackBar_rotateArm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_rotateArm.Scroll += new System.EventHandler(this.trackBar_rotateArm_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "rotate arm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(55, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "1st arm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 38);
            this.label4.TabIndex = 35;
            this.label4.Text = "2nd arm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "3rd arm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(89, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "hand";
            // 
            // textBox_rotateArm
            // 
            this.textBox_rotateArm.Location = new System.Drawing.Point(719, 179);
            this.textBox_rotateArm.Name = "textBox_rotateArm";
            this.textBox_rotateArm.ReadOnly = true;
            this.textBox_rotateArm.Size = new System.Drawing.Size(80, 47);
            this.textBox_rotateArm.TabIndex = 38;
            this.textBox_rotateArm.TabStop = false;
            this.textBox_rotateArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_cargo);
            this.groupBox1.Controls.Add(this.trackBar_cargo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_hand);
            this.groupBox1.Controls.Add(this.textBox_3rdArm);
            this.groupBox1.Controls.Add(this.textBox_2ndArm);
            this.groupBox1.Controls.Add(this.textBox_1stArm);
            this.groupBox1.Controls.Add(this.trackBar_3rdArm);
            this.groupBox1.Controls.Add(this.trackBar_2ndArm);
            this.groupBox1.Controls.Add(this.trackBar_1stArm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_rotateArm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar_rotateArm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBar_hand);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(646, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 712);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arm Control";
            // 
            // textBox_cargo
            // 
            this.textBox_cargo.Location = new System.Drawing.Point(719, 70);
            this.textBox_cargo.Name = "textBox_cargo";
            this.textBox_cargo.ReadOnly = true;
            this.textBox_cargo.Size = new System.Drawing.Size(80, 47);
            this.textBox_cargo.TabIndex = 49;
            this.textBox_cargo.TabStop = false;
            this.textBox_cargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBar_cargo
            // 
            this.trackBar_cargo.AutoSize = false;
            this.trackBar_cargo.Location = new System.Drawing.Point(200, 63);
            this.trackBar_cargo.Maximum = 0;
            this.trackBar_cargo.Minimum = -60;
            this.trackBar_cargo.Name = "trackBar_cargo";
            this.trackBar_cargo.Size = new System.Drawing.Size(487, 60);
            this.trackBar_cargo.TabIndex = 48;
            this.trackBar_cargo.TabStop = false;
            this.trackBar_cargo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_cargo.Scroll += new System.EventHandler(this.trackBar_cargo_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(80, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 38);
            this.label7.TabIndex = 47;
            this.label7.Text = "cargo";
            // 
            // textBox_hand
            // 
            this.textBox_hand.Location = new System.Drawing.Point(719, 622);
            this.textBox_hand.Name = "textBox_hand";
            this.textBox_hand.ReadOnly = true;
            this.textBox_hand.Size = new System.Drawing.Size(80, 47);
            this.textBox_hand.TabIndex = 46;
            this.textBox_hand.TabStop = false;
            this.textBox_hand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_3rdArm
            // 
            this.textBox_3rdArm.Location = new System.Drawing.Point(719, 506);
            this.textBox_3rdArm.Name = "textBox_3rdArm";
            this.textBox_3rdArm.ReadOnly = true;
            this.textBox_3rdArm.Size = new System.Drawing.Size(80, 47);
            this.textBox_3rdArm.TabIndex = 45;
            this.textBox_3rdArm.TabStop = false;
            this.textBox_3rdArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_2ndArm
            // 
            this.textBox_2ndArm.Location = new System.Drawing.Point(719, 393);
            this.textBox_2ndArm.Name = "textBox_2ndArm";
            this.textBox_2ndArm.ReadOnly = true;
            this.textBox_2ndArm.Size = new System.Drawing.Size(80, 47);
            this.textBox_2ndArm.TabIndex = 44;
            this.textBox_2ndArm.TabStop = false;
            this.textBox_2ndArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_1stArm
            // 
            this.textBox_1stArm.Location = new System.Drawing.Point(719, 290);
            this.textBox_1stArm.Name = "textBox_1stArm";
            this.textBox_1stArm.ReadOnly = true;
            this.textBox_1stArm.Size = new System.Drawing.Size(80, 47);
            this.textBox_1stArm.TabIndex = 43;
            this.textBox_1stArm.TabStop = false;
            this.textBox_1stArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBar_3rdArm
            // 
            this.trackBar_3rdArm.AutoSize = false;
            this.trackBar_3rdArm.Location = new System.Drawing.Point(200, 503);
            this.trackBar_3rdArm.Maximum = 55;
            this.trackBar_3rdArm.Minimum = -60;
            this.trackBar_3rdArm.Name = "trackBar_3rdArm";
            this.trackBar_3rdArm.Size = new System.Drawing.Size(487, 60);
            this.trackBar_3rdArm.TabIndex = 41;
            this.trackBar_3rdArm.TabStop = false;
            this.trackBar_3rdArm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_3rdArm.Scroll += new System.EventHandler(this.trackBar_3rdArm_Scroll);
            // 
            // trackBar_2ndArm
            // 
            this.trackBar_2ndArm.AutoSize = false;
            this.trackBar_2ndArm.Location = new System.Drawing.Point(200, 393);
            this.trackBar_2ndArm.Maximum = 60;
            this.trackBar_2ndArm.Name = "trackBar_2ndArm";
            this.trackBar_2ndArm.Size = new System.Drawing.Size(487, 60);
            this.trackBar_2ndArm.TabIndex = 40;
            this.trackBar_2ndArm.TabStop = false;
            this.trackBar_2ndArm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_2ndArm.Scroll += new System.EventHandler(this.trackBar_2ndArm_Scroll);
            // 
            // trackBar_1stArm
            // 
            this.trackBar_1stArm.AutoSize = false;
            this.trackBar_1stArm.Location = new System.Drawing.Point(200, 283);
            this.trackBar_1stArm.Maximum = 55;
            this.trackBar_1stArm.Minimum = -90;
            this.trackBar_1stArm.Name = "trackBar_1stArm";
            this.trackBar_1stArm.Size = new System.Drawing.Size(487, 60);
            this.trackBar_1stArm.TabIndex = 39;
            this.trackBar_1stArm.TabStop = false;
            this.trackBar_1stArm.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_1stArm.Scroll += new System.EventHandler(this.trackBar_1stArm_Scroll);
            // 
            // trackBar_hand
            // 
            this.trackBar_hand.AutoSize = false;
            this.trackBar_hand.Location = new System.Drawing.Point(200, 613);
            this.trackBar_hand.Maximum = 60;
            this.trackBar_hand.Name = "trackBar_hand";
            this.trackBar_hand.Size = new System.Drawing.Size(487, 60);
            this.trackBar_hand.TabIndex = 42;
            this.trackBar_hand.TabStop = false;
            this.trackBar_hand.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_hand.Scroll += new System.EventHandler(this.trackBar_hand_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.glControl_sideView);
            this.groupBox2.Controls.Add(this.glControl_topView);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(1510, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1862, 712);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graphic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(988, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 38);
            this.label9.TabIndex = 45;
            this.label9.Text = "Top View";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(66, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 38);
            this.label8.TabIndex = 44;
            this.label8.Text = "Side View";
            // 
            // glControl_sideView
            // 
            this.glControl_sideView.BackColor = System.Drawing.Color.Black;
            this.glControl_sideView.Location = new System.Drawing.Point(41, 51);
            this.glControl_sideView.Margin = new System.Windows.Forms.Padding(9);
            this.glControl_sideView.Name = "glControl_sideView";
            this.glControl_sideView.Size = new System.Drawing.Size(877, 634);
            this.glControl_sideView.TabIndex = 42;
            this.glControl_sideView.VSync = false;
            this.glControl_sideView.Load += new System.EventHandler(this.glControl_sideView_Load);
            this.glControl_sideView.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_sideView_Paint);
            this.glControl_sideView.Resize += new System.EventHandler(this.glControl_sideView_Resize);
            // 
            // glControl_topView
            // 
            this.glControl_topView.BackColor = System.Drawing.Color.Black;
            this.glControl_topView.Location = new System.Drawing.Point(950, 51);
            this.glControl_topView.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.glControl_topView.Name = "glControl_topView";
            this.glControl_topView.Size = new System.Drawing.Size(877, 634);
            this.glControl_topView.TabIndex = 43;
            this.glControl_topView.VSync = false;
            this.glControl_topView.Load += new System.EventHandler(this.glControl_topView_Load);
            this.glControl_topView.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_topView_Paint);
            this.glControl_topView.Resize += new System.EventHandler(this.glControl_topView_Resize);
            // 
            // Sensor_right_behind
            // 
            this.Sensor_right_behind.BackColor = System.Drawing.Color.Green;
            this.Sensor_right_behind.Enabled = false;
            this.Sensor_right_behind.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_right_behind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_right_behind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sensor_right_behind.Location = new System.Drawing.Point(125, 179);
            this.Sensor_right_behind.Name = "Sensor_right_behind";
            this.Sensor_right_behind.Size = new System.Drawing.Size(69, 46);
            this.Sensor_right_behind.TabIndex = 6;
            this.Sensor_right_behind.UseVisualStyleBackColor = false;
            // 
            // Sensor_left_behind
            // 
            this.Sensor_left_behind.BackColor = System.Drawing.Color.Green;
            this.Sensor_left_behind.Enabled = false;
            this.Sensor_left_behind.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_left_behind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_left_behind.Location = new System.Drawing.Point(105, 179);
            this.Sensor_left_behind.Name = "Sensor_left_behind";
            this.Sensor_left_behind.Size = new System.Drawing.Size(69, 46);
            this.Sensor_left_behind.TabIndex = 5;
            this.Sensor_left_behind.UseVisualStyleBackColor = false;
            // 
            // Sensor_left_front
            // 
            this.Sensor_left_front.BackColor = System.Drawing.Color.Green;
            this.Sensor_left_front.Enabled = false;
            this.Sensor_left_front.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_left_front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_left_front.Location = new System.Drawing.Point(105, 183);
            this.Sensor_left_front.Name = "Sensor_left_front";
            this.Sensor_left_front.Size = new System.Drawing.Size(69, 46);
            this.Sensor_left_front.TabIndex = 4;
            this.Sensor_left_front.UseVisualStyleBackColor = false;
            // 
            // Sensor_right_front
            // 
            this.Sensor_right_front.BackColor = System.Drawing.Color.Green;
            this.Sensor_right_front.Enabled = false;
            this.Sensor_right_front.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_right_front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_right_front.Location = new System.Drawing.Point(125, 183);
            this.Sensor_right_front.Name = "Sensor_right_front";
            this.Sensor_right_front.Size = new System.Drawing.Size(69, 46);
            this.Sensor_right_front.TabIndex = 3;
            this.Sensor_right_front.UseVisualStyleBackColor = false;
            // 
            // Sensor_left
            // 
            this.Sensor_left.BackColor = System.Drawing.Color.Green;
            this.Sensor_left.Enabled = false;
            this.Sensor_left.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_left.Location = new System.Drawing.Point(105, 120);
            this.Sensor_left.Name = "Sensor_left";
            this.Sensor_left.Size = new System.Drawing.Size(69, 46);
            this.Sensor_left.TabIndex = 1;
            this.Sensor_left.UseVisualStyleBackColor = false;
            // 
            // Sensor_right
            // 
            this.Sensor_right.BackColor = System.Drawing.Color.Green;
            this.Sensor_right.Enabled = false;
            this.Sensor_right.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Sensor_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sensor_right.Location = new System.Drawing.Point(125, 110);
            this.Sensor_right.Name = "Sensor_right";
            this.Sensor_right.Size = new System.Drawing.Size(69, 46);
            this.Sensor_right.TabIndex = 2;
            this.Sensor_right.UseVisualStyleBackColor = false;
            // 
            // btn_ResetArm
            // 
            this.btn_ResetArm.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ResetArm.Location = new System.Drawing.Point(356, 397);
            this.btn_ResetArm.Name = "btn_ResetArm";
            this.btn_ResetArm.Size = new System.Drawing.Size(224, 81);
            this.btn_ResetArm.TabIndex = 10;
            this.btn_ResetArm.TabStop = false;
            this.btn_ResetArm.Text = "Reset Arm";
            this.btn_ResetArm.UseVisualStyleBackColor = true;
            this.btn_ResetArm.Click += new System.EventHandler(this.btn_ResetArm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(44, 802);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1803, 428);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save Data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_delete);
            this.groupBox6.Controls.Add(this.btn_Create);
            this.groupBox6.Controls.Add(this.btn_choseSaveFile);
            this.groupBox6.Controls.Add(this.textBox_createFileName);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(56, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(636, 359);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(34, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 99);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(34, 66);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(166, 99);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.TabStop = false;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_choseSaveFile
            // 
            this.btn_choseSaveFile.Location = new System.Drawing.Point(234, 212);
            this.btn_choseSaveFile.Name = "btn_choseSaveFile";
            this.btn_choseSaveFile.Size = new System.Drawing.Size(368, 99);
            this.btn_choseSaveFile.TabIndex = 0;
            this.btn_choseSaveFile.TabStop = false;
            this.btn_choseSaveFile.Text = "Choose";
            this.btn_choseSaveFile.UseVisualStyleBackColor = true;
            this.btn_choseSaveFile.Click += new System.EventHandler(this.btn_choseFile_Click);
            // 
            // textBox_createFileName
            // 
            this.textBox_createFileName.Location = new System.Drawing.Point(291, 123);
            this.textBox_createFileName.Name = "textBox_createFileName";
            this.textBox_createFileName.Size = new System.Drawing.Size(237, 47);
            this.textBox_createFileName.TabIndex = 8;
            this.textBox_createFileName.TabStop = false;
            this.textBox_createFileName.Leave += new System.EventHandler(this.textBox_createFileName_Leave);
            this.textBox_createFileName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_createFileName_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 38);
            this.label12.TabIndex = 10;
            this.label12.Text = ".csv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "FileName:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_saveData);
            this.groupBox5.Controls.Add(this.btn_delData);
            this.groupBox5.Location = new System.Drawing.Point(723, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 359);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "single Data";
            // 
            // btn_saveData
            // 
            this.btn_saveData.Location = new System.Drawing.Point(45, 88);
            this.btn_saveData.Name = "btn_saveData";
            this.btn_saveData.Size = new System.Drawing.Size(166, 99);
            this.btn_saveData.TabIndex = 2;
            this.btn_saveData.TabStop = false;
            this.btn_saveData.Text = "Save";
            this.btn_saveData.UseVisualStyleBackColor = true;
            this.btn_saveData.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delData
            // 
            this.btn_delData.Location = new System.Drawing.Point(45, 234);
            this.btn_delData.Name = "btn_delData";
            this.btn_delData.Size = new System.Drawing.Size(166, 99);
            this.btn_delData.TabIndex = 3;
            this.btn_delData.TabStop = false;
            this.btn_delData.Text = "Delete";
            this.btn_delData.UseVisualStyleBackColor = true;
            this.btn_delData.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_FileName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox_FilePath);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox_data_num);
            this.groupBox4.Location = new System.Drawing.Point(1016, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(757, 359);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File Info";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(218, 187);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.ReadOnly = true;
            this.textBox_FileName.Size = new System.Drawing.Size(512, 47);
            this.textBox_FileName.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 38);
            this.label14.TabIndex = 13;
            this.label14.Text = "File Path:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 38);
            this.label13.TabIndex = 11;
            this.label13.Text = "File Name:";
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(218, 54);
            this.textBox_FilePath.Multiline = true;
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FilePath.Size = new System.Drawing.Size(512, 98);
            this.textBox_FilePath.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 38);
            this.label10.TabIndex = 6;
            this.label10.Text = "Data_Num:";
            // 
            // textBox_data_num
            // 
            this.textBox_data_num.Location = new System.Drawing.Point(218, 275);
            this.textBox_data_num.Name = "textBox_data_num";
            this.textBox_data_num.ReadOnly = true;
            this.textBox_data_num.Size = new System.Drawing.Size(132, 47);
            this.textBox_data_num.TabIndex = 5;
            this.textBox_data_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Example_Red);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.Example_Green);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox7.Location = new System.Drawing.Point(2832, 802);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(540, 712);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sensor";
            // 
            // Example_Red
            // 
            this.Example_Red.BackColor = System.Drawing.Color.Red;
            this.Example_Red.Enabled = false;
            this.Example_Red.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Example_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Example_Red.Location = new System.Drawing.Point(409, 59);
            this.Example_Red.Name = "Example_Red";
            this.Example_Red.Size = new System.Drawing.Size(69, 46);
            this.Example_Red.TabIndex = 46;
            this.Example_Red.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(356, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 38);
            this.label25.TabIndex = 47;
            this.label25.Text = "有";
            // 
            // Example_Green
            // 
            this.Example_Green.BackColor = System.Drawing.Color.Green;
            this.Example_Green.Enabled = false;
            this.Example_Green.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Example_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Example_Green.Location = new System.Drawing.Point(136, 59);
            this.Example_Green.Name = "Example_Green";
            this.Example_Green.Size = new System.Drawing.Size(69, 46);
            this.Example_Green.TabIndex = 5;
            this.Example_Green.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(83, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 38);
            this.label24.TabIndex = 5;
            this.label24.Text = "無";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.Sensor_right_behind);
            this.groupBox11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox11.Location = new System.Drawing.Point(284, 416);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(209, 253);
            this.groupBox11.TabIndex = 45;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "右後";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(25, 191);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 38);
            this.label27.TabIndex = 7;
            this.label27.Text = "朝後";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 38);
            this.label28.TabIndex = 5;
            this.label28.Text = "朝地";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(25, 129);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 38);
            this.label29.TabIndex = 6;
            this.label29.Text = "朝左";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.Sensor_left_behind);
            this.groupBox10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox10.Location = new System.Drawing.Point(31, 416);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(209, 253);
            this.groupBox10.TabIndex = 45;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "左後";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 38);
            this.label21.TabIndex = 10;
            this.label21.Text = "朝後";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 38);
            this.label23.TabIndex = 8;
            this.label23.Text = "朝地";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 38);
            this.label22.TabIndex = 9;
            this.label22.Text = "朝左";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.Sensor_right_front);
            this.groupBox9.Controls.Add(this.Sensor_right);
            this.groupBox9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox9.Location = new System.Drawing.Point(284, 127);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(209, 253);
            this.groupBox9.TabIndex = 44;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "右前";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 38);
            this.label18.TabIndex = 7;
            this.label18.Text = "朝前";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 38);
            this.label20.TabIndex = 5;
            this.label20.Text = "朝地";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 38);
            this.label19.TabIndex = 6;
            this.label19.Text = "朝右";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Sensor_left_front);
            this.groupBox8.Controls.Add(this.Sensor_left);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox8.Location = new System.Drawing.Point(31, 127);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(209, 253);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "左前";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 38);
            this.label15.TabIndex = 0;
            this.label15.Text = "朝地";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "朝左";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 38);
            this.label17.TabIndex = 2;
            this.label17.Text = "朝前";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.listView_ActionList);
            this.groupBox12.Controls.Add(this.btn_ActionList_play);
            this.groupBox12.Controls.Add(this.btn_ActionList_refresh);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox12.Location = new System.Drawing.Point(1876, 802);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(928, 872);
            this.groupBox12.TabIndex = 43;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Action";
            // 
            // listView_ActionList
            // 
            this.listView_ActionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.listView_ActionList.HideSelection = false;
            this.listView_ActionList.Location = new System.Drawing.Point(48, 321);
            this.listView_ActionList.Name = "listView_ActionList";
            this.listView_ActionList.Size = new System.Drawing.Size(824, 349);
            this.listView_ActionList.TabIndex = 7;
            this.listView_ActionList.UseCompatibleStateImageBehavior = false;
            this.listView_ActionList.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "FileName";
            this.FileName.Width = 300;
            // 
            // btn_ActionList_play
            // 
            this.btn_ActionList_play.Location = new System.Drawing.Point(602, 719);
            this.btn_ActionList_play.Name = "btn_ActionList_play";
            this.btn_ActionList_play.Size = new System.Drawing.Size(164, 89);
            this.btn_ActionList_play.TabIndex = 6;
            this.btn_ActionList_play.Text = "Play";
            this.btn_ActionList_play.UseVisualStyleBackColor = true;
            this.btn_ActionList_play.Click += new System.EventHandler(this.btn_ActionList_play_Click);
            // 
            // btn_ActionList_refresh
            // 
            this.btn_ActionList_refresh.Location = new System.Drawing.Point(145, 736);
            this.btn_ActionList_refresh.Name = "btn_ActionList_refresh";
            this.btn_ActionList_refresh.Size = new System.Drawing.Size(164, 89);
            this.btn_ActionList_refresh.TabIndex = 5;
            this.btn_ActionList_refresh.Text = "Refresh";
            this.btn_ActionList_refresh.UseVisualStyleBackColor = true;
            this.btn_ActionList_refresh.Click += new System.EventHandler(this.btn_ActionList_refresh_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btn_chooseActionListFolder);
            this.groupBox14.Controls.Add(this.textBox_ActionListFolder);
            this.groupBox14.Location = new System.Drawing.Point(48, 74);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(824, 206);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Folder";
            // 
            // btn_chooseActionListFolder
            // 
            this.btn_chooseActionListFolder.Location = new System.Drawing.Point(31, 73);
            this.btn_chooseActionListFolder.Name = "btn_chooseActionListFolder";
            this.btn_chooseActionListFolder.Size = new System.Drawing.Size(158, 87);
            this.btn_chooseActionListFolder.TabIndex = 1;
            this.btn_chooseActionListFolder.Text = "Choose";
            this.btn_chooseActionListFolder.UseVisualStyleBackColor = true;
            this.btn_chooseActionListFolder.Click += new System.EventHandler(this.btn_chooseActionListFolder_Click);
            // 
            // textBox_ActionListFolder
            // 
            this.textBox_ActionListFolder.Location = new System.Drawing.Point(214, 73);
            this.textBox_ActionListFolder.Multiline = true;
            this.textBox_ActionListFolder.Name = "textBox_ActionListFolder";
            this.textBox_ActionListFolder.ReadOnly = true;
            this.textBox_ActionListFolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ActionListFolder.Size = new System.Drawing.Size(566, 86);
            this.textBox_ActionListFolder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3399, 1718);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_ResetArm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_connect);
            this.Controls.Add(this.groupBox_control);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "ControlPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox_connect.ResumeLayout(false);
            this.groupBox_connect.PerformLayout();
            this.groupBox_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rotateArm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_3rdArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_2ndArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_1stArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hand)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.GroupBox groupBox_connect;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_shift;
        private System.Windows.Forms.Button btn_ctrl;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_space;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_W;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.GroupBox groupBox_control;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_connection_refresh;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Z;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.TrackBar trackBar_rotateArm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_rotateArm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_hand;
        private System.Windows.Forms.TrackBar trackBar_3rdArm;
        private System.Windows.Forms.TrackBar trackBar_2ndArm;
        private System.Windows.Forms.TrackBar trackBar_1stArm;
        private System.Windows.Forms.TextBox textBox_hand;
        private System.Windows.Forms.TextBox textBox_3rdArm;
        private System.Windows.Forms.TextBox textBox_2ndArm;
        private System.Windows.Forms.TextBox textBox_1stArm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Sensor_right_behind;
        private System.Windows.Forms.Button Sensor_left_behind;
        private System.Windows.Forms.Button Sensor_left_front;
        private System.Windows.Forms.Button Sensor_right_front;
        private System.Windows.Forms.Button Sensor_right;
        private System.Windows.Forms.Button Sensor_left;
        private System.Windows.Forms.TrackBar trackBar_cargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cargo;
        private System.Windows.Forms.Button btn_ResetArm;
        private OpenTK.GLControl glControl_sideView;
        private OpenTK.GLControl glControl_topView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delData;
        private System.Windows.Forms.Button btn_saveData;
        private System.Windows.Forms.Button btn_choseSaveFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_data_num;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_createFileName;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button Example_Red;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button Example_Green;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btn_chooseActionListFolder;
        private System.Windows.Forms.TextBox textBox_ActionListFolder;
        private System.Windows.Forms.Button btn_ActionList_refresh;
        private System.Windows.Forms.Button btn_ActionList_play;
        private System.Windows.Forms.ListView listView_ActionList;
        private System.Windows.Forms.ColumnHeader FileName;
    }
}

