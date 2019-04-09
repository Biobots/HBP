using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace XmlEditor
{
    public class Sys
    {
        static public XmlDocument currentDoc;
        static public XmlNode root;
        static public Dictionary<TreeNode, NodeData> list = new Dictionary<TreeNode, NodeData>();


    }
    static class Extensions
    {
        static TreeNode Search(this TreeNode parent, string input)
        {
            TreeNode temp = null;
            foreach (TreeNode t in parent.Nodes)
            {
                if (t.Text == input)
                { temp = t; }
            }
            return temp;//null
        }
        #region Properties
        static public void AddKey(this XmlNode node, string value)
        {
            XmlElement pointer = Sys.currentDoc.CreateElement("key");
            pointer.InnerText = value;
            node.AppendChild(pointer);
        }
        static public void AddName(this XmlNode node, string value)
        {
            XmlElement pointer = Sys.currentDoc.CreateElement("name");
            pointer.InnerText = value;
            node.AppendChild(pointer);
        }
        static public void AddInfo(this XmlNode node, string value)
        {
            XmlElement pointer = Sys.currentDoc.CreateElement("info");
            pointer.InnerText = value;
            node.AppendChild(pointer);
        }
        static public void AddPosition(this XmlNode node, string x, string y, string z)
        {
            XmlNode pointer = Sys.currentDoc.CreateElement("position");
            XmlElement xe = Sys.currentDoc.CreateElement("x");
            xe.InnerText = x;
            pointer.AppendChild(xe);
            XmlElement ye = Sys.currentDoc.CreateElement("y");
            ye.InnerText = y;
            pointer.AppendChild(ye);
            XmlElement ze = Sys.currentDoc.CreateElement("z");
            ze.InnerText = z;
            pointer.AppendChild(ze);
            node.AppendChild(pointer);
        }
        static public void AddCategory(this XmlNode node, string value)
        {
            XmlElement pointer = Sys.currentDoc.CreateElement("category");
            pointer.InnerText = value;
            node.AppendChild(pointer);
        }
        #endregion
        static public void SaveElement(this XmlNode root, NodeData nd)
        {
            XmlNode element = Sys.currentDoc.CreateElement("Element");
            try
            {
                element.AddKey(nd.Key);
                element.AddName(nd.Name);
                element.AddInfo(nd.Info);
                element.AddPosition(nd.X, nd.Y, nd.Z);
                element.AddCategory(nd.Category);
            }
            catch { }
            if (nd.Node.Nodes != null)
            {
                foreach (TreeNode tn in nd.Node.Nodes)
                {
                    element.SaveElement(Sys.list[tn]);
                }
            }
            root.AppendChild(element);
        }

    }
    public class NodeData
    {
        public TreeNode Node { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Category { get; set; }
    }
}
