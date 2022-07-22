using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        void AddHeading(Heading heading);
        Heading GetHeading(int id);
        void UpdateHeading(Heading category);
        void DeleteHeading(Heading category);
        List<Heading> GetHeadings();
    }
}
