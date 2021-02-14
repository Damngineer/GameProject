using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : DiscountInterface
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Ad + " sepete eklendi.");
        }

        public void Update(Game game)
        {
            string eski;
            eski = game.Ad;
            game.Ad = "csgo";
            Console.WriteLine("Sepetinizdeki " + eski + " oyunu " + game.Ad + " olarak güncellendi.");

        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Ad + " sepetten çıkarıldı.");
        }

    }
}
