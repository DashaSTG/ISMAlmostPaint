namespace WindowsFormsApp2
{
    partial class OOPDrawing
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
            this.buttonDrawing = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxShapes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawing
            // 
            this.buttonDrawing.Location = new System.Drawing.Point(48, 345);
            this.buttonDrawing.Name = "buttonDrawing";
            this.buttonDrawing.Size = new System.Drawing.Size(127, 41);
            this.buttonDrawing.TabIndex = 0;
            this.buttonDrawing.Text = "To draw";
            this.buttonDrawing.UseVisualStyleBackColor = true;
            this.buttonDrawing.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(209, 345);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 41);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(402, 392);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(164, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Шевчик Д.А. , КБ-19-2";
            // 
            // pictureBoxShapes
            // 
            this.pictureBoxShapes.Location = new System.Drawing.Point(43, 26);
            this.pictureBoxShapes.Name = "pictureBoxShapes";
            this.pictureBoxShapes.Size = new System.Drawing.Size(482, 291);
            this.pictureBoxShapes.TabIndex = 3;
            this.pictureBoxShapes.TabStop = false;
            // 
            // OOPDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 420);
            this.Controls.Add(this.pictureBoxShapes);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawing);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(594, 459);
            this.MinimumSize = new System.Drawing.Size(594, 459);
            this.Name = "OOPDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOPDrawing";
            this.Load += new System.EventHandler(this.OOPDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShapes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawing;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxShapes;
    }
}

