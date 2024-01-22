using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal price, bool active)
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(price, 0, "Price", "O preço deve ser maior que zero.")
            );
            
            Title = title;
            Price = price;
            Active = active;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }
    }
}