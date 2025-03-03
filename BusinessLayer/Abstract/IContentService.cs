using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListHeadingById(int id); //parametreye göre listeleme
        void ContentAdd(Content content);
        Category GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
