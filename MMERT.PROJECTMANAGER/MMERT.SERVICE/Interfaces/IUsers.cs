using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface IUsers:IDisposable
    {
        /// <summary>
        /// Tüm Userlar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Users> GetAll();


        /// <summary>
        /// User sistemde kayıtlı mı.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Users> ValidateUser1(MMERT.MODEL.Users kllnici);

        /// <summary>
        /// User bul.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        MMERT.MODEL.Users Find(int UserId);

        /// <summary>
        /// User ekle.
        /// </summary>
        /// <param name="user"></param>
        void Insert(MMERT.MODEL.Users User);

        /// <summary>
        /// User güncelle.
        /// </summary>
        /// <param name="user"></param>
        void Update(MMERT.MODEL.Users User);

        /// <summary>
        /// User sil.
        /// </summary>
        /// <param name="user">User</param>
        void Delete(MMERT.MODEL.Users User);

        /// <summary>
        /// User sil.
        /// </summary>
        /// <param name="userId">User Id</param>
        void Delete(int UserId);
    }
}
