using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BowlingGame;

namespace TestBowlingGame
{
    [TestFixture]
    public class ボウリングのスコア
    {
        public void ピンが一つ倒れた場合()
        {
            var bowling = new Game();
            var pins = new int[] { 1 };

            Assert.That(bowling.Score(pins), Is.EqualTo(1));

        }
    }
}
