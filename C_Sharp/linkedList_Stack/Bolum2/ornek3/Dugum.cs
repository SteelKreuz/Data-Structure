using System;

namespace example
{
    class Dugum
    {
        public string Veri;
        public Dugum Sonraki, Onceki;

        public Dugum(string veri, Dugum sonraki = null, Dugum onceki = null)
        {    // nesne olusturulurken, yapici metoda bazi veriler eksik verilirse; varsayilan degeri null olur.
             // Bu sayede her parametreye bir deger vermek zorunda kalmadan isimizi gormus oluyoruz.
            Veri = veri;
            Sonraki = sonraki;
            Onceki = onceki;
        }
    }

    class BagliListe
    {
        private Dugum Baslangic, Son;

        public void Ekle(string veri)
        {
            if (Baslangic == null)
            {
                Baslangic = new Dugum(veri);
                Son = Baslangic;
            }
            else
            {
                var mevcut = Baslangic;
                while (mevcut != null)
                {
                    if (mevcut.Sonraki == null)
                    {
                        Dugum ekle = new Dugum(veri, null, mevcut);
                        mevcut.Sonraki = ekle;
                        Son = ekle;

                        return;
                    }
                    else
                        mevcut = mevcut.Sonraki;
                }
            }
        }

        public void Yaz()
        {
            Console.WriteLine("Ileri dogru yazma basliyor:\n---------------------------");
            var mevcut = Baslangic;
            while (mevcut != null)
            {
                if (mevcut.Sonraki != null)
                {
                    Console.Write(mevcut.Veri + " -> ");
                    mevcut = mevcut.Sonraki;
                }
                else
                {
                    Console.WriteLine(mevcut.Veri + "\n");
                    return;
                }
            }
        }

        public void GeriYaz()
        {
            Console.WriteLine("Geri dogru yazma basliyor:\n---------------------------");
            var mevcut = Son;
            while (Son != null)
            {
                if (mevcut.Onceki != null)
                {
                    Console.Write(mevcut.Veri + " -> ");
                    mevcut = mevcut.Onceki;
                }
                else
                {
                    Console.WriteLine(mevcut.Veri + "\n");
                    return;
                }
            }
        }

        public void BasaEkle(string veri)
        {
            if (Baslangic == null)
            {
                Baslangic = new Dugum(veri);
                Son = Baslangic;
            }
            else
            {
                Dugum ekle = new Dugum(veri, Baslangic);
                Baslangic.Onceki = ekle;
                Baslangic = ekle;
            }
        }

        public void ArdindanEkle(string hedef, string veri)
        {
            var mevcut = Baslangic;
            while(mevcut != null)
            {
                if (mevcut.Veri == hedef)
                {
                    Dugum ekle = new Dugum(veri, mevcut.Sonraki, mevcut);
                    mevcut.Sonraki.Onceki = ekle;
                    mevcut.Sonraki = ekle;
                    
                    return;
                }
                else
                    mevcut = mevcut.Sonraki;
            }
        }

        public void SonaEkle(string veri)
        {
            Dugum ekle = new Dugum(veri, null, Son);
            Son.Sonraki = ekle;
            Son = ekle;
        }

