using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCreator.Model.Entity
{
    public class System
    {
        public short id { get; set; }        
        public string name { get; set; }
        public bool active { get; set; }
        
        public void LoadSystem(DataTable dataTableSystem)
        {
            DataRow dataRowSystem = dataTableSystem.Rows[0];
            LoadSystem(dataRowSystem);          
        }

        public void LoadSystem(DataRow dataRowSystem)
        {            
            this.id = Convert.ToInt16(dataRowSystem["id"]);
            this.name = dataRowSystem["name"].ToString();
            this.active = Convert.ToBoolean(dataRowSystem["active"]);
        }

        public bool IsActive()
        {
            return this.active;
        }
    }
}
