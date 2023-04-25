namespace ATP.AppGUI
{
    partial class ATPGUI
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
            tabs = new TabControl();
            tabTesis = new TabPage();
            tabYonetim = new TabPage();
            richTextBox1 = new RichTextBox();
            lblYearlyRent = new Label();
            txtYearlyRent = new TextBox();
            chkBoxRent = new CheckBox();
            txtSearchBox = new TextBox();
            btnResetForm = new Button();
            label9 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            txtReturnOfInvesment = new Label();
            txtYearlyProfit = new TextBox();
            label7 = new Label();
            txtYearlyCost = new TextBox();
            label6 = new Label();
            txtInitInvCost = new TextBox();
            lblAdresBilgisi = new Label();
            txtAdresBilgisi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTown = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            lblAdres = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            lblName = new Label();
            facilityDgv = new DataGridView();
            tabs.SuspendLayout();
            tabYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)facilityDgv).BeginInit();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tabTesis);
            tabs.Controls.Add(tabYonetim);
            tabs.Location = new Point(12, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1240, 657);
            tabs.TabIndex = 0;
            // 
            // tabTesis
            // 
            tabTesis.BackgroundImage = Properties.Resources.uygulamaasrkaplan;
            tabTesis.Location = new Point(4, 24);
            tabTesis.Name = "tabTesis";
            tabTesis.Padding = new Padding(3);
            tabTesis.Size = new Size(1232, 629);
            tabTesis.TabIndex = 0;
            tabTesis.Text = "Tesisler";
            tabTesis.UseVisualStyleBackColor = true;
            // 
            // tabYonetim
            // 
            tabYonetim.BackgroundImage = Properties.Resources.uygulamaasrkaplan;
            tabYonetim.Controls.Add(richTextBox1);
            tabYonetim.Controls.Add(lblYearlyRent);
            tabYonetim.Controls.Add(txtYearlyRent);
            tabYonetim.Controls.Add(chkBoxRent);
            tabYonetim.Controls.Add(txtSearchBox);
            tabYonetim.Controls.Add(btnResetForm);
            tabYonetim.Controls.Add(label9);
            tabYonetim.Controls.Add(btnDelete);
            tabYonetim.Controls.Add(btnSave);
            tabYonetim.Controls.Add(txtReturnOfInvesment);
            tabYonetim.Controls.Add(txtYearlyProfit);
            tabYonetim.Controls.Add(label7);
            tabYonetim.Controls.Add(txtYearlyCost);
            tabYonetim.Controls.Add(label6);
            tabYonetim.Controls.Add(txtInitInvCost);
            tabYonetim.Controls.Add(lblAdresBilgisi);
            tabYonetim.Controls.Add(txtAdresBilgisi);
            tabYonetim.Controls.Add(label4);
            tabYonetim.Controls.Add(label3);
            tabYonetim.Controls.Add(txtTown);
            tabYonetim.Controls.Add(label2);
            tabYonetim.Controls.Add(txtCity);
            tabYonetim.Controls.Add(lblAdres);
            tabYonetim.Controls.Add(txtDescription);
            tabYonetim.Controls.Add(label1);
            tabYonetim.Controls.Add(txtName);
            tabYonetim.Controls.Add(lblName);
            tabYonetim.Controls.Add(facilityDgv);
            tabYonetim.Location = new Point(4, 24);
            tabYonetim.Name = "tabYonetim";
            tabYonetim.Padding = new Padding(3);
            tabYonetim.Size = new Size(1232, 629);
            tabYonetim.TabIndex = 1;
            tabYonetim.Text = "Yönetim";
            tabYonetim.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Green;
            richTextBox1.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(86, 400);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(241, 52);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = "Yapı Satınalma (Yaptırma) Maliyeti";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // lblYearlyRent
            // 
            lblYearlyRent.AutoSize = true;
            lblYearlyRent.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYearlyRent.ForeColor = SystemColors.Control;
            lblYearlyRent.Location = new Point(279, 211);
            lblYearlyRent.Name = "lblYearlyRent";
            lblYearlyRent.Size = new Size(96, 26);
            lblYearlyRent.TabIndex = 29;
            lblYearlyRent.Text = "Yıllık Kira";
            lblYearlyRent.Click += label8_Click_2;
            // 
            // txtYearlyRent
            // 
            txtYearlyRent.Location = new Point(381, 214);
            txtYearlyRent.Name = "txtYearlyRent";
            txtYearlyRent.Size = new Size(128, 23);
            txtYearlyRent.TabIndex = 28;
            // 
            // chkBoxRent
            // 
            chkBoxRent.AutoSize = true;
            chkBoxRent.Location = new Point(209, 218);
            chkBoxRent.Name = "chkBoxRent";
            chkBoxRent.Size = new Size(58, 19);
            chkBoxRent.TabIndex = 27;
            chkBoxRent.Text = "Kiralık";
            chkBoxRent.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(652, 68);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(420, 23);
            txtSearchBox.TabIndex = 25;
            // 
            // btnResetForm
            // 
            btnResetForm.BackColor = Color.Blue;
            btnResetForm.ForeColor = Color.White;
            btnResetForm.Location = new Point(498, 581);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(75, 23);
            btnResetForm.TabIndex = 24;
            btnResetForm.Text = "Temizle";
            btnResetForm.UseVisualStyleBackColor = false;
            btnResetForm.Click += btnResetForm_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(458, 139);
            label9.Name = "label9";
            label9.Size = new Size(22, 30);
            label9.TabIndex = 23;
            label9.Text = "*";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(306, 581);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.ForeColor = Color.Snow;
            btnSave.Location = new Point(119, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtReturnOfInvesment
            // 
            txtReturnOfInvesment.AutoSize = true;
            txtReturnOfInvesment.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnOfInvesment.ForeColor = SystemColors.Control;
            txtReturnOfInvesment.Location = new Point(238, 533);
            txtReturnOfInvesment.Name = "txtReturnOfInvesment";
            txtReturnOfInvesment.Size = new Size(255, 26);
            txtReturnOfInvesment.TabIndex = 19;
            txtReturnOfInvesment.Text = "Yatırım Geri Dönüş Süresi";
            // 
            // txtYearlyProfit
            // 
            txtYearlyProfit.Location = new Point(330, 489);
            txtYearlyProfit.Name = "txtYearlyProfit";
            txtYearlyProfit.Size = new Size(243, 23);
            txtYearlyProfit.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(103, 489);
            label7.Name = "label7";
            label7.Size = new Size(224, 26);
            label7.TabIndex = 17;
            label7.Text = "Yıllık Ortalama Kazanç";
            // 
            // txtYearlyCost
            // 
            txtYearlyCost.Location = new Point(330, 449);
            txtYearlyCost.Name = "txtYearlyCost";
            txtYearlyCost.Size = new Size(243, 23);
            txtYearlyCost.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(103, 446);
            label6.Name = "label6";
            label6.Size = new Size(207, 26);
            label6.TabIndex = 15;
            label6.Text = "Yıllık İşletme Maliyeti";
            // 
            // txtInitInvCost
            // 
            txtInitInvCost.Location = new Point(330, 401);
            txtInitInvCost.Name = "txtInitInvCost";
            txtInitInvCost.Size = new Size(243, 23);
            txtInitInvCost.TabIndex = 14;
            // 
            // lblAdresBilgisi
            // 
            lblAdresBilgisi.AutoSize = true;
            lblAdresBilgisi.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdresBilgisi.ForeColor = SystemColors.Control;
            lblAdresBilgisi.Location = new Point(209, 297);
            lblAdresBilgisi.Name = "lblAdresBilgisi";
            lblAdresBilgisi.Size = new Size(128, 26);
            lblAdresBilgisi.TabIndex = 12;
            lblAdresBilgisi.Text = "Adres Bilgisi";
            // 
            // txtAdresBilgisi
            // 
            txtAdresBilgisi.Location = new Point(209, 326);
            txtAdresBilgisi.Multiline = true;
            txtAdresBilgisi.Name = "txtAdresBilgisi";
            txtAdresBilgisi.Size = new Size(302, 44);
            txtAdresBilgisi.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(330, 252);
            label4.Name = "label4";
            label4.Size = new Size(22, 30);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(364, 252);
            label3.Name = "label3";
            label3.Size = new Size(45, 26);
            label3.TabIndex = 9;
            label3.Text = "İlçe";
            // 
            // txtTown
            // 
            txtTown.Location = new Point(415, 252);
            txtTown.Name = "txtTown";
            txtTown.Size = new Size(96, 23);
            txtTown.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(209, 252);
            label2.Name = "label2";
            label2.Size = new Size(23, 26);
            label2.TabIndex = 7;
            label2.Text = "İl";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(238, 252);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(96, 23);
            txtCity.TabIndex = 6;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdres.ForeColor = SystemColors.Control;
            lblAdres.Location = new Point(103, 252);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(67, 26);
            lblAdres.TabIndex = 5;
            lblAdres.Text = "Adres";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(209, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(243, 23);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(103, 177);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 3;
            label1.Text = "Açıklama";
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 23);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(103, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 26);
            lblName.TabIndex = 1;
            lblName.Text = "İsim";
            // 
            // facilityDgv
            // 
            facilityDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facilityDgv.Location = new Point(652, 98);
            facilityDgv.Name = "facilityDgv";
            facilityDgv.RowTemplate.Height = 25;
            facilityDgv.Size = new Size(556, 497);
            facilityDgv.TabIndex = 0;
            facilityDgv.CellMouseDoubleClick += facilityDgv_CellMouseDoubleClick;
            facilityDgv.DoubleClick += facilityDgv_DoubleClick;
            // 
            // ATPGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabs);
            Name = "ATPGUI";
            Text = "Tesis Planlama";
            tabs.ResumeLayout(false);
            tabYonetim.ResumeLayout(false);
            tabYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)facilityDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage tabYonetim;
        private TabPage tabTesis;
        private TextBox txtCity;
        private Label lblAdres;
        private TextBox txtDescription;
        private Label label1;
        private TextBox txtName;
        private Label lblName;
        private DataGridView facilityDgv;
        private Label label2;
        private Label label3;
        private TextBox txtTown;
        private Label lblAdresBilgisi;
        private TextBox txtAdresBilgisi;
        private Label label4;
        private TextBox txtYearlyCost;
        private Label label6;
        private TextBox txtInitInvCost;
        private Button btnDelete;
        private Button btnSave;
        private Label txtReturnOfInvesment;
        private TextBox txtYearlyProfit;
        private Label label7;
        private Label label9;
        private Button btnResetForm;
        private TextBox txtSearchBox;
        private TextBox txtYearlyRent;
        private CheckBox chkBoxRent;
        private Label lblYearlyRent;
        private RichTextBox richTextBox1;
    }
}