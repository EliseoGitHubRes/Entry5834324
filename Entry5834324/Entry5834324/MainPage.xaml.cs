using System;
using Xamarin.Forms;

namespace Entry5834324
{
    public partial class MainPage : ContentPage
    {
        ///<Createddate>21/07/2023</createddate>
        ///<company>INDEL</company>
        ///<lastmodificationdate>21/07/2023</lastmodificationdate>
        ///<lastmodificationdescription>
        ///PROPIEDADES DEL ENTRY
        ///</lastmodificationdescription>
        //////<lastmodifierautor>ELISEO</lastmodifierautor>
        ///</Summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cada ves que escribamos un numero o letra se ira a este evento, pasa saber cada letra que escribimos se ira a este evento
        /// </summary>
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasado = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }

        /// <summary>
        /// Cuadno completemos la entrada del texto(entry) se guardara en esta cadena de string
        /// </summary>
        private void Entry_Completed(object sender, EventArgs e)
        {
            string textO=((Entry)sender).Text;

        }
    }
}
