using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.SERVICE.Interfaces
{
    public interface INotes
    {
        /// <summary>
        /// Tüm Notelar.
        /// </summary>
        /// <returns></returns>
        IQueryable<MMERT.MODEL.Notes> GetAll();


        /// <summary>
        /// Note sistemde kayıtlı mı.
        /// </summary>
        /// <param name="NoteName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<MMERT.MODEL.Notes> ValidateNote1(MMERT.MODEL.Notes kllnici);

        /// <summary>
        /// Note bul.
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        MMERT.MODEL.Notes Find(int NoteId);

        /// <summary>
        /// Note ekle.
        /// </summary>
        /// <param name="Note"></param>
        void Insert(MMERT.MODEL.Notes Note);

        /// <summary>
        /// Note güncelle.
        /// </summary>
        /// <param name="Note"></param>
        void Update(MMERT.MODEL.Notes Note);

        /// <summary>
        /// Note sil.
        /// </summary>
        /// <param name="Note">Note</param>
        void Delete(MMERT.MODEL.Notes Note);

        /// <summary>
        /// Note sil.
        /// </summary>
        /// <param name="NoteId">Note Id</param>
        void Delete(int NoteId);
    }
}
