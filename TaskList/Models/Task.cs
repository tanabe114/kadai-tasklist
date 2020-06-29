using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskList.Models
{
    public class Task
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("タイトル")]
        [Required(ErrorMessage = "タイトルを入力してください。")]
        public string Title { get; set; }

        [DisplayName("タスク")]
        [Required(ErrorMessage = "タスクを入力してください。")]
        public string Content { get; set; }

        [DisplayName("重要度")]
        public string Severity { get; set; }

        [DisplayName("期限")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "期限を入力してください。")]
        public DateTime DeadLine { get; set; }

        [DisplayName("作成日時")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("更新日時")]
        public DateTime UpdatedAt { get; set; }
    }
}