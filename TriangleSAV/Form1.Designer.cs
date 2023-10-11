
namespace TriangleSAV
{
    partial class TriangleForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForms));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottom = new System.Windows.Forms.TextBox();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.resbut = new System.Windows.Forms.Button();
            this.reslab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bottom
            // 
            this.bottom.Location = new System.Drawing.Point(321, 267);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(151, 20);
            this.bottom.TabIndex = 1;
            this.bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_KeyPress);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(189, 179);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(126, 20);
            this.left.TabIndex = 2;
            this.left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_KeyPress);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(478, 179);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(123, 20);
            this.right.TabIndex = 3;
            this.right.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_KeyPress);
            // 
            // resbut
            // 
            this.resbut.Location = new System.Drawing.Point(321, 293);
            this.resbut.Name = "resbut";
            this.resbut.Size = new System.Drawing.Size(151, 44);
            this.resbut.TabIndex = 4;
            this.resbut.Text = "Result!";
            this.resbut.UseVisualStyleBackColor = true;
            this.resbut.Click += new System.EventHandler(this.resbut_Click);
            // 
            // reslab
            // 
            this.reslab.AutoSize = true;
            this.reslab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reslab.Location = new System.Drawing.Point(316, 373);
            this.reslab.Name = "reslab";
            this.reslab.Size = new System.Drawing.Size(76, 25);
            this.reslab.TabIndex = 5;
            this.reslab.Text = "label1";
            this.reslab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriangleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reslab);
            this.Controls.Add(this.resbut);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TriangleForms";
            this.Text = "Треугольный вопрос";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bottom;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.Button resbut;
        private System.Windows.Forms.Label reslab;
    }
}

