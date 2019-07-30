namespace PRG455_PROJECT
{
    partial class Form2_purchase
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
            this.label1_custID = new System.Windows.Forms.Label();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.label1_fn = new System.Windows.Forms.Label();
            this.textBox2_fn = new System.Windows.Forms.TextBox();
            this.label1_ln = new System.Windows.Forms.Label();
            this.textBox1_ln = new System.Windows.Forms.TextBox();
            this.label1_tele = new System.Windows.Forms.Label();
            this.textBox2_tele = new System.Windows.Forms.TextBox();
            this.label1_address = new System.Windows.Forms.Label();
            this.textBox2_address = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.label1_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_custID
            // 
            this.label1_custID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_custID.Location = new System.Drawing.Point(37, 104);
            this.label1_custID.Name = "label1_custID";
            this.label1_custID.Size = new System.Drawing.Size(129, 23);
            this.label1_custID.TabIndex = 0;
            this.label1_custID.Text = "Customer ID :";
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(172, 105);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(153, 20);
            this.textBox1_ID.TabIndex = 1;
            this.textBox1_ID.TextChanged += new System.EventHandler(this.textBox1_ID_TextChanged);
            // 
            // label1_fn
            // 
            this.label1_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_fn.Location = new System.Drawing.Point(37, 158);
            this.label1_fn.Name = "label1_fn";
            this.label1_fn.Size = new System.Drawing.Size(129, 23);
            this.label1_fn.TabIndex = 2;
            this.label1_fn.Text = "First Name :";
            // 
            // textBox2_fn
            // 
            this.textBox2_fn.Location = new System.Drawing.Point(172, 158);
            this.textBox2_fn.Name = "textBox2_fn";
            this.textBox2_fn.Size = new System.Drawing.Size(153, 20);
            this.textBox2_fn.TabIndex = 3;
            this.textBox2_fn.TextChanged += new System.EventHandler(this.textBox2_fn_TextChanged);
            // 
            // label1_ln
            // 
            this.label1_ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_ln.Location = new System.Drawing.Point(37, 214);
            this.label1_ln.Name = "label1_ln";
            this.label1_ln.Size = new System.Drawing.Size(129, 23);
            this.label1_ln.TabIndex = 4;
            this.label1_ln.Text = "Last Name :";
            // 
            // textBox1_ln
            // 
            this.textBox1_ln.Location = new System.Drawing.Point(172, 215);
            this.textBox1_ln.Name = "textBox1_ln";
            this.textBox1_ln.Size = new System.Drawing.Size(153, 20);
            this.textBox1_ln.TabIndex = 5;
            this.textBox1_ln.TextChanged += new System.EventHandler(this.textBox1_ln_TextChanged);
            // 
            // label1_tele
            // 
            this.label1_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_tele.Location = new System.Drawing.Point(37, 273);
            this.label1_tele.Name = "label1_tele";
            this.label1_tele.Size = new System.Drawing.Size(129, 23);
            this.label1_tele.TabIndex = 6;
            this.label1_tele.Text = "Telephone :";
            // 
            // textBox2_tele
            // 
            this.textBox2_tele.Location = new System.Drawing.Point(172, 274);
            this.textBox2_tele.Name = "textBox2_tele";
            this.textBox2_tele.Size = new System.Drawing.Size(153, 20);
            this.textBox2_tele.TabIndex = 7;
            this.textBox2_tele.TextChanged += new System.EventHandler(this.textBox2_tele_TextChanged);
            // 
            // label1_address
            // 
            this.label1_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_address.Location = new System.Drawing.Point(37, 327);
            this.label1_address.Name = "label1_address";
            this.label1_address.Size = new System.Drawing.Size(129, 23);
            this.label1_address.TabIndex = 8;
            this.label1_address.Text = "Address :";
            // 
            // textBox2_address
            // 
            this.textBox2_address.Location = new System.Drawing.Point(172, 328);
            this.textBox2_address.Name = "textBox2_address";
            this.textBox2_address.Size = new System.Drawing.Size(153, 20);
            this.textBox2_address.TabIndex = 9;
            this.textBox2_address.TextChanged += new System.EventHandler(this.textBox2_address_TextChanged);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.Location = new System.Drawing.Point(56, 392);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(98, 37);
            this.btn_cancle.TabIndex = 10;
            this.btn_cancle.Text = "PREVIOUS";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(236, 392);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(89, 37);
            this.btn_purchase.TabIndex = 11;
            this.btn_purchase.Text = "PURCHASE";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // label1_info
            // 
            this.label1_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_info.Location = new System.Drawing.Point(25, 24);
            this.label1_info.Name = "label1_info";
            this.label1_info.Size = new System.Drawing.Size(240, 45);
            this.label1_info.TabIndex = 12;
            this.label1_info.Text = "Personal Information:";
            // 
            // Form2_purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(388, 492);
            this.Controls.Add(this.label1_info);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.textBox2_address);
            this.Controls.Add(this.label1_address);
            this.Controls.Add(this.textBox2_tele);
            this.Controls.Add(this.label1_tele);
            this.Controls.Add(this.textBox1_ln);
            this.Controls.Add(this.label1_ln);
            this.Controls.Add(this.textBox2_fn);
            this.Controls.Add(this.label1_fn);
            this.Controls.Add(this.textBox1_ID);
            this.Controls.Add(this.label1_custID);
            this.Name = "Form2_purchase";
            this.Text = "Flight Purchase";
            this.Load += new System.EventHandler(this.Form2_purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_custID;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.Label label1_fn;
        private System.Windows.Forms.TextBox textBox2_fn;
        private System.Windows.Forms.Label label1_ln;
        private System.Windows.Forms.TextBox textBox1_ln;
        private System.Windows.Forms.Label label1_tele;
        private System.Windows.Forms.TextBox textBox2_tele;
        private System.Windows.Forms.Label label1_address;
        private System.Windows.Forms.TextBox textBox2_address;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label label1_info;
    }
}