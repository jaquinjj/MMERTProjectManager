using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.DATA;
using MMERT.SERVICE.Interfaces;

namespace MMERT.SERVICE
{
    public class UserService:IUsers
    {
        MMERT.DATA.IRepository<MMERT.MODEL.Users> _userRepo;
        MMERT.DATA.IUnitOfWork _uow;

        public UserService(MMERT.DATA.IUnitOfWork uow)
        {
            _uow = uow;
            _userRepo = _uow.GetRepository<MMERT.MODEL.Users>();
        }

        public IQueryable<MMERT.MODEL.Users> GetAll()
        {
          return  _userRepo.GetAll();
        }

        public List<MMERT.MODEL.Users> ValidateUser1(MMERT.MODEL.Users kllnici)
        {
            throw new NotImplementedException();
        }

        public MMERT.MODEL.Users Find(int userd)
        {
           return _userRepo.Find(userd);
        }

        public void Insert(MMERT.MODEL.Users User)
        {
            _userRepo.Insert(User);
        }

        public void Update(MMERT.MODEL.Users User)
        {
            _userRepo.Update(User);
        }

        public void Delete(MMERT.MODEL.Users User)
        {
            _userRepo.Delete(User);
        }

        public void Delete(int userd)
        {
            _userRepo.Delete(userd);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<MMERT.MODEL.Users> Listing(MMERT.MODEL.Users s)
        {
            var result = new List<MMERT.MODEL.Users>();


            using (var db = new Context())
            {
                var user = db.Users.ToList();

                foreach (var userd in user)
                {
                    var model = new MMERT.MODEL.Users
                    {
                        ID = userd.ID,
                        USERNAME = userd.USERNAME,
                        PASSWORD = userd.PASSWORD
                    };

                    result.Add(model);
                }
                return result;
            }


        }
    }
}
