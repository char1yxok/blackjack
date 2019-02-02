using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            //First Distribution
            var random = new Random();
            Boardnum.C1.Add(random.Next(1, 14));
            Boardnum.C1.Add(random.Next(1, 14));
            Boardnum.P1.Add(random.Next(1, 14));
            Boardnum.P1.Add(random.Next(1, 14));

            CroupierCard1.Text = Boardnum.C1[0].ToString();
            PlayerCard1.Text = Boardnum.P1[0].ToString();
            PlayerCard2.Text = Boardnum.P1[1].ToString();

            ResultReload rr = new ResultReload();
            rr.Reload();
            PlayerResult.Text = Boardnum.playersum.ToString();

            if (Boardnum.playersum > 21)
            {
                MessageBox.Show("You Lose. Already Bust.");
                HitButton.Enabled = false;
                StandButton.Enabled = false;
            }

        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            Boardnum.P1.Add(random.Next(1, 14));

            //Add new card
            TextBox PlayerCard = new TextBox();
            PlayerCard.Location = new Point(214 + (Boardnum.count * 64), 119);
            PlayerCard.BackColor = System.Drawing.Color.LightBlue;
            PlayerCard.Enabled = false;
            PlayerCard.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            PlayerCard.ReadOnly = true;
            PlayerCard.Size = new System.Drawing.Size(60, 47);
            PlayerCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            PlayerCard.Text = Boardnum.P1.Last().ToString();

            Boardnum.count += 1;
            this.Controls.Add(PlayerCard);

            ResultReload rr = new ResultReload();
            rr.Reload();
            PlayerResult.Text = Boardnum.playersum.ToString();

            //Bust Judge
            if (Boardnum.playersum > 21)
            {
                MessageBox.Show("Bust. You Lose.");
                HitButton.Enabled = false;
                StandButton.Enabled = false;

                PlayerLabel.ForeColor = Color.DeepSkyBlue;
                PlayerLabel.Text = ("Lose");
                CroupierLabel.ForeColor = Color.LightCoral;
                CroupierLabel.Text = ("Win");
            }
        }



        private void StandButton_Click(object sender, EventArgs e)
        {
            //Croupier's turn Start
            CroupierCard2.Text = Boardnum.C1[1].ToString(); //Second card is opened.

            CroupierThink croupierThink = new CroupierThink();
            croupierThink.Think();

            int i = Boardnum.C1.Count();
            Boardnum.croupiersum = Boardnum.C1[0] + Boardnum.C1[1];

            if (i != 2)
            {
                Boardnum.count = 0;

                while (i > 2)
                {
                    TextBox CroupierCard = new TextBox();
                    CroupierCard.Location = new Point(214 + (Boardnum.count * 64), 30);
                    CroupierCard.BackColor = System.Drawing.Color.LightBlue;
                    CroupierCard.Enabled = false;
                    CroupierCard.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                    CroupierCard.ReadOnly = true;
                    CroupierCard.Size = new System.Drawing.Size(60, 47);
                    CroupierCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    
                    int s = 2;
                    CroupierCard.Text = Boardnum.C1[s].ToString();
                    this.Controls.Add(CroupierCard);
                    Boardnum.croupiersum = Boardnum.croupiersum + Boardnum.C1[s];
                    Boardnum.count += 1;
                    s += 1;
                    i -= 1;
                }
            }

            CroupierResult.Text = Boardnum.croupiersum.ToString();

            HitButton.Enabled = false;
            StandButton.Enabled = false;

            //Result Judge

            //Player's sum is not bust.
            if (0 <= Boardnum.playersum && Boardnum.playersum <= 21 )
            {
                //Croupier's sum is bust.
                if(Boardnum.croupiersum > 21)
                {
                    MessageBox.Show("You Win. (Croupier Bust)");

                    CroupierLabel.ForeColor = Color.DeepSkyBlue;
                    CroupierLabel.Text = ("Lose");
                    PlayerLabel.ForeColor = Color.LightCoral;
                    PlayerLabel.Text = ("Win");

                }
                //Player > Croupier
                else if (21 - Boardnum.playersum < 21 - Boardnum.croupiersum)
                {
                    MessageBox.Show("You Win.");

                    CroupierLabel.ForeColor = Color.DeepSkyBlue;
                    CroupierLabel.Text = ("Lose");
                    PlayerLabel.ForeColor = Color.LightCoral;
                    PlayerLabel.Text = ("Win");
                }
                //Player < Croupier
                else if (21 - Boardnum.playersum > 21 - Boardnum.croupiersum)
                {
                    MessageBox.Show("You Lose.");


                    PlayerLabel.ForeColor = Color.DeepSkyBlue;
                    PlayerLabel.Text = ("Lose");
                    CroupierLabel.ForeColor = Color.LightCoral;
                    CroupierLabel.Text = ("Win");
                }
                //Player = Croupier
                else if (Boardnum.playersum == Boardnum.croupiersum)
                {
                    MessageBox.Show("Draw");

                    PlayerLabel.ForeColor = Color.MediumSeaGreen;
                    PlayerLabel.Text = ("Draw");
                    CroupierLabel.ForeColor = Color.MediumSeaGreen;
                    CroupierLabel.Text = ("Draw");
                }
            }
            //Player's sum is bust.
            else if(Boardnum.croupiersum > 21)
            {
                MessageBox.Show("You Lose. (Each Bust)");

                PlayerLabel.ForeColor = Color.DeepSkyBlue;
                PlayerLabel.Text = ("Lose");
                CroupierLabel.ForeColor = Color.LightCoral;
                CroupierLabel.Text = ("Win");
            }
            else
            {
                MessageBox.Show("You Lose.");

                PlayerLabel.ForeColor = Color.DeepSkyBlue;
                PlayerLabel.Text = ("Lose");
                CroupierLabel.ForeColor = Color.LightCoral;
                CroupierLabel.Text = ("Win");
            }

        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Boardnum.C1.Clear();
            Boardnum.P1.Clear();
            Boardnum.count = 0;
            Boardnum.playersum = 0;
            Boardnum.croupiersum = 0;
        }
    }
    public static class Boardnum
    {
        //The pair cards of Croupier & Player
        public static List<int> C1 = new List<int>();
        public static List<int> P1 = new List<int>();
        public static int count = 0;

        //for Player
        public static int playersum;

        //for Croupier
        public static int croupiersum;

    }


    //Reload sum of Player's card
    class ResultReload
    {
        public void Reload()
        {
            Boardnum.playersum = 0;

            foreach (int n in Boardnum.P1)
            {
                Boardnum.playersum = Boardnum.playersum + n;
            }
        }
    }

    //Croupier choose whether to draw next card.
    class CroupierThink
    {
        public void Think()
        {
            Random r = new Random();
            int x = r.Next(0, 4);
            int y;

            while(x > 0)
            {
                y = r.Next(0, 2);

                if (y == 0)
                {
                    Boardnum.C1.Add(r.Next(1, 14));
                }

                x -= 1;
            }
        }
    }
}
