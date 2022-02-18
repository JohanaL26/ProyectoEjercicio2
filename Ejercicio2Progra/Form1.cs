namespace Ejercicio2Progra
{

        //Desarrolle un programa que almacene dos arreglos, uno para los nombres de varios estudiantes 
        //que el usuario ingrese, y el segundo para almacenar la edad de cada uno de ellos, luego que 
        //los muestre en un ComboBox tanto el nombre y su edad concatenado.


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

            string[] ArrNombre = new string[1];
            string[] ArrEdad = new string[1];

            ListadolistBox.Enabled = true;
            ListadolistBox.Visible=true;

            for (int i = 0; i < ArrNombre.Length; i++)
            {
                ArrNombre[i] = NombretextBox.Text;
                ArrEdad[i] = EdadtextBox.Text;

                string nombre = ArrNombre[i];
                string edad = ArrEdad[i];
            }


            for (int i = 0; i < ArrNombre.Length; i++)
            {
                ListadolistBox.Items.Add(ArrNombre[i].ToString() + " - " + ArrEdad[i].ToString());

            }

            NombretextBox.Clear();
            EdadtextBox.Clear();
            NombretextBox.Focus();



        }


    }
}