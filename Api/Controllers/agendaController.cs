using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class agendaController : ControllerBase
    {
        [HttpGet]
        public List<Models.TbInfo> consultarAgenda()
        {
            Models.AgendaDbContext ctx = new Models.AgendaDbContext();
            List<Models.TbInfo> agendamentos = ctx.TbInfos.ToList();
            return agendamentos;
        }

        [HttpPost]
        public Models.TbInfo inserirTarefa(Models.TbInfo info)
        {
            Models.AgendaDbContext ctx = new Models.AgendaDbContext();
            ctx.TbInfos.Add(info);
            ctx.SaveChanges();
            return info;
        }

        [HttpDelete]
        public void deletarTarefa(Models.TbInfo info)
        {
            Console.WriteLine(info);
            Models.AgendaDbContext ctx = new Models.AgendaDbContext();
            Models.TbInfo tarefa = ctx.TbInfos.First(x => x.IdAfazer == info.IdAfazer);
            ctx.TbInfos.Remove(tarefa);
            ctx.SaveChanges();
        }
    }
}