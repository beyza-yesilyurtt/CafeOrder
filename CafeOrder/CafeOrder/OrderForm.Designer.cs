namespace CafeOrder
{
    partial class OrderForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.colaMinusBtn = new System.Windows.Forms.Button();
            this.colaPlusBtn = new System.Windows.Forms.Button();
            this.colaNumLabel = new System.Windows.Forms.Label();
            this.colaLabel = new System.Windows.Forms.Label();
            this.coffeeMinusBtn = new System.Windows.Forms.Button();
            this.coffeePlusBtn = new System.Windows.Forms.Button();
            this.coffeeNumLabel = new System.Windows.Forms.Label();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.teaMinusBtn = new System.Windows.Forms.Button();
            this.teaPlusBtn = new System.Windows.Forms.Button();
            this.teaNumLabel = new System.Windows.Forms.Label();
            this.teaLabel = new System.Windows.Forms.Label();
            this.RESET = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGroupBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.orderGroupBox.Controls.Add(this.colaMinusBtn);
            this.orderGroupBox.Controls.Add(this.colaPlusBtn);
            this.orderGroupBox.Controls.Add(this.colaNumLabel);
            this.orderGroupBox.Controls.Add(this.colaLabel);
            this.orderGroupBox.Controls.Add(this.coffeeMinusBtn);
            this.orderGroupBox.Controls.Add(this.coffeePlusBtn);
            this.orderGroupBox.Controls.Add(this.coffeeNumLabel);
            this.orderGroupBox.Controls.Add(this.coffeeLabel);
            this.orderGroupBox.Controls.Add(this.teaMinusBtn);
            this.orderGroupBox.Controls.Add(this.teaPlusBtn);
            this.orderGroupBox.Controls.Add(this.teaNumLabel);
            this.orderGroupBox.Controls.Add(this.teaLabel);
            this.orderGroupBox.Location = new System.Drawing.Point(0, 0);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(326, 255);
            this.orderGroupBox.TabIndex = 0;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "ORDER";
            // 
            // colaMinusBtn
            // 
            this.colaMinusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colaMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colaMinusBtn.Location = new System.Drawing.Point(253, 144);
            this.colaMinusBtn.Name = "colaMinusBtn";
            this.colaMinusBtn.Size = new System.Drawing.Size(33, 33);
            this.colaMinusBtn.TabIndex = 11;
            this.colaMinusBtn.Text = "-";
            this.colaMinusBtn.UseVisualStyleBackColor = false;
            this.colaMinusBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // colaPlusBtn
            // 
            this.colaPlusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colaPlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colaPlusBtn.Location = new System.Drawing.Point(194, 144);
            this.colaPlusBtn.Name = "colaPlusBtn";
            this.colaPlusBtn.Size = new System.Drawing.Size(32, 33);
            this.colaPlusBtn.TabIndex = 10;
            this.colaPlusBtn.Text = "+";
            this.colaPlusBtn.UseVisualStyleBackColor = false;
            this.colaPlusBtn.Click += new System.EventHandler(this.colaPlusBtn_Click);
            // 
            // colaNumLabel
            // 
            this.colaNumLabel.AutoSize = true;
            this.colaNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.colaNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colaNumLabel.Location = new System.Drawing.Point(114, 148);
            this.colaNumLabel.Name = "colaNumLabel";
            this.colaNumLabel.Size = new System.Drawing.Size(23, 25);
            this.colaNumLabel.TabIndex = 9;
            this.colaNumLabel.Text = "0";
            // 
            // colaLabel
            // 
            this.colaLabel.AutoSize = true;
            this.colaLabel.BackColor = System.Drawing.Color.Lavender;
            this.colaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colaLabel.Location = new System.Drawing.Point(22, 148);
            this.colaLabel.Name = "colaLabel";
            this.colaLabel.Size = new System.Drawing.Size(53, 25);
            this.colaLabel.TabIndex = 8;
            this.colaLabel.Text = "Cola";
            // 
            // coffeeMinusBtn
            // 
            this.coffeeMinusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coffeeMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coffeeMinusBtn.Location = new System.Drawing.Point(253, 94);
            this.coffeeMinusBtn.Name = "coffeeMinusBtn";
            this.coffeeMinusBtn.Size = new System.Drawing.Size(33, 33);
            this.coffeeMinusBtn.TabIndex = 7;
            this.coffeeMinusBtn.Text = "-";
            this.coffeeMinusBtn.UseVisualStyleBackColor = false;
            this.coffeeMinusBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // coffeePlusBtn
            // 
            this.coffeePlusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coffeePlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coffeePlusBtn.Location = new System.Drawing.Point(194, 94);
            this.coffeePlusBtn.Name = "coffeePlusBtn";
            this.coffeePlusBtn.Size = new System.Drawing.Size(32, 33);
            this.coffeePlusBtn.TabIndex = 6;
            this.coffeePlusBtn.Text = "+";
            this.coffeePlusBtn.UseVisualStyleBackColor = false;
            this.coffeePlusBtn.Click += new System.EventHandler(this.coffeePlusBtn_Click);
            // 
            // coffeeNumLabel
            // 
            this.coffeeNumLabel.AutoSize = true;
            this.coffeeNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.coffeeNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coffeeNumLabel.Location = new System.Drawing.Point(114, 98);
            this.coffeeNumLabel.Name = "coffeeNumLabel";
            this.coffeeNumLabel.Size = new System.Drawing.Size(23, 25);
            this.coffeeNumLabel.TabIndex = 5;
            this.coffeeNumLabel.Text = "0";
            this.coffeeNumLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.AutoSize = true;
            this.coffeeLabel.BackColor = System.Drawing.Color.Lavender;
            this.coffeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coffeeLabel.Location = new System.Drawing.Point(22, 98);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(70, 25);
            this.coffeeLabel.TabIndex = 4;
            this.coffeeLabel.Text = "Coffee";
            this.coffeeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // teaMinusBtn
            // 
            this.teaMinusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.teaMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teaMinusBtn.Location = new System.Drawing.Point(253, 36);
            this.teaMinusBtn.Name = "teaMinusBtn";
            this.teaMinusBtn.Size = new System.Drawing.Size(33, 33);
            this.teaMinusBtn.TabIndex = 3;
            this.teaMinusBtn.Text = "-";
            this.teaMinusBtn.UseVisualStyleBackColor = false;
            this.teaMinusBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // teaPlusBtn
            // 
            this.teaPlusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.teaPlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teaPlusBtn.Location = new System.Drawing.Point(194, 36);
            this.teaPlusBtn.Name = "teaPlusBtn";
            this.teaPlusBtn.Size = new System.Drawing.Size(32, 33);
            this.teaPlusBtn.TabIndex = 2;
            this.teaPlusBtn.Text = "+";
            this.teaPlusBtn.UseVisualStyleBackColor = false;
            this.teaPlusBtn.Click += new System.EventHandler(this.teaPlusBtn_Click);
            // 
            // teaNumLabel
            // 
            this.teaNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teaNumLabel.AutoSize = true;
            this.teaNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.teaNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teaNumLabel.Location = new System.Drawing.Point(114, 41);
            this.teaNumLabel.Name = "teaNumLabel";
            this.teaNumLabel.Size = new System.Drawing.Size(23, 25);
            this.teaNumLabel.TabIndex = 1;
            this.teaNumLabel.Text = "0";
            this.teaNumLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // teaLabel
            // 
            this.teaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teaLabel.AutoSize = true;
            this.teaLabel.BackColor = System.Drawing.Color.Lavender;
            this.teaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teaLabel.Location = new System.Drawing.Point(22, 41);
            this.teaLabel.Name = "teaLabel";
            this.teaLabel.Size = new System.Drawing.Size(47, 25);
            this.teaLabel.TabIndex = 0;
            this.teaLabel.Text = "Tea";
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RESET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RESET.Location = new System.Drawing.Point(12, 289);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(87, 33);
            this.RESET.TabIndex = 1;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(143, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "CONFIRM ORDER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(374, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.orderGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OrderForm";
            this.Text = "Cafe Order Screen";
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Button teaPlusBtn;
        private System.Windows.Forms.Label teaNumLabel;
        private System.Windows.Forms.Label teaLabel;
        private System.Windows.Forms.Button teaMinusBtn;
        private System.Windows.Forms.Button colaMinusBtn;
        private System.Windows.Forms.Button colaPlusBtn;
        private System.Windows.Forms.Label colaNumLabel;
        private System.Windows.Forms.Label colaLabel;
        private System.Windows.Forms.Button coffeeMinusBtn;
        private System.Windows.Forms.Button coffeePlusBtn;
        private System.Windows.Forms.Label coffeeNumLabel;
        private System.Windows.Forms.Label coffeeLabel;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button button2;
    }
}

