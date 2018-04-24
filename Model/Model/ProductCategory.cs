using Model.AbStract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("ProductCategorys")]
    public class ProductCategory: Auditable
    {
    }
}
