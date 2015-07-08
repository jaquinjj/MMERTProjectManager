using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface ITasks
    {
        /// <summary>
        /// Tüm Tasklar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Tasks> GetAll();


        /// <summary>
        /// Task sistemde kayıtlı mı.
        /// </summary>
        /// <param name="TaskName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Tasks> ValidateTask1(MMERT.MODEL.Tasks kllnici);

        /// <summary>
        /// Task bul.
        /// </summary>
        /// <param name="TaskId"></param>
        /// <returns></returns>
        MMERT.MODEL.Tasks Find(int TaskId);

        /// <summary>
        /// Task ekle.
        /// </summary>
        /// <param name="Task"></param>
        void Insert(MMERT.MODEL.Tasks Task);

        /// <summary>
        /// Task güncelle.
        /// </summary>
        /// <param name="Task"></param>
        void Update(MMERT.MODEL.Tasks Task);

        /// <summary>
        /// Task sil.
        /// </summary>
        /// <param name="Task">Task</param>
        void Delete(MMERT.MODEL.Tasks Task);

        /// <summary>
        /// Task sil.
        /// </summary>
        /// <param name="TaskId">Task Id</param>
        void Delete(int TaskId);
    }
}
