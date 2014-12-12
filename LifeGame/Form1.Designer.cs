namespace LifeGame
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonRandomBehavior = new System.Windows.Forms.Button();
            this.buttonDefaultBehavior = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(64, 197);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(700, 12);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "暂停/开始";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonRandomBehavior
            // 
            this.buttonRandomBehavior.Location = new System.Drawing.Point(700, 41);
            this.buttonRandomBehavior.Name = "buttonRandomBehavior";
            this.buttonRandomBehavior.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomBehavior.TabIndex = 5;
            this.buttonRandomBehavior.Text = "随机行为";
            this.buttonRandomBehavior.UseVisualStyleBackColor = true;
            this.buttonRandomBehavior.Click += new System.EventHandler(this.buttonRandomBehavior_Click);
            // 
            // buttonDefaultBehavior
            // 
            this.buttonDefaultBehavior.Location = new System.Drawing.Point(619, 12);
            this.buttonDefaultBehavior.Name = "buttonDefaultBehavior";
            this.buttonDefaultBehavior.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultBehavior.TabIndex = 6;
            this.buttonDefaultBehavior.Text = "默认行为";
            this.buttonDefaultBehavior.UseVisualStyleBackColor = true;
            this.buttonDefaultBehavior.Click += new System.EventHandler(this.buttonDefaultBehavior_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(619, 41);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清理世界";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 576);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDefaultBehavior);
            this.Controls.Add(this.buttonRandomBehavior);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "生命游戏";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonRandomBehavior;
        private System.Windows.Forms.Button buttonDefaultBehavior;
        private System.Windows.Forms.Button buttonClear;
    }
}

