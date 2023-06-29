namespace WinAppBiblioteca.Forms
{
    partial class UpdateForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVGeneral = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_BuscarCodigo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Update_Lib = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cat_Lib = new System.Windows.Forms.TextBox();
            this.txt_Disp_Lib = new System.Windows.Forms.TextBox();
            this.txt_Stock_Lib = new System.Windows.Forms.TextBox();
            this.txt_Ed_Lib = new System.Windows.Forms.TextBox();
            this.txt_LNameAu_Lib = new System.Windows.Forms.TextBox();
            this.txt_NameAutor_Lib = new System.Windows.Forms.TextBox();
            this.txt_Cod_Lib = new System.Windows.Forms.TextBox();
            this.txt_PubDate_Lib = new System.Windows.Forms.TextBox();
            this.txt_Name_Lib = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGeneral
            // 
            this.DGVGeneral.AllowUserToAddRows = false;
            this.DGVGeneral.AllowUserToDeleteRows = false;
            this.DGVGeneral.AllowUserToOrderColumns = true;
            this.DGVGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGeneral.Location = new System.Drawing.Point(29, 333);
            this.DGVGeneral.Name = "DGVGeneral";
            this.DGVGeneral.ReadOnly = true;
            this.DGVGeneral.Size = new System.Drawing.Size(838, 274);
            this.DGVGeneral.TabIndex = 19;
            this.DGVGeneral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGeneral_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Actualizar Registro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(517, 279);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 31);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txt_BuscarCodigo
            // 
            this.txt_BuscarCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCodigo.Location = new System.Drawing.Point(354, 279);
            this.txt_BuscarCodigo.Name = "txt_BuscarCodigo";
            this.txt_BuscarCodigo.Size = new System.Drawing.Size(135, 26);
            this.txt_BuscarCodigo.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(168, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 19);
            this.label16.TabIndex = 20;
            this.label16.Text = "Buscar por Codigo:";
            // 
            // btn_Update_Lib
            // 
            this.btn_Update_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Lib.Location = new System.Drawing.Point(389, 232);
            this.btn_Update_Lib.Name = "btn_Update_Lib";
            this.btn_Update_Lib.Size = new System.Drawing.Size(131, 31);
            this.btn_Update_Lib.TabIndex = 41;
            this.btn_Update_Lib.Text = "Update";
            this.btn_Update_Lib.UseVisualStyleBackColor = true;
            this.btn_Update_Lib.Click += new System.EventHandler(this.btn_Update_Lib_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Disponibilidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(620, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Categoria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 38);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido \r\ndel Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre \r\ndel Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Edicion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha \r\nPublicacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo:";
            // 
            // txt_Cat_Lib
            // 
            this.txt_Cat_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cat_Lib.Location = new System.Drawing.Point(689, 75);
            this.txt_Cat_Lib.Name = "txt_Cat_Lib";
            this.txt_Cat_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Cat_Lib.TabIndex = 29;
            // 
            // txt_Disp_Lib
            // 
            this.txt_Disp_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Disp_Lib.Location = new System.Drawing.Point(689, 181);
            this.txt_Disp_Lib.Name = "txt_Disp_Lib";
            this.txt_Disp_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Disp_Lib.TabIndex = 31;
            // 
            // txt_Stock_Lib
            // 
            this.txt_Stock_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock_Lib.Location = new System.Drawing.Point(689, 125);
            this.txt_Stock_Lib.Name = "txt_Stock_Lib";
            this.txt_Stock_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Stock_Lib.TabIndex = 30;
            // 
            // txt_Ed_Lib
            // 
            this.txt_Ed_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ed_Lib.Location = new System.Drawing.Point(389, 75);
            this.txt_Ed_Lib.Name = "txt_Ed_Lib";
            this.txt_Ed_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Ed_Lib.TabIndex = 26;
            // 
            // txt_LNameAu_Lib
            // 
            this.txt_LNameAu_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LNameAu_Lib.Location = new System.Drawing.Point(389, 181);
            this.txt_LNameAu_Lib.Name = "txt_LNameAu_Lib";
            this.txt_LNameAu_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_LNameAu_Lib.TabIndex = 28;
            // 
            // txt_NameAutor_Lib
            // 
            this.txt_NameAutor_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameAutor_Lib.Location = new System.Drawing.Point(389, 129);
            this.txt_NameAutor_Lib.Name = "txt_NameAutor_Lib";
            this.txt_NameAutor_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_NameAutor_Lib.TabIndex = 27;
            // 
            // txt_Cod_Lib
            // 
            this.txt_Cod_Lib.Enabled = false;
            this.txt_Cod_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cod_Lib.Location = new System.Drawing.Point(137, 75);
            this.txt_Cod_Lib.Name = "txt_Cod_Lib";
            this.txt_Cod_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Cod_Lib.TabIndex = 23;
            // 
            // txt_PubDate_Lib
            // 
            this.txt_PubDate_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PubDate_Lib.Location = new System.Drawing.Point(137, 181);
            this.txt_PubDate_Lib.Name = "txt_PubDate_Lib";
            this.txt_PubDate_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_PubDate_Lib.TabIndex = 25;
            // 
            // txt_Name_Lib
            // 
            this.txt_Name_Lib.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Lib.Location = new System.Drawing.Point(137, 125);
            this.txt_Name_Lib.Name = "txt_Name_Lib";
            this.txt_Name_Lib.Size = new System.Drawing.Size(135, 26);
            this.txt_Name_Lib.TabIndex = 24;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 713);
            this.Controls.Add(this.btn_Update_Lib);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cat_Lib);
            this.Controls.Add(this.txt_Disp_Lib);
            this.Controls.Add(this.txt_Stock_Lib);
            this.Controls.Add(this.txt_Ed_Lib);
            this.Controls.Add(this.txt_LNameAu_Lib);
            this.Controls.Add(this.txt_NameAutor_Lib);
            this.Controls.Add(this.txt_Cod_Lib);
            this.Controls.Add(this.txt_PubDate_Lib);
            this.Controls.Add(this.txt_Name_Lib);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt_BuscarCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGVGeneral);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVGeneral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt_BuscarCodigo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Update_Lib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cat_Lib;
        private System.Windows.Forms.TextBox txt_Disp_Lib;
        private System.Windows.Forms.TextBox txt_Stock_Lib;
        private System.Windows.Forms.TextBox txt_Ed_Lib;
        private System.Windows.Forms.TextBox txt_LNameAu_Lib;
        private System.Windows.Forms.TextBox txt_NameAutor_Lib;
        private System.Windows.Forms.TextBox txt_Cod_Lib;
        private System.Windows.Forms.TextBox txt_PubDate_Lib;
        private System.Windows.Forms.TextBox txt_Name_Lib;
    }
}

