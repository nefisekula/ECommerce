using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comment Get(int ID)
        {
            return _commentRepository.Get(ID);
        }

        public void Insert(Comment comment)
        {
            _commentRepository.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _commentRepository.Update(comment);
        }

        public void Delete(Comment comment)
        {
            _commentRepository.Delete(comment);
        }
    }
}
