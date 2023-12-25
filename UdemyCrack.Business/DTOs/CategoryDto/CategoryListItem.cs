using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Business.DTOs.CategoryDto
{
    public  class CategoryListItem:BaseAuditable
    {
        public string Name { get; set; }
    }
}
