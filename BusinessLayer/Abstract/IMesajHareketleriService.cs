﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesajHareketleriService
    {
        void Add(TBL_MESAJ_HAREKETLERI mesajhareketleri);
        void Remove(TBL_MESAJ_HAREKETLERI mesajhareketleri);
        void Update(TBL_MESAJ_HAREKETLERI mesajhareketleri);
        List<TBL_MESAJ_HAREKETLERI> GetList();
        TBL_MESAJ_HAREKETLERI GetById(int id);
    }
}
