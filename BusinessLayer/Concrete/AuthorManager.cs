using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDAL authorDAL;
        public AuthorManager(IAuthorDAL _authorDAL)
        {
           authorDAL = _authorDAL;
        }

        public void AddAuthor(Author author)
        {
            authorDAL.Add(author);
        }

        public void DeleteAuthor(Author author)
        {
            authorDAL.Delete(author);
        }

        public Author GetAuthor(int id)
        {
            return authorDAL.GetById(x => x.AuthorID == id);
        }

        public List<Author> GetAuthorList()
        {
            return authorDAL.GetAll();
        }

        public void UpdateAuthor(Author author)
        {
            authorDAL.Update(author);
        }
    }
}
