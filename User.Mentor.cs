namespace OquvMarkaz
{
    public partial class User
    {
        public List<Mentor> ToplamMentor=new List<Mentor>();

        public void AddMentor(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
            int newId = ToplamMentor.Count > 0 ? ToplamMentor.Max(m => m.id) + 1 : 1;
            ToplamMentor.Add( new Mentor{id = newId,name = newName});
            Console.WriteLine("Muvaffaqiyatli qo'shildi!");

            }
            else
            {
                System.Console.WriteLine("Bo'sh ma'lumot kiritildi!");
            }



        }

        public void ListMentor()
        {
            foreach(var item in ToplamMentor)
            {

                System.Console.WriteLine($"{item.id}. {item.name}");
            }

        }

        public bool IdTrueOrFalseMentor(int id)
        {
            var teacher=ToplamMentor.FirstOrDefault(k => k.id == id);
            if (teacher != null)
            {
                return true;
            }
            return false;


        }

        public void UpdateMentor(string name,int id)
        {
            if(!string.IsNullOrEmpty(name))
            {
            var kurs=ToplamMentor.FirstOrDefault(k => k.id == id);
            kurs.name=name;
            System.Console.WriteLine("Muvaffaqiyatli o'zgartirildi!");

            }
            else
            {
                System.Console.WriteLine("Bo'sh joy kiritish mumkin emas!");

            }

        }
        public void RemoveMentor(int id)
        {
            var kurs =ToplamMentor.FirstOrDefault(m => m.id == id);
            ToplamMentor.Remove(kurs);
            System.Console.WriteLine("Muvaffaqiyatli o'chirildi!");


        }



    }
}