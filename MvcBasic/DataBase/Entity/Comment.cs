﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcBasic.DataBase.Entity
{
    [DisplayColumn("Body")]
    public class Comment
    {
        public int Id { get; set; }

        [DisplayName("氏名")]
        public string Name { get; set; }

        [DisplayName("コメント")]
        public string Body { get; set; }

        [DisplayName("更新日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime Updated { get; set; }

        [DisplayName("記者")]
        public virtual Article Article { get; set; }
    }
}