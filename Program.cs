namespace Estudante;

class Program
{
	static void main()
	{
		Nome = "Carlos";
		DataDeNascimento = new DateTime(2008, 3, 5);
		Matricula = 2050;
		Curso = "Veterinaria";
	};

	estudande1.AdicionarNota(60);
	estudante2.AdicionarNota(100);

	Estudante estudante2 = new Estudante
	{
		Nome = "Cleide";
		DataDeNascimento = new DateTime(2007, 5, 3)
		Matricula = 2330;
		Curso = "Medicina";
	};
	
	estudante2.AdicionarNota(45);
	estudante2.AdicionarNota(75);
	estudante2.AdicionarNota(90);

	Console.WriteLine($"Estudante1: {estudante1.Nome}  - Idade: {estudante1.CalcularIdade}() - Media de Notas: {estudante1.CalcularMedia()});
		Console.WriteLine($"Estudante2: {estudante2.Nome}  - Idade: {estudante2.CalcularIdade}() - Media de Notas: {estudante2.CalcularMedia()});
}
	