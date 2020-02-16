using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstShop
{
    class Warehouse
    {
        List<Article> InStock;

        //constructor

        public Warehouse()
        {
            InStock = new List<Article>();
            Article cinnamonBun = new Article(1, "cinnamon bun", Category.PASTRY, 0.39);
            InStock.Add(cinnamonBun);

            Article ciabatta = new Article(2, "ciabatta", Category.PASTRY, 0.99);
            InStock.Add(ciabatta);

            Article milk = new Article(3, "milk", Category.DAIRY, 0.59);
            InStock.Add(milk);

            Article yogurt = new Article(4, "yogurt", Category.DAIRY, 0.99);
            InStock.Add(yogurt);

            Article kalevChokolate = new Article(5, "Kalev chokolate", Category.CONFECTIONERY, 1.99);
            InStock.Add(kalevChokolate);

            Article gummybears = new Article(6, "Gummy Bears", Category.CONFECTIONERY, 1.99);
            InStock.Add(gummybears);

            Article cocacola = new Article(7, "coca cola", Category.BEVERGATES, 0.99);
            InStock.Add(cocacola);

            Article crafterBeer = new Article(8, "crafted beer", Category.BEVERGATES, 6);
            InStock.Add(crafterBeer);

            Article orange = new Article(9, "orange", Category.FRUIT, 0.4);
            InStock.Add(orange);

            Article apple = new Article(10, "apple", Category.FRUIT, 0.2);
            InStock.Add(apple);

            Article potato = new Article(11, "potato", Category.FRUIT, 0.29);
            InStock.Add(potato);

            Article tomato = new Article(12, "tomato", Category.VEGGIE, 1.29);
            InStock.Add(tomato);

            Article cannedBeans = new Article(13, "kidney beans in tomato sauce", Category.CANNED_FOOD, 0.69);
            InStock.Add(cannedBeans);

            Article turistieine = new Article(14, "turisti eine", Category.CANNED_FOOD, 2);
            InStock.Add(turistieine);

            Article salmon = new Article(15, "salomon", Category.FISH, 4.99);
            InStock.Add(salmon);

            Article fishfingers = new Article(16, "fish fingers", Category.FISH, 1.69);
            InStock.Add(fishfingers);

            Article pork = new Article(17, "pork", Category.MEAT, 4.99);
            InStock.Add(pork);

            Article beef = new Article(18, "beef", Category.MEAT, 10);
            InStock.Add(beef);

            Article shampoo = new Article(19, "shampoo", Category.TOILETRIES, 4);
            InStock.Add(shampoo);

            Article conditioner = new Article(20, "conditioner", Category.TOILETRIES, 4);
            InStock.Add(conditioner);


        }

        public void PrintInStock()
        {
            foreach (Article article in InStock)
            {
                Console.WriteLine($"ID: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();
            }
        }


        //get an article object from the list
        public Article GetFromStock(int id)
        {
            return InStock[id - 1];
        }
    }
}
