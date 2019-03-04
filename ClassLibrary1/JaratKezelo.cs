,,using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class JaratKezelo
    {
        class Jarat
        {
            public string jaratSzam;
            public string repterHonnan;
            public string repterHova;
            public DateTime indulas;
            public int keses;

            public Jarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                this.jaratSzam = jaratSzam;
                this.repterHonnan = repterHonnan;
                this.repterHova = repterHova;
                this.indulas = indulas;
                keses = 0;
            }

        }

        List<Jarat> jaratok = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                var x = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
                jaratok.Add(x);
            }

            public void Keses(string jaratSzam, int keses)
            {
                foreach (var item in jaratok)
                {
                    if (jaratSzam.Equals(item.jaratSzam))
                    {
                        if ((item.keses = keses) < 0)
                        {
                            throw new NegativKesesExcepton(keses);
                        }
                        else
                        {
                            item.keses = keses;
                        }
                    }
                }

            }

            public DateTime MikorIndul(string jaratSzam)
            {
                foreach (var item in jaratok)
                {
                    if (jaratSzam.Equals(item.jaratSzam))
                    {
                        return item.indulas.AddMinutes(item.keses);
                    }            
                   
                }
                throw new ArgumentException("...");
            }

            public List<string> JaratokRepuloterrol(string repter)
            {
                List<string> repterJaratSzama = new List<string>();
                
                    foreach (var e in jaratok)
                    {
                        if (repterJaratSzama.Equals(e.jaratSzam))
                        {
                        repterJaratSzama.Add(e.repterHonnan);
                    }
                    }
                throw new ArgumentException("...");
            }
        }
    }
}
