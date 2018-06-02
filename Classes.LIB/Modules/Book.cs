using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. */


namespace Classes.LIB.Modules
{
    [Serializable]

    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
