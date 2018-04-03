namespace AppUpdate
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvAndroid = new System.Windows.Forms.DataGridView();
            this.appMarketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appMarketCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minUpdateVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxUpdateVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvIOS = new System.Windows.Forms.DataGridView();
            this.appMarketName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appMarketCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minUpdateVer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxUpdateVer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downUrl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnDataSource = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAndroid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDataSource);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(965, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "重新加载";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "注：1.修改单元格的内容后，需失焦当前单元格，修改后的值才能被有效保存。\r\n    2.若数据无法序列化为Json格式，将提示错误且无法保存。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "一键保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 550);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvAndroid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Android";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvAndroid
            // 
            this.gvAndroid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAndroid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appMarketName,
            this.appMarketCode,
            this.minUpdateVer,
            this.maxUpdateVer,
            this.version,
            this.versionName,
            this.size,
            this.versionDescription,
            this.downUrl});
            this.gvAndroid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAndroid.Location = new System.Drawing.Point(3, 3);
            this.gvAndroid.Name = "gvAndroid";
            this.gvAndroid.RowTemplate.Height = 23;
            this.gvAndroid.Size = new System.Drawing.Size(1081, 518);
            this.gvAndroid.TabIndex = 0;
            // 
            // appMarketName
            // 
            this.appMarketName.DataPropertyName = "appMarketName";
            this.appMarketName.HeaderText = "名称";
            this.appMarketName.Name = "appMarketName";
            this.appMarketName.ReadOnly = true;
            this.appMarketName.Width = 80;
            // 
            // appMarketCode
            // 
            this.appMarketCode.DataPropertyName = "appMarketCode";
            this.appMarketCode.HeaderText = "标识";
            this.appMarketCode.Name = "appMarketCode";
            this.appMarketCode.ReadOnly = true;
            // 
            // minUpdateVer
            // 
            this.minUpdateVer.DataPropertyName = "minUpdateVer";
            this.minUpdateVer.HeaderText = "最小版本值";
            this.minUpdateVer.Name = "minUpdateVer";
            this.minUpdateVer.Width = 90;
            // 
            // maxUpdateVer
            // 
            this.maxUpdateVer.DataPropertyName = "maxUpdateVer";
            this.maxUpdateVer.HeaderText = "最大版本值";
            this.maxUpdateVer.Name = "maxUpdateVer";
            this.maxUpdateVer.Width = 90;
            // 
            // version
            // 
            this.version.DataPropertyName = "version";
            this.version.HeaderText = "版本号";
            this.version.Name = "version";
            this.version.Width = 70;
            // 
            // versionName
            // 
            this.versionName.DataPropertyName = "versionName";
            this.versionName.HeaderText = "版本名称";
            this.versionName.Name = "versionName";
            this.versionName.Width = 80;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "包大小";
            this.size.Name = "size";
            this.size.Width = 70;
            // 
            // versionDescription
            // 
            this.versionDescription.DataPropertyName = "versionDescription";
            this.versionDescription.HeaderText = "更新描述";
            this.versionDescription.Name = "versionDescription";
            this.versionDescription.Width = 350;
            // 
            // downUrl
            // 
            this.downUrl.DataPropertyName = "downUrl";
            this.downUrl.HeaderText = "下载地址";
            this.downUrl.Name = "downUrl";
            this.downUrl.Width = 350;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvIOS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1087, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvIOS
            // 
            this.gvIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appMarketName1,
            this.appMarketCode1,
            this.minUpdateVer1,
            this.maxUpdateVer1,
            this.version1,
            this.versionName1,
            this.size1,
            this.versionDescription1,
            this.downUrl1});
            this.gvIOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvIOS.Location = new System.Drawing.Point(3, 3);
            this.gvIOS.Name = "gvIOS";
            this.gvIOS.RowTemplate.Height = 23;
            this.gvIOS.Size = new System.Drawing.Size(1081, 518);
            this.gvIOS.TabIndex = 1;
            // 
            // appMarketName1
            // 
            this.appMarketName1.DataPropertyName = "appMarketName";
            this.appMarketName1.HeaderText = "名称";
            this.appMarketName1.Name = "appMarketName1";
            this.appMarketName1.ReadOnly = true;
            this.appMarketName1.Width = 80;
            // 
            // appMarketCode1
            // 
            this.appMarketCode1.DataPropertyName = "appMarketCode";
            this.appMarketCode1.HeaderText = "标识";
            this.appMarketCode1.Name = "appMarketCode1";
            this.appMarketCode1.ReadOnly = true;
            // 
            // minUpdateVer1
            // 
            this.minUpdateVer1.DataPropertyName = "minUpdateVer";
            this.minUpdateVer1.HeaderText = "最小版本值";
            this.minUpdateVer1.Name = "minUpdateVer1";
            this.minUpdateVer1.Width = 90;
            // 
            // maxUpdateVer1
            // 
            this.maxUpdateVer1.DataPropertyName = "maxUpdateVer";
            this.maxUpdateVer1.HeaderText = "最大版本值";
            this.maxUpdateVer1.Name = "maxUpdateVer1";
            this.maxUpdateVer1.Width = 90;
            // 
            // version1
            // 
            this.version1.DataPropertyName = "version";
            this.version1.HeaderText = "版本号";
            this.version1.Name = "version1";
            this.version1.Width = 70;
            // 
            // versionName1
            // 
            this.versionName1.DataPropertyName = "versionName";
            this.versionName1.HeaderText = "版本名称";
            this.versionName1.Name = "versionName1";
            this.versionName1.Width = 80;
            // 
            // size1
            // 
            this.size1.DataPropertyName = "size";
            this.size1.HeaderText = "包大小";
            this.size1.Name = "size1";
            this.size1.Width = 70;
            // 
            // versionDescription1
            // 
            this.versionDescription1.DataPropertyName = "versionDescription";
            this.versionDescription1.HeaderText = "更新描述";
            this.versionDescription1.Name = "versionDescription1";
            this.versionDescription1.Width = 350;
            // 
            // downUrl1
            // 
            this.downUrl1.DataPropertyName = "downUrl";
            this.downUrl1.HeaderText = "下载地址";
            this.downUrl1.Name = "downUrl1";
            this.downUrl1.Width = 380;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.xml)|*.xml";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(481, 14);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(206, 21);
            this.txtFile.TabIndex = 3;
            // 
            // btnDataSource
            // 
            this.btnDataSource.Location = new System.Drawing.Point(686, 13);
            this.btnDataSource.Name = "btnDataSource";
            this.btnDataSource.Size = new System.Drawing.Size(75, 23);
            this.btnDataSource.TabIndex = 4;
            this.btnDataSource.Text = "选择数据源";
            this.btnDataSource.UseVisualStyleBackColor = true;
            this.btnDataSource.Click += new System.EventHandler(this.btnDataSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP版本更新配置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAndroid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvAndroid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvIOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appMarketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appMarketCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn minUpdateVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxUpdateVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn downUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn appMarketName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appMarketCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minUpdateVer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxUpdateVer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn version1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn size1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDescription1;
        private System.Windows.Forms.DataGridViewTextBoxColumn downUrl1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDataSource;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

