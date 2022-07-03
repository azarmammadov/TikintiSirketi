
namespace Tikinti_Sirketi
{
    partial class tikintimqiy
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnbarM = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.malnNovu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnbarM)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(716, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tikinti Materiallarına baxış";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 64;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tikinti Şirkəti";
            // 
            // AnbarM
            // 
            this.AnbarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnbarM.Location = new System.Drawing.Point(12, 158);
            this.AnbarM.Name = "AnbarM";
            this.AnbarM.RowTemplate.Height = 25;
            this.AnbarM.Size = new System.Drawing.Size(953, 340);
            this.AnbarM.TabIndex = 62;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(163, 129);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(376, 3);
            this.panel10.TabIndex = 227;
            // 
            // malnNovu
            // 
            this.malnNovu.BackColor = System.Drawing.Color.Lime;
            this.malnNovu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.malnNovu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.malnNovu.Location = new System.Drawing.Point(163, 106);
            this.malnNovu.Name = "malnNovu";
            this.malnNovu.Size = new System.Drawing.Size(376, 19);
            this.malnNovu.TabIndex = 226;
            this.malnNovu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.malnNovu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(163, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 225;
            this.label3.Text = "Materialın növü";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(566, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 30);
            this.button3.TabIndex = 228;
            this.button3.Text = "Axtar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tikintimqiy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(977, 509);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.malnNovu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnbarM);
            this.Name = "tikintimqiy";
            this.Text = "tikintimqiy";
            this.Load += new System.EventHandler(this.tikintimqiy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnbarM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AnbarM;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox malnNovu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}