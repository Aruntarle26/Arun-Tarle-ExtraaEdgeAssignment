using ArunExtraedgeassignment.Data;
using ArunExtraedgeassignment.Model;

namespace ArunExtraedgeassignment.Repository
{
    public class LoginRepository: ILoginRepository
    {
        private readonly ApplicationDbContext db;
        public LoginRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public UserModel Add(UserModel usermodel)
        {

            int result = 0;
            var v=db.Users.Where(x => x.Password == usermodel.Password).FirstOrDefault();
            
           
            return v;
        }
    }
}
