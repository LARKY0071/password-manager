namespace Password_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.пароль1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пароль2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пароль3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пароль4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПаролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Менеджер паролей";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пароль1ToolStripMenuItem,
            this.пароль2ToolStripMenuItem,
            this.пароль3ToolStripMenuItem,
            this.пароль4ToolStripMenuItem,
            this.изменитьПаролиToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 158);
            // 
            // пароль1ToolStripMenuItem
            // 
            this.пароль1ToolStripMenuItem.Name = "пароль1ToolStripMenuItem";
            this.пароль1ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.пароль1ToolStripMenuItem.Text = "Пароль 1";
            this.пароль1ToolStripMenuItem.Click += new System.EventHandler(this.пароль1ToolStripMenuItem_Click);
            // 
            // пароль2ToolStripMenuItem
            // 
            this.пароль2ToolStripMenuItem.Name = "пароль2ToolStripMenuItem";
            this.пароль2ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.пароль2ToolStripMenuItem.Text = "Пароль 2";
            this.пароль2ToolStripMenuItem.Click += new System.EventHandler(this.пароль2ToolStripMenuItem_Click);
            // 
            // пароль3ToolStripMenuItem
            // 
            this.пароль3ToolStripMenuItem.Name = "пароль3ToolStripMenuItem";
            this.пароль3ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.пароль3ToolStripMenuItem.Text = "Пароль 3";
            this.пароль3ToolStripMenuItem.Click += new System.EventHandler(this.пароль3ToolStripMenuItem_Click);
            // 
            // пароль4ToolStripMenuItem
            // 
            this.пароль4ToolStripMenuItem.Name = "пароль4ToolStripMenuItem";
            this.пароль4ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.пароль4ToolStripMenuItem.Text = "Пароль 4";
            this.пароль4ToolStripMenuItem.Click += new System.EventHandler(this.пароль4ToolStripMenuItem_Click);
            // 
            // изменитьПаролиToolStripMenuItem
            // 
            this.изменитьПаролиToolStripMenuItem.Name = "изменитьПаролиToolStripMenuItem";
            this.изменитьПаролиToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.изменитьПаролиToolStripMenuItem.Text = "Изменить Пароли";
            this.изменитьПаролиToolStripMenuItem.Click += new System.EventHandler(this.изменитьПаролиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 159);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пароль1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пароль2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пароль3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пароль4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПаролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}