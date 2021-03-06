﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotorReservas.Entidad;

namespace MotorReservas.Web.Controllers.Administracion
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            AdministraionService.AdministracionClient servicio = new AdministraionService.AdministracionClient();

            List<Usuario> usuarios = new List<Usuario>();

            usuarios = servicio.ListarUsuarios();

            return View(usuarios);
        }

    }
}