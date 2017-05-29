using System;
using System.Collections.Generic;
using System.Data;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Interface.Repository
{
    public interface IAttributeRepository: IBaseRepository<CharacterAttribute>
    {
        DataTable GetBySystemId(short systemId);
    }
}
