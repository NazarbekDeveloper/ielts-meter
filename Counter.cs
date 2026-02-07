namespace IeltsMaster
{
    public class Counter
    {
        decimal yigindi;
        public Counter()
        {
            yigindi = 0;
        }
        public void BallQosh(decimal ball)
        {
            yigindi += ball;
        }
        public decimal YigindiQaytar()
        {
            return yigindi;
        }
    }
}