using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorVehiculos
{
    internal class Vehiculo
    {
        public long Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public DateTime UltimaRevision { get; set; }
        public bool TieneSeguro { get; set; }
        public int Kilometraje { get; set; }

        public Vehiculo(string marca, string modelo, int anio, DateTime ultimaRevision, bool tieneSeguro, int kilometraje)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            UltimaRevision = ultimaRevision;
            TieneSeguro = tieneSeguro;
            Kilometraje = kilometraje;
        }

        public Vehiculo(long id, string marca, string modelo, int anio, DateTime ultimaRevision, bool tieneSeguro, int kilometraje)
            : this(marca, modelo, anio, ultimaRevision, tieneSeguro, kilometraje)
        {
            Id = id;
        }
    }
}

