﻿using SalesWebMvc.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FinAll()
        {
            return _context.Seller.ToList();
        }
    }
}
