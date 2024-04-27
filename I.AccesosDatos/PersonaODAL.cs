using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using O.EN;
using System.Data;

namespace O.DAL
{
    public class PersonaODAL
    {
        public static async Task<Personao?> GetById(int Id)
        {
            Personao? personaO = new();

            using (var dbContext = new ComunDB())
            {
                personaO = await dbContext.PersonaO.FirstOrDefaultAsync(r => r.Id == Id);
            }

            return personaO;
        }

        public static async Task<int?> Create(Personao persoO)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(persoO);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }

        public static async Task<int?> Delete(Personao persoO)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var existingPersonao = await dbContext.PersonaO.FirstOrDefaultAsync(r => r.Id == persoO.Id);
                if (existingPersonao != null)
                {
                    dbContext.Remove(existingPersonao);
                    result = await dbContext.SaveChangesAsync();
                }
            }

            return result;
        }


        public static async Task<int?> Update(Personao persoO)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var personaO = await dbContext.PersonaO.FirstOrDefaultAsync(r => r.Id == persoO.Id);
                if (personaO != null)
                {
                    personaO.NombreO = persoO.NombreO;
                    personaO.NombreO = persoO.ApellidoO;
                    personaO.NombreO = persoO.FehaNacimientoO;
                    personaO.NombreO = persoO.sueldoO;
                    personaO.NombreO = persoO.EstatusO;
                    personaO.NombreO = persoO.ComentarioO;

                    result = await dbContext.SaveChangesAsync();
                }
            }

            return result;
        }


        public static async Task<List<Personao?>> GetAll()
        {
            var pior = new List<Personao>();

            using (var dbContext = new ComunDB())
            {
                pior = await dbContext.PersonaO.ToListAsync();
            }

            return pior;
        }
    }
}
