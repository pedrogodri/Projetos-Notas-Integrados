﻿using ProjetoNotas.Infra.Data.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Repositories
{
    public class NoteRepository
    {
        public NoteRepository(SQLServerContext context)
            : base(context)
        {
        }
    }
}