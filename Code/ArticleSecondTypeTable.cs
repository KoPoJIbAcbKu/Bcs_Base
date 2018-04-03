using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc_Base.Code
{
    public class ArticleSecondTypeTable
    {
        [Key]
        [ForeignKey("ArticleCommonTable")]
        public long Id { get; set; }
        public string ArticleSecondTypeProperty { get; set; }
        public ArticleCommonTable ArticleCommonTable { get; set; }
    }
}
