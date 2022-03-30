
namespace Polymorphizm
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
            this.btnEt = new System.Windows.Forms.Button();
            this.btnSebze = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEt
            // 
            this.btnEt.Location = new System.Drawing.Point(81, 74);
            this.btnEt.Name = "btnEt";
            this.btnEt.Size = new System.Drawing.Size(100, 23);
            this.btnEt.TabIndex = 0;
            this.btnEt.Text = "Et Yemekleri";
            this.btnEt.UseVisualStyleBackColor = true;
            this.btnEt.Click += new System.EventHandler(this.btnEt_Click);
            // 
            // btnSebze
            // 
            this.btnSebze.Location = new System.Drawing.Point(218, 74);
            this.btnSebze.Name = "btnSebze";
            this.btnSebze.Size = new System.Drawing.Size(116, 23);
            this.btnSebze.TabIndex = 1;
            this.btnSebze.Text = "Sebze Yemeklei";
            this.btnSebze.UseVisualStyleBackColor = true;
            this.btnSebze.Click += new System.EventHandler(this.btnSebze_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(374, 74);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(113, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara sıcaklar";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSebze);
            this.Controls.Add(this.btnEt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEt;
        private System.Windows.Forms.Button btnSebze;
        private System.Windows.Forms.Button btnAra;
    }
}

