using BilgeAdam.YMSBank.Contract;
using BilgeAdam.YMSBank.Data.Entities;
using BilgeAdam.YMSBank.DataAccess.Contracts;
using BilgeAdam.YMSBank.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilgeAdam.YMSBank.Business.Concrete
{
    public class MenuService : IMenuApi
    {
        private readonly IUnitOfWork unitofWork;

        public MenuService(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public IEnumerable<MenuDto> GetAllActiveMenus()
        {
            var data = unitofWork.Repository<Menu>()
                                 .Where(i => i.IsDeleted != true && i.IsActive == true)
                                 .Select(i => new MenuDto {
                                     Action = i.Action,
                                     Controller = i.Controller,
                                     Area = i.Area,
                                     Id = i.Id,
                                     ModuleId = i.ModuleId,
                                     ModuleText = i.Module.Name,
                                     ParentId = i.ParentId,
                                     Text = i.Text
                                 });
            return data.ToList();               
        }
    }
}
