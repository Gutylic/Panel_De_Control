using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpiar
{
    public partial class Form1 : Form
    {
        string ruta_amarilla = System.IO.Path.Combine(Application.StartupPath,"imagen/Circle_Yellow.png");
        string ruta_verde = System.IO.Path.Combine(Application.StartupPath, "imagen/Circle_Green.png");
        string ruta_red = System.IO.Path.Combine(Application.StartupPath, "imagen/Circle_Red.png");
        
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();



        private void Usuario_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(1);
            Alerta_1_Usuario.Enabled = false;
            Usuario.Enabled = false;
        }
        
        private void Boton_1_Click(object sender, EventArgs e)
        {
            if (Usuario.Enabled == false)
            {
                if (Alerta_1_Usuario.Enabled == true)
                {
                    Alerta_1_Usuario.Enabled = false;
                    Usuario.Enabled = false;
                }
                else
                {
                    Alerta_1_Usuario.Enabled = true;
                    
                    Alerta_1_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_1_Usuario.Enabled = false;
                Usuario.Enabled = false;
            }
        }

        private void Alerta_1_Usuario_Click(object sender, EventArgs e)
        {
            if (Usuario.Enabled == false)
            {
                Usuario.Enabled = true;
                Alerta_1_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_1_Usuario.Enabled = false;
                Usuario.Enabled = false;
            }
        }



        private void Datos_Usuario_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(2);
            Alerta_2_Usuario.Enabled = false;
            Datos_Usuario.Enabled = false;
        }

        private void Boton_2_Usuario_Click(object sender, EventArgs e)
        {
            if (Datos_Usuario.Enabled == false)
            {
                if (Alerta_2_Usuario.Enabled == true)
                {
                    Alerta_2_Usuario.Enabled = false;
                    Datos_Usuario.Enabled = false;
                }
                else
                {
                    Alerta_2_Usuario.Enabled = true;

                    Alerta_2_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_2_Usuario.Enabled = false;
                Datos_Usuario.Enabled = false;
            }
        }

        private void Alerta_2_Usuario_Click(object sender, EventArgs e)
        {
            if (Usuario.Enabled == false)
            {
                Datos_Usuario.Enabled = true;
                Alerta_2_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_2_Usuario.Enabled = false;
                Datos_Usuario.Enabled = false;
            }
        }


        
        private void Boton_4_Usuario_Click_1(object sender, EventArgs e)
        {
            if (Comentario_Usuario.Enabled == false)
            {
                if (Alerta_4_Usuario.Enabled == true)
                {
                    Alerta_4_Usuario.Enabled = false;
                    Comentario_Usuario.Enabled = false;
                }
                else
                {
                    Alerta_4_Usuario.Enabled = true;

                    Alerta_4_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_4_Usuario.Enabled = false;
                Comentario_Usuario.Enabled = false;
            }
        }

        private void Alerta_4_Usuario_Click_1(object sender, EventArgs e)
        {
            if (Comentario_Usuario.Enabled == false)
            {
                Comentario_Usuario.Enabled = true;
                Alerta_4_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_4_Usuario.Enabled = false;
                Comentario_Usuario.Enabled = false;
            }
        }

        private void Comentario_Usuario_Click_1(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(4);
            Alerta_4_Usuario.Enabled = false;
            Comentario_Usuario.Enabled = false;
        }





        private void Alerta_3_Usuario_Click_1(object sender, EventArgs e)
        {
            if (Extra_Usuario.Enabled == false)
            {
                Extra_Usuario.Enabled = true;
                Alerta_3_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_3_Usuario.Enabled = false;
                Extra_Usuario.Enabled = false;
            }
        }

        private void Boton_3_Usuario_Click_1(object sender, EventArgs e)
        {
            if (Extra_Usuario.Enabled == false)
            {
                if (Alerta_3_Usuario.Enabled == true)
                {
                    Alerta_3_Usuario.Enabled = false;
                    Extra_Usuario.Enabled = false;
                }
                else
                {
                    Alerta_3_Usuario.Enabled = true;

                    Alerta_3_Usuario.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_3_Usuario.Enabled = false;
                Extra_Usuario.Enabled = false;
            }
        }

        private void Extra_Usuario_Click_1(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(3);
            Alerta_3_Usuario.Enabled = false;
            Extra_Usuario.Enabled = false;
        }




        private void Administrador_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(5);
            Alerta_5_Administrador.Enabled = false;
            Administrador.Enabled = false;
        }

        private void Boton_1_Administrador_Click(object sender, EventArgs e)
        {
            if (Administrador.Enabled == false)
            {
                if (Alerta_5_Administrador.Enabled == true)
                {
                    Alerta_5_Administrador.Enabled = false;
                    Administrador.Enabled = false;
                }
                else
                {
                    Alerta_5_Administrador.Enabled = true;

                    Alerta_5_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_5_Administrador.Enabled = false;
                Administrador.Enabled = false;
            }
        }

        private void Alerta_5_Administrador_Click(object sender, EventArgs e)
        {
            if (Administrador.Enabled == false)
            {
                Administrador.Enabled = true;
                Alerta_5_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_5_Administrador.Enabled = false;
                Administrador.Enabled = false;
            }
        }


        private void Comentario_Administrador_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(6);
            Alerta_6_Admonistrador.Enabled = false;
            Comentario_Administrador.Enabled = false;
        }

        private void Boton_2_Administrador_Click(object sender, EventArgs e)
        {
            if (Comentario_Administrador.Enabled == false)
            {
                if (Alerta_6_Admonistrador.Enabled == true)
                {
                    Alerta_6_Admonistrador.Enabled = false;
                    Comentario_Administrador.Enabled = false;
                }
                else
                {
                    Alerta_6_Admonistrador.Enabled = true;

                    Alerta_6_Admonistrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_6_Admonistrador.Enabled = false;
                Comentario_Administrador.Enabled = false;
            }
        }

        private void Alerta_6_Admonistrador_Click(object sender, EventArgs e)
        {
            if (Comentario_Administrador.Enabled == false)
            {
                Comentario_Administrador.Enabled = true;
                Alerta_6_Admonistrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_6_Admonistrador.Enabled = false;
                Comentario_Administrador.Enabled = false;
            }
        }



        private void Categoria_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(7);
            Alerta_7_Administrador.Enabled = false;
            Categoria.Enabled = false;
        }

        private void Boton_3_Administrador_Click(object sender, EventArgs e)
        {
            if (Categoria.Enabled == false)
            {
                if (Alerta_7_Administrador.Enabled == true)
                {
                    Alerta_7_Administrador.Enabled = false;
                    Categoria.Enabled = false;
                }
                else
                {
                    Alerta_7_Administrador.Enabled = true;

                    Alerta_7_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_7_Administrador.Enabled = false;
                Categoria.Enabled = false;
            }
        }

        private void Alerta_7_Administrador_Click(object sender, EventArgs e)
        {
            if (Categoria.Enabled == false)
            {
                Categoria.Enabled = true;
                Alerta_7_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_7_Administrador.Enabled = false;
                Categoria.Enabled = false;
            }
        }

       

        private void Boton_4_Administrador_Click(object sender, EventArgs e)
        {
            if (Control_Administrador.Enabled == false)
            {
                if (Alerta_8_Administrador.Enabled == true)
                {
                    Alerta_8_Administrador.Enabled = false;
                    Control_Administrador.Enabled = false;
                }
                else
                {
                    Alerta_8_Administrador.Enabled = true;

                    Alerta_8_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                Alerta_8_Administrador.Enabled = false;
                Control_Administrador.Enabled = false;
            }
        }

        private void Alerta_8_Administrador_Click(object sender, EventArgs e)
        {
            if (Control_Administrador.Enabled == false)
            {
                Control_Administrador.Enabled = true;
                Alerta_8_Administrador.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                Alerta_8_Administrador.Enabled = false;
                Control_Administrador.Enabled = false;
            }
        }

        private void Control_Administrador_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(8);
            Alerta_8_Administrador.Enabled = false;
            Control_Administrador.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button7.Enabled == false)
            {
                button7.Enabled = true;
                button8.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button8.Enabled = false;
                button7.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(11);
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button9.Enabled == false)
            {
                button9.Enabled = true;
                button10.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button10.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(12);
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button13.Enabled == false)
            {
                if (button14.Enabled == true)
                {
                    button14.Enabled = false;
                    button13.Enabled = false;
                }
                else
                {
                    button14.Enabled = true;

                    button14.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button14.Enabled = false;
                button13.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button13.Enabled == false)
            {
                button13.Enabled = true;
                button14.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button14.Enabled = false;
                button13.Enabled = false;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(9);
            button14.Enabled = false;
            button13.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button11.Enabled == false)
            {
                if (button12.Enabled == true)
                {
                    button12.Enabled = false;
                    button11.Enabled = false;
                }
                else
                {
                    button12.Enabled = true;

                    button12.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button12.Enabled = false;
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button11.Enabled == false)
            {
                button11.Enabled = true;
                button12.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button12.Enabled = false;
                button11.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(10);
            button12.Enabled = false;
            button11.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button9.Enabled == false)
            {
                if (button10.Enabled == true)
                {
                    button10.Enabled = false;
                    button9.Enabled = false;
                }
                else
                {
                    button10.Enabled = true;

                    button10.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button10.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button7.Enabled == false)
            {
                if (button8.Enabled == true)
                {
                    button8.Enabled = false;
                    button7.Enabled = false;
                }
                else
                {
                    button8.Enabled = true;

                    button8.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button17.Enabled == false)
            {
                if (button18.Enabled == true)
                {
                    button18.Enabled = false;
                    button17.Enabled = false;
                }
                else
                {
                    button18.Enabled = true;

                    button18.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button17.Enabled = false;
                button18.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button17.Enabled == false)
            {
                button17.Enabled = true;
                button18.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button18.Enabled = false;
                button17.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(13);
            button17.Enabled = false;
            button18.Enabled = false;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button15.Enabled == false)
            {
                if (button16.Enabled == true)
                {
                    button16.Enabled = false;
                    button15.Enabled = false;
                }
                else
                {
                    button16.Enabled = true;

                    button16.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button15.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button15.Enabled == false)
            {
                button15.Enabled = true;
                button16.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button16.Enabled = false;
                button15.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(14);
            button16.Enabled = false;
            button15.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button35.Enabled == false)
            {
                if (button36.Enabled == true)
                {
                    button36.Enabled = false;
                    button35.Enabled = false;
                }
                else
                {
                    button36.Enabled = true;

                    button36.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button35.Enabled = false;
                button36.Enabled = false;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button35.Enabled == false)
            {
                button35.Enabled = true;
                button36.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button36.Enabled = false;
                button35.Enabled = false;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(15);
            button36.Enabled = false;
            button35.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button33.Enabled == false)
            {
                if (button34.Enabled == true)
                {
                    button34.Enabled = false;
                    button33.Enabled = false;
                }
                else
                {
                    button34.Enabled = true;

                    button34.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button33.Enabled = false;
                button34.Enabled = false;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button33.Enabled == false)
            {
                button33.Enabled = true;
                button34.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button34.Enabled = false;
                button33.Enabled = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(16);
            button33.Enabled = false;
            button34.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button31.Enabled == false)
            {
                if (button32.Enabled == true)
                {
                    button32.Enabled = false;
                    button31.Enabled = false;
                }
                else
                {
                    button32.Enabled = true;

                    button32.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button31.Enabled = false;
                button32.Enabled = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button31.Enabled == false)
            {
                button31.Enabled = true;
                button32.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button32.Enabled = false;
                button31.Enabled = false;
            }
        }


        private void button31_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(17);
            button31.Enabled = false;
            button32.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button26.Enabled == false)
            {
                if (button28.Enabled == true)
                {
                    button28.Enabled = false;
                    button26.Enabled = false;
                }
                else
                {
                    button28.Enabled = true;

                    button28.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button26.Enabled = false;
                button28.Enabled = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button26.Enabled == false)
            {
                button26.Enabled = true;
                button28.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button28.Enabled = false;
                button26.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(18);
            button28.Enabled = false;
            button26.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button29.Enabled == false)
            {
                if (button30.Enabled == true)
                {
                    button30.Enabled = false;
                    button29.Enabled = false;
                }
                else
                {
                    button30.Enabled = true;

                    button30.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button29.Enabled = false;
                button30.Enabled = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button29.Enabled == false)
            {
                button29.Enabled = true;
                button30.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button30.Enabled = false;
                button29.Enabled = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(19);
            button30.Enabled = false;
            button29.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button45.Enabled == false)
            {
                if (button46.Enabled == true)
                {
                    button46.Enabled = false;
                    button45.Enabled = false;
                }
                else
                {
                    button46.Enabled = true;

                    button46.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button45.Enabled = false;
                button46.Enabled = false;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button45.Enabled == false)
            {
                button45.Enabled = true;
                button46.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button46.Enabled = false;
                button45.Enabled = false;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(20);
            button45.Enabled = false;
            button46.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button43.Enabled == false)
            {
                if (button44.Enabled == true)
                {
                    button44.Enabled = false;
                    button43.Enabled = false;
                }
                else
                {
                    button44.Enabled = true;

                    button44.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button43.Enabled = false;
                button44.Enabled = false;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button43.Enabled == false)
            {
                button43.Enabled = true;
                button44.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button44.Enabled = false;
                button43.Enabled = false;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(21);
            button44.Enabled = false;
            button43.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button41.Enabled == false)
            {
                if (button42.Enabled == true)
                {
                    button42.Enabled = false;
                    button41.Enabled = false;
                }
                else
                {
                    button42.Enabled = true;

                    button42.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button41.Enabled = false;
                button42.Enabled = false;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button41.Enabled == false)
            {
                button41.Enabled = true;
                button42.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button42.Enabled = false;
                button41.Enabled = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(22);
            button42.Enabled = false;
            button41.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (button47.Enabled == false)
            {
                if (button48.Enabled == true)
                {
                    button48.Enabled = false;
                    button47.Enabled = false;
                }
                else
                {
                    button48.Enabled = true;

                    button48.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button47.Enabled = false;
                button48.Enabled = false;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button47.Enabled == false)
            {
                button47.Enabled = true;
                button48.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button48.Enabled = false;
                button47.Enabled = false;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(23);
            button48.Enabled = false;
            button47.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (button39.Enabled == false)
            {
                if (button40.Enabled == true)
                {
                    button40.Enabled = false;
                    button39.Enabled = false;
                }
                else
                {
                    button40.Enabled = true;

                    button40.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button39.Enabled = false;
                button40.Enabled = false;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button39.Enabled == false)
            {
                button39.Enabled = true;
                button40.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button40.Enabled = false;
                button39.Enabled = false;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(24);
            button40.Enabled = false;
            button39.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (button23.Enabled == false)
            {
                if (button38.Enabled == true)
                {
                    button38.Enabled = false;
                    button23.Enabled = false;
                }
                else
                {
                    button38.Enabled = true;

                    button38.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button23.Enabled = false;
                button38.Enabled = false;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button23.Enabled == false)
            {
                button23.Enabled = true;
                button38.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button38.Enabled = false;
                button23.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(25);
            button38.Enabled = false;
            button23.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (button49.Enabled == false)
            {
                if (button50.Enabled == true)
                {
                    button50.Enabled = false;
                    button49.Enabled = false;
                }
                else
                {
                    button50.Enabled = true;

                    button50.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button49.Enabled = false;
                button50.Enabled = false;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (button49.Enabled == false)
            {
                button49.Enabled = true;
                button50.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button50.Enabled = false;
                button49.Enabled = false;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(26);
            button50.Enabled = false;
            button49.Enabled = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (button61.Enabled == false)
            {
                if (button62.Enabled == true)
                {
                    button62.Enabled = false;
                    button61.Enabled = false;
                }
                else
                {
                    button62.Enabled = true;

                    button62.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button61.Enabled = false;
                button62.Enabled = false;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (button61.Enabled == false)
            {
                button61.Enabled = true;
                button62.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button62.Enabled = false;
                button61.Enabled = false;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(29);
            button61.Enabled = false;
            button62.Enabled = false;

        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (button59.Enabled == false)
            {
                if (button60.Enabled == true)
                {
                    button60.Enabled = false;
                    button59.Enabled = false;
                }
                else
                {
                    button60.Enabled = true;

                    button60.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button59.Enabled = false;
                button60.Enabled = false;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (button59.Enabled == false)
            {
                button59.Enabled = true;
                button60.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button59.Enabled = false;
                button60.Enabled = false;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(30);
            button60.Enabled = false;
            button59.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (button57.Enabled == false)
            {
                if (button58.Enabled == true)
                {
                    button58.Enabled = false;
                    button57.Enabled = false;
                }
                else
                {
                    button58.Enabled = true;

                    button58.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button57.Enabled = false;
                button58.Enabled = false;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (button57.Enabled == false)
            {
                button57.Enabled = true;
                button58.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button57.Enabled = false;
                button58.Enabled = false;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(31);
            button58.Enabled = false;
            button57.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (button55.Enabled == false)
            {
                if (button56.Enabled == true)
                {
                    button56.Enabled = false;
                    button55.Enabled = false;
                }
                else
                {
                    button56.Enabled = true;

                    button56.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button55.Enabled = false;
                button56.Enabled = false;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (button55.Enabled == false)
            {
                button55.Enabled = true;
                button56.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button55.Enabled = false;
                button56.Enabled = false;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(32);
            button56.Enabled = false;
            button55.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (button77.Enabled == false)
            {
                if (button78.Enabled == true)
                {
                    button78.Enabled = false;
                    button77.Enabled = false;
                }
                else
                {
                    button78.Enabled = true;

                    button78.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button77.Enabled = false;
                button78.Enabled = false;
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button77.Enabled == false)
            {
                button77.Enabled = true;
                button78.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button77.Enabled = false;
                button78.Enabled = false;
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(27);
            button78.Enabled = false;
            button77.Enabled = false;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (button75.Enabled == false)
            {
                if (button76.Enabled == true)
                {
                    button76.Enabled = false;
                    button75.Enabled = false;
                }
                else
                {
                    button76.Enabled = true;

                    button76.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button75.Enabled = false;
                button76.Enabled = false;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (button75.Enabled == false)
            {
                button75.Enabled = true;
                button76.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button75.Enabled = false;
                button76.Enabled = false;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(28);
            button76.Enabled = false;
            button75.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (button81.Enabled == false)
            {
                if (button82.Enabled == true)
                {
                    button82.Enabled = false;
                    button81.Enabled = false;
                }
                else
                {
                    button82.Enabled = true;

                    button82.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button81.Enabled = false;
                button82.Enabled = false;
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (button81.Enabled == false)
            {
                button81.Enabled = true;
                button82.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button81.Enabled = false;
                button82.Enabled = false;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(33);
            button81.Enabled = false;
            button82.Enabled = false;
        }
        private void button73_Click(object sender, EventArgs e)
        {
            if (button79.Enabled == false)
            {
                if (button80.Enabled == true)
                {
                    button80.Enabled = false;
                    button79.Enabled = false;
                }
                else
                {
                    button80.Enabled = true;

                    button80.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button79.Enabled = false;
                button80.Enabled = false;
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (button79.Enabled == false)
            {
                button79.Enabled = true;
                button80.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button79.Enabled = false;
                button80.Enabled = false;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(34);
            button80.Enabled = false;
            button79.Enabled = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (button86.Enabled == false)
            {
                if (button87.Enabled == true)
                {
                    button87.Enabled = false;
                    button86.Enabled = false;
                }
                else
                {
                    button87.Enabled = true;

                    button87.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button86.Enabled = false;
                button87.Enabled = false;
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (button86.Enabled == false)
            {
                button86.Enabled = true;
                button87.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button86.Enabled = false;
                button87.Enabled = false;
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(35);
            button86.Enabled = false;
            button87.Enabled = false;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (button84.Enabled == false)
            {
                if (button85.Enabled == true)
                {
                    button85.Enabled = false;
                    button84.Enabled = false;
                }
                else
                {
                    button85.Enabled = true;

                    button85.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Yellow.png");
                }
            }
            else
            {
                button84.Enabled = false;
                button85.Enabled = false;
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (button84.Enabled == false)
            {
                button84.Enabled = true;
                button85.Image = Image.FromFile(@"C:\Limpiar\imagen\Circle_Green.png");
            }
            else
            {
                button84.Enabled = false;
                button85.Enabled = false;
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            db.Borrar_Todas_Las_Tablas(36);
            button85.Enabled = false;
            button84.Enabled = false;
        }

        

       

        

       
        

        



        
       

       

    }
}
