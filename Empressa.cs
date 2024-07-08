public class Empresa
{
    public List<Funcionario> lista_funcionarios = new List<Funcionario>();

    public void Adicionar_Funcionario(Funcionario Funcionario)
    {
        lista_funcionarios.Add(Funcionario);
    }
    public void Remover_Funcionario(int Numero_Matricula)
    {
        for (int i = 0; i < lista_funcionarios.Count; i++)
        {

            if (lista_funcionarios[i].matricula == Numero_Matricula)
            {
                lista_funcionarios.RemoveAt(i);
            }
        }
    }

    public void Exibir_Funcionario()
    {
        for (int i = 0; i < lista_funcionarios.Count; i++)
        {
            lista_funcionarios[i].Exibir_Informacoes();

            if (lista_funcionarios[i].projetos.Count > 0)
            {
                Console.WriteLine($"Projetos: {string.Join(", ", lista_funcionarios[i].projetos)}");
            }

            else
            {
                Console.WriteLine("Projetos: Nenhum Projeto");
            }
            Console.WriteLine();
        }
    }

}
