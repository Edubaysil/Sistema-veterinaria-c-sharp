﻿using AllqovetBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Allqovet
{
    public partial class frmMenu : Form
    {
        /*private Panel leftBorderBtn;*/
        private BotonesDashboard btns = new BotonesDashboard();
        private Form formActual;

        

        public frmMenu(BotonesDashboard botones)
        {
          InitializeComponent();
            btns = botones;
            /*
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,41);
            panelmenu.Controls.Add(leftBorderBtn);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  BotonActivo(btnVentas);

            MostrarSubmenu(panelSubmenuVentas);

        }

        private void BotonActivo(Button button)
        {

            foreach (Control item in panelmenu.Controls)
            {

              

                if (item is Button )
                {
                   

                    Button botonn = (Button)item;

                    botonn.TextAlign = ContentAlignment.MiddleCenter;
                    botonn.BackColor = Color.FromArgb(153, 128, 154);
                  //  botonn.SendToBack();

                }
          
            }

            if (button.TextAlign == ContentAlignment.MiddleCenter)
            {

                button.TextAlign = ContentAlignment.MiddleRight;
                button.BackColor = Color.FromArgb(144, 116, 140);
                /*leftBorderBtn.BackColor = Color.White;
                leftBorderBtn.Location = new Point(0, button.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();*/

            }
           
            
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Ocultarsubmenu();

            frmDashboard dashboard = new frmDashboard(btns);

            AbrirFormHijo(dashboard);

        }

        private void Diseniomenu()
        {
           
        }

        private void Ocultarsubmenu()
        {
            if (panelSubmenuVentas.Visible == true)
                panelSubmenuVentas.Visible = false;

            if (panelProductos.Visible == true)
                panelProductos.Visible = false;

            if (panelFacturacion.Visible == true)
                panelFacturacion.Visible = false;

            if (panelAlmacen.Visible == true)
                panelAlmacen.Visible = false;

            if (panelPedidos.Visible == true)
                panelPedidos.Visible = false;

            if (panelsubmenuSistemas.Visible == true)
                panelsubmenuSistemas.Visible = false;

            if (panelsubmenuClientes.Visible == true)
                panelsubmenuClientes.Visible = false;

            if (panelSubmenuConsultorio.Visible == true)
                panelSubmenuConsultorio.Visible = false;

            if (panelMantenimiento.Visible == true)
                panelMantenimiento.Visible = false;


            //
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                Ocultarsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

           // BotonActivo(button3);

            frmClientes clientes = new frmClientes();
            AbrirFormHijo(clientes);
        

        }

        private void AbrirFormHijo( Form frm)
        {
            formActual = frm;
            frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(frm);
            panelEscritorio.Tag = frm;
            frm.BringToFront();
            frm.SetDesktopLocation( (panelEscritorio.Width - frm.Width)/2, (panelEscritorio.Height - frm.Height)/2);
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // BotonActivo(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         //   BotonActivo(button5);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(" ¿Salir del Sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubmenuConsultorio);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CajaAbierta())
            {
                frmVentas venta = new frmVentas();
                AbrirFormHijo(venta);
            }

            else
            {
                MessageBox.Show("No existe una caja activa");
            }

         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ventana ventana = new Ventana();

            frmFicha ficha = new frmFicha(false);

          

            ventana.AbrirFormHijo(ficha);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //MostrarSubmenu(panelsubmenuMant);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelAlmacen);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            /*MostrarSubmenu(panelsubmenuFinanzas);*/
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuSistemas);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuClientes);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            frmNuevoCliente clientes = new frmNuevoCliente();

            AbrirFormHijo(clientes);   

          
        }

        private void button27_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevo = new frmNuevoProducto();
            nuevo.Show();

        }

        private void button34_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProductos);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelFacturacion);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            frmRegistroVentas ventas = new frmRegistroVentas();
            AbrirFormHijo(ventas);
        }

        private void panelFacturacion_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelPedidos);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(panelAlmacen);
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            frmIngresoProductos ingreso = new frmIngresoProductos();
            AbrirFormHijo(ingreso);

        }

        private void panelSubmenuConsultorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmCita cita = new frmCita();
            AbrirFormHijo(cita);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            frmProductos prod = new frmProductos();
            prod.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes();
            cli.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCategory cat = new frmCategory();
            cat.Show();
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmUsuarios user = new frmUsuarios();
            user.Show();
        }

        private void panelMantenimiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMantenimiento);
        }

        private void lblModo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!CajaAbierta())
            {

                frmAperturaCaja caja = new frmAperturaCaja();
                AbrirFormHijo(caja);
            }
            else
            {
                MessageBox.Show("Ya existe una caja activa");
            }

        }

        private bool CajaAbierta()
        {
            bool estado = false;
            using (CajachicaBLL db = new CajachicaBLL())
            {
                try
                {
                    int cajachica = 0;
                    cajachica = db.BuscarCajaActiva();

                    if (cajachica == 0)
                    {
                        estado = false;
                     
                    }
                    else
                    {
                        estado = true;
                      
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                return estado;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRegistroVentas ventas = new frmRegistroVentas();
            AbrirFormHijo(ventas);
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            Ventana ventana = new Ventana();
            frmReporteVenta reporte = new frmReporteVenta();
            ventana.AbrirFormHijo(reporte);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            NuevoTipoPago pago = new NuevoTipoPago();
            AbrirFormHijo(pago);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            frmMovCajas mov = new frmMovCajas();
            AbrirFormHijo(mov);
        }

        private void button39_Click(object sender, EventArgs e)
        {

            frmReporteStock frmReporteStock = new frmReporteStock();
            AbrirFormHijo(frmReporteStock);

        }

        private void button26_Click(object sender, EventArgs e)
        {
            frmReporteStock frmReporteStock = new frmReporteStock();
            AbrirFormHijo(frmReporteStock);
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            frmComprobantes comprobantes = new frmComprobantes();
            AbrirFormHijo(comprobantes);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmRegistrofichas registrofichas = new frmRegistrofichas();
            AbrirFormHijo(registrofichas);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmTrabajador trabajador = new frmTrabajador();
            AbrirFormHijo(trabajador);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            AbrirFormHijo(proveedores);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmNuevaVitrina vitrina = new frmNuevaVitrina();
            AbrirFormHijo(vitrina);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            frmRegistroCitas citas = new frmRegistroCitas();
            AbrirFormHijo(citas);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            frmPermiso permiso = new frmPermiso();
            AbrirFormHijo(permiso);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               Application.Exit(); // Cancela el cierre de la ventana
            }
        }

        private void btnRepStock_Click(object sender, EventArgs e)
        {
            frmReporteStock reporteStock = new frmReporteStock();
            AbrirFormHijo(reporteStock);
        }

        private void btnRepVentas_Click(object sender, EventArgs e)
        {
            frmReporteVenta reporteVenta = new frmReporteVenta();
            AbrirFormHijo(reporteVenta);
        }

        private void btnRepCaducidad_Click(object sender, EventArgs e)
        {
            frmReporteCaducidad reporteCaducidad = new frmReporteCaducidad();
            AbrirFormHijo(reporteCaducidad);
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (CajaAbierta())
            {
                frmCiereCaja caja = new frmCiereCaja();
                AbrirFormHijo(caja);
            }

            else
            {
                MessageBox.Show("No existe una caja activa");
            }

           
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            AbrirFormHijo(backup);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cancela el cierre de la ventana
            }
        }
    }
}
