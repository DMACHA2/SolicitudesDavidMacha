﻿using System;
using System.Collections.Generic;

namespace SistemaSolicitud.Model;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int IdRol { get; set; }

    public string Clave { get; set; } = null!;

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Solicitudes> Solicitudes { get; set; } = new List<Solicitudes>();

    public virtual ICollection<SolicitudesEliminadas> SolicitudesEliminadaUsuarioEliminadors { get; set; } = new List<SolicitudesEliminadas>();

    public virtual ICollection<SolicitudesEliminadas> SolicitudesEliminadaUsuarioSolicitantes { get; set; } = new List<SolicitudesEliminadas>();
}