using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Models
{
    public enum FileTyping { SysDrive, Drive, BackFolder, Folder, FILE }

    public class FileItem
    {
        public FileItem(FileTyping type, string name)
        {
            Type = type;
            Name = name;
        }
        public FileTyping Type { get; }
        public string Name { get; }
    }
}
