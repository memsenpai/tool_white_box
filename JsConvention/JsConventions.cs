using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Css
{
    public class JsConventions
    {
        private FileInfo fileInfo;

        public FileInfo FileInfo
        {
            get
            {
                return fileInfo;
            }

            set
            {
                fileInfo = value;
            }
        }

        public ArrayList Notice
        {
            get
            {
                return notice;
            }

            set
            {
                notice = value;
            }
        }

        private ArrayList notice;

        public JsConventions(FileInfo file)
        {
            this.FileInfo = file;
            Notice = new ArrayList();
        }

        public void readFiles()
        {
            int index = 0;
            foreach (string line in File.ReadAllLines(FileInfo.FullName))
            {
                index++;
            }
        }
    }
}
