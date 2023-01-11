using Battle.Properties;

namespace Battle
{
    public partial class Maps : Form
    {
        public static int map = 0;
        public static int character = 0;
        public Maps()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);


            InitializeComponent();

                button1.MouseEnter += new EventHandler(button1_MouseEnter);
                button1.MouseLeave += new EventHandler(button1_MouseLeave);

                button2.MouseEnter += new EventHandler(button2_MouseEnter);
                button2.MouseLeave += new EventHandler(button2_MouseLeave);

                button3.MouseEnter += new EventHandler(button3_MouseEnter);
                button3.MouseLeave += new EventHandler(button3_MouseLeave);

                button4.MouseEnter += new EventHandler(button4_MouseEnter);
                button4.MouseLeave += new EventHandler(button4_MouseLeave);

            button5.MouseEnter += new EventHandler(button5_MouseEnter);
            button5.MouseLeave += new EventHandler(button5_MouseLeave);
            button6.MouseEnter += new EventHandler(button6_MouseEnter);
            button6.MouseLeave += new EventHandler(button6_MouseLeave);

            button7.MouseEnter += new EventHandler(button7_MouseEnter);
            button7.MouseLeave += new EventHandler(button7_MouseLeave);
            button8.MouseEnter += new EventHandler(button8_MouseEnter);
            button8.MouseLeave += new EventHandler(button8_MouseLeave);
            button9.MouseEnter += new EventHandler(button9_MouseEnter);
            button9.MouseLeave += new EventHandler(button9_MouseLeave);
            button10.MouseEnter += new EventHandler(button10_MouseEnter);
            button10.MouseLeave += new EventHandler(button10_MouseLeave);
        }

        void button1_MouseLeave(object sender, EventArgs e)
        {
            if (map!=1)
                this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            if (map != 1)
                this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2));
        }

        void button2_MouseLeave(object sender, EventArgs e)
        {
            if (map != 2)
                this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            if (map != 2)
                this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2));
        }

        void button3_MouseLeave(object sender, EventArgs e)
        {
            if (map != 3)
                this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            if (map != 3)
                this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4));
        }

        void button4_MouseLeave(object sender, EventArgs e)
        {
            if (map != 4)
                this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
        }

        void button4_MouseEnter(object sender, EventArgs e)
        {
            if (map != 4)
                this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4));
        }

        void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button));
        }


        void button5_MouseEnter(object sender, EventArgs e)
        {
            this.button5.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button_hover));
        }

        void button6_MouseLeave(object sender, EventArgs e)
        {
            this.button6.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button));
        }


        void button6_MouseEnter(object sender, EventArgs e)
        {
            this.button6.Image = ((System.Drawing.Image)(Properties.Resources.start_menu_button_hover));
        }

        void button7_MouseLeave(object sender, EventArgs e)
        {
            if (character!=1)
                this.button7.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }


        void button7_MouseEnter(object sender, EventArgs e)
        {
            if (character != 1)
                this.button7.Image = ((System.Drawing.Image)(Properties.Resources.character_button));
        }
        void button8_MouseLeave(object sender, EventArgs e)
        {
            if (character != 2)
                this.button8.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }


        void button8_MouseEnter(object sender, EventArgs e)
        {
            if (character != 2)
                this.button8.Image = ((System.Drawing.Image)(Properties.Resources.character_button));
        }
        void button9_MouseLeave(object sender, EventArgs e)
        {
            if (character != 3)
                this.button9.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }


        void button9_MouseEnter(object sender, EventArgs e)
        {
            if (character != 3)
                this.button9.Image = ((System.Drawing.Image)(Properties.Resources.character_button));
        }
        void button10_MouseLeave(object sender, EventArgs e)
        {
            if (character != 4)
                this.button10.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }


        void button10_MouseEnter(object sender, EventArgs e)
        {
            if (character != 4)
                this.button10.Image = ((System.Drawing.Image)(Properties.Resources.character_button));
        }

        private void Maps_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (map != 0 && character != 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sword);
                player.Play();
                Game game = new();
                this.Hide();
                game.StartPosition = FormStartPosition.Manual;
                game.Location = this.Location;
                game.Size = this.Size;
                game.ShowDialog();
                this.StartPosition = FormStartPosition.Manual;
                this.Location = game.Location;
                this.Size = game.Size;
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map = 1;
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            map = 2;
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            map = 3;
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            map = 4;
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_1_2_basic));
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.button_maps_3_4_basic));
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            character = 1;
            this.button7.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button8.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button9.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button10.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            character = 2;
            this.button7.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button8.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button9.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button10.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }
        private void button9_Click(object sender, EventArgs e)
        {
            character = 3;
            this.button7.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button8.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button9.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
            this.button10.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            character = 4;
            this.button7.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button8.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button9.Image = ((System.Drawing.Image)(Properties.Resources.character_button_hover));
            this.button10.Image = ((System.Drawing.Image)(Properties.Resources.button_maps));
        }
    }
}