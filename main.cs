using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
string entrada;
Double salariof, horames, horae, calculos, calculohe, calculopahe, calculoss,salarioch ; 
    
Console.WriteLine ("salário do funcionario");

entrada=Console.ReadLine();

salariof = Double.Parse(entrada);    

Console.WriteLine ("número de horas trabalhadas ao mês");

entrada=Console.ReadLine();

horames = Double.Parse(entrada);     

Console.WriteLine ("horas extra");

entrada=Console.ReadLine();

horae = Double.Parse(entrada);      
 

calculos = (salariof / horames); // calculo para descobrir salario por hora

calculohe = (calculos * 0.50); // para descobrir quanto é o valor para calcular a hora extra

calculopahe = (calculohe + calculos); // caso tenha feito hora extra o valor a mais

calculoss = (calculos * horames); // pagamento salario 

salarioch = (calculoss + calculopahe);    

Console.WriteLine ("Recebimento por hora é " + calculos);
    
Console.WriteLine ("Salario é " + salarioch);     
                  
    
    

    
  }
}




