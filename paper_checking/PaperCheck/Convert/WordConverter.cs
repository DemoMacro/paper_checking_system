using NPOI.XWPF.UserModel;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace paper_checking.PaperCheck.Convert
{
    class WordConverter : ConvertCore
    {
        public override string ConvertToString(string path, string blockText)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            string text = null;
            try
            {
                XWPFDocument doc = null;
                doc = new XWPFDocument(stream);
                try
                {
                    foreach (var item in doc.Paragraphs)
                    {
                        text += item.ParagraphText + "\r\n";
                    }
                }
                catch
                { }
                text = text.Replace("#", "").Replace('\r', '#').Replace('\n', '#');
                // text = Regex.Replace(text, @"[^\u4e00-\u9fa5\p{P}]", "");
                // 会导致一些特殊字符被过滤掉
                text = Regex.Replace(text, @"[^\u4e00-\u9fa5\《\》\（\）\——\；\，\。\“\”\！\#]", "");
                text = new Regex("[#]+").Replace(text, "@@").Trim("@".ToCharArray());
                text = TextFormat(text, blockText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                stream.Close();
            }
            return text;
        }
    }
}
