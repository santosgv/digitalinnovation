namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        public Series(Genero genero, string descricao, int ano, bool excluido)
        {
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = excluido;

        }
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }
        private bool Excluido { get; set; }
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero; //+ Environment.NewLine;
            retorno += "Titulo: " + this.Titulo; //+ Environment.NewLine;
            retorno += "Descrição: " + this.Descricao;// + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano; //+ Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}