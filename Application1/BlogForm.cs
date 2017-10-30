using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1
{
    public partial class BlogForm : Form
    {
        private BloggingContext bContext;
        public BlogForm()
        {
            InitializeComponent();
        }

        private void BlogForm_Load(object sender, EventArgs e)
        {
            bContext = new BloggingContext();
            bContext.Blogs.Load();
            bContext.Users.Load();
            this.blogBindingSource.DataSource = bContext.Blogs.Local.ToBindingList();
            this.postsBindingSource.DataSource = bContext.Posts.Local.ToBindingList();
            this.userBindingSource.DataSource = bContext.Users.Local.ToBindingList();
        }

        private void blogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bContext.SaveChanges();
        }

        private void setPostsDataSourceMethodSyntax(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string filter = blogsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.postsDataGridView.DataSource =
            bContext.Posts
                .Where(post => post.BlogID.ToString() == filter)
                .Select(post => new
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Content = post.Content,
                    BlogId = post.BlogID,
                    Blog = post.Blog.Name
                }).ToList();
        }

        private void setPostsDatSourceQuerySyntax(DataGridViewCellEventArgs e)
        {
            string filter = blogsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            IEnumerable<Post> query =
                from p in bContext.Posts
                where p.BlogID.ToString() == filter
                select p;
            this.postsDataGridView.DataSource = query.ToList();
        }

        private void blogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setPostsDataSourceMethodSyntax(e);
            this.postsDataGridView.Update();
            this.postsDataGridView.Refresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            bContext.Blogs.Load();
            this.postsDataGridView.DataSource =
            bContext.Posts
                .Where(post =>
                (postFilterID.Text != "" ? post.PostId.ToString().Contains(postFilterID.Text) : true)
                &&
                (postFilterContent.Text != "" ? post.Content.ToString().Contains(postFilterContent.Text) : true)
                &&
                (postFilterTitle.Text != "" ? post.Title.ToString().Contains(postFilterTitle.Text) : true)
                &&
                (postFilterBlog.Text != "" ? post.Blog.Name.ToString().Contains(postFilterBlog.Text) : true)
                )
                .Select(post => new
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Content = post.Content,
                    BlogId = post.BlogID,
                    Blog = post.Blog.Name.ToString()
                }).ToList();
            this.blogsDataGridView.DataSource =
            bContext.Blogs
                .Where(blog =>
                (blogFilterID.Text != "" ? blog.BlogID.ToString().Contains(blogFilterID.Text) : true)
                &&
                (blogFilterName.Text != "" ? blog.Name.ToString().Contains(blogFilterName.Text) : true)
                &&
                (blogFilterUrl.Text != "" ? blog.Url.ToString().Contains(blogFilterUrl.Text) : true)
                )
                .Select(blog => new
                {
                    BlogID = blog.BlogID,
                    Name = blog.Name,
                    Url = blog.Url
                }).ToList();
            this.blogsDataGridView.Update();
            this.blogsDataGridView.Refresh();
            this.postsDataGridView.Update();
            this.postsDataGridView.Refresh();
        }

        private void blogsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setPostsDataSourceMethodSyntax(e);
            this.postsDataGridView.Update();
            this.postsDataGridView.Refresh();
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setBlogsDataSourceQuerySyntax(e);
            this.blogsDataGridView.Update();
            this.blogsDataGridView.Refresh();
        }

        private void setBlogsDataSourceQuerySyntax(DataGridViewCellEventArgs e)
        {
            string filter = userDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            IEnumerable<Blog> query =
                from p in bContext.Blogs
                where p.UserName.ToString() == filter
                select p;
            this.blogsDataGridView.DataSource = query.ToList();
        }
    }
}
