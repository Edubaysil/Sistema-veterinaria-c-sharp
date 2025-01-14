﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Interfaces;
using MySql.Data.MySqlClient;
using System.Data;

namespace AllqovetDAO
{
    public class CajachicaDAO : ICajachica,IDisposable
    {
        string cnx = Conexion.ObtenerConexion();

        public int Agregar(CajaChica caja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_RegistrarApertura", cn))
                {
                   
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdtrabajador", caja.IdTrabajador);
                    cmd.Parameters.AddWithValue("MontoInicial", caja.ImporteApertura);
                  
                    return cmd.ExecuteNonQuery();

                }
            }
        }

        public int BuscarCajaActiva()
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_BuscarCajaActiva", cn))
                {
                    int caja = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cn.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                      
                        while (dr.Read())
                        {
                            caja = Convert.ToInt32(dr["caja"]);
                          
                        }

                        return caja;
                    }
                }
            }
        }

        public int AperturaActual()
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_AperturaActual", cn))
                {
                    int caja = 0;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            caja = Convert.ToInt32(dr["Idcajachica"]);

                        }

                        return caja;
                    }
                }
            }
        }

        public DataTable VentasCierre(int idcaja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ventasCierre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pIdcajachica", idcaja);
                    cn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }


        }
        public DataTable ResumenVentasMedioPago(int idcaja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ResumenVentasMedioPago", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pIdcajachica", idcaja);
                    cn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }


        }

        public DataTable EgresosCierre(int idcaja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_EgresosCierre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pIdcajachica", idcaja);
                    cn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }

        }

        public DataTable ResumenEgresosMEdioPago(int idcaja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_ResumenEgresosMEdioPago", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pIdcajachica", idcaja);
                    cn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }

        }


        public DataTable CobrosCierre(int idcaja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_CobrosCierre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pIdcajachica", idcaja);
                    cn.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }

        }

       

        public int CerrarCaja(CajaChica caja)
        {
            using (MySqlConnection cn = new MySqlConnection(cnx))
            {
                using (MySqlCommand cmd = new MySqlCommand("sp_CerrarCaja", cn))
                {

                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdcaja", caja.Idcajachica);
                    cmd.Parameters.AddWithValue("pImporteCierre", caja.ImporteCierra);

                    return cmd.ExecuteNonQuery();

                }
            }
        }



        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~CajachicaDAO() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
             GC.SuppressFinalize(this);
        }
        #endregion
    }
}
