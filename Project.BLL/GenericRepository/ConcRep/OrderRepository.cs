using Project.BLL.DesignPattern.SingletonPattern;
using Project.BLL.GenericRepository.BaseRep;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.ConcRep
{
    public class OrderRepository : BaseRepository<Order>
    {
        MyContext _orderDb;
        public OrderRepository()
        {
            _orderDb = DBTool.DbInstance;
        }
        public void UpdateDate(string saloonName, int standNumber, int delayNumber)
        {
            IQueryable y = _orderDb.Orders.Where(x => x.Stand.Saloon.SaloonName == $"{saloonName}" && x.Stand.StandNo == $"{standNumber}");

            foreach (Order item in y)
            {
                item.DueDate.AddDays(delayNumber);
                _orderDb.SaveChanges();
            }
        }
    }

}

