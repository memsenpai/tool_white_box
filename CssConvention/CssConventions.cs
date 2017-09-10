using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Css
{
    public class CssConventions
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

        public CssConventions(FileInfo file)
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
                Color(line, index);
                BangFormat(line, index);
            }
        }

        public void Color(string line, int index)
        {
            if (line.Contains("color:"))
            {
                string[] lines = line.Split(':');
                if (lines[1].Contains("#"))
                {
                    Notice.Add("Line " + index + ": Color must declare");
                }
            }
        }

        public void BangFormat(string line, int index)
        {
            if (line.Contains('!'))
            {
                if(line[line.IndexOf('!')-1] != ' ')
                {
                    Notice.Add("Line " + index + ": Need sapce before !");
                }
            }
        }

        public void Comment(string line, int index)
        {
            if (line.Contains("/*"))
            {
                Notice.Add("Line " + index + ": Prefer // comments over /* ... */");
            }
        }

        public void ColorVariable(string line, int index)
        {
            if (line.Contains("color:") && !line.Contains('#') && !line.Contains('$'))
            {
                Notice.Add("Line " + index + ": Prefer color literals(keywords or hexadecimal codes) to be used only in variable declarations"); 
            }
        }
    }
}
