namespace Amparix
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainWindow_Load;
            this.Resize += MainWindow_Resize;
        }

        private void MainWindow_Load(object? sender, EventArgs e)
        {
            CenterLabels();
        }

        private void MainWindow_Resize(object? sender, EventArgs e)
        {
            CenterLabels();
        }

        private void CenterLabels()
        {
            // Calcular el área disponible (excluyendo el panel lateral)
            int availableWidth = this.ClientSize.Width - panelMenu.Width;
            int startX = panelMenu.Width;

            // Centrar label1 (AMPARIX)
            label1.Left = startX + (availableWidth - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - 55) / 2 - 50; // 55 es la altura del menú y toolbar

            // Centrar label2 (subtítulo)
            label2.Left = startX + (availableWidth - label2.Width) / 2;
            label2.Top = label1.Bottom + 10;

            // Centrar label3 (teléfono)
            label3.Left = startX + (availableWidth - label3.Width) / 2;
            label3.Top = label2.Bottom + 10;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

    }
}
