using do_an_tin_hoc_6tr.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_tin_hoc_6tr.List
{
    class product_muonsach : ISevices<Cmuonsach>
    {
        List<Cmuonsach> listmuonsach = new List<Cmuonsach>();

        public List<Cmuonsach> getALL()
        {
            return listmuonsach;
        }

        public Cmuonsach getById(string id)
        {
            throw new NotImplementedException();
        }

        public void setAll(List<Cmuonsach> list)
        {
            listmuonsach=list;
        }

        public void sua(Cmuonsach entity)
        {
            throw new NotImplementedException();
        }

        public void them(Cmuonsach entity)
        {
            listmuonsach.Add(entity);
        }

        public void xoa(Cmuonsach id)
        {
            listmuonsach.Remove(id);
        }
    }
}
