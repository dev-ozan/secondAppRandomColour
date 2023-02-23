
namespace WindowsFormsApp3
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.redText = new System.Windows.Forms.TextBox();
            this.blueText = new System.Windows.Forms.TextBox();
            this.greenText = new System.Windows.Forms.TextBox();
            this.btnKaristir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.Location = new System.Drawing.Point(134, 60);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(99, 70);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "Kirmizi";
            this.btnKirmizi.UseVisualStyleBackColor = true;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(313, 60);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(104, 70);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // redText
            // 
            this.redText.Location = new System.Drawing.Point(170, 165);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(207, 20);
            this.redText.TabIndex = 2;
            // 
            // blueText
            // 
            this.blueText.Location = new System.Drawing.Point(170, 204);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(207, 20);
            this.blueText.TabIndex = 3;
            // 
            // greenText
            // 
            this.greenText.Location = new System.Drawing.Point(170, 247);
            this.greenText.Name = "greenText";
            this.greenText.Size = new System.Drawing.Size(207, 20);
            this.greenText.TabIndex = 4;
            // 
            // btnKaristir
            // 
            this.btnKaristir.Location = new System.Drawing.Point(210, 316);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(104, 70);
            this.btnKaristir.TabIndex = 5;
            this.btnKaristir.Text = "karistir";
            this.btnKaristir.UseVisualStyleBackColor = true;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaristir);
            this.Controls.Add(this.greenText);
            this.Controls.Add(this.blueText);
            this.Controls.Add(this.redText);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.Text = "RandomColourAPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.TextBox redText;
        private System.Windows.Forms.TextBox blueText;
        private System.Windows.Forms.TextBox greenText;
        private System.Windows.Forms.Button btnKaristir;
    }
}

