using ApplicationCore.Entities;
using ApplicationCore.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OrderDetailRepositoryAsync : BaseRepositoryAsync<Order_Detail>, IOrderDetailRepositoryAsync
    {
        public OrderDetailRepositoryAsync(OrderDbContext context) : base(context)
        {
        }
    }
}
