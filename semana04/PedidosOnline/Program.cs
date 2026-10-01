namespace PedidosOnline;

public class Program
{
    public static void Main()
    {
        // Primeiro cliente, morando nos Estados Unidos
        Address enderecoAna = new Address(
            "Rua das Flores, 100",
            "Provo",
            "UT",
            "USA");

        Customer ana = new Customer(
            "Ana Silva",
            enderecoAna);

        Order pedidoAna = new Order(ana);

        pedidoAna.AddProduct(
            new Product("Caderno", "C001", 4.50, 2));

        pedidoAna.AddProduct(
            new Product("Caneta azul", "C002", 1.25, 5));


        // Segundo cliente, morando fora dos Estados Unidos
        Address enderecoBruno = new Address(
            "Avenida Central, 250",
            "São Paulo",
            "SP",
            "Brasil");

        Customer bruno = new Customer(
            "Bruno Souza",
            enderecoBruno);

        Order pedidoBruno = new Order(bruno);

        pedidoBruno.AddProduct(
            new Product("Mochila", "M001", 30.00, 1));

        pedidoBruno.AddProduct(
            new Product("Livro", "L001", 18.00, 2));

        pedidoBruno.AddProduct(
            new Product("Lápis", "L002", 0.80, 10));


        // Exibir os dois pedidos
        ExibirPedido("PEDIDO 1", pedidoAna);
        ExibirPedido("PEDIDO 2", pedidoBruno);
    }

    private static void ExibirPedido(string titulo, Order order)
    {
        Console.WriteLine($"===== {titulo} =====");

        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine(
            $"CUSTO TOTAL: ${order.GetTotalCost():0.00}");

        Console.WriteLine();
    }
}