namespace MathematicsAPI.Services
{
    public interface ICalculateRepo
    {
        //Signatures of needed methods
        double Add(double x, double y);
        double Substract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);

    }
}
