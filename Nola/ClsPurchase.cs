using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nola
{
    public class ClsPurchase
    {
        public void deletePurchase(Purchase pu)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Purchase purchaseFound = new Purchase();
            purchaseFound = entity.Purchase.Where(p => p.IdPurchase.Equals(pu.IdPurchase)).FirstOrDefault();
            entity.Purchase.Remove(purchaseFound);
            entity.SaveChanges();
        }

        public void updatePurchase(Purchase oldPurchase, Purchase newPurchase)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Purchase purchaseFound = new Purchase();
            purchaseFound = entity.Purchase.Where(p => p.IdPurchase.Equals(oldPurchase.IdPurchase)).FirstOrDefault();
            purchaseFound.date = newPurchase.date;
            purchaseFound.fee = newPurchase.fee;
            purchaseFound.idCar = newPurchase.idCar;
            purchaseFound.price = newPurchase.price;
            entity.SaveChanges();
        }

        public void addPurchase(Purchase p)
        {
            NolaDBEntities entity = new NolaDBEntities();
            entity.Purchase.Add(p);
            entity.SaveChanges();
        }

        public List<viewPurchaseCar> listPurchase()
        {
            NolaDBEntities entity = new NolaDBEntities();
            return entity.viewPurchaseCar.ToList();
        }
    }
}
