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
        private SysUpdateConfig _sysUpdateCofig;
        public Uploader()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _sysUpdateCofig = GetSysUpdateConfig();
            txtDllFilesPath.Text = _baseDirectory + "UpgradeFiles\\";
            txtWebPath.Text = _sysUpdateCofig.Config.UpdatePath;

        }

        private SysUpdateConfig GetSysUpdateConfig()
        {
            using(var stream = File.OpenRead(_baseDirectory + "UpgradeConfig.xml"))
            {
                return XmlHelper.Deserialize<SysUpdateConfig>(stream);
            }

        }
        private void UpdateDllFiles()
        {
            string[] files = Directory.GetFiles(this.txtDllFilesPath.Text);

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

            using(var fileStream=new FileStream(_baseDirectory + "UpgradeConfig.xml", FileMode.Create))
            {
                XmlHelper.Serialize(fileStream, _sysUpdateCofig);
            }

        }

        #region 事件方法
        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDllFilesPath.Text = fbd.SelectedPath;
            }
        }

        private void btnRefreshConfigFile_Click(object sender, EventArgs e)
        {
            if (txtDllFilesPath.Text != "")
            {
                UpdateDllFiles();
                MessageBox.Show("刷新成功!");
            }
            else
            {
                MessageBox.Show("路径不能为空!", "提示");
            }
        }
        #endregion
    }
}
