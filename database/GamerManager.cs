using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{//MicroService dışarıdan gelen bir servistir.
    internal class GamerManager : IGamerService
    {
        IUserValidaitonService _userValidaitonService;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidaitonService userValidaitonService)
        {
            _userValidaitonService = userValidaitonService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidaitonService.Validate(gamer)==true)
            {
                Console.WriteLine("kayıt olundu");
            }
            else
            {
                Console.WriteLine("kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
