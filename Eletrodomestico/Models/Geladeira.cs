namespace Eletrodomestico.Models
{
    public class Geladeira : EletroDomestico
    {
        public int CapacidadeLitros {  get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo {ConsumoEnergetico}KWh, Capacidade: {CapacidadeLitros}, Tem Freezer: {(TemFreezer ?"Sim" : "Não")}";
        }
    }
}
