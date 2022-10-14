using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Alumno(string codigo)
        {
            string alumnoNombre = "No Existe";
            
            Dictionary<string, string> alumnos = new Dictionary<string, string>();
            alumnos.Add("0020170415", "Alex Simon Santiago");
            alumnos.Add("0020170416", "Kleisy Linares Rimapa");
            alumnos.Add("0020170417", "José Manuel Bravo");
            alumnos.Add("0020170418", "Lizet Carrasco Peña");
            alumnos.Add("0020170419", "Jesus Marquez Isidro");

            foreach (var i in alumnos)
            {
                if (codigo == i.Key)
                {
                    alumnoNombre = i.Value;
                }
            }

            return alumnoNombre;
        }
    }
}
