using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.SERVICE.Interfaces;

namespace MMERT.SERVICE
{
    public class NoteService:INotes
    {
        public IQueryable<MODEL.Notes> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<MODEL.Notes> ValidateNote1(MODEL.Notes kllnici)
        {
            throw new NotImplementedException();
        }

        public MODEL.Notes Find(int NoteId)
        {
            throw new NotImplementedException();
        }

        public void Insert(MODEL.Notes Note)
        {
            throw new NotImplementedException();
        }

        public void Update(MODEL.Notes Note)
        {
            throw new NotImplementedException();
        }

        public void Delete(MODEL.Notes Note)
        {
            throw new NotImplementedException();
        }

        public void Delete(int NoteId)
        {
            throw new NotImplementedException();
        }
    }
}
