
namespace WindowsFormsApp3
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学籍番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(176, 81);
            this.TxtBox2.Multiline = true;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(200, 25);
            this.TxtBox2.TabIndex = 2;
            // 
            // TxtBox1
            // 
            this.TxtBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtBox1.Location = new System.Drawing.Point(176, 40);
            this.TxtBox1.Multiline = true;
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.ShortcutsEnabled = false;
            this.TxtBox1.Size = new System.Drawing.Size(200, 25);
            this.TxtBox1.TabIndex = 3;
//            this.TxtBox1.TextChanged += new System.EventHandler(this.TxtBox1_TextChanged);
            this.TxtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox1_KeyPress);
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(221, 116);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 33);
            this.Btn.TabIndex = 4;
            this.Btn.Text = "追加";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Button button1;
    }
}