using System;

namespace herencia
{
    class DatosDeEmpleado
        {
		private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasPorSemana; 
        private decimal tarifaComision; 
     
            // constructor
            public DatosDeEmpleado(string nombre, string apellido, string nss,
               decimal ventas, decimal tarifa)
            {
                // la llamada al constructor
                primerNombre = nombre;
                apellidoPaterno = apellido;
                numeroSeguroSocial = nss;
                VentasBrutas = ventas; 
                TarifaComision = tarifa; 
     
                Console.WriteLine("\nConstructor de DatosDeEmpleado:\n" + this);
            } // fin del constructor 
     
            public string PrimerNombre
            {
                get
                {
                    return primerNombre;
                } // fin de get
            } // fin de la propiedad PrimerNombre
     
          
            public string ApellidoPaterno
            {
                get
                {
                    return apellidoPaterno;
                } 
            } // fin de la propiedad ApellidoPaterno
     
            // propiedad de sólo lectura que obtiene el
            // número de seguro social del empleado por comisión
            public string NumeroSeguroSocial
            {
                get
                {
                    return numeroSeguroSocial;
                } // fin de get
            } // fin de la propiedad NumeroSeguroSocial
     
          
            public decimal VentasBrutas
            {
                get
                {
                    return ventasPorSemana;
                } 
                set
                {
                    ventasPorSemana = (value < 0) ? 0 : value;
                } 
            } // fin de la propiedad Ventas por semana
     
           
            public decimal TarifaComision
            {
                get
                {
                    return tarifaComision;
                } 
                set
                {
                    tarifaComision = (value > 0 && value < 1) ? value : 0;
                } 
            } // fin de la propiedad TarifaComision
     
            
            public virtual decimal Ingresos()
            {
                return TarifaComision * VentasBrutas;
            } // fin del método Ingresos
     
            // devuelve string del objeto EmpleadoPorComision
            public override string ToString()
            {
                return string.Format(
                   "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                   "empleado por comisión", PrimerNombre, ApellidoPaterno,
                   "número de seguro social", NumeroSeguroSocial,
                   "ventas por semana", VentasBrutas, "comisión", TarifaComision);
            } // fin del método ToString
        }
    }
 

