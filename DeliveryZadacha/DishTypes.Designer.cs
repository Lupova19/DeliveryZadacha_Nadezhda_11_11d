namespace DeliveryZadacha
{
    partial class DishTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishTypes));
            this.lblId2 = new System.Windows.Forms.Label();
            this.lblNameDish2 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtNameDish2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnSelectAll2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId2
            // 
            this.lblId2.AutoSize = true;
            this.lblId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId2.Location = new System.Drawing.Point(52, 38);
            this.lblId2.Name = "lblId2";
            this.lblId2.Size = new System.Drawing.Size(32, 22);
            this.lblId2.TabIndex = 0;
            this.lblId2.Text = "Id:";
            // 
            // lblNameDish2
            // 
            this.lblNameDish2.AutoSize = true;
            this.lblNameDish2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameDish2.Location = new System.Drawing.Point(71, 76);
            this.lblNameDish2.Name = "lblNameDish2";
            this.lblNameDish2.Size = new System.Drawing.Size(178, 22);
            this.lblNameDish2.TabIndex = 1;
            this.lblNameDish2.Text = "Име на тип ястие:";
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(99, 40);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(100, 22);
            this.txtId2.TabIndex = 2;
            // 
            // txtNameDish2
            // 
            this.txtNameDish2.Location = new System.Drawing.Point(38, 113);
            this.txtNameDish2.Name = "txtNameDish2";
            this.txtNameDish2.Size = new System.Drawing.Size(267, 22);
            this.txtNameDish2.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(12, 209);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(369, 276);
            this.listBox2.TabIndex = 4;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate2.Location = new System.Drawing.Point(597, 368);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(152, 63);
            this.btnUpdate2.TabIndex = 40;
            this.btnUpdate2.Text = "Актуализирай";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete2.Location = new System.Drawing.Point(429, 368);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(147, 63);
            this.btnDelete2.TabIndex = 39;
            this.btnDelete2.Text = "Изтрий";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd2.Location = new System.Drawing.Point(429, 288);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(320, 63);
            this.btnAdd2.TabIndex = 37;
            this.btnAdd2.Text = "Добави";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch2.Location = new System.Drawing.Point(38, 154);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(270, 49);
            this.btnSearch2.TabIndex = 41;
            this.btnSearch2.Text = "Търсене";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // btnSelectAll2
            // 
            this.btnSelectAll2.BackColor = System.Drawing.Color.Salmon;
            this.btnSelectAll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAll2.Location = new System.Drawing.Point(451, 447);
            this.btnSelectAll2.Name = "btnSelectAll2";
            this.btnSelectAll2.Size = new System.Drawing.Size(274, 38);
            this.btnSelectAll2.TabIndex = 42;
            this.btnSelectAll2.Text = "Избери всички";
            this.btnSelectAll2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // DishTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectAll2);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtNameDish2);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.lblNameDish2);
            this.Controls.Add(this.lblId2);
            this.Name = "DishTypes";
            this.Text = "DishTypes";
            this.Load += new System.EventHandler(this.DishTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId2;
        private System.Windows.Forms.Label lblNameDish2;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtNameDish2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnSelectAll2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}