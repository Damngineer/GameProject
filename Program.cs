using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Register reg1 = new Register();
            reg1.Id = 1;
            reg1.Tc = "12345";
            reg1.Ad = "kubilay";
            reg1.Soyad = "arslan";
            reg1.DogumYili = 2000;
            RegisterManager regMan1 = new RegisterManager();

            regMan1.Add(reg1);
            regMan1.Update(reg1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.Ad = "GTA V";
            game1.Fiyat = 100;
            game1.Indirim = 0;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Ad = "CS:GO";
            game2.Fiyat = 50;
            game2.Indirim = 0;


            GameManager gameMan1 = new GameManager();
            gameMan1.Add(game1);

            DiscountManager discountMan1 = new DiscountManager();
            discountMan1.Add(game1);

            gameMan1.Delete(game1);
            discountMan1.Delete(game1);

            gameMan1.Add(game2);
            discountMan1.Add(game2);


        }
    }
}
