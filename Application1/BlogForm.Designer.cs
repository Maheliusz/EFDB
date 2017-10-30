namespace Application1
{
    partial class BlogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogForm));
            this.blogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.blogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogFilterID = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.postFilterID = new System.Windows.Forms.TextBox();
            this.blogFilterName = new System.Windows.Forms.TextBox();
            this.blogFilterUrl = new System.Windows.Forms.TextBox();
            this.postFilterTitle = new System.Windows.Forms.TextBox();
            this.postFilterContent = new System.Windows.Forms.TextBox();
            this.postFilterBlog = new System.Windows.Forms.TextBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogsDataGridView = new System.Windows.Forms.DataGridView();
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingNavigator)).BeginInit();
            this.blogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // blogBindingNavigator
            // 
            this.blogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.blogBindingNavigator.BindingSource = this.blogBindingSource;
            this.blogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.blogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.blogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.blogBindingNavigatorSaveItem});
            this.blogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.blogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.blogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.blogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.blogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.blogBindingNavigator.Name = "blogBindingNavigator";
            this.blogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.blogBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.blogBindingNavigator.TabIndex = 0;
            this.blogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // blogBindingNavigatorSaveItem
            // 
            this.blogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("blogBindingNavigatorSaveItem.Image")));
            this.blogBindingNavigatorSaveItem.Name = "blogBindingNavigatorSaveItem";
            this.blogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.blogBindingNavigatorSaveItem.Text = "Save Data";
            this.blogBindingNavigatorSaveItem.Click += new System.EventHandler(this.blogBindingNavigatorSaveItem_Click);
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.blogBindingSource;
            // 
            // blogFilterID
            // 
            this.blogFilterID.Location = new System.Drawing.Point(46, 44);
            this.blogFilterID.Name = "blogFilterID";
            this.blogFilterID.Size = new System.Drawing.Size(99, 20);
            this.blogFilterID.TabIndex = 4;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(361, 42);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(63, 23);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // postFilterID
            // 
            this.postFilterID.Location = new System.Drawing.Point(430, 44);
            this.postFilterID.Name = "postFilterID";
            this.postFilterID.Size = new System.Drawing.Size(96, 20);
            this.postFilterID.TabIndex = 7;
            // 
            // blogFilterName
            // 
            this.blogFilterName.Location = new System.Drawing.Point(151, 44);
            this.blogFilterName.Name = "blogFilterName";
            this.blogFilterName.Size = new System.Drawing.Size(99, 20);
            this.blogFilterName.TabIndex = 8;
            // 
            // blogFilterUrl
            // 
            this.blogFilterUrl.Location = new System.Drawing.Point(256, 44);
            this.blogFilterUrl.Name = "blogFilterUrl";
            this.blogFilterUrl.Size = new System.Drawing.Size(99, 20);
            this.blogFilterUrl.TabIndex = 9;
            // 
            // postFilterTitle
            // 
            this.postFilterTitle.Location = new System.Drawing.Point(532, 44);
            this.postFilterTitle.Name = "postFilterTitle";
            this.postFilterTitle.Size = new System.Drawing.Size(96, 20);
            this.postFilterTitle.TabIndex = 10;
            // 
            // postFilterContent
            // 
            this.postFilterContent.Location = new System.Drawing.Point(634, 44);
            this.postFilterContent.Name = "postFilterContent";
            this.postFilterContent.Size = new System.Drawing.Size(96, 20);
            this.postFilterContent.TabIndex = 11;
            // 
            // postFilterBlog
            // 
            this.postFilterBlog.Location = new System.Drawing.Point(736, 44);
            this.postFilterBlog.Name = "postFilterBlog";
            this.postFilterBlog.Size = new System.Drawing.Size(96, 20);
            this.postFilterBlog.TabIndex = 12;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(12, 271);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(371, 196);
            this.userDataGridView.TabIndex = 12;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this.userBindingSource;
            // 
            // blogsDataGridView
            // 
            this.blogsDataGridView.AutoGenerateColumns = false;
            this.blogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.blogsDataGridView.DataSource = this.blogsBindingSource;
            this.blogsDataGridView.Location = new System.Drawing.Point(12, 70);
            this.blogsDataGridView.Name = "blogsDataGridView";
            this.blogsDataGridView.Size = new System.Drawing.Size(371, 195);
            this.blogsDataGridView.TabIndex = 12;
            this.blogsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blogsDataGridView_CellContentClick);
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.AutoGenerateColumns = false;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn15});
            this.postsDataGridView.DataSource = this.postsBindingSource;
            this.postsDataGridView.Location = new System.Drawing.Point(389, 71);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.Size = new System.Drawing.Size(461, 194);
            this.postsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PostId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PostId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn3.HeaderText = "Content";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Blog";
            this.dataGridViewTextBoxColumn15.HeaderText = "Blog";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // blogBindingSource
            // 
            this.blogBindingSource.DataSource = typeof(Application1.Blog);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BlogID";
            this.dataGridViewTextBoxColumn11.HeaderText = "BlogID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn13.HeaderText = "Url";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Application1.User);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn9.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn10.HeaderText = "Description";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // blogBindingSource1
            // 
            this.blogBindingSource1.DataSource = typeof(Application1.Blog);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.postsDataGridView);
            this.Controls.Add(this.blogsDataGridView);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.postFilterBlog);
            this.Controls.Add(this.postFilterContent);
            this.Controls.Add(this.postFilterTitle);
            this.Controls.Add(this.blogFilterUrl);
            this.Controls.Add(this.blogFilterName);
            this.Controls.Add(this.postFilterID);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.blogFilterID);
            this.Controls.Add(this.blogBindingNavigator);
            this.Name = "BlogForm";
            this.Text = "BlogForm";
            this.Load += new System.EventHandler(this.BlogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingNavigator)).EndInit();
            this.blogBindingNavigator.ResumeLayout(false);
            this.blogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource blogBindingSource;
        private System.Windows.Forms.BindingNavigator blogBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton blogBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox blogFilterID;
        private System.Windows.Forms.BindingSource blogBindingSource1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox postFilterID;
        private System.Windows.Forms.TextBox blogFilterName;
        private System.Windows.Forms.TextBox blogFilterUrl;
        private System.Windows.Forms.TextBox postFilterTitle;
        private System.Windows.Forms.TextBox postFilterContent;
        private System.Windows.Forms.TextBox postFilterBlog;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private System.Windows.Forms.DataGridView blogsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}