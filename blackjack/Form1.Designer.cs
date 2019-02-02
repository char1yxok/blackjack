namespace blackjack
{
    partial class GameBoard
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.CroupierCard1 = new System.Windows.Forms.TextBox();
            this.CroupierCard2 = new System.Windows.Forms.TextBox();
            this.PlayerCard2 = new System.Windows.Forms.TextBox();
            this.PlayerCard1 = new System.Windows.Forms.TextBox();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.CroupierName = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerResult = new System.Windows.Forms.Label();
            this.CroupierResult = new System.Windows.Forms.Label();
            this.CroupierLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CroupierCard1
            // 
            this.CroupierCard1.BackColor = System.Drawing.Color.LightBlue;
            this.CroupierCard1.Enabled = false;
            this.CroupierCard1.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CroupierCard1.Location = new System.Drawing.Point(124, 37);
            this.CroupierCard1.Name = "CroupierCard1";
            this.CroupierCard1.ReadOnly = true;
            this.CroupierCard1.Size = new System.Drawing.Size(75, 47);
            this.CroupierCard1.TabIndex = 0;
            this.CroupierCard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CroupierCard2
            // 
            this.CroupierCard2.BackColor = System.Drawing.Color.DarkCyan;
            this.CroupierCard2.Enabled = false;
            this.CroupierCard2.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CroupierCard2.Location = new System.Drawing.Point(205, 37);
            this.CroupierCard2.Name = "CroupierCard2";
            this.CroupierCard2.ReadOnly = true;
            this.CroupierCard2.Size = new System.Drawing.Size(75, 47);
            this.CroupierCard2.TabIndex = 1;
            this.CroupierCard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.BackColor = System.Drawing.Color.LightBlue;
            this.PlayerCard2.Enabled = false;
            this.PlayerCard2.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayerCard2.Location = new System.Drawing.Point(205, 149);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.ReadOnly = true;
            this.PlayerCard2.Size = new System.Drawing.Size(75, 47);
            this.PlayerCard2.TabIndex = 2;
            this.PlayerCard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackColor = System.Drawing.Color.LightBlue;
            this.PlayerCard1.Enabled = false;
            this.PlayerCard1.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayerCard1.Location = new System.Drawing.Point(124, 149);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.ReadOnly = true;
            this.PlayerCard1.Size = new System.Drawing.Size(75, 47);
            this.PlayerCard1.TabIndex = 3;
            this.PlayerCard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HitButton
            // 
            this.HitButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HitButton.Location = new System.Drawing.Point(31, 287);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(101, 48);
            this.HitButton.TabIndex = 4;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StandButton.Location = new System.Drawing.Point(138, 287);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(101, 48);
            this.StandButton.TabIndex = 5;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // CroupierName
            // 
            this.CroupierName.AutoSize = true;
            this.CroupierName.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CroupierName.Location = new System.Drawing.Point(27, 51);
            this.CroupierName.Name = "CroupierName";
            this.CroupierName.Size = new System.Drawing.Size(78, 20);
            this.CroupierName.TabIndex = 7;
            this.CroupierName.Text = "Croupier";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayerName.Location = new System.Drawing.Point(36, 162);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(61, 20);
            this.PlayerName.TabIndex = 8;
            this.PlayerName.Text = "Player";
            // 
            // PlayerResult
            // 
            this.PlayerResult.AutoSize = true;
            this.PlayerResult.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerResult.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayerResult.Location = new System.Drawing.Point(51, 219);
            this.PlayerResult.Name = "PlayerResult";
            this.PlayerResult.Size = new System.Drawing.Size(22, 24);
            this.PlayerResult.TabIndex = 9;
            this.PlayerResult.Text = "0";
            // 
            // CroupierResult
            // 
            this.CroupierResult.AutoSize = true;
            this.CroupierResult.BackColor = System.Drawing.SystemColors.Control;
            this.CroupierResult.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CroupierResult.Location = new System.Drawing.Point(51, 98);
            this.CroupierResult.Name = "CroupierResult";
            this.CroupierResult.Size = new System.Drawing.Size(22, 24);
            this.CroupierResult.TabIndex = 10;
            this.CroupierResult.Text = "0";
            // 
            // CroupierLabel
            // 
            this.CroupierLabel.AutoSize = true;
            this.CroupierLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CroupierLabel.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CroupierLabel.Location = new System.Drawing.Point(110, 98);
            this.CroupierLabel.Name = "CroupierLabel";
            this.CroupierLabel.Size = new System.Drawing.Size(0, 24);
            this.CroupierLabel.TabIndex = 11;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerLabel.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayerLabel.Location = new System.Drawing.Point(110, 219);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(0, 24);
            this.PlayerLabel.TabIndex = 12;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 379);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.CroupierLabel);
            this.Controls.Add(this.CroupierResult);
            this.Controls.Add(this.PlayerResult);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.CroupierName);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.CroupierCard2);
            this.Controls.Add(this.CroupierCard1);
            this.Name = "GameBoard";
            this.Text = "BlackJackGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameBoard_FormClosed);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CroupierCard1;
        private System.Windows.Forms.TextBox CroupierCard2;
        private System.Windows.Forms.TextBox PlayerCard2;
        private System.Windows.Forms.TextBox PlayerCard1;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Label CroupierName;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerResult;
        private System.Windows.Forms.Label CroupierResult;
        private System.Windows.Forms.Label CroupierLabel;
        private System.Windows.Forms.Label PlayerLabel;
    }
}

