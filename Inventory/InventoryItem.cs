﻿namespace Inventory
{
    public class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Item# - {ItemNo}, Description - {Description}, Price - {Price:C}";
        }
    }
}