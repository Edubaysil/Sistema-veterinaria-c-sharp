﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;


namespace Interfaces
{
  public  interface IDetalleFactura
    {
        int Agregar(DetalleFactura detalleFactura, ref MySqlConnection con, ref MySqlTransaction transaction);
    }
}
