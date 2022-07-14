using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DXWorld查询器
{
    public partial class OfficeSel : DevExpress.XtraEditors.XtraForm
    {
        public OfficeSel()
        {
            InitializeComponent();
        }
        Thread thread;
        List<string> pathList = new List<string>();//存储集合，listBoxSel显示用
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        string[] docpath = null;//doc文件的路径数组
        string[] xlspath = null;//Excel文件的路径数组
        string[] docxpath = null;//docx文件的路径数组
        /// <summary>
        /// 打开浏览按钮记录路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pathList.Clear();
            listBoxSel.DataSource = null;
            XtraFolderBrowserDialog xtraFolderBrowserDialog = new XtraFolderBrowserDialog();
            xtraFolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; //目录初始化位置
            xtraFolderBrowserDialog.Description = "请选择需要查询World文件或Excel文件的路径文件夹";
            xtraFolderBrowserDialog.Title = "请选择文件夹路径";
            xtraFolderBrowserDialog.ShowNewFolderButton = false;
            if (xtraFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textPathEdit.Text = xtraFolderBrowserDialog.SelectedPath;
            }
        }
        /// <summary>
        /// 递归查询文件
        /// </summary>
        /// <param name="strPath">文件夹路径</param>
        /// <param name="fileNames">文件名绝对路径</param>
        /// <param name="searchForText">内容关键字</param>
        private void GetWorldAndExcelFiles(string strPath, string fileNames, string searchForText)
        {
            if (searchForText == "" || searchForText.Length == 0)//搜索文字内容为空
            {
                if (fileNames != "" || fileNames.Length > 0)//搜索文件名不为空
                {
                    string[] fileName = fileNames.Split('|');
                    for (int i = 0; i < fileName.Length; i++)
                    {
                        docpath = Directory.GetFiles(strPath, $"*{fileName[i]}*.doc");
                        xlspath = Directory.GetFiles(strPath, $"*{fileName[i]}*.xls");
                        if (docpath.Length != 0)
                        {
                            for (int j = 0; j < docpath.Length; j++)
                            {
                                if (!pathList.Contains(docpath[j])) pathList.Add(docpath[j]);
                            }
                        }
                        if (xlspath.Length != 0)
                        {
                            for (int j = 0; j < xlspath.Length; j++)
                            {
                                if (!pathList.Contains(xlspath[j])) pathList.Add(xlspath[j]);
                            }
                        }
                    }
                }
                else if (fileNames == "" || fileNames.Length == 0)//搜索文件名为空同时内容也为空
                {
                    docpath = Directory.GetFiles(strPath, "*.doc");
                    docxpath = Directory.GetFiles(strPath, "*.docx");
                    xlspath = Directory.GetFiles(strPath, "*.xls");

                    if (docpath.Length != 0)
                    {
                        pathList.AddRange(docpath);
                    }
                    if (docxpath.Length != 0)
                    {
                        pathList.AddRange(docxpath);
                    }
                    if (xlspath.Length != 0)
                    {
                        pathList.AddRange(xlspath);
                    }
                }
                string[] dirPath = Directory.GetDirectories(strPath);
                if (dirPath.Length > 0)
                {
                    foreach (string dir in dirPath)
                    {
                        GetWorldAndExcelFiles(dir, fileNames, "");
                    }
                }
            }
            else//搜索文字内容不为空
            {
                docpath = Directory.GetFiles(strPath, "*.doc");
                docxpath = Directory.GetFiles(strPath, "*.docx");
                xlspath = Directory.GetFiles(strPath, "*.xls");
                for (int i = 0; i < docpath.Length; i++)
                {
                    string fileName = docpath[i];
                    dictionary = SelWordText.SearchInDoc(fileName, searchForText);
                    if (dictionary.Count > 0)
                    {
                        foreach (KeyValuePair<string, string> keyValue in dictionary)
                        {
                            pathList.Add(keyValue.Key);
                            NRlistBox.Items.Add(keyValue.Value);
                        }
                    }
                }
                string[] dirPath = Directory.GetDirectories(strPath);
                if (dirPath.Length > 0)
                {
                    foreach (string dir in dirPath)
                    {
                        GetWorldAndExcelFiles(dir, fileNames, searchForText);
                    }
                }
            }
            listBoxSel.DataSource = pathList;
            LabelCount.Text = $"合计：{pathList.Count}个文件";
        }
        /// <summary>
        /// 点击查询按钮执行查询操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (simpleButton2.Text == "查询")
            {
                dictionary.Clear();
                listBoxSel.DataSource = null;
                pathList.Clear();
                docpath = null;//doc文件的路径数组
                xlspath = null;//Excel文件的路径数组
                NRlistBox.Items.Clear();
                if (textPathEdit.Text.Trim() == "")
                {
                    XtraMessageBox.Show("请先选择路径", "提示", MessageBoxButtons.OK);
                }
                else if (textNREdit.Text.Trim() != "" && textWJMEdit.Text != "")
                {
                    XtraMessageBox.Show("文件名搜索和文本内容搜索只能二选一,或者二者都不选", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    thread = new Thread(() =>
                    {
                        GetWorldAndExcelFiles(textPathEdit.Text.Trim(), textWJMEdit.Text.Trim(), textNREdit.Text.Trim());
                        simpleButton2.Text = "查询";
                    });
                    thread.IsBackground = true;
                    thread.Start();
                    simpleButton2.Text = "停止";
                }
            }else if (simpleButton2.Text == "停止")
            {
                DialogResult dialogResult = XtraMessageBox.Show("是否终止运行", "终止", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    thread.Abort();
                    simpleButton2.Text = "查询";
                }
            }

        }
        private void OfficeSel_Load(object sender, EventArgs e)
        {
            //取消（屏蔽）检查跨线程的访问，跳过错误强制访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}

