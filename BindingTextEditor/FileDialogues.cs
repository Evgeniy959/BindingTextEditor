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
        public static string OpenFile(out string pathFile)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                pathFile = openFileDialog.FileName;
                return File.ReadAllText(pathFile); 
            }
            pathFile = null;
            return String.Empty;
        }
        public static void SaveAsFile(string str, out string pathFile)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == true)
            {
                pathFile = saveFileDialog.FileName;
                File.WriteAllText(pathFile, str);
                //File.WriteAllText(saveFileDialog.FileName, str);
                //pathFile = saveFileDialog.FileName;
            }
            pathFile = null;
        }
    }
}
