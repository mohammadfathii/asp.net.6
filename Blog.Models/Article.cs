using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Article")]
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "لطفا عنوان مقاله را وارد کنید")]
        [DisplayName("عنوان مقاله")]
        public string Title { get; set; }
        [Required(ErrorMessage = "لطفا توضیحات مقاله را وارد کنید")]
        [DisplayName("توضیحات مقاله")]
        public string Description { get; set; }
        [Required(ErrorMessage = "لطفا متن مقاله را وارد کنید")]
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
        [Required(ErrorMessage = "لطفا آدرس عکس را وارد کنید")]
        [DisplayName("آدرس عکس")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "لطفا متن جایگزین عکس را وارد کنید")]
        [DisplayName("متن جایگزین عکس")]
        public string ImageAlt { get; set; }
        [Required(ErrorMessage = "لطفا عنوان عکس را وارد کنید")]
        [DisplayName("عنوان عکس")]
        public string ImageTitle { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
