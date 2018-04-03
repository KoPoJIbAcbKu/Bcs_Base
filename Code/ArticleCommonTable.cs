using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsc_Base.Code
{
    public class ArticleCommonTable
    {
        [Key]
        public long Id { get; set; }
        public string ArticleTitle { get; set; }
        public string Type { get; set; }
        public ArticleFirstTypeTable ArticleFirstTypeTable { get; set; }
        public ArticleSecondTypeTable ArticleSecondTypeTable { get; set; }
    }
}
