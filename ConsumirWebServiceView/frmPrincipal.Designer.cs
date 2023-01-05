namespace ConsumirWebServiceView
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.radEstado = new System.Windows.Forms.RadioButton();
            this.radMunicipio = new System.Windows.Forms.RadioButton();
            this.btnLimparGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço da API REST:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(682, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Carregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUrl.Location = new System.Drawing.Point(13, 34);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(681, 25);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.Text = "http://www.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informar XML";
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(13, 89);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(682, 96);
            this.txtXml.TabIndex = 7;
            this.txtXml.Text = resources.GetString("txtXml.Text");
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.Location = new System.Drawing.Point(14, 256);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(681, 374);
            this.dgv.TabIndex = 8;
            // 
            // radEstado
            // 
            this.radEstado.AutoSize = true;
            this.radEstado.Location = new System.Drawing.Point(164, 191);
            this.radEstado.Name = "radEstado";
            this.radEstado.Size = new System.Drawing.Size(66, 21);
            this.radEstado.TabIndex = 9;
            this.radEstado.TabStop = true;
            this.radEstado.Text = "Estado";
            this.radEstado.UseVisualStyleBackColor = true;
            this.radEstado.CheckedChanged += new System.EventHandler(this.radEstado_CheckedChanged);
            // 
            // radMunicipio
            // 
            this.radMunicipio.AutoSize = true;
            this.radMunicipio.Location = new System.Drawing.Point(460, 191);
            this.radMunicipio.Name = "radMunicipio";
            this.radMunicipio.Size = new System.Drawing.Size(83, 21);
            this.radMunicipio.TabIndex = 10;
            this.radMunicipio.TabStop = true;
            this.radMunicipio.Text = "Município";
            this.radMunicipio.UseVisualStyleBackColor = true;
            this.radMunicipio.CheckedChanged += new System.EventHandler(this.radMunicipio_CheckedChanged);
            // 
            // btnLimparGrid
            // 
            this.btnLimparGrid.Location = new System.Drawing.Point(14, 639);
            this.btnLimparGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparGrid.Name = "btnLimparGrid";
            this.btnLimparGrid.Size = new System.Drawing.Size(682, 30);
            this.btnLimparGrid.TabIndex = 11;
            this.btnLimparGrid.Text = "Clear";
            this.btnLimparGrid.UseVisualStyleBackColor = true;
            this.btnLimparGrid.Click += new System.EventHandler(this.btnLimparGrid_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 680);
            this.Controls.Add(this.btnLimparGrid);
            this.Controls.Add(this.radMunicipio);
            this.Controls.Add(this.radEstado);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtXml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumir XML Web";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton radEstado;
        private System.Windows.Forms.RadioButton radMunicipio;
        private System.Windows.Forms.Button btnLimparGrid;
    }
}

