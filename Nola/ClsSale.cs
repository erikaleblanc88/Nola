using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nola
{
    public class ClsSale
    {
        public void deleteSale(Sale s)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Sale saleFound = new Sale();
            saleFound = entity.Sale.Where(p => p.IdSale.Equals(s.IdSale)).FirstOrDefault();
            entity.Sale.Remove(saleFound);
            entity.SaveChanges();
        }

        public void updateSale(Sale oldSale, Sale newSale)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Sale saleFound = new Sale();
            saleFound = entity.Sale.Where(p => p.IdSale.Equals(oldSale.IdSale)).FirstOrDefault();
            saleFound.date = newSale.date;
            saleFound.idCar = newSale.idCar;
            saleFound.price = newSale.price;
            entity.SaveChanges();
        }

        public void addSale(Sale s)
        {
            NolaDBEntities entity = new NolaDBEntities();
            entity.Sale.Add(s);
            entity.SaveChanges();
        }

        public List<viewSaleCar> listSale()
        {
            NolaDBEntities entity = new NolaDBEntities();
            return entity.viewSaleCar.ToList();
        }
    }
}
