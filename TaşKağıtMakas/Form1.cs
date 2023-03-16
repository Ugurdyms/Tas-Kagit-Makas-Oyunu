namespace TaşKağıtMakas
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;
        string[] CPUchoiceList = { "tas", "kagit", "makas", "kagit", "makas", "tas" };
        int randomNumber = 0;
        Random rnd = new Random();
        string CPUChoice;
        string PlayerChoice;
        int playerScore;
        int CPUScore;
        public Form1()
        {
            InitializeComponent();
            geriSayimTimer.Enabled = true;
            PlayerChoice = "none";
            txtGeri.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTas_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            PlayerChoice = "tas";
        }


        private void btnKagit_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            PlayerChoice = "kagit";
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            PlayerChoice = "makas";
        }

        private void btnTekrarBasla_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;
            PlayerChoice = "none";
            geriSayimTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
            gameOver = false;
        }

        private void geriSayimTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            txtGeri.Text = timerPerRound.ToString();
            txtRound.Text = "Round:" + rounds;
            if (timerPerRound < 1)
                geriSayimTimer.Enabled = false;
            timerPerRound = 6;
            randomNumber = rnd.Next(0, CPUchoiceList.Length);
            CPUChoice = CPUchoiceList[randomNumber];
            switch (CPUChoice)
            {
                case "tas":
                    picCPU.Image = Properties.Resources.rock;
                    break;
                case "kagit":
                    picCPU.Image = Properties.Resources.paper;
                    break;
                case "makas":
                    picCPU.Image = Properties.Resources.scissors;
                    break;
            }
            if (rounds > 0)
            {
                checkGame();
            }
            else
            {
                if (playerScore > CPUScore)
                {
                    MessageBox.Show("Player Oyunu Kazandı");
                }
                else
                {
                    MessageBox.Show("CPU Oyunu Kazandı");
                }
                gameOver = true;
            }

        }

        private void checkGame()
        {
            if (PlayerChoice == "tas" && CPUChoice == "kagit")
            {
                CPUChoice += 1;
                rounds -= 1;
                MessageBox.Show("CPU Kazandı.Kağıt taşı kaplar.");
            }
            else if (PlayerChoice == "makas" && CPUChoice == "tas")
            {
                CPUChoice += 1;
                rounds -= 1;
                MessageBox.Show("CPU Kazandı.Tas makası kırar.");
            }
            else if (PlayerChoice == "kagit" && CPUChoice == "makas")
            {
                CPUChoice += 1;
                rounds -= 1;
                MessageBox.Show("CPU Kazandı.Makas kağıdı keser.");
            }
            else if (PlayerChoice == "tas" && CPUChoice == "makas")
            {
                PlayerChoice += 1;
                rounds -= 1;
                MessageBox.Show("Player Kazandı.Tas makası kırar.");
            }
            else if (PlayerChoice == "kagit" && CPUChoice == "tas")
            {
                PlayerChoice += 1;
                rounds -= 1;
                MessageBox.Show("Player Kazandı.Kağıt taşı kaplar.");
            }
            else if (PlayerChoice == "makas" && CPUChoice == "kagit")
            {
                PlayerChoice += 1;
                rounds -= 1;
                MessageBox.Show("Player Kazandı.Makas kapıdı keser.");
            }
            else if (PlayerChoice == "none")
            {
                MessageBox.Show("Seçim yap");
            }
            else
            {
                MessageBox.Show("Berabere!!!");
            }
            startNextRound();
        }
        private void startNextRound()
        {
            if (gameOver == true)
            {
                return;
            }
            txtScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;
            PlayerChoice = "none";
            geriSayimTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
        }
    }
}