using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project_InditionFinal_DAL
{
    public static class DatabaseOperations
    {
        public static List<Klant> OphalenKlant()
        {
            using (InditionEntities entities = new InditionEntities())
            {
                var query = entities.Klanten;
                return query.ToList();
            }
        }
        public static List<Behandeling> OphalenBehandeling(Klant klant)
        {
            using (InditionEntities entities = new InditionEntities())
            {
                var query = entities.Behandelingen
                    .Include(x => x.BehandelingLijn)
                    .Include(x => x.BehandelingLijn.Select(sub => sub.Product))
                    .Where(x => x.behandeling_klant == klant.klant_id);
                return query.ToList();
            }
        }
        public static List<Product> OphalenProduct()
        {
            using (InditionEntities entities = new InditionEntities())
            {
                var query = entities.Producten;
                return query.ToList();
            }
        }
        public static List<BehandelingLijn> OphalenBehandelingLijn()
        {
            using (InditionEntities entities = new InditionEntities())
            {
                var query = entities.BehandelingLijn;
                return query.ToList();
            }
        }
        public static int ToevoegenKlant(Klant klant)
        {
            using (InditionEntities entities = new InditionEntities())
            {
                entities.Klanten.Add(klant);
                return entities.SaveChanges();
            }
        }
        public static int VerwijderenKlant(Klant klant)
        {
            using (InditionEntities entities = new InditionEntities())
            {
                entities.Entry(klant).State = EntityState.Deleted;
                return entities.SaveChanges();
            }
        }
        public static int ToevoegenBehandeling(Behandeling behandeling, BehandelingLijn lijn)
        {
            using (InditionEntities entities = new InditionEntities())
            {
                entities.Behandelingen.Add(behandeling);
                entities.BehandelingLijn.Add(lijn);
                return entities.SaveChanges();
            }
        }
        public static int AanpassenKlant(Klant klant)
        {
            using (InditionEntities entities = new InditionEntities())
            {
                entities.Entry(klant).State = EntityState.Modified;
                return entities.SaveChanges();
            }
        }
    }
}
