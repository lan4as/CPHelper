﻿namespace CPHelper
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDirectoryCopy1 = new CPHelper.ucHelper.ucDirectoryCopy();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucDailyWork1 = new CPHelper.ucHelper.ucDailyWork();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDirectoryCopy1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Directory Copy&Paste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDirectoryCopy1
            // 
            this.ucDirectoryCopy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDirectoryCopy1.Location = new System.Drawing.Point(3, 3);
            this.ucDirectoryCopy1.Name = "ucDirectoryCopy1";
            this.ucDirectoryCopy1.Size = new System.Drawing.Size(895, 667);
            this.ucDirectoryCopy1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucDailyWork1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OneDay Work";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucDailyWork1
            // 
            this.ucDailyWork1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDailyWork1.Location = new System.Drawing.Point(3, 3);
            this.ucDailyWork1.Name = "ucDailyWork1";
            this.ucDailyWork1.Size = new System.Drawing.Size(914, 464);
            this.ucDailyWork1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ucHelper.ucDirectoryCopy ucDirectoryCopy1;
        private ucHelper.ucDailyWork ucDailyWork1;
    }
}

