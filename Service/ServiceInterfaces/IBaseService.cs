﻿using DataTransferObject.DTOClasses;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceInterfaces
{
    public interface IBaseService<Entity,DTO,KeyTypeId> where Entity : class  where DTO : BaseDTO<KeyTypeId> where KeyTypeId : struct
    {
        public DTO TranslateToDTO(Entity entity);
        public Entity TranslateToEntity(DTO dto);
    }
}
