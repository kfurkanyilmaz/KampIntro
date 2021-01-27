using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product          //Entity, Varlık
        //Bu tip classlarda sadece özellik olur. 
    {
        //snippet -tab tab- hazır kodlar
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; } //reference key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
