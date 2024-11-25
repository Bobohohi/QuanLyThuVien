using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using do_an_tin_hoc_6tr.product;

namespace do_an_tin_hoc_6tr.List
{
    class product_admin : ISevices<Cthuvien>
    {
        List<Cthuvien> listsach = new List<Cthuvien>();

        public List<Cthuvien> getALL()
        {
            return listsach;
        }

        public Cthuvien getById(string id)
        {
            throw new NotImplementedException();
        }

        public void setAll(List<Cthuvien> list)
        {
            listsach=list;
        }

        public void sua(Cthuvien entity)
        {
            throw new NotImplementedException();
        }

        public void them(Cthuvien entity)
        {
            listsach.Add(entity);
        }

        public void xoa(Cthuvien id)
        {
            listsach.Remove(id);
        }
    }
}
