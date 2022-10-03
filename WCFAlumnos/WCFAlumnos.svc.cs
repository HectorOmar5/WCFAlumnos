using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Newtonsoft;
using Newtonsoft.Json;

namespace WCFAlumnos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFAlumnos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFAlumnos.svc o WCFAlumnos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFAlumnos : IWCFAlumnos
    {
        public AportacionesIMSS CalcularIMSS(int id)
        {
            //NAlumno alumno = new NAlumno();
            

            Entidades.AportacionesIMSS aportacionesIMSS = NAlumno.CalcularIMSS(id);
            string jsonAportaciones = JsonConvert.SerializeObject(aportacionesIMSS);
            AportacionesIMSS aportaciones = JsonConvert.DeserializeObject<AportacionesIMSS>(jsonAportaciones);
            return aportaciones;
        }

        public ItemTablaISR CalcularISR(int id)
        {
            NAlumno alumno = new NAlumno();
            Entidades.ItemTablaISR tablaISR = alumno.CalcularISR(id);
            string jsonTabla = JsonConvert.SerializeObject(tablaISR);
            ItemTablaISR itemTabla = JsonConvert.DeserializeObject<ItemTablaISR>(jsonTabla);
            return (itemTabla);

        }
    }
}
