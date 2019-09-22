using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sueldo_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtprecio.Text);
            string temporada = "";
            double resultado = double.Parse(txtprecio.Text);
            if (radioButton1.Checked)
            {
                if (total < 100000)
                {

                    lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                    lblresultado.Visible = true;
                   
                }

                else

                    if  (total <= 300000)
                {
                    total = (total * 0.10 );
                    resultado = (resultado - total);
                    lblresultado.Text = "El Precio Final es: " + resultado.ToString();
                    lblresultado.Visible = true;
                }


                else
                {

                    if (total > 300000)
                    {
                        total = (total * 0.15);
                        resultado = (resultado - total);

                        lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                        lblresultado.Visible = true;
                    }

                }

                temporada = radioButton1.Text;
            }



            if (radioButton2.Checked)
            {
                if (total < 50) {

                    MessageBox.Show("Este Valor es invalido");
                }

                else 
                    if ((total >= 50) && (total <= 30000))
                    {

                        lblresultado.Text = "El Precio Final es:" + total.ToString();
                        lblresultado.Visible = true;



                    }
                
                else
                {

                    if ((total>=30001) && (total<= 200000))
                    {
                        total = (total * 0.02);
                        resultado = (resultado - total);

                        lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                        lblresultado.Visible = true;
                    }
                    else
                    {
                        if(total> 200000)
                        {
                            total = (total * 0.05);
                            resultado = (resultado - total);
                            lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                            lblresultado.Visible = true;
                        }
                    }
                }
                temporada = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                if((total>=50) && (total<= 300000))
                {
                    lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                    lblresultado.Visible = true;
                }
                if (total < 50)
                {

                    MessageBox.Show("Este Valor es invalido");
                }
                else
                {
                    if((total>= 300001) && (total<= 500000))
                    {
                        total = (total * 0.05);
                        resultado = (resultado - total);

                        lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                        lblresultado.Visible = true;
                    }
                    else
                    {
                        if(total> 500000)
                        {
                            total = (total * 0.10);
                            resultado = (resultado - total);

                            lblresultado.Text = "El Precio Final es:" + resultado.ToString();
                            lblresultado.Visible = true;
                        }
                    }
                }
                temporada = radioButton3.Text;
            }
            MessageBox.Show(temporada);
        }
    }

}