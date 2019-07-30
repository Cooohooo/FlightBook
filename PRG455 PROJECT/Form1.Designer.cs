namespace PRG455_PROJECT
{
    partial class Form1_reserve
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_reserve));
            this.label1_origin = new System.Windows.Forms.Label();
            this.textBox1_from = new System.Windows.Forms.TextBox();
            this.label1_destination = new System.Windows.Forms.Label();
            this.textBox2_to = new System.Windows.Forms.TextBox();
            this.dataGridView1_show = new System.Windows.Forms.DataGridView();
            this.btn_checkTo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_checkFrom = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.radioButton1_fc = new System.Windows.Forms.RadioButton();
            this.radioButton1_coach = new System.Windows.Forms.RadioButton();
            this.label1_seat = new System.Windows.Forms.Label();
            this.label1_number = new System.Windows.Forms.Label();
            this.textBox1_numbers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_origin
            // 
            this.label1_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_origin.Location = new System.Drawing.Point(58, 336);
            this.label1_origin.Name = "label1_origin";
            this.label1_origin.Size = new System.Drawing.Size(117, 24);
            this.label1_origin.TabIndex = 0;
            this.label1_origin.Text = "Origin(From)";
            // 
            // textBox1_from
            // 
            this.textBox1_from.Location = new System.Drawing.Point(61, 355);
            this.textBox1_from.Name = "textBox1_from";
            this.textBox1_from.Size = new System.Drawing.Size(147, 20);
            this.textBox1_from.TabIndex = 1;
            // 
            // label1_destination
            // 
            this.label1_destination.AutoSize = true;
            this.label1_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_destination.Location = new System.Drawing.Point(379, 336);
            this.label1_destination.Name = "label1_destination";
            this.label1_destination.Size = new System.Drawing.Size(115, 16);
            this.label1_destination.TabIndex = 2;
            this.label1_destination.Text = "Destination(To)";
            // 
            // textBox2_to
            // 
            this.textBox2_to.Location = new System.Drawing.Point(382, 355);
            this.textBox2_to.Name = "textBox2_to";
            this.textBox2_to.Size = new System.Drawing.Size(147, 20);
            this.textBox2_to.TabIndex = 3;
            // 
            // dataGridView1_show
            // 
            this.dataGridView1_show.AllowUserToOrderColumns = true;
            this.dataGridView1_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_show.Location = new System.Drawing.Point(47, 497);
            this.dataGridView1_show.Name = "dataGridView1_show";
            this.dataGridView1_show.ReadOnly = true;
            this.dataGridView1_show.Size = new System.Drawing.Size(602, 143);
            this.dataGridView1_show.TabIndex = 4;
            this.dataGridView1_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_show_CellContentClick);
            // 
            // btn_checkTo
            // 
            this.btn_checkTo.BackColor = System.Drawing.Color.Silver;
            this.btn_checkTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkTo.Location = new System.Drawing.Point(559, 345);
            this.btn_checkTo.Name = "btn_checkTo";
            this.btn_checkTo.Size = new System.Drawing.Size(67, 36);
            this.btn_checkTo.TabIndex = 5;
            this.btn_checkTo.Text = "GO";
            this.btn_checkTo.UseVisualStyleBackColor = false;
            this.btn_checkTo.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 265);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_checkFrom
            // 
            this.btn_checkFrom.BackColor = System.Drawing.Color.Silver;
            this.btn_checkFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkFrom.Location = new System.Drawing.Point(244, 346);
            this.btn_checkFrom.Name = "btn_checkFrom";
            this.btn_checkFrom.Size = new System.Drawing.Size(67, 36);
            this.btn_checkFrom.TabIndex = 7;
            this.btn_checkFrom.Text = "GO";
            this.btn_checkFrom.UseVisualStyleBackColor = false;
            this.btn_checkFrom.Click += new System.EventHandler(this.btn_checkFrom_Click_1);
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.Silver;
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(382, 689);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(100, 34);
            this.btn_purchase.TabIndex = 8;
            this.btn_purchase.Text = "NEXT";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // radioButton1_fc
            // 
            this.radioButton1_fc.AutoSize = true;
            this.radioButton1_fc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1_fc.Location = new System.Drawing.Point(61, 450);
            this.radioButton1_fc.Name = "radioButton1_fc";
            this.radioButton1_fc.Size = new System.Drawing.Size(137, 24);
            this.radioButton1_fc.TabIndex = 9;
            this.radioButton1_fc.TabStop = true;
            this.radioButton1_fc.Text = "first - class seat";
            this.radioButton1_fc.UseVisualStyleBackColor = true;
            this.radioButton1_fc.CheckedChanged += new System.EventHandler(this.radioButton1_fc_CheckedChanged);
            // 
            // radioButton1_coach
            // 
            this.radioButton1_coach.AutoSize = true;
            this.radioButton1_coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1_coach.Location = new System.Drawing.Point(217, 450);
            this.radioButton1_coach.Name = "radioButton1_coach";
            this.radioButton1_coach.Size = new System.Drawing.Size(105, 24);
            this.radioButton1_coach.TabIndex = 10;
            this.radioButton1_coach.TabStop = true;
            this.radioButton1_coach.Text = "coach seat";
            this.radioButton1_coach.UseVisualStyleBackColor = true;
            this.radioButton1_coach.CheckedChanged += new System.EventHandler(this.radioButton1_coach_CheckedChanged);
            // 
            // label1_seat
            // 
            this.label1_seat.AutoSize = true;
            this.label1_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_seat.Location = new System.Drawing.Point(58, 410);
            this.label1_seat.Name = "label1_seat";
            this.label1_seat.Size = new System.Drawing.Size(147, 18);
            this.label1_seat.TabIndex = 11;
            this.label1_seat.Text = "Choose the seat : ";
            // 
            // label1_number
            // 
            this.label1_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_number.Location = new System.Drawing.Point(379, 410);
            this.label1_number.Name = "label1_number";
            this.label1_number.Size = new System.Drawing.Size(166, 23);
            this.label1_number.TabIndex = 12;
            this.label1_number.Text = "Numbers of tickets :";
            // 
            // textBox1_numbers
            // 
            this.textBox1_numbers.Location = new System.Drawing.Point(382, 436);
            this.textBox1_numbers.Name = "textBox1_numbers";
            this.textBox1_numbers.Size = new System.Drawing.Size(147, 20);
            this.textBox1_numbers.TabIndex = 13;
            this.textBox1_numbers.TextChanged += new System.EventHandler(this.textBox1_numbers_TextChanged);
            // 
            // Form1_reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(687, 784);
            this.Controls.Add(this.textBox1_numbers);
            this.Controls.Add(this.label1_number);
            this.Controls.Add(this.label1_seat);
            this.Controls.Add(this.radioButton1_coach);
            this.Controls.Add(this.radioButton1_fc);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_checkFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_checkTo);
            this.Controls.Add(this.dataGridView1_show);
            this.Controls.Add(this.textBox2_to);
            this.Controls.Add(this.label1_destination);
            this.Controls.Add(this.textBox1_from);
            this.Controls.Add(this.label1_origin);
            this.Name = "Form1_reserve";
            this.Text = "Flight Check";
            this.Load += new System.EventHandler(this.Form1_reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_origin;
        private System.Windows.Forms.TextBox textBox1_from;
        private System.Windows.Forms.Label label1_destination;
        private System.Windows.Forms.TextBox textBox2_to;
        private System.Windows.Forms.DataGridView dataGridView1_show;
        private System.Windows.Forms.Button btn_checkTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_checkFrom;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.RadioButton radioButton1_fc;
        private System.Windows.Forms.RadioButton radioButton1_coach;
        private System.Windows.Forms.Label label1_seat;
        private System.Windows.Forms.Label label1_number;
        private System.Windows.Forms.TextBox textBox1_numbers;
    }
}

