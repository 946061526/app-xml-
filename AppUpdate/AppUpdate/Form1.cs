using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace AppUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string xmlPath = Path.Combine(Application.StartupPath, "AppUpdate.xml");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gvAndroid.AutoGenerateColumns = false;
            this.gvAndroid.AllowUserToResizeColumns = true;

            this.gvIOS.AutoGenerateColumns = false;
            this.gvIOS.AllowUserToResizeColumns = true;

            BindData();
        }

        private void BindData()
        {
            var data = new DataModel();
            var doc = new XmlDocument();
            try
            {
                if (File.Exists(xmlPath))
                {
                    doc.Load(xmlPath);
                    data = Tool.XmlDeserialize<DataModel>(doc.OuterXml);
                    if (data != null)
                    {
                        gvAndroid.DataSource = data.ItemsAndroid;
                        gvIOS.DataSource = data.ItemsIOS;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gvAndroid.Rows.Count == 0 && gvIOS.Rows.Count == 0)
                return;
            var tupleObj = this.GetDataModel();
            if (!tupleObj.Item2 || !Tool.IsJson(tupleObj.Item1))
            {
                MessageBox.Show("数据序列化Json失败，不能保存！");
                return;
            }
            try
            {
                bool b = Tool.Serialization(tupleObj.Item1, xmlPath);
                if (b)
                    MessageBox.Show("保存成功！");
                else
                    MessageBox.Show("保存失败！");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private Tuple<DataModel, bool> GetDataModel()
        {
            var dataModel = new DataModel();
            var itemList = new List<Item>();
            var check = true;
            var desc = string.Empty;
            //android
            foreach (DataGridViewRow dr in gvAndroid.Rows)
            {
                desc = dr.Cells["versionDescription"].Value.ToString();
                var descJson = Tool.IsJson(desc);
                if (descJson == "")
                {
                    check = false;
                    break;
                }
                var item = new Item()
                {
                    appMarketName = dr.Cells["appMarketName"].Value.ToString(),
                    appMarketCode = dr.Cells["appMarketCode"].Value.ToString(),
                    minUpdateVer = dr.Cells["minUpdateVer"].Value.ToString(),
                    maxUpdateVer = dr.Cells["maxUpdateVer"].Value.ToString(),
                    version = dr.Cells["version"].Value.ToString(),
                    versionName = dr.Cells["versionName"].Value.ToString(),
                    size = dr.Cells["size"].Value.ToString(),
                    versionDescription = descJson,
                    downUrl = dr.Cells["downUrl"].Value.ToString(),
                };
                itemList.Add(item);
            }
            dataModel.ItemsAndroid = itemList;

            //ios
            itemList = new List<Item>();
            foreach (DataGridViewRow dr in gvIOS.Rows)
            {
                desc = dr.Cells["versionDescription1"].Value.ToString();
                var descJson = Tool.IsJson(desc);
                if (descJson == "")
                {
                    check = false;
                    break;
                }
                var item = new Item()
                {
                    appMarketName = dr.Cells["appMarketName1"].Value.ToString(),
                    appMarketCode = dr.Cells["appMarketCode1"].Value.ToString(),
                    minUpdateVer = dr.Cells["minUpdateVer1"].Value.ToString(),
                    maxUpdateVer = dr.Cells["maxUpdateVer1"].Value.ToString(),
                    version = dr.Cells["version1"].Value.ToString(),
                    versionName = dr.Cells["versionName1"].Value.ToString(),
                    size = dr.Cells["size1"].Value.ToString(),
                    versionDescription = descJson,
                    downUrl = dr.Cells["downUrl1"].Value.ToString(),
                };
                itemList.Add(item);
            }
            dataModel.ItemsIOS = itemList;
            return new Tuple<DataModel, bool>(dataModel, check);
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDataSource_Click(object sender, EventArgs e)
        {
            //判断用户是否正确的选择了文件
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                xmlPath = txtFile.Text;
                BindData();
            }
        }
    }

}
