using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.DATA;
using MMERT.SERVICE.Interfaces;

namespace MMERT.SERVICE
{
    public class TaskService:ITasks
    {
        MMERT.DATA.IRepository<MMERT.MODEL.Tasks> _TaskRepo;
        MMERT.DATA.IUnitOfWork _uow;

        public TaskService(MMERT.DATA.IUnitOfWork uow)
        {
            _uow = uow;
            _TaskRepo = _uow.GetRepository<MMERT.MODEL.Tasks>();
        }

        public IQueryable<MMERT.MODEL.Tasks> GetAll()
        {
          return  _TaskRepo.GetAll();
        }

        public List<MMERT.MODEL.Tasks> ValidateTask1(MMERT.MODEL.Tasks kllnici)
        {
            throw new NotImplementedException();
        }

        public MMERT.MODEL.Tasks Find(int Taskd)
        {
           return _TaskRepo.Find(Taskd);
        }

        public void Insert(MMERT.MODEL.Tasks Task)
        {
            _TaskRepo.Insert(Task);
        }

        public void Update(MMERT.MODEL.Tasks Task)
        {
            _TaskRepo.Update(Task);
        }

        public void Delete(MMERT.MODEL.Tasks Task)
        {
            _TaskRepo.Delete(Task);
        }

        public void Delete(int Taskd)
        {
            _TaskRepo.Delete(Taskd);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<MMERT.MODEL.Tasks> Listing(MMERT.MODEL.Tasks s)
        {
            var result = new List<MMERT.MODEL.Tasks>();


            using (var db = new Context())
            {
                var Task = db.Tasks.ToList();

                foreach (var Taskd in Task)
                {
                    var model = new MMERT.MODEL.Tasks
                    {
                        ID=Taskd.ID,
                        TASKNAME=Taskd.TASKNAME,
                        TASKDATE=Taskd.TASKDATE,
                        TASKNOTE=Taskd.TASKNOTE,
                        TASKSTATE=Taskd.TASKSTATE,
                        TASKTYPE=Taskd.TASKTYPE,
                        ProjectId=Taskd.ProjectId
                    };

                    result.Add(model);
                }
                return result;
            }


        }
    }
}
