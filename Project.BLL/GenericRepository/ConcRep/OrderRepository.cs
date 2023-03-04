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
    public class OrderRepository:BaseRepository<Order>
    {
        MyContext _orderDb;
        public OrderRepository()
        {
            _orderDb = DBTool.DbInstance;
        }

        public void UpdateDate()
        {

        }

    }
}
