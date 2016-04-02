using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingStore.Domain.Entities;

namespace WEBUI.Models
{
    public class CProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaginInfo pagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}