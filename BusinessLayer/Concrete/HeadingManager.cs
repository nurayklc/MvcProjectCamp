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
    public class HeadingManager : IHeadingService
    {
        IHeadingDAL headingDAL;

        public HeadingManager(IHeadingDAL headingDAL)
        {
            this.headingDAL = headingDAL;
        }

        public void AddHeading(Heading heading)
        {
            headingDAL.Add(heading);
        }

        public void DeleteHeading(Heading heading)
        {
            headingDAL.Delete(heading);
        }

        public Heading GetHeading(int id)
        {
            return headingDAL.GetById(x => x.HeadingID == id);
        }

        public List<Heading> GetHeadings()
        {
            return headingDAL.GetAll();
        }

        public void UpdateHeading(Heading heading)
        {
            headingDAL.Update(heading);
        }
    }
}
