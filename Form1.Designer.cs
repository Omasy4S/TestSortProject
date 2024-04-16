namespace MyProject
{
    partial class Form1
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.UpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.Box_Sorters = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(112, 40);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(280, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Визуализация сортировки";
            // 
            // UpDown_Quantity
            // 
            this.UpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Quantity.Location = new System.Drawing.Point(428, 79);
            this.UpDown_Quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpDown_Quantity.Maximum = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.UpDown_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_Quantity.Name = "UpDown_Quantity";
            this.UpDown_Quantity.Size = new System.Drawing.Size(84, 26);
            this.UpDown_Quantity.TabIndex = 1;
            this.UpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(399, 46);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(166, 20);
            this.lbl_Quantity.TabIndex = 2;
            this.lbl_Quantity.Text = "Количество колонок";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Generate.Location = new System.Drawing.Point(403, 126);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(139, 29);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Сформировать";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Sort.Location = new System.Drawing.Point(403, 243);
            this.btn_Sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(172, 26);
            this.btn_Sort.TabIndex = 4;
            this.btn_Sort.Text = "Способ сортировки";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // Box_Sorters
            // 
            this.Box_Sorters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Sorters.FormattingEnabled = true;
            this.Box_Sorters.Items.AddRange(new object[] {
            "Сортировка выборкой",
            "Сортировка вставкой"});
            this.Box_Sorters.Location = new System.Drawing.Point(403, 273);
            this.Box_Sorters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Box_Sorters.Name = "Box_Sorters";
            this.Box_Sorters.Size = new System.Drawing.Size(172, 28);
            this.Box_Sorters.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.Box_Sorters);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.UpDown_Quantity);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Visualized";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.NumericUpDown UpDown_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox Box_Sorters;
    }
}

