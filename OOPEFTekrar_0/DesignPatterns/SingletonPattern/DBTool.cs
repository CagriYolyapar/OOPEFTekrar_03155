using OOPEFTekrar_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEFTekrar_0.DesignPatterns.SingletonPattern
{
    public class DBTool
    {

        //Singleton Pattern görevini uygulayacak bu sınıfımız öncelikle constructor'i private olan bir sınıftır ki dısarıdan bu sınıfın instance'i alınmasın...Aksi halde bir sorundan kacarken baska bir gereksiz instance alınmasını saglamıs olurduk...


        //Class'ın dısarıdan instance'inin alınmasını istemiyorsak bu, ilgili class sadece Abstract veya Static ile işaretlenerek olmak zorunda degildir...Kaldı ki bu class'ımız hic miras vermekle ilgilenmeyecegi icin abstraction prensibi burada uygulanmamalıdır. static'i tercih etmememizin ileride bu sınıfın instance member alacagı gerceginden dolayıdır...
        DBTool() { }

      

        static NorthwindEntities _dbInstance; //burada yarattıgımız field static bir field'dir...Cünkü biz bu field, ram'de olustugu zaman kaldırılmasın program calıstıgı sürece degerini saklasın istiyoruz...


        //Alt taraftaki property'miz Encapsulation prensibini uygulayarak öncelikle sadece read only oluyor...Cünkü zaten Context sınıfınızın ozel bir atanmasının olması düsünce yapımıza ters düser...Read Only kesiminde get metodumuz cagrıldıgında ise  öncelikle ram'i kontrol ediyor... Eger _dbInstance field'i null ise _dbInstance'in icerisine context sınıfınızın nesnesi alınarak atılıyor(Cünkü 1 instance'a ihtiyacınız var)...Sonra ilgili degeri döndürüyor...Böylece bu SingletonPattern tekrar kullanıldıgında bu sefer get'teki karar mekanizması ram'deki o field'in null olmadıgını görüp if'i atlayacak ve direkt var olan degeri döndürecektir...
        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}
