using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_tin_hoc_6tr.List
{
    public interface ISevices<T>
    {
        List<T> getALL();
        void setAll(List<T> list);
        T getById(string id);
        void them(T entity);
        void xoa(T id);
        void sua(T entity);
    }
}