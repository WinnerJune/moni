using O.DAL;
using O.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.BL
{
    public class PersonaOBL
    {
        public static async Task<Personao?> GetById(int Id)
        {
            return await PersonaODAL.GetById(Id);
        }

        public static async Task<int?> Create(Personao persoO)
        {
            return await PersonaODAL.Create(persoO);
        }

        public static async Task<int?> Delete(Personao persoO)
        {
            return await PersonaODAL.Delete(persoO);
        }

        public static async Task<int?> Update(Personao persoO)
        {
            return await PersonaODAL.Update(persoO);
        }

        public static async Task<List<Personao?>> GetAll()
        {
            return await PersonaODAL.GetAll();
        }

    }
}
