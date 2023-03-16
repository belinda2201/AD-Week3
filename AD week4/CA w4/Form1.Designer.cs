namespace CA_w4
{
    partial class formKerja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.radbtn_male = new System.Windows.Forms.RadioButton();
            this.radbtn_fem = new System.Windows.Forms.RadioButton();
            this.label_favColor = new System.Windows.Forms.Label();
            this.radbtn_pink = new System.Windows.Forms.RadioButton();
            this.radbtn_cyan = new System.Windows.Forms.RadioButton();
            this.radbtn_sageGreen = new System.Windows.Forms.RadioButton();
            this.label_hobby = new System.Windows.Forms.Label();
            this.cb_isi = new System.Windows.Forms.CheckBox();
            this.txt_isiHobi = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_WatchTV = new System.Windows.Forms.CheckBox();
            this.cb_reading = new System.Windows.Forms.CheckBox();
            this.cb_playSports = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(148, 163);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(97, 41);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(148, 246);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(71, 41);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "Age";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(148, 336);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(116, 41);
            this.label_gender.TabIndex = 2;
            this.label_gender.Text = "Gender";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(435, 166);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(926, 47);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(435, 246);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(926, 47);
            this.txt_age.TabIndex = 5;
            this.txt_age.TextChanged += new System.EventHandler(this.txt_age_TextChanged);
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // radbtn_male
            // 
            this.radbtn_male.AutoSize = true;
            this.radbtn_male.Location = new System.Drawing.Point(431, 339);
            this.radbtn_male.Name = "radbtn_male";
            this.radbtn_male.Size = new System.Drawing.Size(120, 45);
            this.radbtn_male.TabIndex = 6;
            this.radbtn_male.TabStop = true;
            this.radbtn_male.Text = "Male";
            this.radbtn_male.UseVisualStyleBackColor = true;
            // 
            // radbtn_fem
            // 
            this.radbtn_fem.AutoSize = true;
            this.radbtn_fem.Location = new System.Drawing.Point(715, 339);
            this.radbtn_fem.Name = "radbtn_fem";
            this.radbtn_fem.Size = new System.Drawing.Size(150, 45);
            this.radbtn_fem.TabIndex = 7;
            this.radbtn_fem.TabStop = true;
            this.radbtn_fem.Text = "Female";
            this.radbtn_fem.UseVisualStyleBackColor = true;
            // 
            // label_favColor
            // 
            this.label_favColor.AutoSize = true;
            this.label_favColor.Location = new System.Drawing.Point(148, 425);
            this.label_favColor.Name = "label_favColor";
            this.label_favColor.Size = new System.Drawing.Size(202, 41);
            this.label_favColor.TabIndex = 8;
            this.label_favColor.Text = "Favorite Color";
            // 
            // radbtn_pink
            // 
            this.radbtn_pink.AutoSize = true;
            this.radbtn_pink.Location = new System.Drawing.Point(25, 14);
            this.radbtn_pink.Name = "radbtn_pink";
            this.radbtn_pink.Size = new System.Drawing.Size(111, 45);
            this.radbtn_pink.TabIndex = 9;
            this.radbtn_pink.TabStop = true;
            this.radbtn_pink.Text = "Pink";
            this.radbtn_pink.UseVisualStyleBackColor = true;
            // 
            // radbtn_cyan
            // 
            this.radbtn_cyan.AutoSize = true;
            this.radbtn_cyan.Location = new System.Drawing.Point(313, 14);
            this.radbtn_cyan.Name = "radbtn_cyan";
            this.radbtn_cyan.Size = new System.Drawing.Size(121, 45);
            this.radbtn_cyan.TabIndex = 10;
            this.radbtn_cyan.TabStop = true;
            this.radbtn_cyan.Text = "Cyan";
            this.radbtn_cyan.UseVisualStyleBackColor = true;
            // 
            // radbtn_sageGreen
            // 
            this.radbtn_sageGreen.AutoSize = true;
            this.radbtn_sageGreen.Location = new System.Drawing.Point(606, 14);
            this.radbtn_sageGreen.Name = "radbtn_sageGreen";
            this.radbtn_sageGreen.Size = new System.Drawing.Size(208, 45);
            this.radbtn_sageGreen.TabIndex = 11;
            this.radbtn_sageGreen.TabStop = true;
            this.radbtn_sageGreen.Text = "Sage Green";
            this.radbtn_sageGreen.UseVisualStyleBackColor = true;
            // 
            // label_hobby
            // 
            this.label_hobby.AutoSize = true;
            this.label_hobby.Location = new System.Drawing.Point(148, 525);
            this.label_hobby.Name = "label_hobby";
            this.label_hobby.Size = new System.Drawing.Size(108, 41);
            this.label_hobby.TabIndex = 12;
            this.label_hobby.Text = "Hobby";
            // 
            // cb_isi
            // 
            this.cb_isi.AutoSize = true;
            this.cb_isi.Location = new System.Drawing.Point(434, 695);
            this.cb_isi.Name = "cb_isi";
            this.cb_isi.Size = new System.Drawing.Size(34, 33);
            this.cb_isi.TabIndex = 14;
            this.cb_isi.UseVisualStyleBackColor = true;
            this.cb_isi.CheckedChanged += new System.EventHandler(this.cb_isi_CheckedChanged);
            // 
            // txt_isiHobi
            // 
            this.txt_isiHobi.Location = new System.Drawing.Point(478, 692);
            this.txt_isiHobi.Name = "txt_isiHobi";
            this.txt_isiHobi.Size = new System.Drawing.Size(250, 47);
            this.txt_isiHobi.TabIndex = 15;
            this.txt_isiHobi.TextChanged += new System.EventHandler(this.txt_isiHobi_TextChanged);
            this.txt_isiHobi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_isiHobi_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(167, 812);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(188, 58);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(1000, 812);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(188, 58);
            this.btn_submit.TabIndex = 17;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_WatchTV
            // 
            this.cb_WatchTV.AutoSize = true;
            this.cb_WatchTV.Location = new System.Drawing.Point(435, 581);
            this.cb_WatchTV.Name = "cb_WatchTV";
            this.cb_WatchTV.Size = new System.Drawing.Size(225, 45);
            this.cb_WatchTV.TabIndex = 18;
            this.cb_WatchTV.Text = "Watching TV";
            this.cb_WatchTV.UseVisualStyleBackColor = true;
            // 
            // cb_reading
            // 
            this.cb_reading.AutoSize = true;
            this.cb_reading.Location = new System.Drawing.Point(435, 521);
            this.cb_reading.Name = "cb_reading";
            this.cb_reading.Size = new System.Drawing.Size(164, 45);
            this.cb_reading.TabIndex = 19;
            this.cb_reading.Text = "Reading";
            this.cb_reading.UseVisualStyleBackColor = true;
            // 
            // cb_playSports
            // 
            this.cb_playSports.AutoSize = true;
            this.cb_playSports.Location = new System.Drawing.Point(435, 632);
            this.cb_playSports.Name = "cb_playSports";
            this.cb_playSports.Size = new System.Drawing.Size(245, 45);
            this.cb_playSports.TabIndex = 20;
            this.cb_playSports.Text = "Playing Sports";
            this.cb_playSports.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(420, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 97);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radbtn_sageGreen);
            this.panel2.Controls.Add(this.radbtn_cyan);
            this.panel2.Controls.Add(this.radbtn_pink);
            this.panel2.Location = new System.Drawing.Point(404, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 79);
            this.panel2.TabIndex = 22;
            // 
            // formKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1114);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_playSports);
            this.Controls.Add(this.cb_reading);
            this.Controls.Add(this.cb_WatchTV);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_isiHobi);
            this.Controls.Add(this.cb_isi);
            this.Controls.Add(this.label_hobby);
            this.Controls.Add(this.label_favColor);
            this.Controls.Add(this.radbtn_fem);
            this.Controls.Add(this.radbtn_male);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.panel1);
            this.Name = "formKerja";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Label label_age;
        private Label label_gender;
        private TextBox txt_name;
        private TextBox txt_age;
        private RadioButton radbtn_male;
        private RadioButton radbtn_fem;
        private Label label_favColor;
        private RadioButton radbtn_pink;
        private RadioButton radbtn_cyan;
        private RadioButton radbtn_sageGreen;
        private Label label_hobby;
        private CheckBox cb_isi;
        private TextBox txt_isiHobi;
        private Button btn_clear;
        private Button btn_submit;
        private CheckBox cb_WatchTV;
        private CheckBox cb_reading;
        private CheckBox cb_playSports;
        private Panel panel1;
        private Panel panel2;
    }
}