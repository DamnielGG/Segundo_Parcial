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
    public partial class Eliminar_peliculas : System.Web.UI.Page
    {
        static List<Pelicula> peliculas = new List<Pelicula>();
        static List<Actor> actores = new List<Actor>();
        static string Pelis;
        static string Actors;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pelis = TextBoxTituloPeliEliminar.Text;
            bool disponible = false;
            foreach (var u in peliculas)
            {
                Pelicula eliminar = peliculas.Find(c => c.Titulo == Pelis);

                if (eliminar != null)
                {
                    TextBoxTituloPeliEliminar.Text = eliminar.Titulo;
                    TextBoxAñoEliminar.Text = eliminar.Año;
                    disponible = true;

                }
            }

            if (!disponible)
            {
                Response.Write("<script>alert('La pelicula no se encuentra disponible')</script>");
                Pelis = "";
            }

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

        protected void ButtonEliminarPelicula_Click(object sender, EventArgs e)
        {
            foreach (var u in peliculas)
            {
                Pelicula eliminar = peliculas.Find(c => c.Titulo == Pelis);

                if (eliminar != null)
                {
                    peliculas.Remove(eliminar);
                    break;
                }
            }

            Guardar();
        }
    }
}