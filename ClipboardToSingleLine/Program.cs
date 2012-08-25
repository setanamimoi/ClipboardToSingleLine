using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ClipboardToSingleLine
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (StringReader reader = new StringReader(Clipboard.GetText()))
            using (StringWriter writer = new StringWriter())
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    writer.Write(line);
                }

                Clipboard.SetText(writer.ToString());
            }
        }
    }
}
