namespace CalculaPreco.Entities
{
    public class Item
    {
        public Item(double custoAquisicao, int volumeOcupado, bool refrigeracao, bool riscoValidade, double custo, int validade)
        {
            CustoAquisicao = custoAquisicao;
            VolumeOcupado = volumeOcupado;
            Refrigeracao = refrigeracao;
            RiscoValidade = riscoValidade;
            Custo = custo;
            Validade = validade;
        }

        public double Preco { get; private set; }
        public double CustoAquisicao { get; set; }
        public int VolumeOcupado { get; private set; }
        public bool Refrigeracao { get; private set; }
        public bool RiscoValidade { get; private set; }
        public double Custo { get; private set; }
        public int Validade { get; private set; }

        /// <summary>
        /// Metodo para calculo do preço com base do custo e validade do item.
        /// </summary>
        public void FormulaMagica()
        {
            if (this.Validade < 30)
                this.Preco = this.Custo + (25 / 100);
            else if (this.Validade < 60)
                this.Preco = this.Custo + (50 / 100);
            else if (this.Validade < 90)
                this.Preco = this.Custo + (75 / 100);
            else if (this.Validade < 120)
                this.Preco = this.Custo + (100 / 100);
            else
                this.Preco = this.Custo + (120 / 100);
        }
    }
}
