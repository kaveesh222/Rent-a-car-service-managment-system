namespace Ayubo
{
    partial class Addvehicle
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
            this.dgvvehicle = new System.Windows.Forms.DataGridView();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbvtype = new System.Windows.Forms.ComboBox();
            this.cmbvbrand = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtregisternumber = new System.Windows.Forms.TextBox();
            this.txtowner = new System.Windows.Forms.TextBox();
            this.txtreading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbmfy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbwheels = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvehicle
            // 
            this.dgvvehicle.BackgroundColor = System.Drawing.Color.White;
            this.dgvvehicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehicle.Location = new System.Drawing.Point(17, 349);
            this.dgvvehicle.Name = "dgvvehicle";
            this.dgvvehicle.Size = new System.Drawing.Size(738, 89);
            this.dgvvehicle.TabIndex = 77;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(539, 135);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(217, 20);
            this.dtpdate.TabIndex = 74;
            // 
            // cmbvtype
            // 
            this.cmbvtype.FormattingEnabled = true;
            this.cmbvtype.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Jeep",
            "SUV"});
            this.cmbvtype.Location = new System.Drawing.Point(17, 200);
            this.cmbvtype.Name = "cmbvtype";
            this.cmbvtype.Size = new System.Drawing.Size(216, 21);
            this.cmbvtype.TabIndex = 73;
            // 
            // cmbvbrand
            // 
            this.cmbvbrand.FormattingEnabled = true;
            this.cmbvbrand.Items.AddRange(new object[] {
            "BMW",
            "Benze",
            "Toyota",
            "Nissan",
            "Suzuki",
            "Audi"});
            this.cmbvbrand.Location = new System.Drawing.Point(17, 261);
            this.cmbvbrand.Name = "cmbvbrand";
            this.cmbvbrand.Size = new System.Drawing.Size(216, 21);
            this.cmbvbrand.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Last owner";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Added date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Vehicle type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Vehicle brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Meter reading (Km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Registered number";
            // 
            // txtregisternumber
            // 
            this.txtregisternumber.Location = new System.Drawing.Point(17, 135);
            this.txtregisternumber.Multiline = true;
            this.txtregisternumber.Name = "txtregisternumber";
            this.txtregisternumber.Size = new System.Drawing.Size(216, 26);
            this.txtregisternumber.TabIndex = 63;
            // 
            // txtowner
            // 
            this.txtowner.Location = new System.Drawing.Point(280, 200);
            this.txtowner.Multiline = true;
            this.txtowner.Name = "txtowner";
            this.txtowner.Size = new System.Drawing.Size(216, 26);
            this.txtowner.TabIndex = 62;
            // 
            // txtreading
            // 
            this.txtreading.Location = new System.Drawing.Point(279, 135);
            this.txtreading.Multiline = true;
            this.txtreading.Name = "txtreading";
            this.txtreading.Size = new System.Drawing.Size(217, 26);
            this.txtreading.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Take a vehicle for drop or picking purposes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Hire vehicle for your journey";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 57;
            // 
            // cmbmfy
            // 
            this.cmbmfy.FormattingEnabled = true;
            this.cmbmfy.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013"});
            this.cmbmfy.Location = new System.Drawing.Point(540, 200);
            this.cmbmfy.Name = "cmbmfy";
            this.cmbmfy.Size = new System.Drawing.Size(216, 21);
            this.cmbmfy.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "MFY";
            // 
            // cmbwheels
            // 
            this.cmbwheels.FormattingEnabled = true;
            this.cmbwheels.Items.AddRange(new object[] {
            "2 x 2",
            "4 x 4"});
            this.cmbwheels.Location = new System.Drawing.Point(279, 261);
            this.cmbwheels.Name = "cmbwheels";
            this.cmbwheels.Size = new System.Drawing.Size(216, 21);
            this.cmbwheels.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Wheels";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(254, 308);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 27);
            this.btnsearch.TabIndex = 85;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(382, 308);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(108, 27);
            this.btninsert.TabIndex = 84;
            this.btninsert.Text = "Record";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(513, 308);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(108, 27);
            this.btndelete.TabIndex = 83;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(646, 308);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(108, 27);
            this.btnback.TabIndex = 82;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(45)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(539, 255);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(215, 27);
            this.btnupdate.TabIndex = 86;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Menu;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(22, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 92;
            this.label15.Text = "Search by Reg.No";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Location = new System.Drawing.Point(18, 308);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(216, 26);
            this.txtsearch.TabIndex = 91;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Addvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.cmbwheels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmfy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cmbvtype);
            this.Controls.Add(this.cmbvbrand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtregisternumber);
            this.Controls.Add(this.txtowner);
            this.Controls.Add(this.txtreading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvvehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addvehicle";
            this.Text = "Addvehicle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvvehicle;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbvtype;
        private System.Windows.Forms.ComboBox cmbvbrand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtregisternumber;
        private System.Windows.Forms.TextBox txtowner;
        private System.Windows.Forms.TextBox txtreading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbmfy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbwheels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsearch;
    }
}