﻿using System;
using System.Collections.Generic;
using System.Text;
using Webs.Domain.Entities;

namespace Webs.Domain.Contracts
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
