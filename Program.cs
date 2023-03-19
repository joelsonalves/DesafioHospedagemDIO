// See https://aka.ms/new-console-template for more information
using System.Text;
using DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Exceptions;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria as suítes
Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite2 = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

Console.WriteLine("\nReserva 1:");

try {

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva1 = new Reserva(diasReservados: 5);
    reserva1.CadastrarSuite(suite1);
    reserva1.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: R$ {reserva1.CalcularValorDiaria().ToString("N2")}");

} catch (CapacidadeExcedidaException e) {
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nReserva 2:");

try {

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva2 = new Reserva(diasReservados: 10);
    reserva2.CadastrarSuite(suite2);
    reserva2.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: R$ {reserva2.CalcularValorDiaria().ToString("N2")}");

} catch (CapacidadeExcedidaException e) {
    Console.WriteLine(e.Message);
}
