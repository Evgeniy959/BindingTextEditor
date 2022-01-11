using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingTextEditor
{
    public static class FileDialogues
    {
        public static string OpenFile(out string strPath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                strPath = openFileDialog.FileName;
                return File.ReadAllText(strPath);
            }
            strPath = null;
            return String.Empty;
        }
        public static void SaveAsFile(string str, out string strPath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == true)
            {
                strPath = saveFileDialog.FileName;
                File.WriteAllText(strPath, str);
                //File.WriteAllText(saveFileDialog.FileName, str);
                //strPath = saveFileDialog.FileName;
            }
            strPath = null;
        }
    }
}
