using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionJeuxVideo
{
    class Jeu
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Synopsis { get; set; }
        public int CategorieId { get; set; }
    }

}
