using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Interface.Repository
{
    public interface IScaleRepository : IBaseRepository<Scale>
    {
        DataTable GetAllDataTable();
    }
}
