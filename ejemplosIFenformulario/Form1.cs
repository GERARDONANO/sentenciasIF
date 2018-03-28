using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplosIFenformulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }


        private void btnguardar_Click(object sender, EventArgs e)
        {


            //obtener valor del textfield rut como String 
            string rutstring = txtrut.Text;


            //validar que se ingresarán todos datos 
            if (rutstring != "" && cmbxnacionalidad.Text != "" && cmbxnacionalidad.Text != null)
            {
                    //validar que se ingrese un valor en el campo rut
                if (txtrut.Text != "")
                {

                    int rutint; 
                    bool EsEntero = Int32.TryParse(rutstring ,out rutint);


                    //el rut digitado es un número?
                    //no
                    if (!EsEntero)
                    {
                        lblresultado.Text = ("El rut solo debe contener números");

                    }//si
                    else {
                        //convertir valor del textfield  rut de String a entero
                       rutint = Convert.ToInt32(rutstring);
                        if (cmbxnacionalidad.Text == "Chileno" && rutint > 0)
                        {
                            rutValido();

                        }
                        else if (cmbxnacionalidad.Text == "Argentino" && rutint > 0)
                        {

                            lblresultado.Text = ("Solicitar Folio");

                        }

                        else
                        {
                            lblresultado.Text = ("validar DNI");
                        }

                        limpiarpantalla();
                        aluGuardado();

                        //rut como número negativo
                        if (rutint < 0)
                        {

                            lblresultado.Text = ("Rut Invalido");
                            lblguardado.Text = ("Alumno No guardado");
                            limpiarpantalla();
                        }
                    }



                   
                }

            }
            // sin nacionalidad
            else if (cmbxnacionalidad.Text == null || cmbxnacionalidad.Text == "" && txtrut.Text != "")
            {
                lblresultado.Text = ("debe ingresar la nacionalidad");
                lblguardado.Text = ("Alumno No guardado");


            }// sin rut
            else if (cmbxnacionalidad.Text != "" && txtrut.Text =="") {
                lblresultado.Text = ("debe ingresar el rut");
                lblguardado.Text = ("Alumno No guardado");

            }// sin ningun dato
            else
            {
                lblresultado.Text = ("Ingrese todos los datos solicitados");
                lblguardado.Text = ("Alumno No guardado");
            }
        }
           
           

        



        void limpiarpantalla()
        {
            cmbxnacionalidad.Text = "";
            txtrut.Text = "";
                }

        void rutValido() {
            lblresultado.Text = ("Rut Validado");

        }

         void aluGuardado() {
            lblguardado.Text = ("Alumno Guardado Correctamente");
        }

    }
}
