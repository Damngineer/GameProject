using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class RegisterManager : RegisterInterface
    {
        public void Add(Register register)
        {
            Console.WriteLine(register.Ad + " isimli kullanıcı eklendi.");
        }

        public void Update(Register register)
        {
            Console.WriteLine(register.Ad + " isimli kullanıcının bilgileri güncellendi.");
        }

        public void Delete(Register register)
        {
            Console.WriteLine(register.Ad + " isimli kullanıcının kayıdı silindi.");
        }

    }
}
