using ClientUpgrade.WinformUploader.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientUpgrade.WinformUploader
{
    public partial class Uploader : Form
    {
        private string _baseDirectory;
        private string _programFilePath;
        private string _upgradeConfigFilePath;
        private SysUpdateConfig _sysUpdateCofig;
        public Uploader()
        {
            InitializeComponent();
            InitializeValues();
        }
        public void InitializeValues()
        {
            _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _programFilePath = _baseDirectory + "UpgradeFiles\\";
            _upgradeConfigFilePath = _baseDirectory + "UpgradeConfig.xml";
            _sysUpdateCofig = GetSysUpdateConfig();
            txtProgramFilePath.Text = _programFilePath;
            txtUpdatePathOfClient.Text = _sysUpdateCofig.Config.UpdatePath;

        }

        private SysUpdateConfig GetSysUpdateConfig()
        {
            using(var stream = File.OpenRead(_baseDirectory + "UpgradeConfig.xml"))
            {
                return XmlHelper.Deserialize<SysUpdateConfig>(stream);
            }

        }

        private void SaveSysUpdateConfig()
        {
            using (var fileStream = new FileStream(_upgradeConfigFilePath, FileMode.Create))
            {
                XmlHelper.Serialize(fileStream, _sysUpdateCofig);
            }
        }

        private void UpdateProgramInfoToConfig ()
        {
            string[] files = Directory.GetFiles(txtProgramFilePath.Text);

            var dllFilesInfo = new List<SysUpdateConfigDllFile>();
            foreach (string file in files)
            {
                string versionStr = String.Empty;
                var fileExtension = Path.GetExtension(file);
                if (new string[] { ".DLL", ".EXE" }.Contains(fileExtension.ToUpper()))
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFile(file);
                        Version fileVersion = assembly.GetName().Version;
                        versionStr = fileVersion.ToString();
                    }
                    catch (Exception)
                    {
                        versionStr = "1.0.0.0";
                    }
                   
                    FileInfo fileInfo = new FileInfo(file);
                    
                    dllFilesInfo.Add(new SysUpdateConfigDllFile
                    {
                        CREATEDATE = string.Format("{0:G}", fileInfo.CreationTime),
                        FILELENGTH = fileInfo.Length.ToString(),
                        FILENAME = Path.GetFileName(file),
                        MODIFYDATE=string.Format("{0:G}",fileInfo.LastWriteTime),
                        VERSION=versionStr

                    });

                }
            }
            _sysUpdateCofig.UpdateFiles = dllFilesInfo.ToArray();

            SaveSysUpdateConfig();

        }

        private void UpdateVersion()
        {

            if (chkIsInformUpdate.Checked)
            {
                _sysUpdateCofig.Config.IsUpdate += 1;
            }

            _sysUpdateCofig.Config.UpdatePath = txtUpdatePathOfClient.Text;
            if (radioVersion.Checked)
            {
                _sysUpdateCofig.Config.UpdateWay = "0";
            }
            else if (radioTimestamp.Checked)
            {
                _sysUpdateCofig.Config.UpdateWay = "1";
            }
            else if (radioAllUpdate.Checked)
            {
                _sysUpdateCofig.Config.UpdateWay = "2";
            }

            SaveSysUpdateConfig();
        }

        #region 事件方法

        private void SelectProgramDirectory(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtProgramFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void RefreshProgramFileInfoInConfigFile(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProgramFilePath.Text))
            {
                UpdateProgramInfoToConfig();
                MessageBox.Show("刷新成功!");
            }
            else
            {
                MessageBox.Show("路径不能为空!", "提示");
            }
        }

        private void DisplayProgramDirectoryTip(object sender, EventArgs e)
        {
            ttpProgramDirectory.Show(txtProgramFilePath.Text, txtProgramFilePath, 10000);
        }

        private void Save(object sender,EventArgs e)
        {
            UpdateVersion();
            MessageBox.Show("保存成功", "成功");
        }
        private void Exit(object sender,EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
