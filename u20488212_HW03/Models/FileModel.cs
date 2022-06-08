using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20488212_HW03.Models
{
    public class FileModel
    {
        private string fileName;
        public static List<FileModel> files;
        public FileModel(string fname)
        {
            this.fileName = fname;
            files = new List<FileModel>();
    }

        public string Fname { get => fileName; set => fileName = value; }
    }
}