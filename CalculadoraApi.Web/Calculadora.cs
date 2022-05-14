namespace CalculadoraApi.Web
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 + num2;
            }    
            throw new Exception("Parametro invalido");
        }
         public double Subtrair(double num1, double num2)
        {
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 - num2;
            }
            throw new Exception("Parametro invalido");
            
        }
         public double Dividir(double num1, double num2)
        {
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 / num2;
            }
            throw new Exception("Parametro invalido");
            
        }
         public double Multiplicar(double num1, double num2)
        {
            if(ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 * num2;
            }
            throw new Exception("Parametro invalido");
            
        }
        public bool ValidarNumero(double valor)
        {
            if (valor != 0 & valor < 1000)
            {
                return true;
            }  
            return false;
        }
    }
}