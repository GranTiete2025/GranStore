using GranStore.Models;

namespace GranStore.Data;

public class MockData : IMockData
{
    public List<Categoria> Categorias { get; set; }
    public List<Produto> Produtos { get; set; }

    public MockData()
    {
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Smartphones" },
            new Categoria { Id = 2, Nome = "Notebooks" },
            new Categoria { Id = 3, Nome = "Smartwatches" },
            new Categoria { Id = 4, Nome = "Fones de Ouvido" },
            new Categoria { Id = 5, Nome = "Monitores" },
            new Categoria { Id = 6, Nome = "Teclados e Mouses" },
            new Categoria { Id = 7, Nome = "Consoles" },
            new Categoria { Id = 8, Nome = "Action Figures" },
            new Categoria { Id = 9, Nome = "Drones" },
            new Categoria { Id = 10, Nome = "Câmeras Digitais" }
        };
        Categorias = categorias;

        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Categoria = categorias[0], Nome = "iPhone 14 Pro", Descricao = "Apple A16 Bionic, 128GB", ValorCusto = 4500.00m, ValorVenda = 6999.00m, QtdeEstoque = 10, Foto = "/img/produtos/1.png" },
            new Produto { Id = 2, Categoria = categorias[0], Nome = "Samsung Galaxy S23", Descricao = "Snapdragon 8 Gen 2, 256GB", ValorCusto = 4000.00m, ValorVenda = 6499.00m, QtdeEstoque = 15, Foto = "/img/produtos/2.png" },
            new Produto { Id = 3, Categoria = categorias[1], Nome = "MacBook Pro M2", Descricao = "Apple M2, 16GB RAM, 512GB SSD", ValorCusto = 8000.00m, ValorVenda = 11999.00m, QtdeEstoque = 5, Foto = "/img/produtos/3.png" },
            new Produto { Id = 4, Categoria = categorias[2], Nome = "Apple Watch Series 8", Descricao = "GPS + Cellular, 45mm", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 10, Foto = "/img/produtos/4.png" },
            new Produto { Id = 5, Categoria = categorias[3], Nome = "AirPods Pro", Descricao = "Cancelamento de Ruído Ativo", ValorCusto = 900.00m, ValorVenda = 1499.00m, QtdeEstoque = 12, Foto = "/img/produtos/5.png" },
            new Produto { Id = 6, Categoria = categorias[4], Nome = "LG Ultragear 27\"", Descricao = "IPS, 144Hz, 1ms", ValorCusto = 1200.00m, ValorVenda = 1899.00m, QtdeEstoque = 8, Foto = "/img/produtos/6.png" },
            new Produto { Id = 7, Categoria = categorias[5], Nome = "Logitech G Pro X", Descricao = "Teclado Mecânico, RGB", ValorCusto = 700.00m, ValorVenda = 1099.00m, QtdeEstoque = 20, Foto = "/img/produtos/7.png" },
            new Produto { Id = 8, Categoria = categorias[6], Nome = "PlayStation 5", Descricao = "Edição Standard, SSD 825GB", ValorCusto = 3500.00m, ValorVenda = 4999.00m, QtdeEstoque = 8, Foto = "/img/produtos/8.png" },
            new Produto { Id = 9, Categoria = categorias[7], Nome = "Batman (DC Collectibles)", Descricao = "Figura colecionável 1/6", ValorCusto = 500.00m, ValorVenda = 899.00m, QtdeEstoque = 15, Foto = "/img/produtos/9.png" },
            new Produto { Id = 10, Categoria = categorias[8], Nome = "DJI Mini 3 Pro", Descricao = "4K, Compacto, Smart Features", ValorCusto = 2500.00m, ValorVenda = 3999.00m, QtdeEstoque = 6, Foto = "/img/produtos/10.png" },
            new Produto { Id = 11, Categoria = categorias[9], Nome = "Canon EOS R5", Descricao = "Mirrorless, 8K Video", ValorCusto = 12000.00m, ValorVenda = 15999.00m, QtdeEstoque = 4, Foto = "/img/produtos/11.png" }
        };
    }

    public List<Produto> GetProdutos()
    {
        return Produtos;
    }
}
