using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class DiscountManager : DiscountInterface
    {
        public void Add(Game game)
        {

            Console.WriteLine(game.Ad + " oyununa %" + game.Indirim + " oranında indirim uygulandı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Ad + " oyununun indirim oranı %" + game.Indirim + " olarak güncellendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Ad + " oyununundaki indirim kaldırıldı.");
        }
        

    }
}
