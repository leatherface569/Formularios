namespace Formularios
{
    partial class Inicio
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
            this.dgvNombres = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txboxnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnregresaraloggin = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.txbeliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNombres
            // 
            this.dgvNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNombres.Location = new System.Drawing.Point(44, 227);
            this.dgvNombres.Name = "dgvNombres";
            this.dgvNombres.Size = new System.Drawing.Size(240, 150);
            this.dgvNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txboxnombre
            // 
            this.txboxnombre.Location = new System.Drawing.Point(119, 64);
            this.txboxnombre.Name = "txboxnombre";
            this.txboxnombre.Size = new System.Drawing.Size(100, 20);
            this.txboxnombre.TabIndex = 2;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(130, 109);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(209, 198);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(119, 396);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnregresaraloggin
            // 
            this.btnregresaraloggin.Location = new System.Drawing.Point(171, 12);
            this.btnregresaraloggin.Name = "btnregresaraloggin";
            this.btnregresaraloggin.Size = new System.Drawing.Size(143, 23);
            this.btnregresaraloggin.TabIndex = 6;
            this.btnregresaraloggin.Text = "Regresar a loggin";
            this.btnregresaraloggin.UseVisualStyleBackColor = true;
            this.btnregresaraloggin.Click += new System.EventHandler(this.btnregresaraloggin_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(239, 396);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(75, 23);
            this.btnexportar.TabIndex = 7;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            // 
            // txbeliminar
            // 
            this.txbeliminar.Location = new System.Drawing.Point(196, 172);
            this.txbeliminar.Name = "txbeliminar";
            this.txbeliminar.Size = new System.Drawing.Size(100, 20);
            this.txbeliminar.TabIndex = 8;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 431);
            this.Controls.Add(this.txbeliminar);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnregresaraloggin);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txboxnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNombres);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txboxnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnregresaraloggin;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.TextBox txbeliminar;
    }
}