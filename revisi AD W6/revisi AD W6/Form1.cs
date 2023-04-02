using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace revisi_AD_W6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();

        public string categoryNow = "";
        public string idNow = "";

        private void btn_all_Click(object sender, EventArgs e)
        {
            update("");
            comboBox_filter.Enabled = false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = true;
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            string namaCategory = txt_namaCategory.Text;
            var ID = dtCategory.AsEnumerable().Select(row => row.Field<string>("ID Category"));
            bool cek = false;
            foreach (DataRow row in dtCategory.Rows)
            {
                if (txt_namaCategory.Text != row[1].ToString())
                {
                    continue;
                }
                cek = true;
            }
            if (cek == true)
            {
                MessageBox.Show("Sudah ada kategori yang sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_namaCategory.Text = "";
                return;
            }
            string hurufDepan = "C";
            int IDbaru = 1;

            if (string.IsNullOrEmpty(txt_namaCategory.Text))
            {
                MessageBox.Show("Masukkan nama kategori", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            while (ID.Contains(hurufDepan + IDbaru))
            {
                IDbaru++;
            }

            string newIdCategory = hurufDepan + IDbaru;
            DataRow row_ = dtCategory.NewRow();
            row_[0] = newIdCategory;
            row_[1] = namaCategory;
            dtCategory.Rows.Add(row_);
            update("");
        }

        private void btn_removeCategory_Click(object sender, EventArgs e)
        {
            int i;
            string namaCategory = txt_namaCategory.Text;
            if (string.IsNullOrEmpty(txt_namaCategory.Text))
            {
                MessageBox.Show("Pilih kategori yang mau dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() != categoryNow)
                {
                    continue;
                }
                dtCategory.Rows.Remove(row);
                for (i = dtProdukTampil.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtProdukTampil.Rows[i]["ID Category"] == categoryNow)
                    {
                        dtProdukTampil.Rows.Remove(dtProdukTampil.Rows[i]);
                    }
                }
                update("");
                return;
            }
            for (i = dtProdukTampil.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProdukTampil.Rows[i]["ID Category"] == categoryNow)
                {
                    dtProdukTampil.Rows.Remove(dtProdukTampil.Rows[i]);
                }
            }
            update("");

        }

        private void dataGridView1_showproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1_showproducts.Rows[e.RowIndex];
            idNow = row.Cells[0].Value.ToString();
            txt_namaDetails.Text = row.Cells[1].Value.ToString();
            txt_hargaDetails.Text = row.Cells[2].Value.ToString();
            txt_stokDetails.Text = row.Cells[3].Value.ToString();
            comboBox_details.SelectedValue = row.Cells[4].Value.ToString();
        }

        private void dataGridView2_showcategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryNow = dataGridView2_showcategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_namaCategory.Text = dataGridView2_showcategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (txt_namaDetails.Text == "" || txt_hargaDetails.Text == "" || txt_stokDetails.Text == "" || comboBox_details.SelectedValue == null)
            {
                MessageBox.Show("Isi field yang kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var ID = dtProdukTampil.AsEnumerable().Select(roww => roww.Field<string>("ID Product"));
                string hurufDepan = txt_namaDetails.Text.Substring(0, 1).ToUpper();
                int newId = 1;

                foreach (DataRow roww in dtProdukTampil.Rows)
                {
                    if (roww[0].ToString()[0].ToString() == hurufDepan)
                    {
                        newId++;
                    }
                }

                string newIdTampilan = hurufDepan + newId;
                for (int i = newId.ToString().Length; i < 3; i++)
                {
                    hurufDepan = string.Concat(hurufDepan, "0");
                }
                hurufDepan = string.Concat(hurufDepan, newId.ToString());
                DataRow row = dtProdukTampil.NewRow();
                row[0] = hurufDepan;
                row[1] = txt_namaDetails.Text;
                row[2] = txt_hargaDetails.Text;
                row[3] = txt_stokDetails.Text;
                row[4] = comboBox_details.SelectedValue;
                dtProdukTampil.Rows.Add(row);
                update("");
            }            
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_namaDetails.Text) && !string.IsNullOrEmpty(txt_stokDetails.Text) && !string.IsNullOrEmpty(txt_hargaDetails.Text) && comboBox_details.SelectedValue != null)
            {
                string newValueNama = txt_namaDetails.Text;
                string newValueCategory = comboBox_details.SelectedValue.ToString();
                int newValueHarga = Convert.ToInt32(txt_hargaDetails.Text);
                int newValueStock = Convert.ToInt32(txt_stokDetails.Text);
                foreach (DataRow row in dtProdukTampil.Rows)
                {
                    if (row[0].ToString() != idNow)
                    {
                        continue;
                    }
                    else
                    {
                        row[1] = newValueNama;
                        row[2] = newValueHarga;
                        row[3] = newValueStock;
                        row[4] = newValueCategory;
                    }

                    if (row[3].ToString() != "0")
                    {
                        continue;
                    }
                    else
                    {
                        dtProdukTampil.Rows.Remove(row);
                    }
                    update("");
                }
                update("");
            }
            else
            {
                MessageBox.Show("Isi field yang kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void update(string ambil)
        {
            if (ambil == "")
            {
                dtProdukSimpan.Rows.Clear();
                for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
                {
                    DataRow row = dtProdukSimpan.NewRow();
                    row[0] = dtProdukTampil.Rows[i][0];
                    row[1] = dtProdukTampil.Rows[i][1];
                    row[2] = dtProdukTampil.Rows[i][2];
                    row[3] = dtProdukTampil.Rows[i][3];
                    row[4] = dtProdukTampil.Rows[i][4];
                    dtProdukSimpan.Rows.Add(row);
                }
            }
            else
            {
                dtProdukSimpan.Rows.Clear();
                for (int j = 0; j < dtProdukTampil.Rows.Count; j++)
                {
                    if (dtProdukTampil.Rows[j][4].ToString() == ambil)
                    {
                        DataRow row = dtProdukSimpan.NewRow();
                        row[0] = dtProdukTampil.Rows[j][0];
                        row[1] = dtProdukTampil.Rows[j][1];
                        row[2] = dtProdukTampil.Rows[j][2];
                        row[3] = dtProdukTampil.Rows[j][3];
                        row[4] = dtProdukTampil.Rows[j][4];
                        dtProdukSimpan.Rows.Add(row);
                    }
                }
            }

            dataGridView1_showproducts.CurrentCell = null;
            dataGridView2_showcategory.CurrentCell = null;
            txt_namaDetails.Clear();
            txt_hargaDetails.Clear();
            txt_stokDetails.Clear();

            idNow = "";
            categoryNow = "";

            comboBox_details.DataSource = dtCategory.Copy();
            comboBox_filter.DataSource = dtCategory.Copy();
            comboBox_details.Text = "";
            comboBox_filter.Text = "";
            txt_namaCategory.Text = "";

        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            if (txt_namaDetails.Text == "" || txt_stokDetails.Text == "" || txt_hargaDetails.Text == "" || comboBox_details.SelectedValue == null)
            {
                MessageBox.Show("Pilih barang yang mau dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in dtProdukTampil.Rows)
            {
                if (row[0].ToString() != idNow)
                {
                    continue;
                }
                dtProdukTampil.Rows.Remove(row);
                update("");
                return;
            }
            update("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtProdukTampil.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtProdukTampil.Rows.Add("T001", "T-Shirt Black Pink", 70000, 20, "C2");
            dtProdukTampil.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dtProdukTampil.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dtProdukTampil.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dtProdukTampil.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dtProdukTampil.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            dtProdukTampil.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            dtCategory.Columns.Add("ID Category", typeof(string));
            dtCategory.Columns.Add("Nama Category", typeof(string));

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            comboBox_filter.Enabled = false;
            comboBox_filter.Text = "";
            comboBox_filter.DataSource = dtCategory.Copy();
            comboBox_filter.DisplayMember = "Nama Category";
            comboBox_filter.ValueMember = "ID Category";

            dtProdukSimpan = dtProdukTampil.Copy();

            dataGridView2_showcategory.DataSource = dtCategory;
            dataGridView1_showproducts.DataSource = dtProdukSimpan;
            comboBox_details.DataSource = dtCategory.Copy();
            comboBox_details.DisplayMember = "Nama Category";
            comboBox_details.ValueMember = "ID Category";

            dataGridView2_showcategory.CurrentCell = null;
            dataGridView1_showproducts.ClearSelection();
            dataGridView1_showproducts.CurrentCell = null;
            comboBox_details.Text = "";
            comboBox_filter.Text = "";
        }

        private void txt_hargaDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_stokDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nama;
            bool select = false;
            nama = comboBox_filter.SelectedValue.ToString();
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() == nama)
                {
                    nama = row[1].ToString();
                    break;
                }
            }
            update(comboBox_filter.SelectedValue.ToString());
            if (select == true)
            {
                comboBox_filter.Text = nama;
            }
        }
    }
}
