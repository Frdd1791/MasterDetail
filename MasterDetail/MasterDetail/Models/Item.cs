using System;

namespace MasterDetail.Models
{
    using SQLite;
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Valor { get; set; }
        public string Detalle { get; set; }
    }
}