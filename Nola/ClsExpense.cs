using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nola
{
    public class ClsExpense
    {
        public void deleteExpense(Expense e)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Expense expenseFound = new Expense();
            expenseFound = entity.Expense.Where(p => p.IdExpense.Equals(e.IdExpense)).FirstOrDefault();
            entity.Expense.Remove(expenseFound);
            entity.SaveChanges();
        }

        public void updateExpense(Expense oldExpense, Expense newExpense)
        {
            NolaDBEntities entity = new NolaDBEntities();
            Expense expenseFound = new Expense();
            expenseFound = entity.Expense.Where(p => p.IdExpense.Equals(oldExpense.IdExpense)).FirstOrDefault();
            expenseFound.description = newExpense.description;
            expenseFound.price = newExpense.price;
            expenseFound.date = newExpense.date;
            expenseFound.idCar = newExpense.idCar;
            entity.SaveChanges();
        }

        public void addExpense(Expense e)
        {
            NolaDBEntities entity = new NolaDBEntities();
            entity.Expense.Add(e);
            entity.SaveChanges();
        }

        public List<viewExpenseCar> listExpense()
        {
            NolaDBEntities entity = new NolaDBEntities();
            return entity.viewExpenseCar.ToList();
        }
    }
}
