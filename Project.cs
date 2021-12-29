using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project
{
    public partial class Project : Form
    {

        Player player;
        bool firstTime = true;

        Bullet bullet;

        Rabbit rabbit1;
        Rabbit rabbit2;
        Rabbit rabbit3;
        Rabbit rabbit4;

        Wolf wolf1;
        Wolf wolf2;
        Wolf wolf3;
        Wolf wolf4;


        PlayerController playerController;
        Rabbit[] rabbit_array = new Rabbit[4];
        Wolf[] wolf_array = new Wolf[4];
        bool shoot = false;

        public Project()
        {
            InitializeComponent();
            initTimer();
            initResources();
            if (firstTime)
            {
                btnContinue.Enabled = false; btnContinue.Visible = false;
                btnReset.Enabled = false; btnReset.Visible = false;
                labelMod.Visible = false;
                labelWolf.Visible = false;
                labelWolfCounter.Visible = false;
                labelRabbit.Visible = false;
                labelRabbitCounter.Visible = false;
            }
        }

        private void initTimer()
        {
            timerMove.Enabled = true;
            timerMove.Tick += new System.EventHandler(timerMove_Tick);
            timerMove.Interval = 24;

        }

        private void initResources()
        {


            timerMove.Stop();
            player = new Player();
            rabbit1 = new Rabbit(0, 50, 1);
            rabbit2 = new Rabbit(87, 100, 2);
            rabbit3 = new Rabbit(45, 150, 2);
            rabbit4 = new Rabbit(20, 200, 1);

            wolf1 = new Wolf(ClientSize.Width / 2, 20, 2, true);
            wolf2 = new Wolf(200, 50, 1, false);
            wolf3 = new Wolf(250, 10, 1, true);
            wolf4 = new Wolf(340, 100, 1, false);

            wolf_array[0] = wolf1;
            wolf_array[1] = wolf2;
            wolf_array[2] = wolf3;
            wolf_array[3] = wolf4;

            rabbit_array[0] = rabbit1;
            rabbit_array[1] = rabbit2;
            rabbit_array[2] = rabbit3;
            rabbit_array[3] = rabbit4;

            bullet1 = new Bullet(40, 50, ClientSize.Width, ClientSize.Height);

            playerController = new PlayerController(ClientSize.Width, ClientSize.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            drawPlayer(e.Graphics);
            drawAnimals(e.Graphics);
            //if (panelMenu.Visible) { panelMenu.BackgroundImage = Lab8.Properties.Resources.fon2; }
        }

        private void drawPlayer(Graphics graphics)
        {
            player.render(graphics, playerController.getPlayerPosition());
            bullet1.changePosition(graphics, playerController.getPosition(), shoot);
            //player.render(graphics, playerController.getPlayerPosition(), playerController.testCollision(mushroom1.getMushroomPosition(ClientSize.Height), 40, 60);
        }
        private void drawAnimals(Graphics graphics)
        {
            //if (checkBoxShooter.Checked)
            if (shoot)
            {
                foreach (Rabbit rabbit in rabbit_array)
                {
                    if ((!rabbit.testCollision(bullet1.getPosition(), 10, 10, rabbit.getPosition(), 20, 20)) && (bullet1.getPosition() != new Point(playerController.getPosition().X + 40 / 2, playerController.getPosition().Y + 50 / 2)))
                    {

                        labelRabbitsCounter.Text = Int32.Parse(labelRabbitsCounter.Text) + 1 + "";
                    }
                    rabbit.render(graphics, ClientSize.Width, playerController.getPosition(), 40, 50, bullet1.getPosition(), 10, 10, shoot);
                }
                foreach (Wolf wolf in wolf_array)
                {
                    if ((!wolf.testCollision(bullet1.getPosition(), 10, 10, wolf.getPosition(), 20, 20)) && (bullet1.getPosition() != new Point(playerController.getPosition().X + 40 / 2, playerController.getPosition().Y + 50 / 2)))
                    {

                        labelWolfsCounter.Text = Int32.Parse(labelWolfsCounter.Text) + 1 + "";
                    };
                   wolf.render(graphics, ClientSize.Height, playerController.getPosition(), 40, 50, bullet1.getPosition(), 10, 10, shoot);
                }
            }
            else
            {
                foreach (Rabbit rabbit in rabbit_array)
                {
                    if (!rabbit.testCollision(playerController.getPosition(), 40, 50, rabbit.getPosition(), 20, 20))
                    {
                        labelRabbitsCounter.Text = Int32.Parse(labelRabbitsCounter.Text) + 1 + "";
                    }
                    rabbit.render(graphics, ClientSize.Width, playerController.getPosition(), 40, 50, bullet1.getPosition(), 10, 10, shoot);
                }
                foreach (Wolf wolf in wolf_array)
                {
                    if (!wolf.testCollision(playerController.getPosition(), 40, 50, wolf.getPosition(), 20, 20))
                    {
                        labelWolfsCounter.Text = Int32.Parse(labelWolfsCounter.Text) + 1 + "";
                    };
                    wolf.render(graphics, ClientSize.Height, playerController.getPosition(), 40, 60, bullet1.getPosition(), 10, 10, shoot);
                }
            }

        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }



        private void Project_KeyDown(object sender, KeyEventArgs e)
        {

            playerController.updatePlayerPosition(e.KeyCode);
            bullet1.updatePosition(e.KeyCode);


            if (e.KeyCode == Keys.E)
            {

                panelMenu.Visible = true;
                panelMenu.Enabled = true;

                timerMove.Stop();
                btnContinue.Enabled = true;
                btnContinue.Visible = true;
                btnReset.Enabled = true; btnReset.Visible = true;

            }

        }

        private void Project_KeyUp(object sender, KeyEventArgs e)
        {
            // isKeyDown = false;
            bullet1.reset();
            playerController.reset();
        }

        private void btnShooterMod_Click(object sender, EventArgs e)
        {
            if (firstTime) { labelMod.Visible = true;
                labelWolfs.Visible = true;
                labelWolfsCounter.Visible = true;
                labelRabbits.Visible = true;
                labelRabbitsCounter.Visible = true;
            }
            if ((!shoot) || firstTime)
            {
                shoot = true;
                labelWolfsCounter.Text = "0";
                labelRabbitsCounter.Text = "0";

                BackgroundImage = Lab8.Properties.Resources.fon_shoot;
                panelMenu.BackgroundImage = Lab8.Properties.Resources.panel_shoot;
                btnSimpleMod.ForeColor = Color.Olive;
                btnShooterMod.ForeColor = Color.Olive;
                btnReset.ForeColor = Color.Olive;
                btnContinue.ForeColor = Color.Olive;
                btnExit.ForeColor = Color.Olive;
                labelWolfs.ForeColor = Color.MediumSeaGreen;
                labelWolfsCounter.ForeColor = Color.MediumSeaGreen;
                labelRabbits.ForeColor = Color.MediumSeaGreen;
                labelRabbitsCounter.ForeColor = Color.MediumSeaGreen;
                labelHunter.BackColor = Color.DarkOliveGreen;
                labelMod.Text = "Shooter Mod";
                labelMod.ForeColor = Color.YellowGreen;
            }
            panelMenu.Visible = false;
            panelMenu.Enabled = false;
            firstTime = false;
            timerMove.Start();

        }

        private void btnSimpleMod_Click(object sender, EventArgs e)
        {
            if (firstTime) { labelMod.Visible = true;
                labelWolfs.Visible = true;
                labelWolfsCounter.Visible = true;
                labelRabbits.Visible = true;
                labelRabbitsCounter.Visible = true;
            }
            if ((shoot) || firstTime)
            {
                shoot = false;
                labelWolfsCounter.Text = "0";
                labelRabbitsCounter.Text = "0";

                BackgroundImage = Lab8.Properties.Resources.forrest;
                panelMenu.BackgroundImage = Lab8.Properties.Resources.forrest;
                btnSimpleMod.ForeColor = Color.BlueViolet;
                btnShooterMod.ForeColor = Color.BlueViolet;
                btnReset.ForeColor = Color.BlueViolet;
                btnContinue.ForeColor = Color.BlueViolet;
                btnExit.ForeColor = Color.BlueViolet;
                labelWolfs.ForeColor = Color.BlueViolet;
                labelWolfsCounter.ForeColor = Color.BlueViolet;
                labelRabbits.ForeColor = Color.BlueViolet;
                labelRabbitsCounter.ForeColor = Color.BlueViolet;
                labelHunter.BackColor = Color.DeepPink;
                labelMod.Text = "Simple Mod";
                labelMod.ForeColor = Color.MediumPurple;

            }

            panelMenu.Visible = false;
            panelMenu.Enabled = false;
            timerMove.Start();
            firstTime = false;


             private void btnReset_Click(object sender, EventArgs e)
        {
            labelWolfsCounter.Text = "0";
            labelRabbitsCounter.Text = "0";
            /*panelMenu.Visible = false;
            panelMenu.Enabled = false;
            timerMove.Start();
            firstTime = false;*/
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu.Enabled = false;
            timerMove.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

