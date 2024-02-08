using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibantanimahelper
{
    public class Repository {
        public Dictionary<int, string> getData()
        {
            var BankCodes = new Dictionary<int, string>()
            {                
                {
                    1,
                    " TC Merkez Bankası"
                },
                {
                    4,
                    " İller Bankası"
                },
                {
                    10,
                    " Ziraat Bankası"
                },
                {
                    12,
                    " Halk bank"
                },
                {
                    14,
                    " Sınai Kalkınma Bankası"
                },
                {
                    15,
                    " Vakıflar Bankası"
                },
                {
                    16,
                    " Eximbank"
                },
                {
                    17,
                    " Kalkınma Bankası"
                },
                {
                    29,
                    " Birleşik Fon Bankası"
                },
                {
                    32,
                    " Türk Ekonomi Bankası (TEB)"
                },
                {
                    46,
                    " Akbank"
                },
                {
                    59,
                    " Şekerbank"
                },
                {
                    62,
                    " Garanti Bankası"
                },
                {
                    64,
                    " İş Bankası"
                },
                {
                    67,
                    " Yapı ve Kredi Bankası"
                },
                {
                    91,
                    " Arap Türk Bankası"
                },
                {
                    92,
                    " Citibank"
                },
                {
                    94,
                    " Bank Mellat"
                },
                {
                    96,
                    " Turkish Bank"
                },
                {
                    98,
                    " JPMorgan Chase Bank"
                },
                {
                    99,
                    " ING Bank"
                },
                {
                    100,
                    " Adabank"
                },
                {
                    103,
                    " Fibabanka"
                },
                {
                    108,
                    " Turkland Bank"
                },
                {
                    109,
                    " ICBC Turkey Bank"
                },
                {
                    111,
                    " Finansbank"
                },
                {
                    115,
                    " Deutsche Bank"
                },
                {
                    116,
                    " Pasha Yatırım Bankası"
                },
                {
                    121,
                    " Standard Chartered Yatırım Bankası"
                },
                {
                    122,
                    " Societe Generale"
                },
                {
                    123,
                    " HSBC"
                },
                {
                    124,
                    " Alternatif Bank"
                },
                {
                    125,
                    " Burgan Bank"
                },
                {
                    129,
                    " Merrill Lynch Yatırım Bank"
                },
                {
                    132,
                    " Takasbank"
                },
                {
                    134,
                    " Denizbank"
                },
                {
                    135,
                    " Anadolu Bank"
                },
                {
                    137,
                    " Rabobank"
                },
                {
                    138,
                    " Dilerbank"
                },
                {
                    139,
                    " GSD Bank"
                },
                {
                    141,
                    " Nurol Yatırım Bankası"
                },
                {
                    142,
                    " Bankpozitif Kredi ve Kalkınma Bankası"
                },
                {
                    143,
                    " Aktif Yatırım Bankası"
                },
                {
                    146,
                    " Odea Bank"
                },
                {
                    147,
                    " Bank of Tokyo-Mitsubishi UFJ Turkey"
                },
                {
                    148,
                    " Intesa Sanpaolo"
                },
                {
                    203,
                    " Albaraka Türk Katılım Bankası"
                },
                {
                    205,
                    " Kuveyt Türk Katılım Bankası"
                },
                {
                    206,
                    " Türkiye Finans Katılım Bankası"
                },
                {
                    209,
                    " Ziraat Katılım Bankası"
                },
                {
                    210,
                    " Vakıf Katılım Bankası"
                },
                {
                    806,
                    " Merkezi Kayıt Kuruluşu"
                }
            };
            return BankCodes;


        }
        public Dictionary<int, string> getSWIFT()
        {
            var BankCodes = new Dictionary<int, string>()
            {
                {
                    1,
                    "TCMBTR2A"
                },
                {
                    4,
                    " "
                },
                {
                    10,
                    "TCBZTR2A"
                },
                {
                    12,
                    "TRHBTV2A"
                },
                {
                    14,
                    "TSKBTRIS"
                },
                {
                    15,
                    "TVBATR2A"
                },
                {
                    16,
                    "TIKBTR2A"
                },
                {
                    17,
                    " "
                },
                {
                    29,
                    " "
                },
                {
                    32,
                    "TEBUTRIS"
                },
                {
                    46,
                    "AKBKTRIS"
                },
                {
                    59,
                    "SEKETR2A"
                },
                {
                    62,
                    "TGBATRIS"
                },
                {
                    64,
                    "ISBKTRIS"
                },
                {
                    67,
                    "YAPITRIS"
                },
                {
                    91,
                    " "
                },
                {
                    92,
                    "CITITRIX"
                },
                {
                    94,
                    " "
                },
                {
                    96,
                    " "
                },
                {
                    98,
                    " "
                },
                {
                    99,
                    "INGBTRIS"
                },
                {
                    100,
                    "ADABTRIS"
                },
                {
                    103,
                    "FBHLTRIS"
                },
                {
                    108,
                    "TBNKTRIS"
                },
                {
                    109,
                    " "
                },
                {
                    111,
                    "FNNBTRIS"
                },
                {
                    115,
                    " "
                },
                {
                    116,
                    " "
                },
                {
                    121,
                    " "
                },
                {
                    122,
                    " "
                },
                {
                    123,
                    "HSBCTRIX"
                },
                {
                    124,
                    " "
                },
                {
                    125,
                    "TEKSTRIS"
                },
                {
                    129,
                    " "
                },
                {
                    132,
                    " "
                },
                {
                    134,
                    "DENITRIS"
                },
                {
                    135,
                    "ANDLTRIS"
                },
                {
                    137,
                    " "
                },
                {
                    138,
                    " "
                },
                {
                    139,
                    " "
                },
                {
                    141,
                    " "
                },
                {
                    142,
                    " "
                },
                {
                    143,
                    "CAYTTRIS"
                },
                {
                    146,
                    "ODEATRIS"
                },
                {
                    147,
                    " "
                },
                {
                    148,
                    " "
                },
                {
                    203,
                    "BTFHTRIS"
                },
                {
                    205,
                    "KTEFTRIS"
                },
                {
                    206,
                    "AFKBTRIS"
                },
                {
                    209,
                    "TCZBTR2A"
                },
                {
                    210,
                    " "
                },
                {
                    806,
                    " "
                }
            };
            return BankCodes;


        }

    }
    
}
