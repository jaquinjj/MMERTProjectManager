using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface IReports
    {
        /// <summary>
        /// Tüm Reportslar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Reports> GetAll();


        /// <summary>
        /// Reports sistemde kayıtlı mı.
        /// </summary>
        /// <param name="ReportsName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Reports> ValidateReports1(MMERT.MODEL.Reports kllnici);

        /// <summary>
        /// Reports bul.
        /// </summary>
        /// <param name="ReportsId"></param>
        /// <returns></returns>
        MMERT.MODEL.Reports Find(int ReportsId);

        /// <summary>
        /// Reports ekle.
        /// </summary>
        /// <param name="Reports"></param>
        void Insert(MMERT.MODEL.Reports Reports);

        /// <summary>
        /// Reports güncelle.
        /// </summary>
        /// <param name="Reports"></param>
        void Update(MMERT.MODEL.Reports Reports);

        /// <summary>
        /// Reports sil.
        /// </summary>
        /// <param name="Reports">Reports</param>
        void Delete(MMERT.MODEL.Reports Reports);

        /// <summary>
        /// Reports sil.
        /// </summary>
        /// <param name="ReportsId">Reports Id</param>
        void Delete(int ReportsId);
    }
}
