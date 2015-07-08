using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface IWorks
    {
        /// <summary>
        /// Tüm Reportlar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Reports> GetAll();


        /// <summary>
        /// Report sistemde kayıtlı mı.
        /// </summary>
        /// <param name="ReportName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Reports> ValidateReport1(MMERT.MODEL.Reports kllnici);

        /// <summary>
        /// Report bul.
        /// </summary>
        /// <param name="ReportId"></param>
        /// <returns></returns>
        MMERT.MODEL.Reports Find(int ReportId);

        /// <summary>
        /// Report ekle.
        /// </summary>
        /// <param name="Report"></param>
        void Insert(MMERT.MODEL.Reports Report);

        /// <summary>
        /// Report güncelle.
        /// </summary>
        /// <param name="Report"></param>
        void Update(MMERT.MODEL.Reports Report);

        /// <summary>
        /// Report sil.
        /// </summary>
        /// <param name="Report">Report</param>
        void Delete(MMERT.MODEL.Reports Report);

        /// <summary>
        /// Report sil.
        /// </summary>
        /// <param name="ReportId">Report Id</param>
        void Delete(int ReportId);
    }
}
