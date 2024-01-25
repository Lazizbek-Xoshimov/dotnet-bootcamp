using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInCSharp
{
    public class Xodim
    {
        public int Id {  get; set; }
        public string Ismi { get; set; }
        public string Familiyasi {  get; set; }
        public string TugulganSanasi {  get; set; }
        public string Jinsi {  get; set; }
        public string Millati {  get; set; }
        public string TelefonRaqami {  get; set; }
        public string Email {  get; set; }
        public decimal Maoshi {  get; set; }

        public Xodim(int id, string ismi, string familiyasi, string tugilganSana, string jinsi, string millati, string telRaqami, string email, decimal maoshi)
        {
            Id = id;
            Ismi = ismi;
            Familiyasi = familiyasi;
            TugulganSanasi = tugilganSana;
            Jinsi = jinsi;
            Millati = millati;
            TelefonRaqami = telRaqami;
            Email = email;
            Maoshi = maoshi;
        }

        public object this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0:
                        return Id;
                    case 1:
                        return Ismi;
                    case 2:
                        return Familiyasi;
                    case 3:
                        return TugulganSanasi;
                    case 4:
                        return Jinsi;
                    case 5:
                        return Millati;
                    case 6:
                        return TelefonRaqami;
                    case 7:
                        return Email;
                    case 8:
                        return Maoshi;
                    default:
                        return null;
                }
            }
            set
            {
                switch(index)
                {
                    case 0:
                        Id = (int) value;
                        break;
                    case 1:
                        Ismi = (string) value;
                        break;
                    case 2:
                        Familiyasi = (string) value;    
                        break;
                    case 3:
                        TugulganSanasi = (string) value;
                        break;
                    case 4:
                        Jinsi = (string) value;
                        break;
                    case 5:
                        Millati = (string) value;
                        break;
                    case 6:
                        TelefonRaqami = (string) value;
                        break;
                    case 7:
                        Email = (string) value;
                        break;
                    case 8:
                        Maoshi = (decimal) value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
