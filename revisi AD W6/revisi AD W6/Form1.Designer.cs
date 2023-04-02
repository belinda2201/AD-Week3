namespace revisi_AD_W6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1_showproducts = new System.Windows.Forms.DataGridView();
            this.dataGridView2_showcategory = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_namaDetails = new System.Windows.Forms.Label();
            this.label_namaCategory = new System.Windows.Forms.Label();
            this.label_stokDetails = new System.Windows.Forms.Label();
            this.label_hargaDetails = new System.Windows.Forms.Label();
            this.label_categoryDetails = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.txt_namaDetails = new System.Windows.Forms.TextBox();
            this.txt_hargaDetails = new System.Windows.Forms.TextBox();
            this.txt_stokDetails = new System.Windows.Forms.TextBox();
            this.txt_namaCategory = new System.Windows.Forms.TextBox();
            this.comboBox_details = new System.Windows.Forms.ComboBox();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            this.pictureBox_yuegui = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_showproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_showcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yuegui)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_showproducts
            // 
            this.dataGridView1_showproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_showproducts.Location = new System.Drawing.Point(77, 107);
            this.dataGridView1_showproducts.Name = "dataGridView1_showproducts";
            this.dataGridView1_showproducts.ReadOnly = true;
            this.dataGridView1_showproducts.RowHeadersWidth = 102;
            this.dataGridView1_showproducts.RowTemplate.Height = 49;
            this.dataGridView1_showproducts.Size = new System.Drawing.Size(1187, 670);
            this.dataGridView1_showproducts.TabIndex = 0;
            this.dataGridView1_showproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_showproducts_CellClick);
            // 
            // dataGridView2_showcategory
            // 
            this.dataGridView2_showcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_showcategory.Location = new System.Drawing.Point(1422, 107);
            this.dataGridView2_showcategory.Name = "dataGridView2_showcategory";
            this.dataGridView2_showcategory.ReadOnly = true;
            this.dataGridView2_showcategory.RowHeadersWidth = 102;
            this.dataGridView2_showcategory.RowTemplate.Height = 49;
            this.dataGridView2_showcategory.Size = new System.Drawing.Size(733, 485);
            this.dataGridView2_showcategory.TabIndex = 1;
            this.dataGridView2_showcategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_showcategory_CellClick);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_product.Location = new System.Drawing.Point(77, 41);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(160, 50);
            this.label_product.TabIndex = 2;
            this.label_product.Text = "Product";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_category.Location = new System.Drawing.Point(1422, 41);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(181, 50);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            // 
            // label_namaDetails
            // 
            this.label_namaDetails.AutoSize = true;
            this.label_namaDetails.Location = new System.Drawing.Point(77, 899);
            this.label_namaDetails.Name = "label_namaDetails";
            this.label_namaDetails.Size = new System.Drawing.Size(103, 41);
            this.label_namaDetails.TabIndex = 4;
            this.label_namaDetails.Text = "Nama:";
            // 
            // label_namaCategory
            // 
            this.label_namaCategory.AutoSize = true;
            this.label_namaCategory.Location = new System.Drawing.Point(1422, 632);
            this.label_namaCategory.Name = "label_namaCategory";
            this.label_namaCategory.Size = new System.Drawing.Size(103, 41);
            this.label_namaCategory.TabIndex = 5;
            this.label_namaCategory.Text = "Nama:";
            // 
            // label_stokDetails
            // 
            this.label_stokDetails.AutoSize = true;
            this.label_stokDetails.Location = new System.Drawing.Point(77, 1157);
            this.label_stokDetails.Name = "label_stokDetails";
            this.label_stokDetails.Size = new System.Drawing.Size(83, 41);
            this.label_stokDetails.TabIndex = 6;
            this.label_stokDetails.Text = "Stok:";
            // 
            // label_hargaDetails
            // 
            this.label_hargaDetails.AutoSize = true;
            this.label_hargaDetails.Location = new System.Drawing.Point(77, 1068);
            this.label_hargaDetails.Name = "label_hargaDetails";
            this.label_hargaDetails.Size = new System.Drawing.Size(104, 41);
            this.label_hargaDetails.TabIndex = 7;
            this.label_hargaDetails.Text = "Harga:";
            // 
            // label_categoryDetails
            // 
            this.label_categoryDetails.AutoSize = true;
            this.label_categoryDetails.Location = new System.Drawing.Point(77, 984);
            this.label_categoryDetails.Name = "label_categoryDetails";
            this.label_categoryDetails.Size = new System.Drawing.Size(146, 41);
            this.label_categoryDetails.TabIndex = 8;
            this.label_categoryDetails.Text = "Category:";
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_details.Location = new System.Drawing.Point(77, 812);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(141, 50);
            this.label_details.TabIndex = 9;
            this.label_details.Text = "Details";
            // 
            // txt_namaDetails
            // 
            this.txt_namaDetails.Location = new System.Drawing.Point(249, 896);
            this.txt_namaDetails.Name = "txt_namaDetails";
            this.txt_namaDetails.Size = new System.Drawing.Size(670, 47);
            this.txt_namaDetails.TabIndex = 10;
            // 
            // txt_hargaDetails
            // 
            this.txt_hargaDetails.Location = new System.Drawing.Point(249, 1068);
            this.txt_hargaDetails.Name = "txt_hargaDetails";
            this.txt_hargaDetails.Size = new System.Drawing.Size(670, 47);
            this.txt_hargaDetails.TabIndex = 11;
            this.txt_hargaDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hargaDetails_KeyPress);
            // 
            // txt_stokDetails
            // 
            this.txt_stokDetails.Location = new System.Drawing.Point(249, 1157);
            this.txt_stokDetails.Name = "txt_stokDetails";
            this.txt_stokDetails.Size = new System.Drawing.Size(670, 47);
            this.txt_stokDetails.TabIndex = 12;
            this.txt_stokDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stokDetails_KeyPress);
            // 
            // txt_namaCategory
            // 
            this.txt_namaCategory.Location = new System.Drawing.Point(1531, 629);
            this.txt_namaCategory.Name = "txt_namaCategory";
            this.txt_namaCategory.Size = new System.Drawing.Size(624, 47);
            this.txt_namaCategory.TabIndex = 13;
            // 
            // comboBox_details
            // 
            this.comboBox_details.FormattingEnabled = true;
            this.comboBox_details.Location = new System.Drawing.Point(249, 981);
            this.comboBox_details.Name = "comboBox_details";
            this.comboBox_details.Size = new System.Drawing.Size(670, 49);
            this.comboBox_details.TabIndex = 14;
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(979, 41);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(285, 49);
            this.comboBox_filter.TabIndex = 15;
            this.comboBox_filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filter_SelectionChangeCommitted);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(693, 35);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(125, 58);
            this.btn_all.TabIndex = 16;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(834, 35);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(125, 58);
            this.btn_filter.TabIndex = 17;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(1019, 812);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(245, 148);
            this.btn_addProduct.TabIndex = 18;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(1019, 967);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(245, 148);
            this.btn_editProduct.TabIndex = 19;
            this.btn_editProduct.Text = "Edit Product";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(1019, 1121);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(245, 148);
            this.btn_removeProduct.TabIndex = 20;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(1659, 697);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(245, 148);
            this.btn_addCategory.TabIndex = 21;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Location = new System.Drawing.Point(1910, 697);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(245, 148);
            this.btn_removeCategory.TabIndex = 22;
            this.btn_removeCategory.Text = "Remove Category";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // pictureBox_yuegui
            // 
            this.pictureBox_yuegui.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_yuegui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_yuegui.BackgroundImage")));
            this.pictureBox_yuegui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_yuegui.Location = new System.Drawing.Point(1582, 887);
            this.pictureBox_yuegui.Name = "pictureBox_yuegui";
            this.pictureBox_yuegui.Size = new System.Drawing.Size(383, 356);
            this.pictureBox_yuegui.TabIndex = 23;
            this.pictureBox_yuegui.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2227, 1296);
            this.Controls.Add(this.pictureBox_yuegui);
            this.Controls.Add(this.btn_removeCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.comboBox_details);
            this.Controls.Add(this.txt_namaCategory);
            this.Controls.Add(this.txt_stokDetails);
            this.Controls.Add(this.txt_hargaDetails);
            this.Controls.Add(this.txt_namaDetails);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.label_categoryDetails);
            this.Controls.Add(this.label_hargaDetails);
            this.Controls.Add(this.label_stokDetails);
            this.Controls.Add(this.label_namaCategory);
            this.Controls.Add(this.label_namaDetails);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dataGridView2_showcategory);
            this.Controls.Add(this.dataGridView1_showproducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_showproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_showcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yuegui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1_showproducts;
        private DataGridView dataGridView2_showcategory;
        private Label label_product;
        private Label label_category;
        private Label label_namaDetails;
        private Label label_namaCategory;
        private Label label_stokDetails;
        private Label label_hargaDetails;
        private Label label_categoryDetails;
        private Label label_details;
        private TextBox txt_namaDetails;
        private TextBox txt_hargaDetails;
        private TextBox txt_stokDetails;
        private TextBox txt_namaCategory;
        private ComboBox comboBox_details;
        private ComboBox comboBox_filter;
        private Button btn_all;
        private Button btn_filter;
        private Button btn_addProduct;
        private Button btn_editProduct;
        private Button btn_removeProduct;
        private Button btn_addCategory;
        private Button btn_removeCategory;
        private PictureBox pictureBox_yuegui;
    }
}