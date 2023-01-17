using Hotel.Models;
internal class Program
{
    public static void Main(string[] args)
    {

        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "");
        Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "");
        Pessoa p4 = new Pessoa(nome: "Hóspede 4", sobrenome: "");

        hospedes.Add(p1);
        hospedes.Add(p2);
        hospedes.Add(p3);
        hospedes.Add(p4);

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 20);

        Reserva reserva = new Reserva(diasReservados: 02);
        reserva.cadastrarSuite(suite);
        reserva.cadastrarHospedes(hospedes);


        Console.WriteLine($"Hóspedes: {reserva.obterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: R$ {reserva.calcularValorDiaria()}");

    }
}