        public void VeriIleSil(string aranan) // Veriye gore silme islemi
        {
            Dugum bakilan = Baslangic, oncesi = null;

            if (bakilan == null)
            {
                Console.WriteLine("Liste bostur!!");
                return;
            }

            if(bakilan.Veri == aranan) // Aranan eleman (dugum) ilk elemansa direkt bulunur.
            {
                Baslangic = bakilan.Sonraki; // ilk dugumu tutan baslangic nesnesine, ilk dugumden sonraki dugum atanir.
                                             // Yani 1. dugumu silecegimizden, ilk dugumu tutan nesneye 2. dugumu atayarak
                                             // 2. dugumu, ilk dugum yapmis oluyoruz.
                Baslangic.Onceki = null;     // 1. dugum yapilan 2. dugumun, onceki isaretcisi null yapilir. Cunku artik ilk dugumdur.
                                             // kendisinden once baska dugum yoktur.
                Console.WriteLine("Aranan eleman bulundu.\n");
            }
            else // Ilk eleman degilse:
            {
                bool durum = false;
                while(bakilan != null && bakilan.Veri != aranan) // bakilan nesnesi null olmadigi surece VE dongude o anki dugumun verisi aradigimiz veri olmadigi surece devam et.
                {//  Bu dongude, aranan dugum ve o dugumden hemen onceki dugum aranir.
                    oncesi = bakilan; // bakilan dugum, dongudeki o an aranan dugumdur. bu dugumu "oncesi" nesnesine atariz.
                    bakilan = bakilan.Sonraki; // bakilan dugum bir eleman ilerletilir.
                                               // Eger listenin sonuna gelirse "bakilan" nesnesi NULL olur!
                                               // Ve donguden cikma sartlartinden birisi de budur zaten.
                    if(bakilan != null) // Listenin sonuna gelip "bakilan" null olursa; bu if blogu calismayacak
                        if (bakilan.Sonraki == null) // listenin son elemanin sonraki isaretcisi null'dur. Eger son elemandaysak
                            durum = true;            // bu durumu belirten degiskeni aktif hale getiriyoruz. Yani true oluyor.
                }
                if(bakilan == null)            // Listenin sonuna gelindiyse, liste komple kontrol edilmis ve sonuc bulunamamistir.
                {
                    Console.WriteLine("Aranan eleman bulunamadi.\n");
                    return;
                }
                else
                {   // Elemanlarin isaretcileri degisir.                
                    Console.WriteLine("Aranan eleman bulundu.\n");
                    oncesi.Sonraki = bakilan.Sonraki; // aranan dugumun, hemen oncesindeki dugumun, sonraki isaretcisi;
                                                      // aranan dugumun sonraki isaretcisinin, isaret ettigi nesneyi isaret eder.
                                                      // Yani:  oncesi -> bakilan (aradigimiz eleman) -> aranan elemandan sonraki eleman
                                                      // oncesi -> bakilandan sonraki eleman ->>>> Artik aranan eleman silinmistir.
                                                      // Not: "bakilandan sonraki eleman" bazen olmayabilir. Yani null olabilir.
                    if(!durum) // Eger 171. satirdaki durum yoksa 156. satirdaki if blogu calismayacak ve durum = false olucak. Bu if blogu calisacak.
                        bakilan.Sonraki.Onceki = oncesi; // oncesi -> bakilan -> bakilandan sonraki dugum (x diyelim)
                                                         // x dugumunun onceki isaretcisi, oncesini isaret edicek. Yani baglanicak.
                    if(durum) // Eger aranan eleman son dugum ise
                        Son = oncesi; // aranan eleman silinir ve onceki eleman son eleman olur.
                }
            }
        }
        // Liste index'i 1'den basliyor diye varsayiyoruz burada.
        public void IndexIleSil(int index) // Listede verilen pozisyona gore silme islemi
        {
            if (0 < index) // gecerli deger girerse bu blok isleyecek
            {
                if (Baslangic == null) // liste bossa metod direkt sonlanir.
                    return;

                Dugum tutucu = Baslangic;

                if (index == 1) // ilk elemansa direkt silinir.
                {
                    Baslangic = tutucu.Sonraki;
                    Baslangic.Onceki = null;
                    Console.WriteLine("Aranan eleman bulundu.\n");
                    return;
                }

                for (int i = 1; (tutucu != null) && (i < (index - 1)); i++)
                {   // aranan elemandan bir onceki elemani tespit eder.
                    tutucu = tutucu.Sonraki;
                    if (tutucu == null) // edemezse metod sonlanir.
                        return;
                }
                // aranan elemana "X" diyelim.
                // tutucu, X'den bir onceki elemani tutuyor.
                // tutucu -> X oluyor.
                // tutucu.Sonraki = X olur. Yani tutucu.Sonraki.Sonraki = X.Sonraki olur
                // x.Sonraki deger de; aranan elemandan sonraki(buna da "Z" diyelim) eleman olur. Kisaca:
                // tutucu -> X -> Z
                // tutucu'nun sonraki isaretcisi, Z'yi gostererek
                // X'i aradan cikartmis yani silmis oluyor.

                // eger son eleman siliniyorsa, tutucu, son elemandan bir onceki elemani tutar. Yani:
                // tutucu -> X -> null
                // tutucu.Sonraki = null olur.
                tutucu.Sonraki = tutucu.Sonraki.Sonraki;

                if (tutucu.Sonraki == null) // 215. satirdaki durum gerceklesiyosa
                    Son = tutucu;           // Son nesnesine, tutucu atanir. Cunku son eleman silinince, ondan onceki eleman(tutucunun tuttugu eleman) son eleman olur
                else                        // degilse
                    tutucu.Sonraki.Onceki = tutucu; // tutucu.Sonraki = x -> X
            }
            else
                Console.WriteLine("0'dan buyuk deger giriniz!!\n");

        }
    }
}
