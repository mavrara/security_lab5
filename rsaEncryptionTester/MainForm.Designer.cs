﻿namespace RSAEncryptionTester
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExponent = new System.Windows.Forms.TextBox();
            this.txtModulus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEncMsg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkShowData = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createKeyToolStripMenuItem,
            this.loadKeyToolStripMenuItem,
            this.loadPrivateKeyToolStripMenuItem,
            this.privateEncryptionToolStripMenuItem,
            this.publicDecryptionToolStripMenuItem,
            this.publicEncryptionToolStripMenuItem,
            this.privateDecryptionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.fileToolStripMenuItem.Text = "Головне меню";
            // 
            // createKeyToolStripMenuItem
            // 
            this.createKeyToolStripMenuItem.Name = "createKeyToolStripMenuItem";
            this.createKeyToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.createKeyToolStripMenuItem.Text = "Створити ключі";
            this.createKeyToolStripMenuItem.Click += new System.EventHandler(this.createKeyToolStripMenuItem_Click);
            // 
            // loadKeyToolStripMenuItem
            // 
            this.loadKeyToolStripMenuItem.Name = "loadKeyToolStripMenuItem";
            this.loadKeyToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.loadKeyToolStripMenuItem.Text = "Завантажити відкриті ключі";
            this.loadKeyToolStripMenuItem.Click += new System.EventHandler(this.loadKeyToolStripMenuItem_Click);
            // 
            // loadPrivateKeyToolStripMenuItem
            // 
            this.loadPrivateKeyToolStripMenuItem.Name = "loadPrivateKeyToolStripMenuItem";
            this.loadPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.loadPrivateKeyToolStripMenuItem.Text = "Завантажити закриті ключі";
            this.loadPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.loadKeyToolStripMenuItem_Click);
            // 
            // privateEncryptionToolStripMenuItem
            // 
            this.privateEncryptionToolStripMenuItem.Name = "privateEncryptionToolStripMenuItem";
            this.privateEncryptionToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.privateEncryptionToolStripMenuItem.Text = "Закрита шифрація";
            this.privateEncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // publicDecryptionToolStripMenuItem
            // 
            this.publicDecryptionToolStripMenuItem.Name = "publicDecryptionToolStripMenuItem";
            this.publicDecryptionToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.publicDecryptionToolStripMenuItem.Text = "Відкрита дешифрація";
            this.publicDecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // publicEncryptionToolStripMenuItem
            // 
            this.publicEncryptionToolStripMenuItem.Name = "publicEncryptionToolStripMenuItem";
            this.publicEncryptionToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.publicEncryptionToolStripMenuItem.Text = "Відкрита шифрація";
            this.publicEncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // privateDecryptionToolStripMenuItem
            // 
            this.privateDecryptionToolStripMenuItem.Name = "privateDecryptionToolStripMenuItem";
            this.privateDecryptionToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.privateDecryptionToolStripMenuItem.Text = "Закрита дешифрація";
            this.privateDecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // openKeyFileDialog
            // 
            this.openKeyFileDialog.Filter = "Key File|*.xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дані ключа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Експонента:";
            // 
            // txtExponent
            // 
            this.txtExponent.BackColor = System.Drawing.SystemColors.Window;
            this.txtExponent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExponent.Location = new System.Drawing.Point(132, 75);
            this.txtExponent.Margin = new System.Windows.Forms.Padding(4);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.Size = new System.Drawing.Size(379, 26);
            this.txtExponent.TabIndex = 2;
            this.txtExponent.TextChanged += new System.EventHandler(this.txtExponent_TextChanged);
            // 
            // txtModulus
            // 
            this.txtModulus.BackColor = System.Drawing.SystemColors.Window;
            this.txtModulus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtModulus.Location = new System.Drawing.Point(132, 110);
            this.txtModulus.Margin = new System.Windows.Forms.Padding(4);
            this.txtModulus.Multiline = true;
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.ReadOnly = true;
            this.txtModulus.Size = new System.Drawing.Size(899, 73);
            this.txtModulus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Модуль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(17, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повідомлення:";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMessage.Location = new System.Drawing.Point(132, 320);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(899, 26);
            this.txtMessage.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(40, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";
            // 
            // txtEncMsg
            // 
            this.txtEncMsg.BackColor = System.Drawing.SystemColors.Window;
            this.txtEncMsg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEncMsg.Location = new System.Drawing.Point(132, 354);
            this.txtEncMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncMsg.Multiline = true;
            this.txtEncMsg.Name = "txtEncMsg";
            this.txtEncMsg.Size = new System.Drawing.Size(899, 73);
            this.txtEncMsg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(16, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "D (приховане):";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.SystemColors.Window;
            this.txtD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtD.Location = new System.Drawing.Point(132, 191);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(899, 73);
            this.txtD.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(16, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Шифрування / Дешифрування";
            // 
            // chkShowData
            // 
            this.chkShowData.AutoSize = true;
            this.chkShowData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkShowData.Location = new System.Drawing.Point(132, 44);
            this.chkShowData.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowData.Name = "chkShowData";
            this.chkShowData.Size = new System.Drawing.Size(94, 22);
            this.chkShowData.TabIndex = 11;
            this.chkShowData.Text = "Показати";
            this.chkShowData.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 444);
            this.Controls.Add(this.chkShowData);
            this.Controls.Add(this.txtEncMsg);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtModulus);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtExponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Розробка програми керування ключами шифрування за схемою RSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openKeyFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExponent;
        private System.Windows.Forms.TextBox txtModulus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem loadPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateEncryptionToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEncMsg;
        private System.Windows.Forms.ToolStripMenuItem publicDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateDecryptionToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkShowData;
    }
}

