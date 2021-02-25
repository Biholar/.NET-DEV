using System;
using System.Collections.Generic;
using System.Text;

namespace SkillAppAdoDapperWebApi.DAL.Entities.SQLEntities
{
    class Categories
    {
        public int categories_id { get; set; }

        public string category_name { get; set; }

        public string category_desc { get; set; }

        public string exp_date { get; set; }

    }
}
