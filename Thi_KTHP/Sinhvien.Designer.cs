namespace Thi_KTHP
{
    partial class frmqtsv
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
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemsv = new System.Windows.Forms.Button();
            this.btnqtsuasv = new System.Windows.Forms.Button();
            this.btnqtxoasv = new System.Windows.Forms.Button();
            this.btnqtghisv = new System.Windows.Forms.Button();
            this.btnqthuysv = new System.Windows.Forms.Button();
            this.btnqtxuatexcell = new System.Windows.Forms.Button();
            this.btnqttksv = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cboqttennganh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboqttenkhoa = new System.Windows.Forms.ComboBox();
            this.txtqttksv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqtghichu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtqtnoisinhsv = new System.Windows.Forms.TextBox();
            this.rdoqtnu = new System.Windows.Forms.RadioButton();
            this.rdoqtnam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpngaysinhsv = new System.Windows.Forms.DateTimePicker();
            this.cboqttenlop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtquequansv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqttensv = new System.Windows.Forms.TextBox();
            this.txtqtmasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlqtcsdl = new System.Windows.Forms.Panel();
            this.dgvqtsv = new System.Windows.Forms.DataGridView();
            this.errorbatloi = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbtt = new System.Windows.Forms.GroupBox();
            this.floqtnut.SuspendLayout();
            this.pnlqttruong.SuspendLayout();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).BeginInit();
            this.grbtt.SuspendLayout();
            this.SuspendLayout();
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.BackColor = System.Drawing.Color.LightBlue;
            this.floqtnut.Controls.Add(this.btnqtthemsv);
            this.floqtnut.Controls.Add(this.btnqtsuasv);
            this.floqtnut.Controls.Add(this.btnqtxoasv);
            this.floqtnut.Controls.Add(this.btnqtghisv);
            this.floqtnut.Controls.Add(this.btnqthuysv);
            this.floqtnut.Controls.Add(this.btnqtxuatexcell);
            this.floqtnut.Controls.Add(this.btnqttksv);
            this.floqtnut.Location = new System.Drawing.Point(0, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(149, 541);
            this.floqtnut.TabIndex = 5;
            // 
            // btnqtthemsv
            // 
            this.btnqtthemsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqtthemsv.Image = global::Thi_KTHP.Properties.Resources.Them;
            this.btnqtthemsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtthemsv.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemsv.Name = "btnqtthemsv";
            this.btnqtthemsv.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemsv.TabIndex = 0;
            this.btnqtthemsv.Text = "Thêm";
            this.btnqtthemsv.UseVisualStyleBackColor = true;
            this.btnqtthemsv.Click += new System.EventHandler(this.btnqtthemsv_Click);
            // 
            // btnqtsuasv
            // 
            this.btnqtsuasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqtsuasv.Image = global::Thi_KTHP.Properties.Resources.sửa;
            this.btnqtsuasv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtsuasv.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuasv.Name = "btnqtsuasv";
            this.btnqtsuasv.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuasv.TabIndex = 1;
            this.btnqtsuasv.Text = "Sửa";
            this.btnqtsuasv.UseVisualStyleBackColor = true;
            this.btnqtsuasv.Click += new System.EventHandler(this.btnqtsuasv_Click);
            // 
            // btnqtxoasv
            // 
            this.btnqtxoasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqtxoasv.Image = global::Thi_KTHP.Properties.Resources.xoa;
            this.btnqtxoasv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtxoasv.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoasv.Name = "btnqtxoasv";
            this.btnqtxoasv.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoasv.TabIndex = 2;
            this.btnqtxoasv.Text = "Xóa";
            this.btnqtxoasv.UseVisualStyleBackColor = true;
            this.btnqtxoasv.Click += new System.EventHandler(this.btnqtxoasv_Click);
            // 
            // btnqtghisv
            // 
            this.btnqtghisv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqtghisv.Image = global::Thi_KTHP.Properties.Resources.ghi;
            this.btnqtghisv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtghisv.Location = new System.Drawing.Point(3, 228);
            this.btnqtghisv.Name = "btnqtghisv";
            this.btnqtghisv.Size = new System.Drawing.Size(144, 69);
            this.btnqtghisv.TabIndex = 3;
            this.btnqtghisv.Text = "Ghi";
            this.btnqtghisv.UseVisualStyleBackColor = true;
            this.btnqtghisv.Click += new System.EventHandler(this.btnqtghisv_Click);
            // 
            // btnqthuysv
            // 
            this.btnqthuysv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqthuysv.Image = global::Thi_KTHP.Properties.Resources.huy;
            this.btnqthuysv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqthuysv.Location = new System.Drawing.Point(3, 303);
            this.btnqthuysv.Name = "btnqthuysv";
            this.btnqthuysv.Size = new System.Drawing.Size(144, 69);
            this.btnqthuysv.TabIndex = 4;
            this.btnqthuysv.Text = "Hủy";
            this.btnqthuysv.UseVisualStyleBackColor = true;
            this.btnqthuysv.Click += new System.EventHandler(this.btnqthuysv_Click);
            // 
            // btnqtxuatexcell
            // 
            this.btnqtxuatexcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqtxuatexcell.Image = global::Thi_KTHP.Properties.Resources.excel;
            this.btnqtxuatexcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtxuatexcell.Location = new System.Drawing.Point(3, 378);
            this.btnqtxuatexcell.Name = "btnqtxuatexcell";
            this.btnqtxuatexcell.Size = new System.Drawing.Size(144, 69);
            this.btnqtxuatexcell.TabIndex = 12;
            this.btnqtxuatexcell.Text = "Excell";
            this.btnqtxuatexcell.UseVisualStyleBackColor = true;
            // 
            // btnqttksv
            // 
            this.btnqttksv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqttksv.Image = global::Thi_KTHP.Properties.Resources.timkiem;
            this.btnqttksv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqttksv.Location = new System.Drawing.Point(3, 453);
            this.btnqttksv.Name = "btnqttksv";
            this.btnqttksv.Size = new System.Drawing.Size(144, 69);
            this.btnqttksv.TabIndex = 13;
            this.btnqttksv.Text = "Tìm Kiếm";
            this.btnqttksv.UseVisualStyleBackColor = true;
            this.btnqttksv.Click += new System.EventHandler(this.btnqttksv_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.BackColor = System.Drawing.Color.LightBlue;
            this.pnlqttruong.Controls.Add(this.grbtt);
            this.pnlqttruong.Location = new System.Drawing.Point(155, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(626, 372);
            this.pnlqttruong.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(310, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ngành:";
            // 
            // cboqttennganh
            // 
            this.cboqttennganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqttennganh.FormattingEnabled = true;
            this.cboqttennganh.Items.AddRange(new object[] {
            "--"});
            this.cboqttennganh.Location = new System.Drawing.Point(314, 214);
            this.cboqttennganh.Name = "cboqttennganh";
            this.cboqttennganh.Size = new System.Drawing.Size(192, 28);
            this.cboqttennganh.TabIndex = 25;
            this.cboqttennganh.SelectedIndexChanged += new System.EventHandler(this.cboqttennganh_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Khoa:";
            // 
            // cboqttenkhoa
            // 
            this.cboqttenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqttenkhoa.FormattingEnabled = true;
            this.cboqttenkhoa.Items.AddRange(new object[] {
            "--"});
            this.cboqttenkhoa.Location = new System.Drawing.Point(6, 266);
            this.cboqttenkhoa.Name = "cboqttenkhoa";
            this.cboqttenkhoa.Size = new System.Drawing.Size(217, 28);
            this.cboqttenkhoa.TabIndex = 23;
            this.cboqttenkhoa.SelectedIndexChanged += new System.EventHandler(this.cboqttenkhoa_SelectedIndexChanged);
            // 
            // txtqttksv
            // 
            this.txtqttksv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttksv.Location = new System.Drawing.Point(97, 302);
            this.txtqttksv.Name = "txtqttksv";
            this.txtqttksv.Size = new System.Drawing.Size(456, 27);
            this.txtqttksv.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // txtqtghichu
            // 
            this.txtqtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtghichu.Location = new System.Drawing.Point(6, 214);
            this.txtqtghichu.Name = "txtqtghichu";
            this.txtqtghichu.Size = new System.Drawing.Size(205, 27);
            this.txtqtghichu.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ghi Chú:";
            // 
            // txtqtnoisinhsv
            // 
            this.txtqtnoisinhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtnoisinhsv.Location = new System.Drawing.Point(7, 161);
            this.txtqtnoisinhsv.Name = "txtqtnoisinhsv";
            this.txtqtnoisinhsv.Size = new System.Drawing.Size(208, 27);
            this.txtqtnoisinhsv.TabIndex = 17;
            // 
            // rdoqtnu
            // 
            this.rdoqtnu.AutoSize = true;
            this.rdoqtnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoqtnu.Location = new System.Drawing.Point(444, 168);
            this.rdoqtnu.Name = "rdoqtnu";
            this.rdoqtnu.Size = new System.Drawing.Size(51, 24);
            this.rdoqtnu.TabIndex = 16;
            this.rdoqtnu.TabStop = true;
            this.rdoqtnu.Text = "Nữ";
            this.rdoqtnu.UseVisualStyleBackColor = true;
            // 
            // rdoqtnam
            // 
            this.rdoqtnam.AutoSize = true;
            this.rdoqtnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoqtnam.Location = new System.Drawing.Point(322, 168);
            this.rdoqtnam.Name = "rdoqtnam";
            this.rdoqtnam.Size = new System.Drawing.Size(65, 24);
            this.rdoqtnam.TabIndex = 15;
            this.rdoqtnam.TabStop = true;
            this.rdoqtnam.Text = "Nam";
            this.rdoqtnam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nơi sinh:";
            // 
            // dtpngaysinhsv
            // 
            this.dtpngaysinhsv.CustomFormat = "dd/MM/yyyy";
            this.dtpngaysinhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysinhsv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinhsv.Location = new System.Drawing.Point(314, 108);
            this.dtpngaysinhsv.Name = "dtpngaysinhsv";
            this.dtpngaysinhsv.Size = new System.Drawing.Size(208, 27);
            this.dtpngaysinhsv.TabIndex = 12;
            // 
            // cboqttenlop
            // 
            this.cboqttenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqttenlop.FormattingEnabled = true;
            this.cboqttenlop.Items.AddRange(new object[] {
            "--"});
            this.cboqttenlop.Location = new System.Drawing.Point(314, 268);
            this.cboqttenlop.Name = "cboqttenlop";
            this.cboqttenlop.Size = new System.Drawing.Size(208, 28);
            this.cboqttenlop.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            // 
            // txtqtquequansv
            // 
            this.txtqtquequansv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtquequansv.Location = new System.Drawing.Point(7, 108);
            this.txtqtquequansv.Name = "txtqtquequansv";
            this.txtqtquequansv.Size = new System.Drawing.Size(208, 27);
            this.txtqtquequansv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtqttensv
            // 
            this.txtqttensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttensv.Location = new System.Drawing.Point(314, 55);
            this.txtqttensv.Name = "txtqttensv";
            this.txtqttensv.Size = new System.Drawing.Size(269, 27);
            this.txtqttensv.TabIndex = 3;
            // 
            // txtqtmasv
            // 
            this.txtqtmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmasv.Location = new System.Drawing.Point(7, 55);
            this.txtqtmasv.Name = "txtqtmasv";
            this.txtqtmasv.Size = new System.Drawing.Size(208, 27);
            this.txtqtmasv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.Color.LightBlue;
            this.pnlqtcsdl.Controls.Add(this.dgvqtsv);
            this.pnlqtcsdl.Location = new System.Drawing.Point(155, 381);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(629, 163);
            this.pnlqtcsdl.TabIndex = 7;
            // 
            // dgvqtsv
            // 
            this.dgvqtsv.AllowUserToAddRows = false;
            this.dgvqtsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtsv.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtsv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtsv.Location = new System.Drawing.Point(3, 32);
            this.dgvqtsv.Name = "dgvqtsv";
            this.dgvqtsv.RowHeadersWidth = 51;
            this.dgvqtsv.RowTemplate.Height = 24;
            this.dgvqtsv.Size = new System.Drawing.Size(623, 128);
            this.dgvqtsv.TabIndex = 4;
            this.dgvqtsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtsv_CellClick);
            // 
            // errorbatloi
            // 
            this.errorbatloi.ContainerControl = this;
            // 
            // grbtt
            // 
            this.grbtt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbtt.Controls.Add(this.label10);
            this.grbtt.Controls.Add(this.label1);
            this.grbtt.Controls.Add(this.cboqttennganh);
            this.grbtt.Controls.Add(this.label2);
            this.grbtt.Controls.Add(this.label11);
            this.grbtt.Controls.Add(this.txtqtmasv);
            this.grbtt.Controls.Add(this.cboqttenkhoa);
            this.grbtt.Controls.Add(this.txtqttensv);
            this.grbtt.Controls.Add(this.txtqttksv);
            this.grbtt.Controls.Add(this.label4);
            this.grbtt.Controls.Add(this.label3);
            this.grbtt.Controls.Add(this.txtqtquequansv);
            this.grbtt.Controls.Add(this.txtqtghichu);
            this.grbtt.Controls.Add(this.label5);
            this.grbtt.Controls.Add(this.label9);
            this.grbtt.Controls.Add(this.label6);
            this.grbtt.Controls.Add(this.txtqtnoisinhsv);
            this.grbtt.Controls.Add(this.cboqttenlop);
            this.grbtt.Controls.Add(this.rdoqtnu);
            this.grbtt.Controls.Add(this.dtpngaysinhsv);
            this.grbtt.Controls.Add(this.rdoqtnam);
            this.grbtt.Controls.Add(this.label7);
            this.grbtt.Controls.Add(this.label8);
            this.grbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtt.Location = new System.Drawing.Point(13, 9);
            this.grbtt.Name = "grbtt";
            this.grbtt.Size = new System.Drawing.Size(590, 345);
            this.grbtt.TabIndex = 5;
            this.grbtt.TabStop = false;
            this.grbtt.Text = "Thông Tin Sinh Viên";
            // 
            // frmqtsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 547);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.pnlqttruong);
            this.Controls.Add(this.floqtnut);
            this.Name = "frmqtsv";
            this.Text = "Sinhvien";
            this.Load += new System.EventHandler(this.frmqtsv_Load);
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).EndInit();
            this.grbtt.ResumeLayout(false);
            this.grbtt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemsv;
        private System.Windows.Forms.Button btnqtsuasv;
        private System.Windows.Forms.Button btnqtxoasv;
        private System.Windows.Forms.Button btnqtghisv;
        private System.Windows.Forms.Button btnqthuysv;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtquequansv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqttensv;
        private System.Windows.Forms.TextBox txtqtmasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqtsv;
        private System.Windows.Forms.TextBox txtqtnoisinhsv;
        private System.Windows.Forms.RadioButton rdoqtnu;
        private System.Windows.Forms.RadioButton rdoqtnam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpngaysinhsv;
        private System.Windows.Forms.ComboBox cboqttenlop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqtghichu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnqtxuatexcell;
        private System.Windows.Forms.Button btnqttksv;
        private System.Windows.Forms.TextBox txtqttksv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboqttennganh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboqttenkhoa;
        private System.Windows.Forms.ErrorProvider errorbatloi;
        private System.Windows.Forms.GroupBox grbtt;
    }
}