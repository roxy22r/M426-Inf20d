using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public enum ScoreText {
        Love = 0,
        Fifteen = 1,
        Thirty = 2,
        Forty = 3
    }
    public class TennisGameManager
    {
      private  Player player1 = new Player();
      private Player player2 = new Player();  


        public TennisGameManager(string player1Name, string player2Name)
            
        {
            this.player1.Name = player1Name;
            this.player2.Name = player2Name;
        }

        public string Score_Getter()
        {
            ScoreText score;
            if (doBothHaveSamePointsAndGameIsSamllerThanThree())
            {
               int scoreTextValues= System.Enum.GetNames(typeof(ScoreText)).Length;
                for (int score = 0; score<=scoreTextValues;score++) {
                    if (player1.Point == score)
                        score = (ScoreText)score;
                }


              
                if (player1.Point == 1)
                    score = "Fifteen";
                if (player1.Point == 2)
                    score = "Thirty";

                score += "-All";
            }
            if (player1.Point == player2.Point && player1.Point > 2)
                score = "Deuce";

            playerOneIsMoreThanZeroePlayerTwoEqualZero(player1,player2);
            secondPlayerLessThanForeButMoreThanFirstPlayer(player1,player2);
           score= secondPlayerLessThanFirstAndBiggerOrEqualThree(score,player1,player2);

          
            Player player = GetWinner(score, player1, player2);
            return score;
        }

        private string secondPlayerLessThanFirstAndBiggerOrEqualThree(string score,Player player1,Player player2)
        {

            if (isFirstPlayerScoreHigherThanOther(player1, player2) && isScoreHigherOrEqualThreee(player2))
            {
                score = "Advantage" + player1;
            }

            return score;
        }

        private static bool isScoreHigherOrEqualThreee(Player player)
        {
            return player.Point >= 3;
        }

        private static bool isFirstPlayerScoreHigherThanOther(Player player1, Player player2)
        {
            return player1.Point > player2.Point;
        }

        private void secondPlayerLessThanForeButMoreThanFirstPlayer(Player player1, Player player2)
        {

            if(isFirstPlayerScoreHigherThanOther(player1,player2) && player1.Point < 4)
            {
                if (player1.Point == 2)
                    player1.ResultText = "Thirty";
                if (player1.Point == 3)
                    player1.ResultText = "Forty";
                if (player2.Point == 1)
                    player2.ResultText = "Fifteen";
                if (player2.Point == 2)
                    player2.ResultText = "Thirty";
            }

        }

        private void playerOneIsMoreThanZeroePlayerTwoEqualZero(Player player1, Player player2)
        {
            if (isSocreMoreThanZero(player1) && isSocreEqualToZero(player2))
            {
                if (player1.Point == 1)
                    player1.ResultText = "Five_teen";
                if (player1.Point == 2)
                    player1.ResultText = "Thirty";
                if (player1.Point == 3)
                    player1.ResultText = "Forty";
                player2.ResultText = "Love";
            }

        }

        private static bool isSocreEqualToZero(Player player)
        {
            return player.Point == 0;
        }

        private bool isSocreMoreThanZero(Player player) {
            return player.Point > 0;
        }

        private bool doBothHaveSamePointsAndGameIsSamllerThanThree()
        {
            return isPlayerSocreEqual(player1,player1) && player1.Point < 3;
        }

        private bool isPlayerSocreEqual(Player player1, Player player2)
        {
            return player1.Point == player2.Point;
        }

        public static Player GetWinner(Player player1, Player player2)
        {
            if (player2.Point >= 4 && player1.Point >= 0 && (player2.Point - player1.Point) >= 2)
            {
                return player2;
            }
            else {
                return null;
            }
                  
        }

        private string createWinnerText(Player player) {
            return "Win for" +player.Name;
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

