﻿using ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Insert;
using ParseadorXML.Domain.src.Interfaces.Services.Base.CRUD.Select;
using ParseadorXML.Domain.src.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseadorXML.Domain.src.Interfaces.Services.Base
{
    public interface IEmisorService : IInsertServceAsync<EmisorDTO>,
                                      ISelectAllServiceAsync<EmisorDTO>
    {
    }
}
