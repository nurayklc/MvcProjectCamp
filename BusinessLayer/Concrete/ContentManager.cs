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
    public class ContentManager : IContentService
    {
        IContentDAL _contentDal;

        public ContentManager(IContentDAL contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetContent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContentList()
        {
            return _contentDal.GetAll();
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.GetFilterList(x => x.HeadingID == id);
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
