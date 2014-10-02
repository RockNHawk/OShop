﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OShop.Models {
    public class ShoppingCartItem {
        public int Id;
        public IShopItem Item;
        public IShippingInfo ShippingInfo;
        public int Quantity;

        public decimal UnitPrice {
            get {
                return Item.GetUnitPrice(Quantity);
            }
        }

    }
}