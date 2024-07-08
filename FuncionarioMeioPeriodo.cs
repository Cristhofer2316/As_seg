public class Funcionario_Meio_Periodo : Funcionario
{
    private double salario_por_hora;
    private double horas_trabalhadas;

    public Funcionario_Meio_Periodo(string Nome, int Matricula, double Salario_Por_Hora, double Horas_Trabalhadas) : base(Nome, Matricula)
    {
        this.salario_por_hora = Salario_Por_Hora;
        this.horas_trabalhadas = Horas_Trabalhadas;
    }

    public override double Calcular_Salario()
    {
        return salario_por_hora * horas_trabalhadas;

    }

    public override void Exibir_Informacoes()
    {
        double Salario_Mensal = Calcular_Salario();
        Console.WriteLine($"Nome: {nome}, Matrícula: {matricula}, Salário Mensal: R${Salario_Mensal} e sou um Funcionário de meio pariodo");

    }

    public double Calcular_Bonus()
    {
        return Calcular_Salario() * 0.05;
    }
}