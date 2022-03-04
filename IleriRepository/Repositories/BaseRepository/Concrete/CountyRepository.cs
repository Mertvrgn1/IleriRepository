using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    class CountyRepository : BaseRepository<County>, ICountyRepository
    {
        public ComboBox GetCombo(ComboBox cb,int id)
        {
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            cb.DataSource = GetOption(id);
            
            return cb;
        }

        public List<CountyDTO>GetOption(int id)
        {
            return Set().Select(x => new CountyDTO
            {
                Id = x.Id,
                Name = x.Name,
                CityId=x.CityId

            }).Where(x=> x.CityId==id).ToList();
        }
    }

}
