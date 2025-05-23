﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaM_Controles
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        //contador de tiempo
        int tiempo = 0;


        private void btnAuditar_Click(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = true;
            OpenFileDialog archivoCoordenadas = new OpenFileDialog();

            if (archivoCoordenadas.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader srAuditar = new StreamReader(archivoCoordenadas.FileName))
                {
                    while (!srAuditar.EndOfStream)
                    {
                        lstCoordenadas.Items.Add(srAuditar.ReadLine());
                    }
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.");
            }
        }

        private void pnlPanelTrabajo_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoTrabajo.Enabled = false;     //se desactiva cuando salgo del panel
        }

        private void pnlPanelTrabajo_MouseMove(object sender, MouseEventArgs e)
        {

            timerTiempoTrabajo.Enabled = true;                                                  //se activa cuando muevo el cursor

            lblCoordenadas.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();             //coordenadas del mouse

            using (StreamWriter swAuditar = new StreamWriter("ZonaDeCalor.txt", true))                //escribir en el archivo
            {
                swAuditar.WriteLine(lblCoordenadas.Text);
            }
        }

        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblTiempo.Text = tiempo.ToString();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {

        }
    }
}
