using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingStore.Domain.Entities;

namespace WEBUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}