namespace Dynamite
{
    partial class MainMenu
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
            this.btnLocalGame = new System.Windows.Forms.Button();
            this.btnLanMode = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLocalGame
            // 
            this.btnLocalGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLocalGame.AutoSize = true;
            this.btnLocalGame.Location = new System.Drawing.Point(105, 110);
            this.btnLocalGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLocalGame.Name = "btnLocalGame";
            this.btnLocalGame.Size = new System.Drawing.Size(192, 39);
            this.btnLocalGame.TabIndex = 0;
            this.btnLocalGame.Text = "Play locally";
            this.btnLocalGame.UseVisualStyleBackColor = true;
            this.btnLocalGame.Click += new System.EventHandler(this.btnLocalGame_Click);
            // 
            // btnLanMode
            // 
            this.btnLanMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLanMode.AutoSize = true;
            this.btnLanMode.Location = new System.Drawing.Point(105, 150);
            this.btnLanMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLanMode.Name = "btnLanMode";
            this.btnLanMode.Size = new System.Drawing.Size(192, 39);
            this.btnLanMode.TabIndex = 1;
            this.btnLanMode.Text = "Play online";
            this.btnLanMode.UseVisualStyleBackColor = true;
            this.btnLanMode.Click += new System.EventHandler(this.btnLanMode_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(118, 69);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(169, 39);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Dynamite";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 260);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnLanMode);
            this.Controls.Add(this.btnLocalGame);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalGame;
        private System.Windows.Forms.Button btnLanMode;
        private System.Windows.Forms.Label lbTitle;
    }
}