using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.DATA;
using MMERT.SERVICE.Interfaces;

namespace MMERT.SERVICE
{
    public class ProjectsService:IProjects
    {
        MMERT.DATA.IRepository<MMERT.MODEL.Projects> _userRepo;
        MMERT.DATA.IUnitOfWork _uow;

        public ProjectsService(MMERT.DATA.IUnitOfWork uow)
        {
            _uow = uow;
            _userRepo = _uow.GetRepository<MMERT.MODEL.Projects>();
        }

        public IQueryable<MMERT.MODEL.Projects> GetAll()
        {
          return  _userRepo.GetAll();
        }

        public List<MMERT.MODEL.Projects> ValidateUser1(MMERT.MODEL.Projects kllnici)
        {
            throw new NotImplementedException();
        }

        public MMERT.MODEL.Projects Find(int userd)
        {
           return _userRepo.Find(userd);
        }

        public void Insert(MMERT.MODEL.Projects Project)
        {
            _userRepo.Insert(Project);
        }

        public void Update(MMERT.MODEL.Projects Project)
        {
            _userRepo.Update(Project);
        }

        public void Delete(MMERT.MODEL.Projects Project)
        {
            _userRepo.Delete(Project);
        }

        public void Delete(int Project)
        {
            _userRepo.Delete(Project);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<MMERT.MODEL.Projects> Listing(MMERT.MODEL.Projects s)
        {
            var result = new List<MMERT.MODEL.Projects>();


            using (var db = new Context())
            {
                var proje = db.Projects.ToList();

                foreach (var prjd in proje)
                {
                    var model = new MMERT.MODEL.Projects
                    {
                        ID = prjd.ID,
                        PROJECTNAME = prjd.PROJECTNAME,
                        PROJECTDESCRP = prjd.PROJECTDESCRP,
                        BEGIN = prjd.BEGIN,
                        FINISH=prjd.FINISH,
                        CATEGORYID=prjd.CATEGORYID
                    };

                    result.Add(model);
                }
                return result;
            }


        }


        public List<MODEL.Projects> ValidateProject1(MODEL.Projects kllnici)
        {
            throw new NotImplementedException();
        }
    }
}
