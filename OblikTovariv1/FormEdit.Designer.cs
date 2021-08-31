namespace OblikTovariv1
{
    partial class FormEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtarticle = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(342, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.article,
            this.count,
            this.price,
            this.pricesum,
            this.position});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 89);
            this.dataGridView1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Місце розміщення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Кількість";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Код товару";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Назва";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(462, 274);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(90, 22);
            this.txtposition.TabIndex = 17;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(242, 274);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(90, 22);
            this.txtcount.TabIndex = 16;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(354, 274);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(90, 22);
            this.txtprice.TabIndex = 15;
            // 
            // txtarticle
            // 
            this.txtarticle.Location = new System.Drawing.Point(462, 205);
            this.txtarticle.Name = "txtarticle";
            this.txtarticle.Size = new System.Drawing.Size(90, 22);
            this.txtarticle.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(242, 205);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(171, 22);
            this.txtname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(115, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "Редагування запису";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "Найменування";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // article
            // 
            this.article.HeaderText = "Код товару";
            this.article.Name = "article";
            // 
            // count
            // 
            this.count.HeaderText = "Кількість";
            this.count.Name = "count";
            // 
            // price
            // 
            this.price.HeaderText = "Ціна";
            this.price.Name = "price";
            // 
            // pricesum
            // 
            this.pricesum.HeaderText = "Ціна (Сумарна)";
            this.pricesum.Name = "pricesum";
            // 
            // position
            // 
            this.position.HeaderText = "Місце розміщення";
            this.position.Name = "position";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtarticle);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormEdit";
            this.Text = "Облік товарів - Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtarticle;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesum;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
    }
}