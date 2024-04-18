namespace Biblioteca_Central.Entities
{
    public class Livro
    {
        public required int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public string Categoria { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }

    public class Usuario
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
    }

    public class Emprestimo
    {
        public required int Id { get; set; }
        public required int LivroId { get; set; }
        public required int UsuarioId { get; set; }
        public required DateTime DataEmprestimo { get; set; }
        public required DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataRealDevolucao { get; set; }
    }

    public class Multa
    {
        public required int Id { get; set; }
        public required int EmprestimoId { get; set; }
        public required int DiasAtraso { get; set; }
        public required decimal ValorMulta { get; set; }
    }
}
