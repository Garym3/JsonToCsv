using System;
using System.Text;

namespace WindowsFormsApp1
{
    class FileConvert
    {
        public string HorodateFileName(string filename)
        {
            string[] parts = filename.Split('.');
            int fileNameLength = parts.Length - 1;
            StringBuilder sb = new StringBuilder();

            parts[fileNameLength - 1] = parts[fileNameLength - 1] + "-" + DateTime.Now.ToString("yyyyMMdd-HHmm");
            parts[fileNameLength] = ".csv";

            foreach (string part in parts)
            {
                sb.Append(part);
            }

            return sb.ToString();
        }
    }
}
