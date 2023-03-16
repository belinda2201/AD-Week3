namespace CA_w4
{
    public partial class formKerja : Form
    {
        public formKerja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_isiHobi.Enabled = false;
        }

        public string Hobi = "";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txt_age.Text);

            if (cb_reading.Checked)
            {
                Hobi += Convert.ToString(cb_reading.Text) + ", ";
            }
            if (cb_WatchTV.Checked)
            {
                Hobi += Convert.ToString(cb_WatchTV.Text) + ", ";
            }
            if (cb_playSports.Checked)
            {
                Hobi += Convert.ToString(cb_playSports.Text) + ", ";
            }
            if (cb_isi.Checked) 
            {
                Hobi += Convert.ToString(txt_isiHobi.Text);
            }

            if (radbtn_cyan.Checked)
            {
                this.BackColor = Color.Cyan;
            }
            if (radbtn_pink.Checked)
            {
                this.BackColor = Color.Pink;
            }
            if (radbtn_sageGreen.Checked)
            {
                this.BackColor = Color.DarkOliveGreen;
            }

            if (radbtn_male.Checked)
            {
                string info = "Name : " + txt_name.Text + "\nAge : " + txt_age.Text + "\nGender : Male\nHobbies : " + Hobi;
                MessageBox.Show(info);
            }
            if (radbtn_fem.Checked)
            {
                string info1 = "Name : " + txt_name.Text + "\nAge : " + txt_age.Text + "\nGender : Female\nHobbies : " + Hobi;
                MessageBox.Show(info1);
            }            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = ""; ;
            txt_age.Text = ""; ;
            txt_isiHobi.Text = "";
            radbtn_male.Checked= false;
            radbtn_fem.Checked= false;
            radbtn_cyan.Checked= false;
            radbtn_pink.Checked= false;
            radbtn_sageGreen.Checked= false;
            cb_isi.Checked = false;
            cb_playSports.Checked = false;
            cb_WatchTV.Checked = false;
            cb_reading.Checked = false;
            this.BackColor = Color.White;
        }

        private void cb_isi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isi.Checked)
            {
                txt_isiHobi.Enabled = true;     
            }
            else
            {
                txt_isiHobi.Enabled = false;
            }

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
            }
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }        
        
        private void txt_isiHobi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_age.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_age.Text = txt_age.Text.Remove(txt_age.Text.Length - 1);
            }
        }

        private void txt_isiHobi_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
            }
        }
    }
}