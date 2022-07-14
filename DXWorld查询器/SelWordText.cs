using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Text;


namespace DXWorld查询器
{
    internal class SelWordText
    {
        public static Dictionary<string, string> SearchInDoc(string fileName, string searchForText)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            Application app = new Application();
            Document doc = null;
            object missing = Type.Missing;
            object ReadOnly = true;//是否只能读
            object encoding = Encoding.UTF8;//UTF8编码
            app.Visible = false;
            string str = fileName;//文档的路径
            object file = str;
            Microsoft.Office.Interop.Word.Find wfnd;//声明查找检索对象
            try
            {
                doc = app.Documents.Open(ref file, ref missing,
                ref ReadOnly, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing);
                if (doc.Paragraphs != null && doc.Paragraphs.Count > 0)
                {
                    int iCount = doc.Paragraphs.Count;
                    //读取第几段内容（空白行、各级标题等均作为一段来算）  
                    //string strParaghaph = doc.Paragraphs[4].Range.Text.Trim();
                    //读取第几句内容(空白行、各级标题等都作为一句来算)
                    // string strSentence = doc.Sentences[5].Text;
                    for (int i = 1; i < iCount; i++)
                    {
                        wfnd = doc.Paragraphs[i].Range.Find;
                        wfnd.ClearFormatting();
                        wfnd.Text = searchForText.Trim();
                        if (wfnd.Execute(ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing, ref missing,
                            ref missing))
                        {
                            string textParagraph = doc.Paragraphs[i].Range.Text.Trim();
                            int index = textParagraph.IndexOf(searchForText);
                            string beforeIndex = textParagraph.Substring(index - 10 < 0 ? 0 : index - 10, index) + searchForText;
                            string afterIndex = textParagraph.Substring(index);
                            string strText = beforeIndex + afterIndex;
                            result.Add(fileName, strText);
                            return result;
                        }
                    }
                }
                return result;
            }
            finally
            {
                if (app != null)
                {
                    if (doc != null)
                    {
                        Word.Document docc = doc as Word.Document;
                        docc.Close(ref missing, ref missing, ref missing);
                    }
                    app.Quit(ref missing, ref missing, ref missing);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }

            }
        }
    }
}
