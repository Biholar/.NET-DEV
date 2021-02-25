using System;
using System.Collections.Generic;
using System.Text;

namespace SkillAppAdoDapperWebApi.DAL.Entities.SQLEntities
{
    public class Product
    {
        public int prod_id { get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public string desc { get; set; }

        public int category_id { get; set; }

        public int prod_date { get; set; }
    }
}
