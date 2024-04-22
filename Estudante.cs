public class Estudante : Pessoa
{
	public int Matricula { get; set; }
	public string Curso { get; set; }
	public List<int> Notas { get ; set }

	public void AdicionarNota(int nota)
	{
		if (Notas == null)
		{
			Notas = new list<int>();
		}
		Notas.Add(nota);
	}
	
	public double CalcularMediaNotas()
	{
		if (Notas == null || Notas.Count == 0)
		{
			return 0;
		}

		double soma = 0;
		foreach (int nota in Notas)
		{
			soma += nota;
		}
		return soma / Notas.Count;
	}
}