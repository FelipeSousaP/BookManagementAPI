namespace GerenciadorDeLivroAPI.Objects
{
    public class Livro
    {
        public int id { get; set; }
        public string? nameDoLivro { get; set; }
        public string? nomeDoAutor { get; set; }
        public string? dataDaPublicação { get; set; }
        public Livro() 
        {
           
        }
    }
}
