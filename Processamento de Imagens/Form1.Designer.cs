namespace Processamento_de_Imagens
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.l = new System.Windows.Forms.Label();
            this.txtLarguraOriginal = new System.Windows.Forms.TextBox();
            this.txtAlturaOriginal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.lstHistogramaOriginal = new System.Windows.Forms.ListBox();
            this.lstOperacoes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLarguraProcessada = new System.Windows.Forms.TextBox();
            this.txtAlturaProcessada = new System.Windows.Forms.TextBox();
            this.lstHistogramaProcessada = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.picProcessada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.barLimiar = new System.Windows.Forms.TrackBar();
            this.txtLimiar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLimiar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.txtLarguraOriginal);
            this.panel1.Controls.Add(this.txtAlturaOriginal);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.picOriginal);
            this.panel1.Controls.Add(this.lstHistogramaOriginal);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 539);
            this.panel1.TabIndex = 1;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(166, 371);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(14, 15);
            this.l.TabIndex = 6;
            this.l.Text = "X";
            // 
            // txtLarguraOriginal
            // 
            this.txtLarguraOriginal.BackColor = System.Drawing.Color.White;
            this.txtLarguraOriginal.Location = new System.Drawing.Point(60, 368);
            this.txtLarguraOriginal.Name = "txtLarguraOriginal";
            this.txtLarguraOriginal.ReadOnly = true;
            this.txtLarguraOriginal.Size = new System.Drawing.Size(100, 23);
            this.txtLarguraOriginal.TabIndex = 4;
            this.txtLarguraOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlturaOriginal
            // 
            this.txtAlturaOriginal.BackColor = System.Drawing.Color.White;
            this.txtAlturaOriginal.Location = new System.Drawing.Point(186, 368);
            this.txtAlturaOriginal.Name = "txtAlturaOriginal";
            this.txtAlturaOriginal.ReadOnly = true;
            this.txtAlturaOriginal.Size = new System.Drawing.Size(100, 23);
            this.txtAlturaOriginal.TabIndex = 4;
            this.txtAlturaOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(19, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Selecionar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.InitialImage = null;
            this.picOriginal.Location = new System.Drawing.Point(19, 15);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(308, 288);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // lstHistogramaOriginal
            // 
            this.lstHistogramaOriginal.FormattingEnabled = true;
            this.lstHistogramaOriginal.ItemHeight = 15;
            this.lstHistogramaOriginal.Location = new System.Drawing.Point(19, 397);
            this.lstHistogramaOriginal.Name = "lstHistogramaOriginal";
            this.lstHistogramaOriginal.Size = new System.Drawing.Size(308, 124);
            this.lstHistogramaOriginal.TabIndex = 5;
            // 
            // lstOperacoes
            // 
            this.lstOperacoes.FormattingEnabled = true;
            this.lstOperacoes.ItemHeight = 15;
            this.lstOperacoes.Location = new System.Drawing.Point(359, 45);
            this.lstOperacoes.Name = "lstOperacoes";
            this.lstOperacoes.Size = new System.Drawing.Size(308, 304);
            this.lstOperacoes.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(359, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLarguraProcessada);
            this.panel2.Controls.Add(this.txtAlturaProcessada);
            this.panel2.Controls.Add(this.lstHistogramaProcessada);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.picProcessada);
            this.panel2.Location = new System.Drawing.Point(670, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 539);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // txtLarguraProcessada
            // 
            this.txtLarguraProcessada.BackColor = System.Drawing.Color.White;
            this.txtLarguraProcessada.Location = new System.Drawing.Point(60, 368);
            this.txtLarguraProcessada.Name = "txtLarguraProcessada";
            this.txtLarguraProcessada.ReadOnly = true;
            this.txtLarguraProcessada.Size = new System.Drawing.Size(100, 23);
            this.txtLarguraProcessada.TabIndex = 7;
            this.txtLarguraProcessada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlturaProcessada
            // 
            this.txtAlturaProcessada.BackColor = System.Drawing.Color.White;
            this.txtAlturaProcessada.Location = new System.Drawing.Point(186, 368);
            this.txtAlturaProcessada.Name = "txtAlturaProcessada";
            this.txtAlturaProcessada.ReadOnly = true;
            this.txtAlturaProcessada.Size = new System.Drawing.Size(100, 23);
            this.txtAlturaProcessada.TabIndex = 8;
            this.txtAlturaProcessada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstHistogramaProcessada
            // 
            this.lstHistogramaProcessada.FormattingEnabled = true;
            this.lstHistogramaProcessada.ItemHeight = 15;
            this.lstHistogramaProcessada.Location = new System.Drawing.Point(19, 397);
            this.lstHistogramaProcessada.Name = "lstHistogramaProcessada";
            this.lstHistogramaProcessada.Size = new System.Drawing.Size(308, 124);
            this.lstHistogramaProcessada.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(19, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picProcessada
            // 
            this.picProcessada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProcessada.Location = new System.Drawing.Point(19, 15);
            this.picProcessada.Margin = new System.Windows.Forms.Padding(0);
            this.picProcessada.Name = "picProcessada";
            this.picProcessada.Size = new System.Drawing.Size(308, 288);
            this.picProcessada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcessada.TabIndex = 0;
            this.picProcessada.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imagem A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(359, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Controle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(670, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagem B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 660);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 660);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // barLimiar
            // 
            this.barLimiar.AutoSize = false;
            this.barLimiar.LargeChange = 1;
            this.barLimiar.Location = new System.Drawing.Point(359, 377);
            this.barLimiar.Maximum = 255;
            this.barLimiar.Name = "barLimiar";
            this.barLimiar.Size = new System.Drawing.Size(308, 45);
            this.barLimiar.TabIndex = 9;
            this.barLimiar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtLimiar
            // 
            this.txtLimiar.Location = new System.Drawing.Point(463, 354);
            this.txtLimiar.Name = "txtLimiar";
            this.txtLimiar.Size = new System.Drawing.Size(100, 23);
            this.txtLimiar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1040, 660);
            this.Controls.Add(this.txtLimiar);
            this.Controls.Add(this.barLimiar);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstOperacoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLimiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.ListBox lstOperacoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picProcessada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLarguraOriginal;
        private System.Windows.Forms.TextBox txtAlturaOriginal;
        private System.Windows.Forms.ListBox lstHistogramaOriginal;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TrackBar barLimiar;
        private System.Windows.Forms.TextBox txtLimiar;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ListBox O;
        private System.Windows.Forms.ListBox lstHistogramaProcessada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLarguraProcessada;
        private System.Windows.Forms.TextBox txtAlturaProcessada;
    }
}