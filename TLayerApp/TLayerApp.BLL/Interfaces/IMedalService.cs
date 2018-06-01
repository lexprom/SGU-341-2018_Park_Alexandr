using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLayerApp.BLL.DTO;

namespace TLayerApp.BLL.Interfaces
{
    public interface IMedalService
    {
        MedalDTO GetMedal(int id);
        IEnumerable<UserDTO> GetUsers();
        void AssignMedal(MedalDTO userDTO);
        void Dispose();
    }
}
