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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chtHistogramaOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.l = new System.Windows.Forms.Label();
            this.txtLarguraOriginal = new System.Windows.Forms.TextBox();
            this.txtAlturaOriginal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.lstHistogramaOriginal = new System.Windows.Forms.ListBox();
            this.lstOperacoes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chtHistogramaProcessada = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLimiar = new System.Windows.Forms.TextBox();
            this.barLimiar = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSegundaMascara = new System.Windows.Forms.DataGridView();
            this.rdbSegundaMascara = new System.Windows.Forms.RadioButton();
            this.dgvPrimeiraMascara = new System.Windows.Forms.DataGridView();
            this.rdPrimeiraMascara = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rdAzul = new System.Windows.Forms.RadioButton();
            this.rdVerde = new System.Windows.Forms.RadioButton();
            this.rdVermelho = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbNumeroCanais = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogramaOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogramaProcessada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessada)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barLimiar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaMascara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeiraMascara)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chtHistogramaOriginal);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.txtLarguraOriginal);
            this.panel1.Controls.Add(this.txtAlturaOriginal);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.picOriginal);
            this.panel1.Controls.Add(this.lstHistogramaOriginal);
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 594);
            this.panel1.TabIndex = 1;
            // 
            // chtHistogramaOriginal
            // 
            chartArea7.Name = "ChartArea1";
            this.chtHistogramaOriginal.ChartAreas.Add(chartArea7);
            this.chtHistogramaOriginal.Location = new System.Drawing.Point(16, 458);
            this.chtHistogramaOriginal.Name = "chtHistogramaOriginal";
            this.chtHistogramaOriginal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.chtHistogramaOriginal.Series.Add(series7);
            this.chtHistogramaOriginal.Size = new System.Drawing.Size(265, 133);
            this.chtHistogramaOriginal.TabIndex = 11;
            this.chtHistogramaOriginal.Text = "chart1";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(142, 322);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(14, 13);
            this.l.TabIndex = 6;
            this.l.Text = "X";
            // 
            // txtLarguraOriginal
            // 
            this.txtLarguraOriginal.BackColor = System.Drawing.Color.White;
            this.txtLarguraOriginal.Location = new System.Drawing.Point(51, 319);
            this.txtLarguraOriginal.Name = "txtLarguraOriginal";
            this.txtLarguraOriginal.ReadOnly = true;
            this.txtLarguraOriginal.Size = new System.Drawing.Size(86, 20);
            this.txtLarguraOriginal.TabIndex = 4;
            this.txtLarguraOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlturaOriginal
            // 
            this.txtAlturaOriginal.BackColor = System.Drawing.Color.White;
            this.txtAlturaOriginal.Location = new System.Drawing.Point(159, 319);
            this.txtAlturaOriginal.Name = "txtAlturaOriginal";
            this.txtAlturaOriginal.ReadOnly = true;
            this.txtAlturaOriginal.Size = new System.Drawing.Size(86, 20);
            this.txtAlturaOriginal.TabIndex = 4;
            this.txtAlturaOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(16, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Selecionar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.InitialImage = null;
            this.picOriginal.Location = new System.Drawing.Point(16, 13);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(264, 250);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // lstHistogramaOriginal
            // 
            this.lstHistogramaOriginal.FormattingEnabled = true;
            this.lstHistogramaOriginal.Location = new System.Drawing.Point(16, 344);
            this.lstHistogramaOriginal.Name = "lstHistogramaOriginal";
            this.lstHistogramaOriginal.Size = new System.Drawing.Size(265, 108);
            this.lstHistogramaOriginal.TabIndex = 5;
            // 
            // lstOperacoes
            // 
            this.lstOperacoes.FormattingEnabled = true;
            this.lstOperacoes.Location = new System.Drawing.Point(308, 39);
            this.lstOperacoes.Name = "lstOperacoes";
            this.lstOperacoes.Size = new System.Drawing.Size(265, 264);
            this.lstOperacoes.TabIndex = 2;
            this.lstOperacoes.SelectedValueChanged += new System.EventHandler(this.lstOperacoes_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(308, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chtHistogramaProcessada);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLarguraProcessada);
            this.panel2.Controls.Add(this.txtAlturaProcessada);
            this.panel2.Controls.Add(this.lstHistogramaProcessada);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.picProcessada);
            this.panel2.Location = new System.Drawing.Point(574, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 594);
            this.panel2.TabIndex = 1;
            // 
            // chtHistogramaProcessada
            // 
            chartArea8.Name = "ChartArea1";
            this.chtHistogramaProcessada.ChartAreas.Add(chartArea8);
            this.chtHistogramaProcessada.Location = new System.Drawing.Point(16, 458);
            this.chtHistogramaProcessada.Name = "chtHistogramaProcessada";
            this.chtHistogramaProcessada.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series8.ChartArea = "ChartArea1";
            series8.Name = "Series1";
            this.chtHistogramaProcessada.Series.Add(series8);
            this.chtHistogramaProcessada.Size = new System.Drawing.Size(265, 133);
            this.chtHistogramaProcessada.TabIndex = 12;
            this.chtHistogramaProcessada.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // txtLarguraProcessada
            // 
            this.txtLarguraProcessada.BackColor = System.Drawing.Color.White;
            this.txtLarguraProcessada.Location = new System.Drawing.Point(51, 319);
            this.txtLarguraProcessada.Name = "txtLarguraProcessada";
            this.txtLarguraProcessada.ReadOnly = true;
            this.txtLarguraProcessada.Size = new System.Drawing.Size(86, 20);
            this.txtLarguraProcessada.TabIndex = 7;
            this.txtLarguraProcessada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlturaProcessada
            // 
            this.txtAlturaProcessada.BackColor = System.Drawing.Color.White;
            this.txtAlturaProcessada.Location = new System.Drawing.Point(159, 319);
            this.txtAlturaProcessada.Name = "txtAlturaProcessada";
            this.txtAlturaProcessada.ReadOnly = true;
            this.txtAlturaProcessada.Size = new System.Drawing.Size(86, 20);
            this.txtAlturaProcessada.TabIndex = 8;
            this.txtAlturaProcessada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstHistogramaProcessada
            // 
            this.lstHistogramaProcessada.FormattingEnabled = true;
            this.lstHistogramaProcessada.Location = new System.Drawing.Point(16, 344);
            this.lstHistogramaProcessada.Name = "lstHistogramaProcessada";
            this.lstHistogramaProcessada.Size = new System.Drawing.Size(265, 108);
            this.lstHistogramaProcessada.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(16, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(264, 33);
            this.button5.TabIndex = 3;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picProcessada
            // 
            this.picProcessada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProcessada.Location = new System.Drawing.Point(16, 13);
            this.picProcessada.Margin = new System.Windows.Forms.Padding(0);
            this.picProcessada.Name = "picProcessada";
            this.picProcessada.Size = new System.Drawing.Size(264, 250);
            this.picProcessada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcessada.TabIndex = 0;
            this.picProcessada.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imagem A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(308, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(574, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagem B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 642);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 642);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(309, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Controle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(308, 325);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 166);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLimiar);
            this.tabPage1.Controls.Add(this.barLimiar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(255, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Limiar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLimiar
            // 
            this.txtLimiar.Location = new System.Drawing.Point(86, 14);
            this.txtLimiar.Name = "txtLimiar";
            this.txtLimiar.Size = new System.Drawing.Size(86, 20);
            this.txtLimiar.TabIndex = 14;
            // 
            // barLimiar
            // 
            this.barLimiar.AutoSize = false;
            this.barLimiar.BackColor = System.Drawing.Color.White;
            this.barLimiar.LargeChange = 1;
            this.barLimiar.Location = new System.Drawing.Point(6, 40);
            this.barLimiar.Maximum = 255;
            this.barLimiar.Name = "barLimiar";
            this.barLimiar.Size = new System.Drawing.Size(243, 39);
            this.barLimiar.TabIndex = 13;
            this.barLimiar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSegundaMascara);
            this.tabPage2.Controls.Add(this.rdbSegundaMascara);
            this.tabPage2.Controls.Add(this.dgvPrimeiraMascara);
            this.tabPage2.Controls.Add(this.rdPrimeiraMascara);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(255, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Máscara";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSegundaMascara
            // 
            this.dgvSegundaMascara.AllowUserToResizeColumns = false;
            this.dgvSegundaMascara.AllowUserToResizeRows = false;
            this.dgvSegundaMascara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSegundaMascara.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSegundaMascara.BackgroundColor = System.Drawing.Color.White;
            this.dgvSegundaMascara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegundaMascara.ColumnHeadersVisible = false;
            this.dgvSegundaMascara.Enabled = false;
            this.dgvSegundaMascara.EnableHeadersVisualStyles = false;
            this.dgvSegundaMascara.Location = new System.Drawing.Point(24, 72);
            this.dgvSegundaMascara.MultiSelect = false;
            this.dgvSegundaMascara.Name = "dgvSegundaMascara";
            this.dgvSegundaMascara.ReadOnly = true;
            this.dgvSegundaMascara.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSegundaMascara.RowHeadersVisible = false;
            this.dgvSegundaMascara.RowHeadersWidth = 40;
            this.dgvSegundaMascara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSegundaMascara.Size = new System.Drawing.Size(228, 60);
            this.dgvSegundaMascara.TabIndex = 3;
            this.dgvSegundaMascara.TabStop = false;
            // 
            // rdbSegundaMascara
            // 
            this.rdbSegundaMascara.AutoSize = true;
            this.rdbSegundaMascara.Location = new System.Drawing.Point(6, 80);
            this.rdbSegundaMascara.Name = "rdbSegundaMascara";
            this.rdbSegundaMascara.Size = new System.Drawing.Size(14, 13);
            this.rdbSegundaMascara.TabIndex = 2;
            this.rdbSegundaMascara.UseVisualStyleBackColor = true;
            // 
            // dgvPrimeiraMascara
            // 
            this.dgvPrimeiraMascara.AllowUserToResizeColumns = false;
            this.dgvPrimeiraMascara.AllowUserToResizeRows = false;
            this.dgvPrimeiraMascara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrimeiraMascara.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrimeiraMascara.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrimeiraMascara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimeiraMascara.ColumnHeadersVisible = false;
            this.dgvPrimeiraMascara.Enabled = false;
            this.dgvPrimeiraMascara.EnableHeadersVisualStyles = false;
            this.dgvPrimeiraMascara.Location = new System.Drawing.Point(24, 6);
            this.dgvPrimeiraMascara.MultiSelect = false;
            this.dgvPrimeiraMascara.Name = "dgvPrimeiraMascara";
            this.dgvPrimeiraMascara.ReadOnly = true;
            this.dgvPrimeiraMascara.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPrimeiraMascara.RowHeadersVisible = false;
            this.dgvPrimeiraMascara.RowHeadersWidth = 40;
            this.dgvPrimeiraMascara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPrimeiraMascara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrimeiraMascara.Size = new System.Drawing.Size(228, 60);
            this.dgvPrimeiraMascara.TabIndex = 1;
            this.dgvPrimeiraMascara.TabStop = false;
            // 
            // rdPrimeiraMascara
            // 
            this.rdPrimeiraMascara.AutoSize = true;
            this.rdPrimeiraMascara.Checked = true;
            this.rdPrimeiraMascara.Location = new System.Drawing.Point(6, 14);
            this.rdPrimeiraMascara.Name = "rdPrimeiraMascara";
            this.rdPrimeiraMascara.Size = new System.Drawing.Size(14, 13);
            this.rdPrimeiraMascara.TabIndex = 0;
            this.rdPrimeiraMascara.TabStop = true;
            this.rdPrimeiraMascara.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdAzul);
            this.tabPage3.Controls.Add(this.rdVerde);
            this.tabPage3.Controls.Add(this.rdVermelho);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(255, 140);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Canal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rdAzul
            // 
            this.rdAzul.AutoSize = true;
            this.rdAzul.Location = new System.Drawing.Point(13, 60);
            this.rdAzul.Name = "rdAzul";
            this.rdAzul.Size = new System.Drawing.Size(45, 17);
            this.rdAzul.TabIndex = 2;
            this.rdAzul.Text = "Azul";
            this.rdAzul.UseVisualStyleBackColor = true;
            // 
            // rdVerde
            // 
            this.rdVerde.AutoSize = true;
            this.rdVerde.Location = new System.Drawing.Point(13, 37);
            this.rdVerde.Name = "rdVerde";
            this.rdVerde.Size = new System.Drawing.Size(53, 17);
            this.rdVerde.TabIndex = 1;
            this.rdVerde.Text = "Verde";
            this.rdVerde.UseVisualStyleBackColor = true;
            // 
            // rdVermelho
            // 
            this.rdVermelho.AutoSize = true;
            this.rdVermelho.Checked = true;
            this.rdVermelho.Location = new System.Drawing.Point(13, 14);
            this.rdVermelho.Name = "rdVermelho";
            this.rdVermelho.Size = new System.Drawing.Size(69, 17);
            this.rdVermelho.TabIndex = 0;
            this.rdVermelho.TabStop = true;
            this.rdVermelho.Text = "Vermelho";
            this.rdVermelho.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbNumeroCanais);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(255, 140);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Número de Canais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbNumeroCanais
            // 
            this.cmbNumeroCanais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroCanais.FormattingEnabled = true;
            this.cmbNumeroCanais.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.cmbNumeroCanais.Location = new System.Drawing.Point(70, 14);
            this.cmbNumeroCanais.Name = "cmbNumeroCanais";
            this.cmbNumeroCanais.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroCanais.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(878, 642);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogramaOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogramaProcessada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessada)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barLimiar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegundaMascara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimeiraMascara)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ListBox O;
        private System.Windows.Forms.ListBox lstHistogramaProcessada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLarguraProcessada;
        private System.Windows.Forms.TextBox txtAlturaProcessada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtHistogramaOriginal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtHistogramaProcessada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLimiar;
        private System.Windows.Forms.TrackBar barLimiar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdPrimeiraMascara;
        private System.Windows.Forms.DataGridView dgvPrimeiraMascara;
        private System.Windows.Forms.DataGridView dgvSegundaMascara;
        private System.Windows.Forms.RadioButton rdbSegundaMascara;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rdAzul;
        private System.Windows.Forms.RadioButton rdVerde;
        private System.Windows.Forms.RadioButton rdVermelho;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbNumeroCanais;
    }
}