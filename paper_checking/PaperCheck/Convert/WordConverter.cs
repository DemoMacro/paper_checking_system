using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using NPOI.XWPF.UserModel;

namespace paper_checking.PaperCheck.Convert
{
    class WordConverter : ConvertCore
    {
        public override string ConvertToString(string path, string blockText)
        {
            System.Text.Encoding encoding = EncodingType.GetType(path);
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
                        text += item.ParagraphText + "\r";
                    }
                }
                catch
                { }
                text = text.Replace("#", "").Replace('\r', '#').Replace('\n', '#');
                text = Regex.Replace(text, @"[^\u4e00-\u9fa5\《\》\（\）\——\；\，\。\“\”\！\#]", "");
                text = new Regex("[#]+").Replace(text, "@@").Trim();
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
