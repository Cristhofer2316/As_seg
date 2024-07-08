public class Funcionario_Tempo_Integral : Funcionario, IBonus{
    private double salario_mensal;
    public double bonus;

    public Funcionario_Tempo_Integral(string nome, int matricula, double salario_mensal) : base(nome, matricula){
        this.salario_mensal = salario_mensal;
   }

   public override double Calcular_Salario(){
        return salario_mensal;
   }

   public override void Exibir_Informacoes(){
    Console.WriteLine($"Nome: {nome}, Matrícula: {matricula}, Salário Mensal: R${salario_mensal} e sou um Funcionário Tempo Integral");
   }
   public double Calcular_Bonus(){
    return salario_mensal * 0.10;
   }
}