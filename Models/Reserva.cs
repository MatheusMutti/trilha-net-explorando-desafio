using Microsoft.VisualBasic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                                    
            bool Status = (Suite.Capacidade <= hospedes.Count);

            if (Status == true) 
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes não pode exceder a capacidade da suíte.");
                
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int QtdeHospedes = Hospedes.Count;
            return QtdeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
                        
            decimal valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            bool desconto = (DiasReservados >= 10);

            if (true)
            {
                valor = valor * 0.9m;
            }

            return valor;
        }
    }
}