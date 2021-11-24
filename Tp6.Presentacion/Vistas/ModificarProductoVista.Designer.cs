
namespace Tp6.Presentacion.Vistas
{
    partial class ModificarProductoVista
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
            this.existenciaLabel = new System.Windows.Forms.Label();
            this.existenciaText = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.precioFinalLabel = new System.Windows.Forms.Label();
            this.gananciaLabel = new System.Windows.Forms.Label();
            this.precioIVALabel = new System.Windows.Forms.Label();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioFinalText = new System.Windows.Forms.TextBox();
            this.gananciaText = new System.Windows.Forms.TextBox();
            this.precioIVAText = new System.Windows.Forms.TextBox();
            this.ivaText = new System.Windows.Forms.TextBox();
            this.precioBaseText = new System.Windows.Forms.TextBox();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // existenciaLabel
            // 
            this.existenciaLabel.AutoSize = true;
            this.existenciaLabel.Location = new System.Drawing.Point(14, 265);
            this.existenciaLabel.Name = "existenciaLabel";
            this.existenciaLabel.Size = new System.Drawing.Size(68, 17);
            this.existenciaLabel.TabIndex = 34;
            this.existenciaLabel.Text = "Cantidad:";
            // 
            // existenciaText
            // 
            this.existenciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Existencia", true));
            this.existenciaText.Location = new System.Drawing.Point(124, 261);
            this.existenciaText.Name = "existenciaText";
            this.existenciaText.Size = new System.Drawing.Size(327, 22);
            this.existenciaText.TabIndex = 33;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Dominio.Producto);
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Location = new System.Drawing.Point(354, 350);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(97, 40);
            this.confirmarBoton.TabIndex = 26;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // precioFinalLabel
            // 
            this.precioFinalLabel.AutoSize = true;
            this.precioFinalLabel.Location = new System.Drawing.Point(15, 235);
            this.precioFinalLabel.Name = "precioFinalLabel";
            this.precioFinalLabel.Size = new System.Drawing.Size(86, 17);
            this.precioFinalLabel.TabIndex = 32;
            this.precioFinalLabel.Text = "Precio Final:";
            // 
            // gananciaLabel
            // 
            this.gananciaLabel.AutoSize = true;
            this.gananciaLabel.Location = new System.Drawing.Point(13, 207);
            this.gananciaLabel.Name = "gananciaLabel";
            this.gananciaLabel.Size = new System.Drawing.Size(73, 17);
            this.gananciaLabel.TabIndex = 31;
            this.gananciaLabel.Text = "Ganancia:";
            // 
            // precioIVALabel
            // 
            this.precioIVALabel.AutoSize = true;
            this.precioIVALabel.Location = new System.Drawing.Point(13, 179);
            this.precioIVALabel.Name = "precioIVALabel";
            this.precioIVALabel.Size = new System.Drawing.Size(104, 17);
            this.precioIVALabel.TabIndex = 30;
            this.precioIVALabel.Text = "Precio con IVA:";
            // 
            // ivaLabel
            // 
            this.ivaLabel.AutoSize = true;
            this.ivaLabel.Location = new System.Drawing.Point(15, 151);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(33, 17);
            this.ivaLabel.TabIndex = 29;
            this.ivaLabel.Text = "IVA:";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(13, 121);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(88, 17);
            this.baseLabel.TabIndex = 28;
            this.baseLabel.Text = "Precio Base:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(13, 94);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(86, 17);
            this.descripcionLabel.TabIndex = 27;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // precioFinalText
            // 
            this.precioFinalText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PrecioFinal", true));
            this.precioFinalText.Location = new System.Drawing.Point(124, 232);
            this.precioFinalText.Name = "precioFinalText";
            this.precioFinalText.Size = new System.Drawing.Size(327, 22);
            this.precioFinalText.TabIndex = 25;
            // 
            // gananciaText
            // 
            this.gananciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MargenGanancia", true));
            this.gananciaText.Location = new System.Drawing.Point(124, 204);
            this.gananciaText.Name = "gananciaText";
            this.gananciaText.Size = new System.Drawing.Size(327, 22);
            this.gananciaText.TabIndex = 24;
            // 
            // precioIVAText
            // 
            this.precioIVAText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PrecioIVA", true));
            this.precioIVAText.Location = new System.Drawing.Point(124, 176);
            this.precioIVAText.Name = "precioIVAText";
            this.precioIVAText.Size = new System.Drawing.Size(327, 22);
            this.precioIVAText.TabIndex = 23;
            // 
            // ivaText
            // 
            this.ivaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PorcentajeIVA", true));
            this.ivaText.Location = new System.Drawing.Point(124, 148);
            this.ivaText.Name = "ivaText";
            this.ivaText.Size = new System.Drawing.Size(327, 22);
            this.ivaText.TabIndex = 22;
            // 
            // precioBaseText
            // 
            this.precioBaseText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PrecioBase", true));
            this.precioBaseText.Location = new System.Drawing.Point(124, 118);
            this.precioBaseText.Name = "precioBaseText";
            this.precioBaseText.Size = new System.Drawing.Size(327, 22);
            this.precioBaseText.TabIndex = 21;
            // 
            // descripcionText
            // 
            this.descripcionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Descripcion", true));
            this.descripcionText.Location = new System.Drawing.Point(124, 91);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(327, 22);
            this.descripcionText.TabIndex = 19;
            // 
            // codigoText
            // 
            this.codigoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Codigo", true));
            this.codigoText.Location = new System.Drawing.Point(124, 62);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(327, 22);
            this.codigoText.TabIndex = 18;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(13, 65);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(56, 17);
            this.codigoLabel.TabIndex = 20;
            this.codigoLabel.Text = "Codigo:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(12, 20);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(221, 20);
            this.tituloLabel.TabIndex = 17;
            this.tituloLabel.Text = "MODIFICAR PRODUCTO";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(124, 290);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(327, 24);
            this.estadoComboBox.TabIndex = 35;
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(16, 296);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(52, 17);
            this.estadoLabel.TabIndex = 36;
            this.estadoLabel.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "%";
            // 
            // ModificarVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.existenciaLabel);
            this.Controls.Add(this.existenciaText);
            this.Controls.Add(this.confirmarBoton);
            this.Controls.Add(this.precioFinalLabel);
            this.Controls.Add(this.gananciaLabel);
            this.Controls.Add(this.precioIVALabel);
            this.Controls.Add(this.ivaLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.precioFinalText);
            this.Controls.Add(this.gananciaText);
            this.Controls.Add(this.precioIVAText);
            this.Controls.Add(this.ivaText);
            this.Controls.Add(this.precioBaseText);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "ModificarVista";
            this.Text = "ModificarVista";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label existenciaLabel;
        private System.Windows.Forms.TextBox existenciaText;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.Label precioFinalLabel;
        private System.Windows.Forms.Label gananciaLabel;
        private System.Windows.Forms.Label precioIVALabel;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox precioFinalText;
        private System.Windows.Forms.TextBox gananciaText;
        private System.Windows.Forms.TextBox precioIVAText;
        private System.Windows.Forms.TextBox ivaText;
        private System.Windows.Forms.TextBox precioBaseText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}