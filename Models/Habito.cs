using ProjApi.Models.Enuns;


namespace ProjApi.Models
{
    
    public class Habito 
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public HabitosEnum Classe { get; set; }
    }
}