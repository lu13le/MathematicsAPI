namespace MathematicsAPI.Services
{
    public class CalclulateRepo : ICalculateRepo
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if(x==0 || y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            }
           
        }

        //test for multiplying nums
        public double Multiply(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            else
            {
                return x * y;
            }
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }
    }
}
