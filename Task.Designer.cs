
namespace TestTask
{
    partial class Task
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
            this.components = new System.ComponentModel.Container();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.tbReplicaPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnReplica = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbTick = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbSourcePath
            // 
            this.tbSourcePath.Location = new System.Drawing.Point(144, 34);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.ReadOnly = true;
            this.tbSourcePath.Size = new System.Drawing.Size(473, 20);
            this.tbSourcePath.TabIndex = 0;
            // 
            // tbReplicaPath
            // 
            this.tbReplicaPath.Location = new System.Drawing.Point(144, 72);
            this.tbReplicaPath.Name = "tbReplicaPath";
            this.tbReplicaPath.ReadOnly = true;
            this.tbReplicaPath.Size = new System.Drawing.Size(473, 20);
            this.tbReplicaPath.TabIndex = 1;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(35, 34);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(103, 22);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Источник";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnReplica
            // 
            this.btnReplica.Location = new System.Drawing.Point(35, 72);
            this.btnReplica.Name = "btnReplica";
            this.btnReplica.Size = new System.Drawing.Size(103, 22);
            this.btnReplica.TabIndex = 3;
            this.btnReplica.Text = "Реплика";
            this.btnReplica.UseVisualStyleBackColor = true;
            this.btnReplica.Click += new System.EventHandler(this.btnReplica_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(468, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Запустить \\ Остановить";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbTick
            // 
            this.tbTick.Location = new System.Drawing.Point(233, 106);
            this.tbTick.Name = "tbTick";
            this.tbTick.Size = new System.Drawing.Size(103, 20);
            this.tbTick.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 170);
            this.Controls.Add(this.tbTick);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnReplica);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.tbReplicaPath);
            this.Controls.Add(this.tbSourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.TextBox tbReplicaPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnReplica;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbTick;
        private System.Windows.Forms.Timer timer1;
    }
}

