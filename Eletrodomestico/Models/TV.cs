namespace Eletrodomestico.Models
{
    public class TV : EletroDomestico
    {
        public int Tamnho { get; set; }
        public bool Smart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo {Modelo}, Consumo {ConsumoEnergetico}Wh, Tela {Tamnho}, É smart: {(Smart ? "Sim" : "Não")}";
        }
    }
}
