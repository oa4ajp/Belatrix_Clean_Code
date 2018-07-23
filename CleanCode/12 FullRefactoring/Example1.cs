using CleanCode.FullRefactoring;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        public Label PostBody { get; set; }
        public Label PostTitle { get; set; }
        public int? PostId { get; set; }

        private readonly PostRepository _postRepository;
        private readonly PostValidator _validator;

        public PostControl()
        {
            _postRepository = new PostRepository();
            _validator = new PostValidator();
        }

        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Page.IsPostBack)
            {
                ValidateForm();
            }
            else
            {
                DisplayForm();
            }
        }

        private void ValidateForm()
        {
            Post entity = GetPost();

            var validationResults = _validator.Validate(entity);

            if (validationResults.IsValid)
            {
                _postRepository.SavePost(entity);
            }
            else
            {
                DisplayErrors(validationResults);
            }
        }

        private Post GetPost()
        {
            Post entity = new Post()
            {
                // Map form fields to entity properties
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
            return entity;
        }

        private void DisplayForm()
        {
            var postId = Convert.ToInt32(Request.QueryString["id"]);
            Post entity = _postRepository.GetPost(postId);
            PostBody.Text = entity.Body;
            PostTitle.Text = entity.Title;
        }

        private void DisplayErrors(ValidationResult results)
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");

            // Display errors to the user
            foreach (var failure in results.Errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    summary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }
    }

    #region helpers

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<ValidationError> Errors { get; set; }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostValidator
    {
        public ValidationResult Validate(Post entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T> : IQueryable<T>
    {
        public void Add(T entity)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class PostDbContext
    {
        public DbSet<Post> Posts { get; set; }

        public void SaveChanges()
        {
        }
    }
    #endregion

}