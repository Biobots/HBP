using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace XmlEditor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openXML.Filter = "xml files(*.xml)|*.xml";
            saveXML.Filter = "xml files(*.xml)|*.xml";
        }

        #region OpenXML
        private void ReadButton_Click(object sender, EventArgs e)
        {
            openXML.ShowDialog();
        }

        private void openXML_FileOk(object sender, CancelEventArgs e)
        {
            tree.Nodes.Clear();
            Sys.list.Clear();
            Sys.currentDoc = new XmlDocument();
            Sys.currentDoc.Load(openXML.FileName);
            Sys.root = Sys.currentDoc.DocumentElement;
            XmlNodeList nodes = Sys.root.SelectNodes("/Collection/Element");
            foreach (XmlNode node in nodes)
            { LoadData(node); }
        }
        #endregion
        #region CreateXML
        private void NewButton_Click(object sender, EventArgs e)
        {
            tree.Nodes.Clear();
            Sys.list.Clear();
            Sys.currentDoc = new XmlDocument();
            XmlDeclaration dec;
            dec = Sys.currentDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            Sys.currentDoc.AppendChild(dec);
            XmlNode node = Sys.currentDoc.CreateElement("Collection");
            Sys.currentDoc.AppendChild(node);
            Sys.root = Sys.currentDoc.DocumentElement;
        }

        #endregion
        #region SaveXML
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Sys.currentDoc = new XmlDocument();
            XmlDeclaration dec;
            dec = Sys.currentDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            Sys.currentDoc.AppendChild(dec);
            XmlNode node = Sys.currentDoc.CreateElement("Collection");
            Sys.currentDoc.AppendChild(node);
            Sys.root = Sys.currentDoc.DocumentElement;
            XmlNode temp = Sys.currentDoc.SelectSingleNode("/Collection");
            foreach (TreeNode tn in tree.Nodes)
            {
                temp.SaveElement(Sys.list[tn]);
            }
            saveXML.ShowDialog();
        }
        private void saveXML_FileOk(object sender, CancelEventArgs e)
        {
            Sys.currentDoc.Save(saveXML.FileName);
        }

        #endregion

        private void tree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (KeyInput.Text != null && tree.SelectedNode != null)
            {
                tree.SelectedNode.Text = Sys.list[tree.SelectedNode].Key;
                try
                {
                    Sys.list[tree.SelectedNode].Name = NameInput.Text;
                    Sys.list[tree.SelectedNode].Info = InfoInput.Text;
                    Sys.list[tree.SelectedNode].X = XInput.Text;
                    Sys.list[tree.SelectedNode].Y = YInput.Text;
                    Sys.list[tree.SelectedNode].Z = ZInput.Text;
                    Sys.list[tree.SelectedNode].Category = CategoryInput.Text;
                }
                catch
                { }
            }
        }
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            KeyInput.Text = tree.SelectedNode.Text;
            try
            {
                NameInput.Text = Sys.list[tree.SelectedNode].Name;
                InfoInput.Text = Sys.list[tree.SelectedNode].Info;
                XInput.Text = Sys.list[tree.SelectedNode].X;
                YInput.Text = Sys.list[tree.SelectedNode].Y;
                ZInput.Text = Sys.list[tree.SelectedNode].Z;
                CategoryInput.Text = Sys.list[tree.SelectedNode].Category;
            }
            catch
            { }
        }

        private void CreateNodeButton_Click(object sender, EventArgs e)
        {
            //if (tree.SelectedNode != null)
            //{
            //    TreeNode tempNode = tree.SelectedNode.Nodes.Add("Unamed");
            //    NodeData tempData = new NodeData();
            //    tempData.Node = tempNode;
            //    tempData.Key = "Unamed";
            //    Sys.list.Add(tempNode, tempData);
            //}
            //else
            //{
                TreeNode tempNode = tree.Nodes.Add("Unamed");
                NodeData tempData = new NodeData();
                tempData.Node = tempNode;
                tempData.Key = "Unamed";
                Sys.list.Add(tempNode, tempData);
            //}
        }
        #region Text Change
        private void KeyInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Key = KeyInput.Text;
                tree.SelectedNode.Text = KeyInput.Text;
            }
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Name = NameInput.Text;
            }
        }

        private void InfoInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Info = InfoInput.Text;
            }
        }

        private void XInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].X = XInput.Text;
            }
        }

        private void YInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Y = YInput.Text;
            }
        }

        private void ZInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Z = ZInput.Text;
            }
        }
        private void CategoryInput_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Sys.list[tree.SelectedNode].Category = CategoryInput.Text;
            }
        }

        #endregion

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == tree.SelectedNode && e.Button == MouseButtons.Right)
            {
                tree.SelectedNode = null;
            }
        }




        void LoadData(TreeNode Tparent, XmlNode Xparent)
        {
            NodeData nd = new NodeData();
            TreeNode Tchild = Tparent.Nodes.Add("Unamed");
            foreach (XmlNode content in Xparent.ChildNodes)
            {
                if (content.Name == "key")
                { nd.Key = content.InnerText; }
                else if (content.Name == "name")
                { nd.Name = content.InnerText; }
                else if (content.Name == "info")
                { nd.Info = content.InnerText; }
                else if (content.Name == "category")
                { nd.Category = content.InnerText; }
                else if (content.Name == "position")
                {
                    foreach (XmlElement e in content.ChildNodes)
                    {
                        if (e.Name == "x")
                        { nd.X = e.InnerText; }
                        else if (e.Name == "y")
                        { nd.Y = e.InnerText; }
                        else if (e.Name == "z")
                        { nd.Z = e.InnerText; }
                    }
                }
                else if (content.Name == "Element")
                {
                    LoadData(Tchild, content);
                }
            }
            Tchild.Text = nd.Key;
            nd.Node = Tchild;
            Sys.list.Add(Tchild, nd);
        }
        void LoadData(XmlNode Xparent)
        {
            NodeData nd = new NodeData();
            TreeNode Tchild = tree.Nodes.Add("Unamed");
            foreach (XmlNode content in Xparent.ChildNodes)
            {
                if (content.Name == "key")
                { nd.Key = content.InnerText; }
                else if (content.Name == "name")
                { nd.Name = content.InnerText; }
                else if (content.Name == "info")
                { nd.Info = content.InnerText; }
                else if (content.Name == "category")
                { nd.Category = content.InnerText; }
                else if (content.Name == "position")
                {
                    foreach (XmlElement e in content.ChildNodes)
                    {
                        if (e.Name == "x")
                        { nd.X = e.InnerText; }
                        else if (e.Name == "y")
                        { nd.Y = e.InnerText; }
                        else if (e.Name == "z")
                        { nd.Z = e.InnerText; }
                    }
                }
                else if (content.Name == "Element")
                {
                    LoadData(Tchild, content);
                }
            }
            Tchild.Text = nd.Key;
            nd.Node = Tchild;
            Sys.list.Add(Tchild, nd);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                //foreach (TreeNode tn in tree.SelectedNode.Nodes)
                //{
                //    Sys.list.Remove(tn);
                //    tree.SelectedNode.Nodes.Remove(tn);
                //}
                Sys.list.Remove(tree.SelectedNode);
                tree.Nodes.Remove(tree.SelectedNode);
            }
        }

    }
}
