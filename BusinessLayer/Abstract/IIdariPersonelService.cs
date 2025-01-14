﻿using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IIdariPersonelService
    {
        void Add(TBL_IDARI_PERSONEL idaripersonel);
        void Remove(TBL_IDARI_PERSONEL idaripersonel);
        void Update(TBL_IDARI_PERSONEL idaripersonel);
        List<TBL_IDARI_PERSONEL> GetList();
        TBL_IDARI_PERSONEL GetById(int id);
    }
}
