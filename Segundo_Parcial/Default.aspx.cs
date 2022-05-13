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
    public partial class _Default : Page
    {
        static List<Pelicula> peliculas = new List<Pelicula>();
        static List<Actor> actores = new List<Actor>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(peliculas);

            string archivo = Server.MapPath("Peliculas.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonBuscarPeli_Click(object sender, EventArgs e)
        {
            Pelicula xd = new Pelicula();
            xd.Año = TextBox1.Text;
            peliculas.Add(xd);
            GridView1.DataSource = peliculas;
            GridView1.DataBind();
            
        }
    }
}