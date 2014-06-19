using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using ImageSystem.CommonStaticVar;

namespace ImageSystem.XMLHandle
{
    class ImagesXMLHandler
    {
        private XmlDocument images = null;
        private XmlElement curImage = null;
        private XmlElement curElem = null;
        private XmlElement root = null;

        public ImagesXMLHandler()
        {
            images = new XmlDocument();
            images.Load(CommonStaticVariables.imagesFilePath);
            root = images.DocumentElement;
        }

        public void reload()
        {
            images = new XmlDocument();
            images.Load(CommonStaticVariables.imagesFilePath);
            root = images.DocumentElement;
        }

        public List<Image> getAllImages()
        {
            XmlNodeList allImages = root.ChildNodes;
            List<Image> allImageList = new List<Image>();
            foreach (XmlElement image in allImages)
            {
                Image curImage = new Image();
                curImage.Name = image.GetElementsByTagName("name").Item(0).InnerText;
                curImage.DateAdded = image.GetElementsByTagName("dateAdded").Item(0).InnerText;
                curImage.Type = image.GetElementsByTagName("type").Item(0).InnerText;
                curImage.Size = Convert.ToInt64(image.GetElementsByTagName("size").Item(0).InnerText);
                curImage.TimeLimit = Convert.ToInt32(image.GetElementsByTagName("timeLimit").Item(0).InnerText);
                curImage.Path = image.GetElementsByTagName("path").Item(0).InnerText;

                if (!allImageList.Contains(curImage))
                {
                    allImageList.Add(curImage);
                }
            }
            return allImageList;
        }

        public Image search(string path)
        {
            string searchString = "/images/image[path='" + path + "']";
            curImage = (XmlElement)root.SelectSingleNode(searchString);

            Image retImage = new Image();
            retImage.Name = curImage.GetElementsByTagName("name").Item(0).InnerText;
            retImage.DateAdded = curImage.GetElementsByTagName("dateAdded").Item(0).InnerText;
            retImage.Type = curImage.GetElementsByTagName("type").Item(0).InnerText;
            retImage.Size = Convert.ToInt64(curImage.GetElementsByTagName("size").Item(0).InnerText);
            retImage.TimeLimit = Convert.ToInt32(curImage.GetElementsByTagName("timeLimit").Item(0).InnerText);
            retImage.Path = curImage.GetElementsByTagName("path").Item(0).InnerText;

            return retImage;
        }

        public bool exits(string path)
        {
            string searchString = "/images/image[path='" + path + "']";
            curImage = (XmlElement)root.SelectSingleNode(searchString);
            if (curImage == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void delete(string path)
        {
            string searchString = "/images/image[path='" + path + "']";
            curImage = (XmlElement)root.SelectSingleNode(searchString);
            curImage.ParentNode.RemoveChild(curImage);

            save();
        }

        public void add(Image newImage)
        {
            curImage = images.CreateElement("image");

            curElem = images.CreateElement("name");
            curElem.InnerText = newImage.Name;
            curImage.AppendChild(curElem);

            curElem = images.CreateElement("dateAdded");
            curElem.InnerText = newImage.DateAdded;
            curImage.AppendChild(curElem);

            curElem = images.CreateElement("type");
            curElem.InnerText = newImage.Type;
            curImage.AppendChild(curElem);

            curElem = images.CreateElement("size");
            curElem.InnerText = newImage.Size.ToString();
            curImage.AppendChild(curElem);

            curElem = images.CreateElement("timeLimit");
            curElem.InnerText = newImage.TimeLimit.ToString();
            curImage.AppendChild(curElem);

            curElem = images.CreateElement("path");
            curElem.InnerText = newImage.Path;
            curImage.AppendChild(curElem);

            root.AppendChild(curImage);

            save();
        }

        public void update(Image newImage)
        {
            string searchString = "/images/image[path='" + newImage.Path + "']";
            curImage = (XmlElement)root.SelectSingleNode(searchString);

            curImage.GetElementsByTagName("name").Item(0).InnerText = newImage.Name;
            curImage.GetElementsByTagName("timeLimit").Item(0).InnerText = newImage.TimeLimit.ToString();

            save();
        }

        private void save()
        {
            images.Save(CommonStaticVariables.imagesFilePath);
        }
    }
}
