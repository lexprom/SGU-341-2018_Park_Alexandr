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
            User user = DataBase.Users.Get(medalDTO.UserID);
            Medal medal = DataBase.Medals.Get(medalDTO.ID);
            if (user == null)
                throw new Exception("404");
            user.Medals.Add(medal);
            medal.Users.Add(user);
            DataBase.Users.Update(user);
            DataBase.Medals.Update(medal);
            DataBase.Save();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(DataBase.Users.GetAll());
        }
    }
}
