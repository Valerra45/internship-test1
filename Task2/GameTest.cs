using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Xunit;

namespace Task2
{
    public class GameTest
    {
        [Fact]
        public void GameScore_Should_Return_Zero_Zero_On_Zero_Offset()
        {
            //Arrange
            var offset = 0;
            var score = new Score(0, 0);

            var gameStamps = new GameStamp[]
            {
                new GameStamp{offset = 0, score = new Score(0, 0) },
                new GameStamp{offset = 2, score = new Score(0, 0) },
                new GameStamp{offset = 5, score = new Score(0, 0) },
                new GameStamp{offset = 6, score = new Score(0, 0) },
                new GameStamp{offset = 9, score = new Score(0, 0) },
                new GameStamp{offset = 11, score = new Score(0, 1) },
            };

            var game = new Game(gameStamps);

            //Act
            var result = game.getScore(offset);


            //Assert
            Assert.Equal(score.home, result.home);
            Assert.Equal(score.away, result.away);
        }

        [Fact]
        public void GameScore_Should_Return_Final_Score_On_Offset_More_Then_Max_GameStamp_Offset()
        {
            //Arrange
            var offset = 100500;

            var score = new Score(3, 5);

            var gameStamps = new GameStamp[]
            {
                new GameStamp{offset = 100428, score = new Score(2, 4) },
                new GameStamp{offset = 100431, score = new Score(2, 4) },
                new GameStamp{offset = 100433, score = new Score(2, 4) },
                new GameStamp{offset = 100435, score = new Score(3, 4) },
                new GameStamp{offset = 100438, score = new Score(3, 4) },
                new GameStamp{offset = 100440, score = new Score(3, 5) },
            };

            var game = new Game(gameStamps);

            //Act
            var result = game.getScore(offset);

            //Assert
            Assert.Equal(score.home, result.home);
            Assert.Equal(score.away, result.away);
        }

        [Fact]
        public void GameScore_Should_Return_Current_Score_On_Offset_Equal_GameStamp_Offset()
        {
            //Arrange
            var offset = 100433;

            var score = new Score(2, 4);

            var gameStamps = new GameStamp[]
            {
                new GameStamp{offset = 100428, score = new Score(2, 4) },
                new GameStamp{offset = 100431, score = new Score(2, 4) },
                new GameStamp{offset = 100433, score = new Score(2, 4) },
                new GameStamp{offset = 100435, score = new Score(3, 4) },
                new GameStamp{offset = 100438, score = new Score(3, 4) },
                new GameStamp{offset = 100440, score = new Score(3, 5) },
            };

            var game = new Game(gameStamps);

            //Act
            var result = game.getScore(offset);

            //Assert
            Assert.Equal(score.home, result.home);
            Assert.Equal(score.away, result.away);
        }

        [Fact]
        public void GameScore_Should_Return_Actual_Score_On_OffsetMore_Then_GameStamp_Offset()
        {
            //Arrange
            var offset = 100434;

            var score = new Score(2, 4);

            var gameStamps = new GameStamp[]
            {
                new GameStamp{offset = 100428, score = new Score(2, 4) },
                new GameStamp{offset = 100431, score = new Score(2, 4) },
                new GameStamp{offset = 100433, score = new Score(2, 4) },
                new GameStamp{offset = 100435, score = new Score(3, 4) },
                new GameStamp{offset = 100438, score = new Score(3, 4) },
                new GameStamp{offset = 100440, score = new Score(3, 5) },
            };

            var game = new Game(gameStamps);

            //Act
            var result = game.getScore(offset);

            //Assert
            Assert.Equal(score.home, result.home);
            Assert.Equal(score.away, result.away);
        }
    }
}
