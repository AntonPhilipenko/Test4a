using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Completor.Core.Tools
{
    /// <summary>
    /// Read file contents
    /// </summary>
    public class FileProcessor
    {
        private string GetRelative()
        {
            string dir = Directory.GetCurrentDirectory();
            StringBuilder stringBuilder = new StringBuilder(dir);
            stringBuilder.Append("\\..");

            return stringBuilder.ToString();
        }

        public string[] ReadAllLines(string path, bool relative = false)
        {
            if (relative)
            {
                path = string.Format("{0}{1}", GetRelative(), path);
            }

            try
            {
                return File.Exists(path)
                    ? File.ReadAllLines(path)
                    : new string[0];
            }
            catch (IOException)
            {
                // TODO:
                return new string[0];
            }
        }
    }
}
