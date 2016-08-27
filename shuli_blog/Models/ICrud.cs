using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuli_blog.Models
{
    interface ICrud<E>
    {
        E index(int id);
        List<E> list();
        void details(E entity);
        Boolean delete(int id);
        E create();
    }
}
