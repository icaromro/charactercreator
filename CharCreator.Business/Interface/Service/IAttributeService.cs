using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Model.Entity;

namespace CharCreator.Business.Interface.Service
{
    public interface IAttributeService: IBaseService<CharacterAttribute>
    {
        DataTable GetBySystemId(short systemId);
    }
}
