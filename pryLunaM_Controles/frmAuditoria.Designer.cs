namespace pryLunaM_Controles
{
    partial class frmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCoordenadas = new System.Windows.Forms.ListBox();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblShowCoordenadas = new System.Windows.Forms.Label();
            this.lblShowTiempo = new System.Windows.Forms.Label();
            this.timerTiempoTrabajo = new System.Windows.Forms.Timer(this.components);
            this.pnlPanelTrabajo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.FormattingEnabled = true;
            this.lstCoordenadas.Location = new System.Drawing.Point(38, 26);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(399, 290);
            this.lstCoordenadas.TabIndex = 0;
            this.lstCoordenadas.Visible = false;
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(270, 364);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(128, 39);
            this.btnAuditar.TabIndex = 9;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenadas.Location = new System.Drawing.Point(149, 387);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(12, 16);
            this.lblCoordenadas.TabIndex = 8;
            this.lblCoordenadas.Text = "-";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(149, 355);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(12, 16);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "-";
            // 
            // lblShowCoordenadas
            // 
            this.lblShowCoordenadas.AutoSize = true;
            this.lblShowCoordenadas.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoordenadas.Location = new System.Drawing.Point(35, 387);
            this.lblShowCoordenadas.Name = "lblShowCoordenadas";
            this.lblShowCoordenadas.Size = new System.Drawing.Size(51, 16);
            this.lblShowCoordenadas.TabIndex = 6;
            this.lblShowCoordenadas.Text = "Lugares:";
            // 
            // lblShowTiempo
            // 
            this.lblShowTiempo.AutoSize = true;
            this.lblShowTiempo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTiempo.Location = new System.Drawing.Point(35, 355);
            this.lblShowTiempo.Name = "lblShowTiempo";
            this.lblShowTiempo.Size = new System.Drawing.Size(107, 16);
            this.lblShowTiempo.TabIndex = 5;
            this.lblShowTiempo.Text = "Tiempo de Trabajo:";
            // 
            // timerTiempoTrabajo
            // 
            this.timerTiempoTrabajo.Tick += new System.EventHandler(this.timerTiempoTrabajo_Tick);
            // 
            // pnlPanelTrabajo
            // 
            this.pnlPanelTrabajo.Location = new System.Drawing.Point(38, 26);
            this.pnlPanelTrabajo.Name = "pnlPanelTrabajo";
            this.pnlPanelTrabajo.Size = new System.Drawing.Size(401, 290);
            this.pnlPanelTrabajo.TabIndex = 0;
            this.pnlPanelTrabajo.MouseLeave += new System.EventHandler(this.pnlPanelTrabajo_MouseLeave);
            this.pnlPanelTrabajo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPanelTrabajo_MouseMove);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.pnlPanelTrabajo);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblShowCoordenadas);
            this.Controls.Add(this.lblShowTiempo);
            this.Controls.Add(this.lstCoordenadas);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCoordenadas;
        private System.Windows.Forms.Button btnAuditar;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblShowCoordenadas;
        private System.Windows.Forms.Label lblShowTiempo;
        private System.Windows.Forms.Timer timerTiempoTrabajo;
        private System.Windows.Forms.Panel pnlPanelTrabajo;
    }
}