using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Article> Articles { get; set; }

        [Required(ErrorMessage = "لطفا نام دسته بندی را وارد کنید")]
        [DisplayName("نام")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا توضیحات دسته بندی را وارد کنید")]
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("تاریخ ساخت")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
