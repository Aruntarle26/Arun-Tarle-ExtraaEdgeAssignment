﻿using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public interface IMobileRepository
    {
        IEnumerable<Mobile> GetAllMobile();
        Mobile GetMobileById(int id);
        int AddMobile(Mobile mob);
        int UpdateMobile(Mobile mob);
        int DeleteMobile(int id);
    }
}
