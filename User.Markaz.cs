namespace OquvMarkaz;

    public partial class User
    {
        public string malumot=string.Empty;
        public void  MarkazMalumoti(string malumot)
        {
            if(!string.IsNullOrEmpty(malumot))
            {
                this.malumot=malumot;
                System.Console.WriteLine("Ma'lumot qo'shildi!");
            }
            else
            {
                System.Console.WriteLine("Bo'sh joy bo'lishi mumkin emas!");

            }
        }
        public string GetMalumot()
        {
            return this.malumot;
        }
        public void RemoveMalumot()
        {
            malumot=string.Empty;
            System.Console.WriteLine("Ma'lumot muvaffaqiyatli o'chirildi!");
        }

    }
