﻿
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ユーザToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_del = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(170, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "入室";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button2.Location = new System.Drawing.Point(358, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "退室";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(179, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(-4, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(706, 100);
            this.label2.TabIndex = 3;
            this.label2.Text = "おはようございます！";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ユーザToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ユーザToolStripMenuItem
            // 
            this.ユーザToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add,
            this.Menu_del});
            this.ユーザToolStripMenuItem.Name = "ユーザToolStripMenuItem";
            this.ユーザToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.ユーザToolStripMenuItem.Text = "ユーザ";
            // 
            // menu_add
            // 
            this.menu_add.Name = "menu_add";
            this.menu_add.Size = new System.Drawing.Size(164, 26);
            this.menu_add.Text = "部員の追加";
            this.menu_add.Click += new System.EventHandler(this.menu_add_Click);
            // 
            // Menu_del
            // 
            this.Menu_del.Name = "Menu_del";
            this.Menu_del.Size = new System.Drawing.Size(164, 26);
            this.Menu_del.Text = "部員の削除";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ユーザToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_add;
        private System.Windows.Forms.ToolStripMenuItem Menu_del;
    }
}

