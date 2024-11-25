using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using do_an_tin_hoc_6tr.product;
namespace do_an_tin_hoc_6tr.List
{
    class product_docgia :ISevices<Cdocgia>
    {
        List<Cdocgia> listdocgia = new List<Cdocgia>();

        public List<Cdocgia> getALL()
        {
            return listdocgia;
        }

        public Cdocgia getById(string id)
        {
            throw new NotImplementedException();
        }

        public void setAll(List<Cdocgia> list)
        {
            listdocgia=list;
        }

        public void sua(Cdocgia entity)
        {
            throw new NotImplementedException();
        }

        public void them(Cdocgia entity)
        {
            listdocgia.Add(entity);
        }

        public void xoa(Cdocgia id)
        {
            listdocgia.Remove(id);
        }
    }
}
