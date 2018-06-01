using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TLayerApp.BLL.DTO;
using TLayerApp.BLL.Interfaces;
using TLayerApp.DAL.Entities;
using TLayerApp.DAL.Interfaces;

namespace TLayerApp.BLL.Services
{
    public class MedalService : IMedalService
    {
        IUnitOfWork DataBase { get; set; }

        public MedalService (IUnitOfWork unit)
        {
            DataBase = unit;
        }

        public void AssignMedal(MedalDTO medalDTO)
        {
            User user = DataBase.User.Get(1);
            Medal medal = DataBase.Medal.Get(medalDTO.ID);
            if (user == null)
                throw new Exception("404 not found User");
            if (medal == null)
                throw new Exception("404 not found Medal");
 
            DataBase.User.Update(user);
            DataBase.Medal.Update(medal);
            DataBase.Save();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(DataBase.User.GetAll());
        }

        public MedalDTO GetMedal(int id)
        {
            var medal = DataBase.Medal.Get(1);
            return new MedalDTO { ID = medal.ID, Material = medal.Material, Name = medal.Name, UserID = 1};
        }
    }
}
