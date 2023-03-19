using DesafioProjetoHospedagem.Exceptions;

namespace DesafioProjetoHospedagem.Models;

public class Reserva {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados) {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes) {
        // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        // *IMPLEMENTE AQUI*
        if (hospedes.Count() <= Suite.Capacidade) {
            Hospedes = hospedes;
        } else {
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*
            throw new CapacidadeExcedidaException($"Essa suíte comporta apenas {Suite.Capacidade} hóspede(s)! Você precisa de uma suíte com capacidade para pelo menos {hospedes.Count()} hóspede(s).");
        }
    }

    public void CadastrarSuite(Suite suite) {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes() {
        // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
        // *IMPLEMENTE AQUI*
        if (Hospedes != null) return Hospedes.Count();
        return 0;
    }

    public decimal CalcularValorDiaria() {
        // TODO: Retorna o valor da diária
        // Cálculo: DiasReservados X Suite.ValorDiaria
        // *IMPLEMENTE AQUI*
        decimal valor = DiasReservados * Suite.ValorDiaria;

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
        // *IMPLEMENTE AQUI*
        if (DiasReservados >= 10) {
            valor *= 0.9M;
        }

        return valor;
    }
}