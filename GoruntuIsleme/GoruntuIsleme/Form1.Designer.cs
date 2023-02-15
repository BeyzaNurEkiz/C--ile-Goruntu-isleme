
namespace GoruntuIsleme
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griTonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eşiklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastGermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEşitlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alçakGeçirgenFiltrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medyanFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradyentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometrikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açılıDöndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntününTersÇevrilmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçültmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüÖtelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfolojikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaymaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşındırmaErosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüNetleştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspektifDüzeltmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griTonToolStripMenuItem,
            this.parlaklıkDeğiştirToolStripMenuItem,
            this.negatifAlmaToolStripMenuItem,
            this.eşiklemeToolStripMenuItem,
            this.kontrastToolStripMenuItem,
            this.histogramEşitlemeToolStripMenuItem,
            this.alçakGeçirgenFiltrelemeToolStripMenuItem,
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem,
            this.geometrikİşlemlerToolStripMenuItem,
            this.morfolojikİşlemlerToolStripMenuItem,
            this.görüntüNetleştirmeToolStripMenuItem,
            this.perspektifDüzeltmeToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Image = global::GoruntuIsleme.Properties.Resources._3844475_filter_filters_icon;
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // griTonToolStripMenuItem
            // 
            this.griTonToolStripMenuItem.Name = "griTonToolStripMenuItem";
            this.griTonToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.griTonToolStripMenuItem.Text = "Gri Ton";
            this.griTonToolStripMenuItem.Click += new System.EventHandler(this.griTonToolStripMenuItem_Click);
            // 
            // parlaklıkDeğiştirToolStripMenuItem
            // 
            this.parlaklıkDeğiştirToolStripMenuItem.Name = "parlaklıkDeğiştirToolStripMenuItem";
            this.parlaklıkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.parlaklıkDeğiştirToolStripMenuItem.Text = "Parlaklık Değiştir";
            this.parlaklıkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkDeğiştirToolStripMenuItem_Click);
            // 
            // negatifAlmaToolStripMenuItem
            // 
            this.negatifAlmaToolStripMenuItem.Name = "negatifAlmaToolStripMenuItem";
            this.negatifAlmaToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.negatifAlmaToolStripMenuItem.Text = "Negatif Alma";
            this.negatifAlmaToolStripMenuItem.Click += new System.EventHandler(this.negatifAlmaToolStripMenuItem_Click);
            // 
            // eşiklemeToolStripMenuItem
            // 
            this.eşiklemeToolStripMenuItem.Name = "eşiklemeToolStripMenuItem";
            this.eşiklemeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.eşiklemeToolStripMenuItem.Text = "Eşikleme";
            this.eşiklemeToolStripMenuItem.Click += new System.EventHandler(this.eşiklemeToolStripMenuItem_Click);
            // 
            // kontrastToolStripMenuItem
            // 
            this.kontrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrastGermeToolStripMenuItem});
            this.kontrastToolStripMenuItem.Name = "kontrastToolStripMenuItem";
            this.kontrastToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.kontrastToolStripMenuItem.Text = "Kontrast";
            this.kontrastToolStripMenuItem.Click += new System.EventHandler(this.kontrastToolStripMenuItem_Click);
            // 
            // kontrastGermeToolStripMenuItem
            // 
            this.kontrastGermeToolStripMenuItem.Name = "kontrastGermeToolStripMenuItem";
            this.kontrastGermeToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.kontrastGermeToolStripMenuItem.Text = "Kontrast Germe";
            this.kontrastGermeToolStripMenuItem.Click += new System.EventHandler(this.kontrastGermeToolStripMenuItem_Click);
            // 
            // histogramEşitlemeToolStripMenuItem
            // 
            this.histogramEşitlemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem});
            this.histogramEşitlemeToolStripMenuItem.Name = "histogramEşitlemeToolStripMenuItem";
            this.histogramEşitlemeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.histogramEşitlemeToolStripMenuItem.Text = "Histogram ";
            this.histogramEşitlemeToolStripMenuItem.Click += new System.EventHandler(this.histogramEşitlemeToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.histogramToolStripMenuItem.Text = "Histogram Eşitleme";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // alçakGeçirgenFiltrelemeToolStripMenuItem
            // 
            this.alçakGeçirgenFiltrelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem,
            this.meanFiltreToolStripMenuItem,
            this.medyanFiltreToolStripMenuItem});
            this.alçakGeçirgenFiltrelemeToolStripMenuItem.Name = "alçakGeçirgenFiltrelemeToolStripMenuItem";
            this.alçakGeçirgenFiltrelemeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.alçakGeçirgenFiltrelemeToolStripMenuItem.Text = "Alçak Geçirgen Filtreleme";
            // 
            // gaussAlçakGeçirgenFiltresiToolStripMenuItem
            // 
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem.Name = "gaussAlçakGeçirgenFiltresiToolStripMenuItem";
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem.Text = "Gauss Filtresi";
            this.gaussAlçakGeçirgenFiltresiToolStripMenuItem.Click += new System.EventHandler(this.gaussAlçakGeçirgenFiltresiToolStripMenuItem_Click);
            // 
            // meanFiltreToolStripMenuItem
            // 
            this.meanFiltreToolStripMenuItem.Name = "meanFiltreToolStripMenuItem";
            this.meanFiltreToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.meanFiltreToolStripMenuItem.Text = "Mean Filtre";
            this.meanFiltreToolStripMenuItem.Click += new System.EventHandler(this.meanFiltreToolStripMenuItem_Click_1);
            // 
            // medyanFiltreToolStripMenuItem
            // 
            this.medyanFiltreToolStripMenuItem.Name = "medyanFiltreToolStripMenuItem";
            this.medyanFiltreToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.medyanFiltreToolStripMenuItem.Text = "Medyan Filtre";
            this.medyanFiltreToolStripMenuItem.Click += new System.EventHandler(this.medyanFiltreToolStripMenuItem_Click);
            // 
            // yüksekGeçirgenFiltrelemeToolStripMenuItem
            // 
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplacianToolStripMenuItem,
            this.sobelFiltresiToolStripMenuItem,
            this.prewittFiltresiToolStripMenuItem,
            this.gradyentToolStripMenuItem});
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem.Name = "yüksekGeçirgenFiltrelemeToolStripMenuItem";
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.yüksekGeçirgenFiltrelemeToolStripMenuItem.Text = "Yüksek Geçirgen Filtreleme";
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.laplacianToolStripMenuItem.Text = "Laplacian Filtre";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // sobelFiltresiToolStripMenuItem
            // 
            this.sobelFiltresiToolStripMenuItem.Name = "sobelFiltresiToolStripMenuItem";
            this.sobelFiltresiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobelFiltresiToolStripMenuItem.Text = "Sobel Filtresi";
            this.sobelFiltresiToolStripMenuItem.Click += new System.EventHandler(this.sobelFiltresiToolStripMenuItem_Click);
            // 
            // prewittFiltresiToolStripMenuItem
            // 
            this.prewittFiltresiToolStripMenuItem.Name = "prewittFiltresiToolStripMenuItem";
            this.prewittFiltresiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prewittFiltresiToolStripMenuItem.Text = "Prewitt Filtresi";
            this.prewittFiltresiToolStripMenuItem.Click += new System.EventHandler(this.prewittFiltresiToolStripMenuItem_Click);
            // 
            // gradyentToolStripMenuItem
            // 
            this.gradyentToolStripMenuItem.Name = "gradyentToolStripMenuItem";
            this.gradyentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gradyentToolStripMenuItem.Text = "Gradyent";
            this.gradyentToolStripMenuItem.Click += new System.EventHandler(this.gradyentToolStripMenuItem_Click);
            // 
            // geometrikİşlemlerToolStripMenuItem
            // 
            this.geometrikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açılıDöndürmeToolStripMenuItem,
            this.görüntününTersÇevrilmesiToolStripMenuItem,
            this.aynalamaToolStripMenuItem,
            this.küçültmeToolStripMenuItem,
            this.yakınlaştırmaToolStripMenuItem,
            this.görüntüÖtelemeToolStripMenuItem});
            this.geometrikİşlemlerToolStripMenuItem.Name = "geometrikİşlemlerToolStripMenuItem";
            this.geometrikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.geometrikİşlemlerToolStripMenuItem.Text = "Geometrik İşlemler";
            // 
            // açılıDöndürmeToolStripMenuItem
            // 
            this.açılıDöndürmeToolStripMenuItem.Name = "açılıDöndürmeToolStripMenuItem";
            this.açılıDöndürmeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.açılıDöndürmeToolStripMenuItem.Text = "Açılı döndürme";
            this.açılıDöndürmeToolStripMenuItem.Click += new System.EventHandler(this.açılıDöndürmeToolStripMenuItem_Click);
            // 
            // görüntününTersÇevrilmesiToolStripMenuItem
            // 
            this.görüntününTersÇevrilmesiToolStripMenuItem.Name = "görüntününTersÇevrilmesiToolStripMenuItem";
            this.görüntününTersÇevrilmesiToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.görüntününTersÇevrilmesiToolStripMenuItem.Text = "Görüntünün ters çevrilmesi";
            this.görüntününTersÇevrilmesiToolStripMenuItem.Click += new System.EventHandler(this.görüntününTersÇevrilmesiToolStripMenuItem_Click);
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.aynalamaToolStripMenuItem_Click);
            // 
            // küçültmeToolStripMenuItem
            // 
            this.küçültmeToolStripMenuItem.Name = "küçültmeToolStripMenuItem";
            this.küçültmeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.küçültmeToolStripMenuItem.Text = "Küçültme";
            this.küçültmeToolStripMenuItem.Click += new System.EventHandler(this.küçültmeToolStripMenuItem_Click);
            // 
            // yakınlaştırmaToolStripMenuItem
            // 
            this.yakınlaştırmaToolStripMenuItem.Name = "yakınlaştırmaToolStripMenuItem";
            this.yakınlaştırmaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.yakınlaştırmaToolStripMenuItem.Text = "Yakınlaştırma";
            this.yakınlaştırmaToolStripMenuItem.Click += new System.EventHandler(this.yakınlaştırmaToolStripMenuItem_Click);
            // 
            // görüntüÖtelemeToolStripMenuItem
            // 
            this.görüntüÖtelemeToolStripMenuItem.Name = "görüntüÖtelemeToolStripMenuItem";
            this.görüntüÖtelemeToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.görüntüÖtelemeToolStripMenuItem.Text = "Görüntü öteleme";
            this.görüntüÖtelemeToolStripMenuItem.Click += new System.EventHandler(this.görüntüÖtelemeToolStripMenuItem_Click);
            // 
            // morfolojikİşlemlerToolStripMenuItem
            // 
            this.morfolojikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaymaToolStripMenuItem,
            this.aşındırmaErosionToolStripMenuItem});
            this.morfolojikİşlemlerToolStripMenuItem.Name = "morfolojikİşlemlerToolStripMenuItem";
            this.morfolojikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.morfolojikİşlemlerToolStripMenuItem.Text = "Morfolojik İşlemler";
            // 
            // yaymaToolStripMenuItem
            // 
            this.yaymaToolStripMenuItem.Name = "yaymaToolStripMenuItem";
            this.yaymaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yaymaToolStripMenuItem.Text = "Yayma (Dilation)";
            this.yaymaToolStripMenuItem.Click += new System.EventHandler(this.yaymaToolStripMenuItem_Click);
            // 
            // aşındırmaErosionToolStripMenuItem
            // 
            this.aşındırmaErosionToolStripMenuItem.Name = "aşındırmaErosionToolStripMenuItem";
            this.aşındırmaErosionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aşındırmaErosionToolStripMenuItem.Text = "Aşındırma (Erosion)";
            this.aşındırmaErosionToolStripMenuItem.Click += new System.EventHandler(this.aşındırmaErosionToolStripMenuItem_Click);
            // 
            // görüntüNetleştirmeToolStripMenuItem
            // 
            this.görüntüNetleştirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konToolStripMenuItem});
            this.görüntüNetleştirmeToolStripMenuItem.Name = "görüntüNetleştirmeToolStripMenuItem";
            this.görüntüNetleştirmeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.görüntüNetleştirmeToolStripMenuItem.Text = "Görüntü Netleştirme";
            // 
            // konToolStripMenuItem
            // 
            this.konToolStripMenuItem.Name = "konToolStripMenuItem";
            this.konToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.konToolStripMenuItem.Text = "Konvolüsyon (Çekidek matris)";
            this.konToolStripMenuItem.Click += new System.EventHandler(this.konToolStripMenuItem_Click);
            // 
            // perspektifDüzeltmeToolStripMenuItem
            // 
            this.perspektifDüzeltmeToolStripMenuItem.Name = "perspektifDüzeltmeToolStripMenuItem";
            this.perspektifDüzeltmeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.perspektifDüzeltmeToolStripMenuItem.Text = "Perspektif Düzeltme";
            this.perspektifDüzeltmeToolStripMenuItem.Click += new System.EventHandler(this.perspektifDüzeltmeToolStripMenuItem_Click);
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.BackColor = System.Drawing.Color.Transparent;
            this.btnDosyaAc.Image = global::GoruntuIsleme.Properties.Resources._3643772_folder_archive_open_archives_document_icon;
            this.btnDosyaAc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaAc.Location = new System.Drawing.Point(58, 392);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(134, 67);
            this.btnDosyaAc.TabIndex = 3;
            this.btnDosyaAc.Text = "Dosya Aç";
            this.btnDosyaAc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaAc.UseVisualStyleBackColor = false;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(406, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 427);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(576, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(576, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "X1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "X2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "X3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "X4:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(760, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 420);
            this.listBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "siyah-beyaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDosyaAc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griTonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifAlmaToolStripMenuItem;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.ToolStripMenuItem eşiklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem kontrastGermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEşitlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alçakGeçirgenFiltrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussAlçakGeçirgenFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFiltreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medyanFiltreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüksekGeçirgenFiltrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometrikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açılıDöndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntününTersÇevrilmesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem küçültmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradyentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüÖtelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfolojikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaymaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşındırmaErosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüNetleştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perspektifDüzeltmeToolStripMenuItem;
    }
}

