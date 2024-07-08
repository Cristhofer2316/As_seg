public abstract class Funcionario
{
    public string nome;

    public int matricula;

    public List<string> projetos = new List<string>();

    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    public abstract double Calcular_Salario();
    public abstract void Exibir_Informacoes();

    public void Adicionar_Projeto(string projeto)
    {
        projetos.Add(projeto);
    }

    public void Adicionar_Projeto(List<string> Lista)
    {
        for (int i = 0; i < Lista.Count; i++)
        {
            projetos.Add(Lista[i]);
        }
    }
}


