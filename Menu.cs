using Battle.Properties;

namespace Battle
{
    public partial class Menu : Form
    {

        public static System.Media.SoundPlayer player;
        public Menu()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            button2.MouseEnter += new EventHandler(button2_MouseEnter);
            button2.MouseLeave += new EventHandler(button2_MouseLeave);
            player = new System.Media.SoundPlayer(Resources.background);
            player.PlayLooping();
        }

        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button));
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button_hover));
        }

        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button));
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button_hover));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maps maps = new();
            this.Hide();
            maps.StartPosition = FormStartPosition.Manual;
            maps.Location = this.Location;
            maps.Size = this.Size;
            maps.ShowDialog();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = maps.Location;
            this.Size = maps.Size;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}