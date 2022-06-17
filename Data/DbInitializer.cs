using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
  public static class DbInitializer
  {
    public static void Initialize(StoreContext context)
    {
      if (context.Products.Any()) return;

      var products = new List<Product>
      {
new Product
        {
            Name = "Classic Crepe",
            Description =
                "Faithfully adheres to the orignial crepe recipe as developed by the Belges of yore.",
            Price = 1,
            PictureUrl = "/images/products/classic_crepe.png",
            Brand = "Belgique",
            Type = "crepe",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "American Crepe",
            Description = "Objectively disgusting, but somehow our most popular.",
            Price = 2,
            PictureUrl = "/images/products/crepes/american_crepe.png",
            Brand = "Creppies",
            Type = "crepe",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "French Crepe",
            Description =
                "The ultimate improvement over the Belgian classic.",
            Price = 5,
            PictureUrl = "/images/products/crepes/french_crepe.png",
            Brand = "Meilleurs",
            Type = "crepe",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Fruit Crepe",
            Description =
                "Special recipe that can tolerate the extra juices of a fruit topping without getting soggy.  Note: without a fruit topping, the consistency will be overly dry and pasty.",
            Price = 3,
            PictureUrl = "/images/products/crepes/fruit_crepe.png",
            Brand = "FruityFlapjacks",
            Type = "crepe",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Mixed Berry Topping",
            Description =
                "Blueberries, blackberries, raspberries.",
            Price = 1,
            PictureUrl = "/images/products/crepes/toppings/mixed_berry.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Blueberry Topping",
            Description =
                "Just blueberries, but very fresh.",
            Price = 1,
            PictureUrl = "/images/products/toppings/blueberry.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Raspberry Topping",
            Description =
                "Just raspberries, but very fresh.",
            Price = 1,
            PictureUrl = "/images/products/toppings/raspberry.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Blackberry Topping",
            Description =
                "Just blackberries, but very fresh.",
            Price = 1,
            PictureUrl = "/images/products/toppings/blackberry.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Nutella",
            Description =
                "That heavenly hazelnut spread.",
            Price = 1,
            PictureUrl = "/images/products/toppings/nutella.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Organic Hazy Spread",
            Description =
                "Like Nutella, but all natural.",
            Price = 1,
            PictureUrl = "/images/products/toppings/organiz_hazy_spread.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Poo's Hunny Spread",
            Description =
                "Yes, honey!",
            Price = 1,
            PictureUrl = "/images/products/toppings/poos_hunny_spread.png",
            Brand = "FlatToppers",
            Type = "topping",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Fancy Box - Petit",
            Description =
                "Carry your small stack of crepes safely, and present them confidently to even your snobbiest acquaintance.",
            Price = 1,
            PictureUrl = "/images/products/boxes/fancy_petit.png",
            Brand = "Prezentables",
            Type = "box",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Fancy Box - Moyen",
            Description =
                "Carry your medium stack of crepes safely, and present them confidently to even your snobbiest acquaintance.",
            Price = 1,
            PictureUrl = "/images/products/boxes/fancy_moyen.png",
            Brand = "Prezentables",
            Type = "box",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Fancy Box - Grand",
            Description =
                "Carry your large stack of crepes safely, and present them confidently to even your snobbiest acquaintance.",
            Price = 1,
            PictureUrl = "/images/products/boxes/fancy_grand.png",
            Brand = "Prezentables",
            Type = "box",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Fancy Box - Fete",
            Description =
                "Carry your party-size stack of crepes safely, and present them confidently to even your snobbiest acquaintance.",
            Price = 1,
            PictureUrl = "/images/products/boxes/fancy_fete.png",
            Brand = "Prezentables",
            Type = "box",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Boulle de Glace - Vanille",
            Description =
                "Scoop of vanilla ice cream on the side.",
            Price = 1,
            PictureUrl = "/images/products/ice_cream/boulle_de_glace_vanilla.png",
            Brand = "FlatToppers",
            Type = "ice cream",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Boulle de Glace - Fraise",
            Description =
                "Scoop of strawberry ice cream on the side.",
            Price = 1,
            PictureUrl = "/images/products/ice_cream/boulle_de_glace_fraise.png",
            Brand = "Glace a la Mode",
            Type = "ice cream",
            QuantityInStock = 100
        },
        new Product
        {
            Name = "Cidre",
            Description =
                "Glass of cider to accompany your crepe.",
            Price = 1,
            PictureUrl = "/images/products/drinks/cidre.png",
            Brand = "BubblesOfCheer",
            Type = "drink",
            QuantityInStock = 100
        },
      };

      foreach (var product in products)
      {
        context.Products.Add(product);
      }

      context.SaveChanges();
    }
  }
}