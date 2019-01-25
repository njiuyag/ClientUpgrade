using ClientUpgrade.WinformUploader.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUpgrade.WinfromUpdater
{
    public partial class Updater : Form
    {
        private string updatePath;
        private string updateWay;
        private HttpClient httpClient;
        private SysUpdateConfig serverSysUpdateConfig;
        private SysUpdateConfig localSysUpdateConfig;
        public Updater(string updatePath, string updateWay)
        {
            InitializeComponent();
            this.updatePath = updatePath;
            this.updateWay = updateWay;
            httpClient = new HttpClient();
        }

        private void LoadFileList()
        {
            lbUpdateContent.Items.Clear();
            var stream = httpClient.GetStreamAsync(updatePath + "UpgradeConfig.xml").Result;
            serverSysUpdateConfig = XmlHelper.Deserialize<SysUpdateConfig>(stream);
            if (!File.Exists("UpgradeConfig.xml"))
            {
                updateWay = "2";
            }
            else
            {
                using(var fileStream=new FileStream("UpgradeConfig.xml", FileMode.Open))
                {
                    localSysUpdateConfig = XmlHelper.Deserialize<SysUpdateConfig>(fileStream);
                }
            }
            //获取服务端更新文件列表
            //    System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(updatePath + "UpgradeConfig.xml");
            //    System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
            //    System.IO.Stream st = myrp.GetResponseStream();
            //    XmlDocument doc = new XmlDocument();
            //    XmlDocument docLocal = new XmlDocument();
            //    doc.Load(st);
            //    st.Close();
            //    if (!File.Exists("UpgradeConfig.xml"))
            //    {
            //        this.UpdateWay = "2";
            //    }
            //    else
            //    {
            //        docLocal.Load("UpgradeConfig.xml");
            //    }
            //    switch (this.UpdateWay)
            //    {
            //        case "0":
            //            {

            //                foreach (XmlNode node in doc.GetElementsByTagName("UpdateFiles")[0].ChildNodes)
            //                {
            //                    foreach (XmlNode nodeLocal in docLocal.GetElementsByTagName("UpdateFiles")[0].ChildNodes)
            //                    {
            //                        if (node.Attributes[0].Value == nodeLocal.Attributes[0].Value)
            //                        {
            //                            if (node.Attributes[1].Value != nodeLocal.Attributes[1].Value)
            //                            {
            //                                string FILENAME = node.Attributes[0].Value;
            //                                this.lboxUpdateList.Items.Add(FILENAME);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //            break;
            //        case "1":
            //            {
            //                foreach (XmlNode node in doc.GetElementsByTagName("UpdateFiles")[0].ChildNodes)
            //                {
            //                    foreach (XmlNode nodeLocal in docLocal.GetElementsByTagName("UpdateFiles")[0].ChildNodes)
            //                    {
            //                        if (node.Attributes[0].Value == nodeLocal.Attributes[0].Value)
            //                        {
            //                            if (node.Attributes[4].Value != nodeLocal.Attributes[4].Value)
            //                            {
            //                                string FILENAME = node.Attributes[0].Value;
            //                                this.lboxUpdateList.Items.Add(FILENAME);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //            break;

            //        case "2":
            //            {
            //                foreach (XmlNode node in doc.GetElementsByTagName("UpdateFiles")[0].ChildNodes)
            //                {
            //                    string FILENAME = node.Attributes[0].Value;
            //                    this.lboxUpdateList.Items.Add(FILENAME);
            //                }
            //            }
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message); ;
            //}
        }
    }
}
