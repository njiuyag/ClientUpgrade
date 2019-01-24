using System.Windows.Forms;

namespace ClientUpgrade.WinfromUpdater
{
    partial class Updater
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.gbUpgradeInfo = new System.Windows.Forms.GroupBox();
            this.gbUpdateContent = new System.Windows.Forms.GroupBox();
            this.lbUpdateContent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.btnStartUpdate = new System.Windows.Forms.Button();
            this.gbUpgradeInfo.SuspendLayout();
            this.gbUpdateContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUpgradeInfo
            // 
            this.gbUpgradeInfo.Controls.Add(this.btnStartUpdate);
            this.gbUpgradeInfo.Controls.Add(this.pbUpdate);
            this.gbUpgradeInfo.Controls.Add(this.label2);
            this.gbUpgradeInfo.Controls.Add(this.label1);
            this.gbUpgradeInfo.Controls.Add(this.gbUpdateContent);
            this.gbUpgradeInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbUpgradeInfo.Location = new System.Drawing.Point(12, 12);
            this.gbUpgradeInfo.Name = "gbUpgradeInfo";
            this.gbUpgradeInfo.Size = new System.Drawing.Size(345, 301);
            this.gbUpgradeInfo.TabIndex = 0;
            this.gbUpgradeInfo.TabStop = false;
            this.gbUpgradeInfo.Text = "升级信息";
            // 
            // gbUpdateContent
            // 
            this.gbUpdateContent.Controls.Add(this.lbUpdateContent);
            this.gbUpdateContent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbUpdateContent.Location = new System.Drawing.Point(6, 22);
            this.gbUpdateContent.Name = "gbUpdateContent";
            this.gbUpdateContent.Size = new System.Drawing.Size(333, 119);
            this.gbUpdateContent.TabIndex = 0;
            this.gbUpdateContent.TabStop = false;
            this.gbUpdateContent.Text = "更新内容";
            // 
            // lbUpdateContent
            // 
            this.lbUpdateContent.FormattingEnabled = true;
            this.lbUpdateContent.ItemHeight = 12;
            this.lbUpdateContent.Location = new System.Drawing.Point(6, 22);
            this.lbUpdateContent.Name = "lbUpdateContent";
            this.lbUpdateContent.Size = new System.Drawing.Size(321, 88);
            this.lbUpdateContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "正在下载更新";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "更新进度";
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(12, 209);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(321, 23);
            this.pbUpdate.TabIndex = 3;
            // 
            // btnStartUpdate
            // 
            this.btnStartUpdate.Location = new System.Drawing.Point(213, 254);
            this.btnStartUpdate.Name = "btnStartUpdate";
            this.btnStartUpdate.Size = new System.Drawing.Size(89, 25);
            this.btnStartUpdate.TabIndex = 4;
            this.btnStartUpdate.Text = "开始升级";
            this.btnStartUpdate.UseVisualStyleBackColor = true;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 325);
            this.Controls.Add(this.gbUpgradeInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线升级";
            this.gbUpgradeInfo.ResumeLayout(false);
            this.gbUpgradeInfo.PerformLayout();
            this.gbUpdateContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbUpgradeInfo;
        private GroupBox gbUpdateContent;
        private Button btnStartUpdate;
        private ProgressBar pbUpdate;
        private Label label2;
        private Label label1;
        private ListBox lbUpdateContent;
    }
}

