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
      private  Player playerOne = new Player();
      private Player playerTwo = new Player();  


        public TennisGameManager(string player1Name, string player2Name)
            
        {
            this.playerOne .Name = player1Name;
            this.playerTwo.Name = player2Name;
        }

        public string Score_Getter()
        {
            setRegularScoreText(playerOne);
            setRegularScoreText(playerTwo);
            setTextToAllOFirstfPointsAreValid(playerOne,playerTwo);
            setLoveToPlayerOne(playerTwo, playerOne);
            setLoveToPlayerOne(playerOne, playerTwo);

            Player player= returnWinner(playerOne, playerTwo);
            if (player != null) {
                return player.ResultText;
            }
            player = returnAdvenced(playerOne, playerTwo);
            if (player != null)
            {
                return player.ResultText;
            }



            if (isPlayerSocreEqual(playerOne,playerTwo) && playerOne.Point > 2)
                return "Deuce";

            return playerOne.ResultText + "-" + playerTwo.ResultText;
        }

        private Player returnAdvenced(Player player1, Player player2) {
            for (int i = 0; i < 3; i++)
            {
                if (secondPlayerLessThanFirstAndBiggerOrEqualThree(player2, player1))
            {
                setResultTextToAdvantage(player2);
                return player2;
            }
            Player player = player1;
            player1 = player2;
            player2 = player;
        }
            return null;
          
        }
        private Player returnWinner(Player player1,Player player2) {

            for (int i = 0; i < 3; i++)
            {
                if (IsFristPlayerWinner(player1, player2))
                {
                    createWinnerText(player1);
                    return player1;
                }
                Player player = player1;
                player1 = player2;
                player2 = player;
            }
            return null;
        }
        private void setTextToAllOFirstfPointsAreValid(Player player1,Player player2)
        {
            if (doBothHaveSamePointsAndGameIsSamllerThanThree(player1, player2))
            {
                player2.ResultText = "All";
            }
        }

        private static void setRegularScoreText(Player player1)
        {
            int scoreTextValues = System.Enum.GetNames(typeof(ScoreText)).Length;

            for (int i = 0; i <= scoreTextValues; i++)
            {
                if (player1.Point == i)
                {
                    ScoreText text = (ScoreText)i;
                    player1.ResultText = text.ToString();
                }
            }
        }

        private bool secondPlayerLessThanFirstAndBiggerOrEqualThree(Player player1,Player player2)
        {
            return (isFirstPlayerScoreHigherThanOther(player1, player2) && isScoreHigherOrEqualThreee(player2));   
        }
        private void setResultTextToAdvantage(Player player) {
            player.ResultText = "Advantage " + player.Name;
        }

        private static bool isScoreHigherOrEqualThreee(Player player)
        {
            return player.Point >= 3;
        }

        private static bool isFirstPlayerScoreHigherThanOther(Player player1, Player player2)
        {
            return player1.Point > player2.Point;
        }


        private void setLoveToPlayerOne(Player player1, Player player2)
        {
            if (isSocreMoreThanZero(player2) && isSocreEqualToZero(player1))
            {
                player1.ResultText = "Love";
            }
        }

        private static bool isSocreEqualToZero(Player player)
        {
            return player.Point == 0;
        }

        private bool isSocreMoreThanZero(Player player) {
            return player.Point > 0;
        }

        private bool doBothHaveSamePointsAndGameIsSamllerThanThree(Player player1, Player player2)
        {
            return isPlayerSocreEqual(player1,player2) && player1.Point < 3;
        }

        private bool isPlayerSocreEqual(Player player1, Player player2)
        {
            return player1.Point == player2.Point;
        }

        
        private  bool  IsFristPlayerWinner( Player player2, Player player1)
        {
            return (player2.Point >= 4 && player1.Point >= 0 && (player2.Point - player1.Point) >= 2);
            
                  
        }
         
        private void createWinnerText(Player player) {

            player.ResultText = "Win for " + player.Name;
        }

        private void FirstPlayerScore() => playerOne.Point++;
        private void SecondPlayerScore()=>playerTwo.Point++;
        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1"){
                FirstPlayerScore();}
            else
                SecondPlayerScore();
        }

    }
}

