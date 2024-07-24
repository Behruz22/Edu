namespace OquvMarkaz
{
    public partial class User
    {
        int i=0;
        public List<KursVaMentor> kursVaMentors=new List<KursVaMentor>();
        public List<string> arizalar=new List<string>();
        public void GuruhAdd(int idMentor,int idKurs)
        {
            string nameMentor=string.Empty;
            string nameKurs=string.Empty;
            foreach(var m in ToplamMentor)
            {
                if(m.id == idMentor)
                {
                    nameMentor=m.name;
                }
            }
            foreach(var k in ToplamKurs)
            {
                if(k.id == idKurs)
                {
                    nameKurs=k.name;
                }
            }
            if(nameMentor==string.Empty || nameKurs==string.Empty)
            {
                System.Console.WriteLine("Id ni xato kiritdingiz qayta urunib ko'ring!");
            }
            else
            {
                int newId = kursVaMentors.Count > 0 ? kursVaMentors.Max(m => m.id) + 1 : 1;
                kursVaMentors.Add( new KursVaMentor{id = newId,teacher = nameMentor,spec=nameKurs});
                System.Console.WriteLine("Muvaffaqiyatli qo'shildi!");

            }


        }

        public void ListKursVaMentor()
        {
            System.Console.WriteLine("Guruhlar ro'yhati:");
            foreach(var item in kursVaMentors)
            {
                System.Console.WriteLine($"{item.id}. Ustoz: {item.teacher} => Mutaxassislik: {item.spec}");

            }
        }
        public void YangiAriza(int id,string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                foreach(var item in kursVaMentors)
                {
                    if(item.id == id)
                    {
                        arizalar.Add($"{i+=1}.O'quvchi: {name}\nMutaxassislik: {item.spec}\nO'qituvchi: {item.teacher}");
                        System.Console.WriteLine("Ariza muvaffaqiyatli yuborildi!");

                    }
                }

            }
            else
            {
                System.Console.WriteLine("Bo'sh ma'lumot kiritish mumkin emas!");
            }
        }

        public void ListArizalar()
        {
            foreach (var item in arizalar)
            {
                System.Console.WriteLine(item);

            }
        }

    }
}