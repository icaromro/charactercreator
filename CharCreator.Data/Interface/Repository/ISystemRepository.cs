using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCreator.Data.Interface.Repository
{
    public interface ISystemRepository : IBaseRepository<Model.Entity.System>
    {
        DataTable GetAllActive();
    }
}
