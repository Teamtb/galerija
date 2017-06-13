using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galerija
{
    public class Album
    {
        public List<String> slike;//definicija  promjenljive kooja se zove slika,tipa je lista stringova i ogranicenje pristupa je public
        public String naziv;//ovo su osobine klase-nisu f-je,f-je imaju uvijek otvorenu i zatvorenu zagradu pored imena
        public Color pozadina;

        public Album()
        {
            int i = 0;
            int a = 5;
            int c;
            c = i + a;
            slike = new List<string>();
            slike.Add("C:\\Users\\Nikola\\Desktop\\tea\\webGalerija\\images\\prva.jpg");
            pozadina = Color.BlanchedAlmond;
        }


    }
}
