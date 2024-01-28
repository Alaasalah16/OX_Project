using Microsoft.Data.SqlClient;

namespace OXproject
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = x turn; false = y turn
        int turnCount = 0;
        static String player1, player2;
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            // con = new SqlConnection("Server=.;Database=oxgame;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }



        //about
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by alaa  \n jan 21, 2023", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            turnCount++;
            b.Enabled = false;

            checkForWinner();
        }
        private void checkForWinner()
        {
            bool thereIsAWinner = false;

            //HORIZONTAL CHECK  
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            //VERTICAL CHECK  
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            //DIAGONAL CHECK
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    X_win_Count.Text = (Int32.Parse(X_win_Count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " wins!", "Yay!");
            }//if
            else
            {
                if (turnCount == 9)
                {
                    drawcount.Text = (Int32.Parse(drawcount.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }
        }//checkforwinner

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            } // foreach
        } //disableButtons

        //newgame
        private void button10_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//try
                catch { }

            }//foreach
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//try
                catch { }

            }//foreach
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            o_win_count.Text = "0";
            X_win_Count.Text = "0";
            drawcount.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            X_win_Count.Text = "0";
            drawcount.Text = "0";
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//if
        }

        private void buttonLeave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void saveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into oxgame values (@PlayerOneName ,@PlayerTwoName,@Xwin,@OWin)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@PlayerOneName", label1.Text);
            cmd.Parameters.AddWithValue("@PlayerTwoName", label3.Text);
            cmd.Parameters.AddWithValue("@XWin", int.Parse(o_win_count.Text));
            cmd.Parameters.AddWithValue("@OWin", int.Parse(X_win_Count.Text));
            con.Close();
            MessageBox.Show("Data was added");
        }





        //private void saveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        // private string connectionString = "YourConnectionStringHere";

        //    private void SaveScore(string playerOneName, string playerTwoName, int XWin, int OWin)
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = "INSERT INTO GameScores (Player1Name, Player2Name, Winner, DatePlayed) " +
        //                           "VALUES (@Player1Name, @Player2Name, @Winner, GETDATE())";

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@Player1Name", playerOneName);
        //                command.Parameters.AddWithValue("@Player2Name", playerTwoName);
        //                command.Parameters.AddWithValue("@Winner", XWin);
        //                command.Parameters.AddWithValue("@Winner", OWin);
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
    }
}

