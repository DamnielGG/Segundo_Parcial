using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace Segundo_Parcial
{
    public partial class Agregar_peliculas : System.Web.UI.Page
    {
        static List<Pelicula> peliculas = new List<Pelicula>();
        static List<Actor> actores = new List<Actor>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Leer()
        {
            string archivo2 = Server.MapPath("Peliculas.json");
            StreamReader json1 = File.OpenText(archivo2);
            string json2 = json1.ReadToEnd();
            json1.Close();

            peliculas = JsonConvert.DeserializeObject<List<Pelicula>>(json2);
        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(peliculas);

            string archivo = Server.MapPath("Peliculas.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pelicula Pelixd = new Pelicula();
            Pelixd.Titulo = TextBoxTituloAgregar.Text;
            Pelixd.Año = TextBoxAñoAgregar.Text;
            Pelixd.Genero = TextBoxGeneroAgregar.Text;
            Pelixd.Estudio = TextBoxEstudioAgregar.Text;
            Pelixd.Elenco = TextBoxElencoAgregar.Text;
            peliculas.Add(Pelixd);

            Guardar();
        }
    }
}