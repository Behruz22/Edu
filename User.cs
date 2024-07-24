using System.Text.Json;

namespace OquvMarkaz;
    public partial class User
    {
        public List<Kurs> ToplamKurs =new List<Kurs>();
        string path=Directory.GetCurrentDirectory();



        public void AddKurs(string newName)
        {
             string kursPath=path+"Kurslar.json";

            if (!string.IsNullOrEmpty(newName))
            {
            int newId = ToplamKurs.Count > 0 ? ToplamKurs.Max(k => k.id) + 1 : 1;
            ToplamKurs.Add( new Kurs{id = newId,name = newName});

            Console.WriteLine("Muvaffaqiyatli qo'shildi!");


            }
            else
            {
                System.Console.WriteLine("Bo'sh ma'lumot kiritildi!");
            }



        }

        public void ListKurs()
        {
            foreach(var item in ToplamKurs)
            {

                System.Console.WriteLine($"{item.id}. {item.name}");
            }

        }

        public bool IdTrueOrFalse(int id)
        {
            var teacher=ToplamKurs.FirstOrDefault(k => k.id == id);
            if (teacher != null)
            {
                return true;
            }
            return false;


        }

        public void UpdateKurs(string name,int id)
        {
            if(!string.IsNullOrEmpty(name))
            {
            var kurs=ToplamKurs.FirstOrDefault(k => k.id == id);
            kurs.name=name;
            System.Console.WriteLine("Muvaffaqiyatli o'zgartirildi!");

            }
            else
            {
                System.Console.WriteLine("Bo'sh joy kiritish mumkin emas!");

            }

        }
        public void RemoveKurs(int id)
        {
            var kurs =ToplamKurs.FirstOrDefault(k => k.id == id);
            ToplamKurs.Remove(kurs);
            System.Console.WriteLine("Muvaffaqiyatli o'chirildi!");


        }




    }
