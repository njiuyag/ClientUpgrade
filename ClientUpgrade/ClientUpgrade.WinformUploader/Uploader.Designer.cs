namespace ClientUpgrade.WinformUploader
{
    partial class Uploader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploader));
            this.txtDllFilesPath = new System.Windows.Forms.TextBox();
            this.btnRefreshConfigFile = new System.Windows.Forms.Button();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.txtWebPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.chkIsUpdate = new System.Windows.Forms.CheckBox();
            this.gboxUpdate = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipPath = new System.Windows.Forms.ToolTip(this.components);
            this.gboxInfo.SuspendLayout();
            this.gboxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDllFilesPath
            // 
            this.txtDllFilesPath.Location = new System.Drawing.Point(21, 89);
            this.txtDllFilesPath.Name = "txtDllFilesPath";
            this.txtDllFilesPath.ReadOnly = true;
            this.txtDllFilesPath.Size = new System.Drawing.Size(403, 21);
            this.txtDllFilesPath.TabIndex = 0;
            // 
            // btnRefreshConfigFile
            // 
            this.btnRefreshConfigFile.ForeColor = System.Drawing.Color.Blue;
            this.btnRefreshConfigFile.Location = new System.Drawing.Point(333, 164);
            this.btnRefreshConfigFile.Name = "btnRefreshConfigFile";
            this.btnRefreshConfigFile.Size = new System.Drawing.Size(91, 26);
            this.btnRefreshConfigFile.TabIndex = 2;
            this.btnRefreshConfigFile.Text = "刷新配置文件";
            this.btnRefreshConfigFile.UseVisualStyleBackColor = true;
            this.btnRefreshConfigFile.Click += new System.EventHandler(this.btnRefreshConfigFile_Click);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(21, 49);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(74, 26);
            this.btnSelectDirectory.TabIndex = 3;
            this.btnSelectDirectory.Text = "选择目录";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(225, 307);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 36);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // gboxInfo
            // 
            this.gboxInfo.BackColor = System.Drawing.Color.Transparent;
            this.gboxInfo.Controls.Add(this.txtWebPath);
            this.gboxInfo.Controls.Add(this.label1);
            this.gboxInfo.Controls.Add(this.buttonClose);
            this.gboxInfo.Controls.Add(this.chkIsUpdate);
            this.gboxInfo.Controls.Add(this.gboxUpdate);
            this.gboxInfo.Controls.Add(this.label2);
            this.gboxInfo.Controls.Add(this.buttonSave);
            this.gboxInfo.Controls.Add(this.txtDllFilesPath);
            this.gboxInfo.Controls.Add(this.btnSelectDirectory);
            this.gboxInfo.Controls.Add(this.btnRefreshConfigFile);
            this.gboxInfo.Location = new System.Drawing.Point(17, 12);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Size = new System.Drawing.Size(444, 375);
            this.gboxInfo.TabIndex = 5;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "更新信息";
            // 
            // txtWebPath
            // 
            this.txtWebPath.Location = new System.Drawing.Point(24, 253);
            this.txtWebPath.Name = "txtWebPath";
            this.txtWebPath.Size = new System.Drawing.Size(400, 21);
            this.txtWebPath.TabIndex = 12;
            this.txtWebPath.Text = "http://wms.ecom-pl.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "客户端更新路径:";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(332, 307);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 36);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // chkIsUpdate
            // 
            this.chkIsUpdate.AutoSize = true;
            this.chkIsUpdate.Location = new System.Drawing.Point(24, 290);
            this.chkIsUpdate.Name = "chkIsUpdate";
            this.chkIsUpdate.Size = new System.Drawing.Size(108, 16);
            this.chkIsUpdate.TabIndex = 6;
            this.chkIsUpdate.Text = "通知客户端更新";
            this.chkIsUpdate.UseVisualStyleBackColor = true;
            // 
            // gboxUpdate
            // 
            this.gboxUpdate.Controls.Add(this.radioButton3);
            this.gboxUpdate.Controls.Add(this.radioButton2);
            this.gboxUpdate.Controls.Add(this.radioButton1);
            this.gboxUpdate.Location = new System.Drawing.Point(24, 144);
            this.gboxUpdate.Name = "gboxUpdate";
            this.gboxUpdate.Size = new System.Drawing.Size(293, 65);
            this.gboxUpdate.TabIndex = 9;
            this.gboxUpdate.TabStop = false;
            this.gboxUpdate.Text = "更新方式";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(179, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "全部更新";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "按时间戳";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "按版本号";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "注:选择需要更新程序的目录";
            // 
            // toolTipPath
            // 
            this.toolTipPath.AutomaticDelay = 0;
            this.toolTipPath.AutoPopDelay = 50000;
            this.toolTipPath.ForeColor = System.Drawing.Color.Red;
            this.toolTipPath.InitialDelay = 10;
            this.toolTipPath.ReshowDelay = 50000;
            this.toolTipPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPath.ToolTipTitle = "当前路径";
            // 
            // Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 398);
            this.Controls.Add(this.gboxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uploader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统更新配置";
            this.gboxInfo.ResumeLayout(false);
            this.gboxInfo.PerformLayout();
            this.gboxUpdate.ResumeLayout(false);
            this.gboxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDllFilesPath;
        private System.Windows.Forms.Button btnRefreshConfigFile;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipPath;
        private System.Windows.Forms.CheckBox chkIsUpdate;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gboxUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox txtWebPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

