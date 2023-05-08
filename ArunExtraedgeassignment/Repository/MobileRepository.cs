﻿using ArunExtraedgeassignment.Data;
using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public class MobileRepository : IMobileRepository
    {
        private readonly ApplicationDbContext db;
        public MobileRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddMobile(Mobile mob)
        {
            int result = 0;
            db.Mobiles.Add(mob);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteMobile(int id)
        {
            int result = 0;

            var mob = db.Mobiles.Where(x => x.MobileId == id).FirstOrDefault();
            if (mob != null)
            {
                db.Mobiles.Remove(mob);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Mobile> GetAllMobile()
        {
            return db.Mobiles.ToList();
        }

        public Mobile GetMobileById(int id)
        {
            var mob = db.Mobiles.Where(x => x.MobileId == id).FirstOrDefault();
            return mob;
        }

        public int UpdateMobile(Mobile mob)
        {
            int result = 0;

            var c = db.Mobiles.Where(x => x.MobileId == mob.MobileId).FirstOrDefault();
            if (c != null)
            {
                c.MobilePrice = mob.MobilePrice;
                c.BrandId = mob.BrandId;
                c.Model = mob.Model;
                c.ModelDescription = mob.ModelDescription;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
