﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_LOG
    {

        [Key]
        public int TBL_LOG_ID { get; set; }
        public int USER_ID { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime GIRIS { get; set; }
        public DateTime CIKIS { get; set; }

        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }

        public string? OZEL_KOD { get; set; }




    }
}
