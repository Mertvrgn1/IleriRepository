using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    class EmpRepository : BaseRepository<Employees>, IEmpRepository
    {
        
        public void IncreaseSalarybyPercent(decimal rate)
        {
            
            //Zam Yapma Kodu Yazılacak
        }

        public List<HumanDTO> SummaryList()
        {
            return Set().Select(x => new HumanDTO 
            {
                Id=x.Id,
                Name=x.Name,
                Surname=x.Surname,
                //Salary=x.Salary

            }).ToList();
        }
    }
}
