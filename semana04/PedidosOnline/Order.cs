using System.Text;

namespace PedidosOnline;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Frete: $5 nos EUA e $35 fora dos EUA
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("ETIQUETA DE EMBALAGEM");

        foreach (Product product in _products)
        {
            label.AppendLine(
                $"Produto: {product.GetName()} " +
                $"(ID: {product.GetProductId()})");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"ETIQUETA DE ENVIO\n" +
               $"{_customer.GetName()}\n" +
               $"{_customer.GetAddress()}";
    }
}