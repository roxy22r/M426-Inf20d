using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
      private  Player player1 = new Player();
      private Player player2 = new Player();  
      private string Five_teen = "Fifteen";


        public TennisGameManager(string player1Name, 
            string player2Name)
            
        {
            this.player1.Name = player1Name;
            player1.Point = 0;
            this.player2.Name = player2Name;
        }

        public string Score_Getter()
        {
            var score = "";
            if (doBothHaveSamePointsAndGameIsSamllerThanThree())
            {
                if (player1.Point == 0)
                    score = "Love";
                if (player1.Point == 1)
                {
                    score = "Fifteen";
                }
                if (player1.Point == 2)
                    score = "Thirty";
          
                score += "-All";
            }
            if (player1.Point == player2.Point && player1.Point> 2)
                score = "Deuce";

            if (player1.Point > 0 && player2.Point== 0)
            {
                if (player1.Point == 1)
                    player1.ResultText = Five_teen;
                if (player1.Point == 2)
                    player1.ResultText = "Thirty";
                if (player1.Point == 3)
                    player1.ResultText = "Forty";

                player2.ResultText = "Love";
                score = player1.ResultText + "-" + player2.ResultText;
            }
            if (player2.Point > 0 && player1.Point== 0)
            {
                var temp = player2.Point;
                if (temp == 1)
                    player2.ResultText = "Fifteen";
                else
                {
                    // todo: 
                }
                if (temp == 2)
                    player2.ResultText = "Thirty";
                if (temp == 3)
                    player2.ResultText = "Forty";

                player1.ResultText = "Love";
                score = player1.ResultText + "-" + player2.ResultText;
            }
            if (player1.Point > player2.Point&& player1.Point < 4)
            {
                if (player1.Point == 2)
                    player1.ResultText = "Thirty";
                if (player1.Point == 3)
                    player1.ResultText = "Forty";
                if (player2.Point == 1)
                    player2.ResultText = "Fifteen";
                if (player2.Point == 2)
                    player2.ResultText = "Thirty";
                score = player1.ResultText + "-" + player2.ResultText;
            }



            if (player2.Point > player1.Point && player2.Point < 4)
            {
                if (player2.Point == 2)
                    player2.ResultText = "Thirty";
                if (player2.Point == 3)
                    player2.ResultText = "Forty";
                if (player1.Point == 1)
                    player1.ResultText = "Fifteen";
                if (player1.Point == 2)
                    player1.ResultText = "Thirty";
                score = player1.ResultText + "-" + player2.ResultText;
            }

            if (player1.Point > player2.Point && player2.Point >= 3)
            {
                score = "Advantage player1";
            }

            if (player2.Point > player1.Point && player1.Point >= 3)
            {
                score = generate_Player_2_Name();
            }

            if (player1.Point >= 4 && player2.Point >= 0 && (player1.Point - player2.Point) >= 2)
            {
                score = "Win for player1";
            }
            score = returnWinForPlayerOneIfWon(score, player1.Point, player2.Point);
            return score;
        }

        private bool doBothHaveSamePointsAndGameIsSamllerThanThree()
        {
            return player1.Point == player2.Point && player1.Point < 3;
        }
        private static string generate_Player_2_Name()
        {
            return "Advantage player2";
        }

        public string returnWinForPlayerOneIfWon(string s, int q, int y)
        {
            if (y >= 4 && q >= 0 && (y - q) >= 2)
            {
                return "Win for player2";
            }
            return s; 
        }

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                SecondPlayerScore();
            }
        }

        private void P1Score() => player1.Point++;
        private void SecondPlayerScore()
        {
            player2.Point++;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1"){
                P1Score();}
            else
                SecondPlayerScore();
        }

    }
}

