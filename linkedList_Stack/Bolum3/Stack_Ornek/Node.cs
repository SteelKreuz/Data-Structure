using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public string Data // Her düğümdeki veri için
        {
            get;
            set;
        }

        public Node Next // Bir sonraki düğümü işaret etmek için
        {
            get;
            set;
        }

        public Node (string data) // Yapıcı
        {
            Data = data;
            Next = null;
        }
    }
}
