
using pruebaescritorio.Modelos;

namespace pruebaescritorio
{
    public partial class Form1 : Form
    {
        List<Persona> listaPersona = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            textNombre.Text = string.Empty; // accede al contenido nombre y el string representa una cadena vacia
            textEdad.Text = string.Empty; // cuando se ejecuta limpiar ambos campos quedan vacios. tambien el metodo se utiliza cuanod se guarda una PER queda limpo el formulario
            textCorreo.Text = string.Empty; // limpia tambien el campo del correo
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e) // KeyPress	Evento que se genera cuando se pulsa una tecla que produce un carácter.
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //e.KeyChar	Es el carácter que se intenta escribir.
            {
                e.Handled = true;  // La condición significa: si el carácter no es de control y tampoco es un dígito, se bloque
            }
        }


        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Por tanto, si el carácter no es letra, espacio ni carácter de control, se bloquea.
            }
        }
        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir todos los caracteres en el correo
            e.Handled = false;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (SePuedeGuardar())
            {
                Guardar();
                MostrarDatos();
                Limpiar();

                MessageBox.Show(
                    "¡Persona guardada correctamente!",
                    "Guardado exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Guardar()
        {
            // 5. Crear y guardar la persona
            Persona objetoPersona = new Persona();        //Persona: identifica la clase, objetoPersona: es el nombre de la variable que referencia la nueva instancia.

            objetoPersona.Nombre = textNombre.Text.Trim();  // asigna el nombre.
            objetoPersona.Edad = int.Parse(textEdad.Text);

            listaPersona.Add(objetoPersona); //agrega el objeto a la lista.

        }

        private void MostrarDatos()                   // declara un método que no devuelve valor.
        {
            GridDatos.DataSource = null;
            GridDatos.DataSource = listaPersona;
        }

        private bool SePuedeGuardar()
        {

            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(textNombre.Text))       // string.IsNullOrWhiteSpace() comprueba si el texto es nulo, está vacío o contiene solamente espacios.
            {
                MessageBox.Show("Por favor, ingrese el nombre."); // Muestra el mensaje.
                textNombre.Focus();                               // Lleva el foco al campo Nombre mediante Focus().
                return false;                                     // Ejecuta return false, que termina el método e informa que la operación falló.
            }
            // 2. Validar que el nombre solo contenga letras y espacios
            bool nombreValido = true;    //empieza suponiendo que el nombre es válido.

            foreach (char caracter in textNombre.Text.Trim())    //foreach: recorre los elementos de una colección o secuencia, uno por uno.
                                                                 //declara una variable que representa el carácter actual.
                                                                 //textNombre.Text.Trim(): obtiene el texto y elimina los espacios de los extremos.
            {
                if (!char.IsLetter(caracter) &&                  //comprueba si es una letra
                    !char.IsWhiteSpace(caracter))                //comprueba si es un espacio u otro carácter de espacio en blanco.
                {
                    nombreValido = false;
                    break;                                       //interrumpe el recorrido cuando encuentra un carácter no permitido.
                }
            }

            if (!nombreValido)
            {
                MessageBox.Show(
                    "El nombre solo puede contener letras y espacios."
                );

                textNombre.Focus();
                textNombre.SelectAll();
                return false;
            }

            // 3. Validar que la edad no esté vacía
            if (string.IsNullOrWhiteSpace(textEdad.Text)) //comprueba si el texto es nulo, está vacío o contiene solamente espacios y puntos
            {
                MessageBox.Show("Por favor, ingrese la edad.");
                textEdad.Focus();
                return false;
            }

            // 4. Validar que la edad sea un entero positivo
            if (!int.TryParse(textEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show(
                    "Ingrese una edad válida, solo números enteros mayores que cero."
                );

                textEdad.Focus();
                textEdad.SelectAll();
                return false;
            }

            //if que llame a la función de validar correo y se le debe enviar como parametro el textoCorreo
            // if (!validarcorreo(textocorreo.text.trim()))

            // 5. Validar que el correo sea válido
            if (!validarcorreo(textCorreo.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingrese un correo válido.");
                textCorreo.Focus();
                textCorreo.SelectAll();
                return false;
            }

            return true;


        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funcion para validar si el correo es valido, debe tener un parametro que sea el correo, debe retorar true o false
        private bool validarcorreo(string correo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }

    }
}
