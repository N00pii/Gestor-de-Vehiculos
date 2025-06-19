using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace GestorVehiculos
{
    internal class Conexion
    {
        private static SqliteConnection conexion;

        private Conexion() { }

        public static SqliteConnection GetConexion()
        {
            if (conexion == null)
            {
                conexion = new SqliteConnection("Data Source=vehiculos.db");
                conexion.Open();

                using var comandoCrearTabla = conexion.CreateCommand();
                comandoCrearTabla.CommandText = @"
                    CREATE TABLE IF NOT EXISTS vehiculos (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        marca TEXT NOT NULL,
                        modelo TEXT NOT NULL,
                        anio INTEGER NOT NULL,
                        ultima_revision TEXT NOT NULL,
                        tiene_seguro INTEGER NOT NULL,
                        kilometraje INTEGER NOT NULL
                    );
                ";
                comandoCrearTabla.ExecuteNonQuery();
            }

            return conexion;
        }
    }
}
