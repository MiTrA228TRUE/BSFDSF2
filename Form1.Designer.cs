namespace BSFDSF2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.num_first = new System.Windows.Forms.NumericUpDown();
            this.num_end = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_end)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(303, 13);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(485, 342);
            this.dgv.TabIndex = 0;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(16, 361);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(263, 77);
            this.bt.TabIndex = 1;
            this.bt.Text = "ЗАПУСК";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(13, 13);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(27, 13);
            this.lb.TabIndex = 2;
            this.lb.Text = "BFS";
            // 
            // num_first
            // 
            this.num_first.Location = new System.Drawing.Point(159, 309);
            this.num_first.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_first.Name = "num_first";
            this.num_first.Size = new System.Drawing.Size(120, 20);
            this.num_first.TabIndex = 3;
            // 
            // num_end
            // 
            this.num_end.Location = new System.Drawing.Point(159, 335);
            this.num_end.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_end.Name = "num_end";
            this.num_end.Size = new System.Drawing.Size(120, 20);
            this.num_end.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый элемент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Искомый элемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "РАЗМЕР";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(706, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(750, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 50);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(57, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Дейкстра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_end);
            this.Controls.Add(this.num_first);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.NumericUpDown num_first;
        private System.Windows.Forms.NumericUpDown num_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb2;
    }
}

