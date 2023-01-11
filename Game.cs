using Battle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Battle
{
    public partial class Game : Form
    {

        int userhp = 100;
        int enemyhp = 100;
        int userdefense = 0;
        int enemydefense = 0;
        int run = 1;
        public Game()
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

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            if (Maps.map == 1) this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.map1));
            else if (Maps.map == 2) this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.map2));
            else if (Maps.map == 3) this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.map3));
            else if (Maps.map == 4) this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.map4));

            if (Maps.character == 1) pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.Aiden___Ethan));
            else if (Maps.character == 2) pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.Anwir));
            else if (Maps.character == 3) pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.Peteplank));
            else if (Maps.character == 4) pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.Yamato));

            Random rnd = new();
            int boss = rnd.Next(1, 5);
            if (boss==1) pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.Adbaldar));
            else if (boss==2) pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.Atlantes));
            else if (boss==3) pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.Elminster));
            else if (boss==4) pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.Radagast));
            
            

        }

        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.gamebuttonhover));
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Image = ((System.Drawing.Image)(Properties.Resources.gamebutton));
        }

        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.gamebuttonhover));
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.gamebutton));
        }

        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.gamebuttonhover));
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.Image = ((System.Drawing.Image)(Properties.Resources.gamebutton));
        }

        void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.gamebuttonhover));
        }

        void button4_MouseEnter(object sender, EventArgs e)
        {
            this.button4.Image = ((System.Drawing.Image)(Properties.Resources.gamebutton));
        }
        private int checkDeath(int hp)
        {
            if (hp <= 0)
            {
                hp = 0;
            }

            if (hp == 0) return 0;
            else return 1;
        }
        void enemyAction()
        {
            Random rnd = new();
            int action = rnd.Next(1, 3);
            if (enemydefense == 1) action = 1;
            if (action == 1) //attack
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sword);
                int damage = rnd.Next(5, 10);
                if (userdefense == 0)
                {
                    userhp -= damage;
                    textBox4.Text = "Attacked for " + damage.ToString() + " hp";
                }
                else
                {
                    userhp -= damage / 2;
                    textBox4.Text = "Attacked for only " + (damage / 2).ToString() + " hp because their shield was on";
                    userdefense = 0;
                }
                player.Play();

                textBox1.Text = "HP: " + userhp.ToString();

                pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.attack_enemy));
            }
            else if (action == 2) //defense
            {
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Resources.shield);
                enemydefense = 1;
                pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.defend_enemy));
                textBox4.Text = "SHIELD ON";
                player2.Play();
            }

            run = 1;
            if (checkDeath(userhp)==0)
            {
                textBox3.Text = "Lose";
                textBox4.Text = "Win";
                userhp = 0;
                textBox1.Text = "HP: " + userhp.ToString();
                run = 0;
            }
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e) //attack button
        {
            if (run == 1)
            {
                run = 0;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sword);
                Random rnd = new();
                int damage = rnd.Next(5, 10);
                if (enemydefense == 0)
                {
                    enemyhp -= damage;
                    textBox3.Text = "Attacked for " + damage.ToString() + " hp";
                }
                else
                {
                    enemyhp -= damage / 2;
                    textBox3.Text = "Attacked for only " + (damage / 2).ToString() + " hp because their shield was on";
                    enemydefense = 0;
                }
                player.Play();

                textBox2.Text = "HP: " + enemyhp.ToString();

                pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.attack));

                wait(1000);
                if (checkDeath(enemyhp) == 0)
                {
                    textBox3.Text = "Win";
                    textBox4.Text = "Lose";
                    enemyhp = 0;
                    textBox2.Text = "HP: " + enemyhp.ToString();
                    run = 0;
                }
                else enemyAction();
            }
        }

        private void button2_Click(object sender, EventArgs e) //defense button
        {
            if (run == 1)
            {
                run = 0;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.shield);
                player.Play();
                userdefense = 1;
                textBox3.Text = "SHIELD ON";
                pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.defend));

                wait(1000);
                if (checkDeath(enemyhp) == 0)
                {
                    textBox3.Text = "Win";
                    textBox4.Text = "Lose";
                    enemyhp = 0;
                    textBox2.Text = "HP: " + enemyhp.ToString();
                    run = 0;
                }
                else enemyAction();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.ability);
                player.Play();
                run = 0;
                Random rnd = new();
                int damage = rnd.Next(5, 10);
                //1 - Aiden Ethan
                //2 - Anwir
                //3 - Peteplank
                //4 - Yamato
                textBox3.Text = "Ability used";
                if (Maps.character == 1) //removes enemy defense and deals double damage but takes half the normal damage
                {
                    pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.aidenethan_ability));
                    enemydefense = 0;
                    userhp -= damage / 2;
                    enemyhp -= damage * 2;
                }
                else if (Maps.character == 2) //heals 10 hp, can overheal
                {
                    userhp += 10;
                    pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.anwir_ability));
                }
                else if (Maps.character == 3) //puts on defense and attacks but takes 5 hp
                {
                    pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.peteplank_ability));
                    userdefense = 1;
                    if (enemydefense == 0)
                    {
                        enemyhp -= damage;
                    }
                    else
                    {
                        enemyhp -= damage / 2;
                        enemydefense = 0;
                    }
                    userhp -= 5;
                }
                else if (Maps.character == 4) // 3 attacks but you get half the damage
                {
                    pictureBox3.Image = ((System.Drawing.Image)(Properties.Resources.yamato_ability));
                    for (int i = 0; i < 3; i++)
                    {
                        if (enemydefense == 0)
                        {
                            enemyhp -= damage;
                            userhp -= damage / 2;
                        }
                        else
                        {
                            enemyhp -= damage / 2;
                            userhp -= (damage / 2) / 2;
                            enemydefense = 0;
                        }
                        textBox2.Text = "HP: " + enemyhp.ToString();
                        wait(1000);
                    }
                }

                textBox1.Text = "HP: " + userhp.ToString();
                textBox2.Text = "HP: " + enemyhp.ToString();
                wait(1000);
                if (checkDeath(enemyhp) == 0)
                {
                    textBox3.Text = "Win";
                    textBox4.Text = "Lose";
                    enemyhp = 0;
                    textBox2.Text = "HP: " + enemyhp.ToString();
                    run = 0;
                }
                else enemyAction();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu.player.PlayLooping();
            this.Close();
        }
    }
}
