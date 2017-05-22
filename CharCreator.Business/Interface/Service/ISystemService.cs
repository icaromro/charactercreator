using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCreator.Business.Interface.Service
{
    public interface ISystemService : IBaseService<Model.Entity.System>
    {
        IEnumerable<Model.Entity.System> GetAllActive();
        DataTable GetAllActiveDataTable();
    }
}
