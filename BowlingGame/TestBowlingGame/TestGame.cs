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
        [Test]
        public void ピンが一つ倒れた場合()
        {
            var bowling = new Game();
            var pins = new int[] { 1 };

            Assert.That(bowling.Score(pins), Is.EqualTo(1));

        }

        [Test]
        public void ピンが二つ倒れた場合()
        {
            var bowling = new Game();
            var pins = new int[] { 2 };

            Assert.That(bowling.Score(pins), Is.EqualTo(2));

        }

        [Test]
        public void 二回投げた時で合計が十本以下の場合True()
        {
            var bowling = new Game();
            var pins = new int[] { 2 , 3 };

            Assert.That(bowling.Score(pins), Is.EqualTo(5));
        }
    }
}
