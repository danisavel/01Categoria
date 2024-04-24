using System;
using System.Windows.Forms;

namespace _01Categoria
{
    public partial class FCategoria : Form
    {
        //Variables de cantidad de las categorías
        int cantQuerubin = 0;
        int cantBenjamin = 0;
        int cantInfantil = 0;
        int cantCadete = 0;
        int cantJuvenil = 0;
        int cantAmateur = 0;
        int cantVeterano = 0;

        public FCategoria()
        {
            InitializeComponent();
        
            //Variables para el límite del año en el formulario
            decimal anioActual = DateTime.Today.Year;
            nudAnio.Maximum = anioActual - 2;
            nudAnio.Minimum = 1924;
        }
        
        private void BIngresar_Click(object sender, EventArgs e)
        {
            //Variables año de nacimiento y año actual
            int anioNac = Convert.ToInt32(nudAnio.Value);
            int anioAct = DateTime.Today.Year;

            //Convertir nombre y apellido
            string nombre = Convert.ToString(TNombre.Text);
            string apellido = Convert.ToString(TApellido.Text);
            string categoria;

            //Si no introdujo un nombre
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nombre");
                TNombre.Focus();
            }
            //Si no introdujo un apellido
            else if (apellido == "")
            {
                MessageBox.Show("Ingrese un apellido");
                TApellido.Focus();
            }

            //Si están todos los datos
            else
            {
                //VALIDAR FECHA
                //Convertir valor de entrada
                int dia = Convert.ToInt32(nudDia.Value);
                int mes = Convert.ToInt32(nudMes.Value);
                int anio = Convert.ToInt32(nudAnio.Value);


                if ((dia == 29) && (mes == 2))
                {
                    //Para ser bisiesto debe ser divisible x 4
                    if (anio % 4 != 0)
                    {
                        MessageBox.Show($"La fecha {dia}/{mes}/{anio} es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudDia.Focus();
                    }
                    //Si es divisible x 4 y 100, debe ser divisible x 400
                    else if ((anio % 100 == 0) && (anio % 400 != 0))
                    {
                        MessageBox.Show($"La fecha {dia}/{mes}/{anio} es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudDia.Focus();
                    }
                    else
                    {
                        //Reemplazar MB con todo lo que hace si es correcta la fecha
                        MessageBox.Show($"La fecha {dia}/{mes}/{anio} es correcta", "Confirmado");
                    }
                }
                else if ((dia == 30) && (mes == 2))
                {
                    MessageBox.Show($"La fecha {dia}/{mes}/{anio} es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudDia.Focus();
                }
                else if (dia == 31)
                {
                    //Meses que no tienen 31 días
                    if ((mes == 2) || (mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                    {
                        MessageBox.Show($"La fecha {dia}/{mes}/{anio} es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudDia.Focus();
                    }
                    else
                    {
                        //Reemplazar MB con todo lo que hace si es correcta la fecha
                        MessageBox.Show($"La fecha {dia}/{mes}/{anio} es correcta", "Confirmado");
                    }
                }
                //Si la fecha es correcta
                else
                {
                    //Cambiar iniciales de nombre y apellido a mayúscula, y el resto a minúscula 
                    int longNom = nombre.Length -1;
                    string nomInicial = nombre.Substring(0,1);
                    nomInicial = nomInicial.ToUpper();
                    string nomMinusc = nombre.Substring(1, longNom);
                    nomMinusc = nomMinusc.ToLower();
                    string nombreFin = nomInicial + nomMinusc;

                    int longApe = apellido.Length -1;
                    string apeInicial = apellido.Substring(0,1);
                    apeInicial = apeInicial.ToUpper();
                    string apeMinusc = apellido.Substring(1, longApe);
                    apeMinusc = apeMinusc.ToLower();
                    string apellidoFin = apeInicial + apeMinusc;

                    //Calcular edad
                    int edad = anioAct - anioNac;

                    //CATEGORÍAS POR EDAD
                    if (edad < 3)
                    {
                        MessageBox.Show("Los menores de 3 años no pueden ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudDia.Focus();
                    }
                    else if ((edad >= 3) && (edad <= 5))
                    {
                        cantQuerubin++;
                        categoria = "Querubín";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else if ((edad >= 6) && (edad <= 8))
                    {
                        cantBenjamin++;
                        categoria = "Benjamín";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else if ((edad >= 9) && (edad <= 12))
                    {
                        cantInfantil++;
                        categoria = "Infantil";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else if ((edad >= 13) && (edad <= 15))
                    {
                        cantCadete++;
                        categoria = "Cadete";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else if ((edad >= 16) && (edad <= 18))
                    {
                        cantJuvenil++;
                        categoria = "Juvenil";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else if ((edad >= 19) && (edad <= 30))
                    {
                        cantAmateur++;
                        categoria = "Amateur";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    else
                    {
                        cantVeterano++;
                        categoria = "Veterano";
                        MessageBox.Show($"Ingreso exitoso\n-{apellidoFin}, {nombreFin}.\n-Edad: {edad} años.\n-Categoría: {categoria}.", "Confirmado");
                    }
                    //Limpiar campos
                    TNombre.Clear();
                    TApellido.Clear();
                    nudDia.Value = nudDia.Minimum;
                    nudMes.Value = nudMes.Minimum;
                    nudAnio.Value = nudAnio.Minimum;
                }
            }
            //Actualizar categorías
            LCantQuerubin.Text = ($"•Querubín: {cantQuerubin}");
            LCantBenjamin.Text = ($"•Benjamín: {cantBenjamin}");
            LCantInfantil.Text = ($"•Infantil: {cantInfantil}");
            LCantCadete.Text = ($"•Cadete: {cantCadete}");
            LCantJuvenil.Text = ($"•Juvenil: {cantJuvenil}");
            LCantAmateur.Text = ($"•Amateur: {cantAmateur}");
            LCantVeterano.Text = ($"•Veterano: {cantVeterano}");
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
