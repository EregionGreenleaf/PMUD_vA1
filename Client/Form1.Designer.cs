namespace Client
{
    partial class frmClient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtbBlocco = new System.Windows.Forms.RichTextBox();
            this.lblContatoreTick = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(547, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(99, 47);
            this.textBox1.TabIndex = 1;
            // 
            // rtbBlocco
            // 
            this.rtbBlocco.BackColor = System.Drawing.Color.Black;
            this.rtbBlocco.ForeColor = System.Drawing.Color.White;
            this.rtbBlocco.Location = new System.Drawing.Point(12, 12);
            this.rtbBlocco.Name = "rtbBlocco";
            this.rtbBlocco.ReadOnly = true;
            this.rtbBlocco.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbBlocco.Size = new System.Drawing.Size(517, 266);
            this.rtbBlocco.TabIndex = 2;
            this.rtbBlocco.Text = "";
            // 
            // lblContatoreTick
            // 
            this.lblContatoreTick.AutoSize = true;
            this.lblContatoreTick.BackColor = System.Drawing.Color.Gray;
            this.lblContatoreTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoreTick.ForeColor = System.Drawing.Color.White;
            this.lblContatoreTick.Location = new System.Drawing.Point(535, 102);
            this.lblContatoreTick.Name = "lblContatoreTick";
            this.lblContatoreTick.Size = new System.Drawing.Size(49, 20);
            this.lblContatoreTick.TabIndex = 3;
            this.lblContatoreTick.Text = "TEST";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(517, 22);
            this.textBox2.TabIndex = 4;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(694, 417);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblContatoreTick);
            this.Controls.Add(this.rtbBlocco);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClient";
            this.Text = "Client PMUD";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtbBlocco;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label lblContatoreTick;
    }
}

