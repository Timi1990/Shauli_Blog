using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuli_blog.Services
{
    interface IService<T>
    {
        T index(int id);

        List<T> list();

        void details(T entity);
    }
}
