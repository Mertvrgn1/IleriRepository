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
    public class LecRepository : BaseRepository<Lecturer>, ILecRepository
    {
        
        public void IncreaseSalarybyPercent(decimal rate)
        {
            //Zam yapılacak.
            throw new NotImplementedException();
        }

        public List<HumanDTO> SummaryList()
        {
            return Set().Select(x => new HumanDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname

            }).ToList();

         
        }
    }
}
