﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationService.Models
{
    public class TarefasContext: DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
     
    }
}