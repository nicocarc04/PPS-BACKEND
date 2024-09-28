﻿using Application.Models;
using Application.Models.Requests;
using Infrastructure.TempModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAllUsers();
        UserDto GetUserById(int id);
        //User CreateUser(UserRequest user);
        //void DeleteUser(int id);
        //void UpdateUser(int id, UserRequest updatedUser);
    }
}
