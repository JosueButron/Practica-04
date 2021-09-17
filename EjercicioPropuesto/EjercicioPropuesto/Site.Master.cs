using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Img1.Visible = false;
            Img2.Visible = false;
            Img3.Visible = false;
            Img4.Visible = false;
        }

        

        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            
            Img1.Src = "figura1.jpg";
            Img1.Alt = "Grafico Electrodomestico";
            Img1.Visible = true;
            Img2.Src = "figura2.jpg";
            Img2.Alt = "Grafico Electrodomestico";
            Img2.Visible = true;
            Img3.Src = "figura3.jpg";
            Img3.Alt = "Grafico Electrodomestico";
            Img3.Visible = true;
            Img4.Src = "figura4.jpg";
            Img4.Alt = "Grafico Electrodomestico";
            Img4.Visible = true;
        }

        protected void Pulsado2(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList1.SelectedValue);
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }
    }
}