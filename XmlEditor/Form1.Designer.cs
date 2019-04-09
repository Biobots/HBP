namespace XmlEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PartnerBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZInput = new System.Windows.Forms.TextBox();
            this.YInput = new System.Windows.Forms.TextBox();
            this.XInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.openXML = new System.Windows.Forms.OpenFileDialog();
            this.saveXML = new System.Windows.Forms.SaveFileDialog();
            this.CreateChildNodeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CategoryInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SelectBox);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.PartnerBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ZInput);
            this.panel1.Controls.Add(this.YInput);
            this.panel1.Controls.Add(this.XInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.InfoInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KeyInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(164, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 394);
            this.panel1.TabIndex = 0;
            // 
            // SelectBox
            // 
            this.SelectBox.FormattingEnabled = true;
            this.SelectBox.ItemHeight = 12;
            this.SelectBox.Location = new System.Drawing.Point(280, 165);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(120, 208);
            this.SelectBox.TabIndex = 15;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(406, 260);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "<<<删除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(406, 231);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "添加>>>";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // PartnerBox
            // 
            this.PartnerBox.FormattingEnabled = true;
            this.PartnerBox.ItemHeight = 12;
            this.PartnerBox.Location = new System.Drawing.Point(487, 167);
            this.PartnerBox.Name = "PartnerBox";
            this.PartnerBox.Size = new System.Drawing.Size(131, 208);
            this.PartnerBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Partner";
            // 
            // ZInput
            // 
            this.ZInput.Location = new System.Drawing.Point(518, 26);
            this.ZInput.Name = "ZInput";
            this.ZInput.Size = new System.Drawing.Size(55, 21);
            this.ZInput.TabIndex = 9;
            this.ZInput.TextChanged += new System.EventHandler(this.ZInput_TextChanged);
            // 
            // YInput
            // 
            this.YInput.Location = new System.Drawing.Point(457, 26);
            this.YInput.Name = "YInput";
            this.YInput.Size = new System.Drawing.Size(55, 21);
            this.YInput.TabIndex = 8;
            this.YInput.TextChanged += new System.EventHandler(this.YInput_TextChanged);
            // 
            // XInput
            // 
            this.XInput.Location = new System.Drawing.Point(396, 26);
            this.XInput.Name = "XInput";
            this.XInput.Size = new System.Drawing.Size(55, 21);
            this.XInput.TabIndex = 7;
            this.XInput.TextChanged += new System.EventHandler(this.XInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "绝对坐标(Position)";
            // 
            // InfoInput
            // 
            this.InfoInput.Location = new System.Drawing.Point(16, 167);
            this.InfoInput.Multiline = true;
            this.InfoInput.Name = "InfoInput";
            this.InfoInput.Size = new System.Drawing.Size(227, 206);
            this.InfoInput.TabIndex = 5;
            this.InfoInput.TextChanged += new System.EventHandler(this.InfoInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "简介(Info)";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(91, 98);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(152, 21);
            this.NameInput.TabIndex = 3;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "中文名(Name)";
            // 
            // KeyInput
            // 
            this.KeyInput.Location = new System.Drawing.Point(91, 26);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(152, 21);
            this.KeyInput.TabIndex = 1;
            this.KeyInput.TextChanged += new System.EventHandler(this.KeyInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "英文名(Key)";
            // 
            // tree
            // 
            this.tree.HideSelection = false;
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(146, 433);
            this.tree.TabIndex = 1;
            this.tree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tree_BeforeSelect);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.SearchInput);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.ReadButton);
            this.panel2.Controls.Add(this.NewButton);
            this.panel2.Location = new System.Drawing.Point(164, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 62);
            this.panel2.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(249, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(143, 22);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(100, 21);
            this.SearchInput.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(559, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 56);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存！";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(3, 36);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(82, 23);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "读取XML文件";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(3, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(82, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "新建XML文件";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // openXML
            // 
            this.openXML.FileName = "openFileDialog1";
            this.openXML.FileOk += new System.ComponentModel.CancelEventHandler(this.openXML_FileOk);
            // 
            // saveXML
            // 
            this.saveXML.FileOk += new System.ComponentModel.CancelEventHandler(this.saveXML_FileOk);
            // 
            // CreateChildNodeButton
            // 
            this.CreateChildNodeButton.Location = new System.Drawing.Point(12, 451);
            this.CreateChildNodeButton.Name = "CreateChildNodeButton";
            this.CreateChildNodeButton.Size = new System.Drawing.Size(75, 23);
            this.CreateChildNodeButton.TabIndex = 10;
            this.CreateChildNodeButton.Text = "新建项";
            this.CreateChildNodeButton.UseVisualStyleBackColor = true;
            this.CreateChildNodeButton.Click += new System.EventHandler(this.CreateNodeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(83, 451);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "删除项";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "分类";
            // 
            // CategoryInput
            // 
            this.CategoryInput.Location = new System.Drawing.Point(401, 83);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(100, 21);
            this.CategoryInput.TabIndex = 17;
            this.CategoryInput.TextChanged += new System.EventHandler(this.CategoryInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 486);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateChildNodeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.OpenFileDialog openXML;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZInput;
        private System.Windows.Forms.TextBox YInput;
        private System.Windows.Forms.TextBox XInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InfoInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CreateChildNodeButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox PartnerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox SelectBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox CategoryInput;
        private System.Windows.Forms.Label label6;
    }
}

