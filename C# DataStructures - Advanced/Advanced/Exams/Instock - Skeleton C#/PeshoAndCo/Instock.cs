using System;
using System.Collections;
using System.Collections.Generic;
using Wintellect.PowerCollections;
using System.Linq;
using System.Diagnostics;

public class Instock : IProductStock
{
    private Dictionary<string, Product> products = new Dictionary<string, Product>();
    private Dictionary<int,Product> productsByIndex = new Dictionary<int, Product>();
    private int indexCounter = 0;

    public int Count => this.products.Count;

    public void Add(Product product)
    {
        this.products.Add(product.Label, product);
        product.SetIndex(this.indexCounter, this.products.Values);
        this.productsByIndex.Add(product.Index, product);

        this.indexCounter++;
    }

    public void ChangeQuantity(string product, int quantity)
    {
        if (!this.products.ContainsKey(product))
        {
            throw new ArgumentException();
        }

        var tempProduct = this.products[product];
        this.productsByIndex[tempProduct.Index].Quantity = quantity;
        this.products[product].Quantity = quantity;
    }

    public bool Contains(Product product)
    {
        return this.products.ContainsKey(product.Label);
    }

    public Product Find(int index)
    {
        if (index < 0 || index >= this.productsByIndex.Values.Count)
        {
            throw new IndexOutOfRangeException();
        }

        return this.productsByIndex[index];
    }

    public IEnumerable<Product> FindAllByPrice(double price)
    {
        return this.products.Values.Where(p => p.Price == price);
    }

    public IEnumerable<Product> FindAllByQuantity(int quantity)
    {
          return this.products.Values.Where(p => p.Quantity == quantity);
    }

    public IEnumerable<Product> FindAllInRange(double lo, double hi)
    {
        return this.products.Values
            .Where(p => p.Price > lo && p.Price <= hi)
            .OrderByDescending(p => p.Price);
    }

    public Product FindByLabel(string label)
    {
        if (!this.products.ContainsKey(label))
        {
            throw new ArgumentException();
        }

        return this.products[label];
    }

    public IEnumerable<Product> FindFirstByAlphabeticalOrder(int count)
    {
        var list = this.products.Values.OrderBy(p => p.Label).ToList();
        if (list.Count < count)
        {
            throw new ArgumentException();
        }

        return list.Take(count);
    }

    public IEnumerable<Product> FindFirstMostExpensiveProducts(int count)
    {
        var list = this.products.Values.OrderByDescending(p => p.Price).ToList();

        if (list.Count < count)
        {
            throw new ArgumentException();
        }

        return list.Take(count);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        foreach (var product in this.products.Values)
        {
            yield return product;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
}
