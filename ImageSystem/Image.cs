using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageSystem
{
    public class Image
    {
        public Image()
        {
        }

        public Image(string name, string dateAdded, string type, long size, string path, int timeLimit)
        {
            this.name = name;
            this.dateAdded = dateAdded;
            this.type = type;
            this.size = size;
            this.path = path;
            this.timeLimit = timeLimit;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string DateAdded
        {
            get
            {
                return dateAdded;
            }
            set
            {
                dateAdded = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public long Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public int TimeLimit
        {
            get
            {
                return timeLimit;
            }
            set
            {
                timeLimit = value;
            }
        }

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        private string name;
        private string dateAdded;
        private string type;
        private long size;
        private int timeLimit;
        private string path;
    }
}
