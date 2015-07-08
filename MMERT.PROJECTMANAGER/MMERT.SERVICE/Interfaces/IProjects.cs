using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface IProjects
    {
        /// <summary>
        /// Tüm Projectlar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Projects> GetAll();


        /// <summary>
        /// Project sistemde kayıtlı mı.
        /// </summary>
        /// <param name="ProjectName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Projects> ValidateProject1(MMERT.MODEL.Projects kllnici);

        /// <summary>
        /// Project bul.
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        MMERT.MODEL.Projects Find(int ProjectId);

        /// <summary>
        /// Project ekle.
        /// </summary>
        /// <param name="Project"></param>
        void Insert(MMERT.MODEL.Projects Project);

        /// <summary>
        /// Project güncelle.
        /// </summary>
        /// <param name="Project"></param>
        void Update(MMERT.MODEL.Projects Project);

        /// <summary>
        /// Project sil.
        /// </summary>
        /// <param name="Project">Project</param>
        void Delete(MMERT.MODEL.Projects Project);

        /// <summary>
        /// Project sil.
        /// </summary>
        /// <param name="ProjectId">Project Id</param>
        void Delete(int ProjectId);
    }
}
