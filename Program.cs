using Desafio2.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Renan");
Pessoa p2 = new Pessoa(nome:"Isa");


hospedes.Add(p1);
hospedes.Add(p2);




Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiario: 30);

Reserva reserva = new Reserva(diasReservados: 9);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.ObterValorDiaria():C}");

