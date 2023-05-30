using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TestXceedDocx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region XceedDoc
            FileStream fs_1 = new FileStream("../../1.docx", FileMode.Open);
            DocX doc_1 = DocX.Load(fs_1);
            FileStream fs_2 = new FileStream("../../2.docx", FileMode.Open);

            DocX doc_2 = DocX.Load(fs_2);

            doc_1.InsertDocument(doc_2, true, true, mergingMode: MergingMode.Remote);

            try
            {
                doc_1.SaveAs("../../result.docx");
            }
            catch (Exception)
            {

                throw;
            }
            #endregion
        }
    }
}
