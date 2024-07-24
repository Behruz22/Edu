using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using OquvMarkaz;

class Program
{
  public static void Main(string[] args)
  {
    try
    {
      User user=new User();
      System.Console.WriteLine("Welcome!");
      List<string> Choice = new List<string>{"Admin","O'quvchi","Exit"};
      int cursor=0;
      bool exit=true;
      while(exit)
      {
        Console.Clear();
        for (int i=0;i< Choice.Count;i++)
        {
        if(cursor==i)
          {
          Console.BackgroundColor = ConsoleColor.White;
          Console.ForegroundColor = ConsoleColor.Black;
          }
        System.Console.WriteLine(Choice[i]);
        Console.ResetColor();

        }
        var kl=Console.ReadKey(true);

        if(kl.Key==ConsoleKey.DownArrow)
        {
          cursor = (cursor + 1) % Choice.Count;
        }
        else if(kl.Key==ConsoleKey.UpArrow)
        {
          cursor=(cursor+Choice.Count-1) % Choice.Count;
        }
    else if(kl.Key == ConsoleKey.Enter)
    {
      switch (cursor)
      {
        case 0:
        Console.Clear();
        List<string> AdminList = new List<string>{"Kurslar","Mentorlar","Markaz haqida","Guruh tashkil qilish","Guruhlar ro'yhati","Arizalar","Orqaga"};
        int cursorAdmin=0;
        bool exitAdmin=true;
        while(exitAdmin)
        {
          Console.Clear();
          for(int i=0;i< AdminList.Count;i++)
          {
            if(cursorAdmin==i)
            {
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor= ConsoleColor.Black;
            }
            System.Console.WriteLine(AdminList[i]);
            Console.ResetColor();
          }
          var klAdmin=Console.ReadKey(true);
          if(klAdmin.Key==ConsoleKey.DownArrow)
          {
            cursorAdmin=(cursorAdmin+1) % AdminList.Count;
          }
          else if(klAdmin.Key==ConsoleKey.UpArrow)
          {
            cursorAdmin=(cursorAdmin+AdminList.Count-1) % AdminList.Count;
          }
          else if(klAdmin.Key==ConsoleKey.Enter)
          {
            switch (cursorAdmin)
            {
              case 0:
              List<string> Kurslar=new List<string>(){"Kurs qo'shish","Kursni o'zgartirish","Kursni o'chirish","Kurslar ro'yxati","Orqaga"};
              int cursorKurs=0;
              bool exitKurs=true;
              while(exitKurs)
              {
                Console.Clear();
                for(int i=0;i<Kurslar.Count;i++)
                {
                  if(cursorKurs==i)
                  {
                    Console.BackgroundColor= ConsoleColor.White;
                    Console.ForegroundColor= ConsoleColor.Black;
                  }
                  System.Console.WriteLine(Kurslar[i]);
                  Console.ResetColor();
                }
                var klKurs=Console.ReadKey(true);
                if(klKurs.Key==ConsoleKey.DownArrow)
                {
                  cursorKurs=(cursorKurs+1)% Kurslar.Count;
                }
                else if(klKurs.Key==ConsoleKey.UpArrow)
                {
                  cursorKurs=(cursorKurs+Kurslar.Count-1)% Kurslar.Count;
                }
                else if(klKurs.Key==ConsoleKey.Enter)
                {
                  switch (cursorKurs)
                  {
                    case 0:
                    Console.Clear();
                    System.Console.Write("Kurs nomini kiriting: ");
                    user.AddKurs(Console.ReadLine());
                    Console.ReadKey();
                    break;

                    case 1:
                    Console.Clear();
                    if(user.ToplamKurs.Count>0)
                    {
                    user.ListKurs();
                    System.Console.Write("O'zgartirmoqchi bo'lgan kursni id sini kiriting:");
                    int numberId;
                    bool tF=int.TryParse(Console.ReadLine(), out numberId);
                    if(user.IdTrueOrFalse(numberId))
                    {
                      System.Console.Write("Yangi kurs nomini kiriring: ");
                      user.UpdateKurs(Console.ReadLine(), numberId);
                    }
                    else
                    {
                      System.Console.WriteLine("Bunaqa id li kurs mavjud emas!");
                    }
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali kurslar mavjud emas!");
                    }
                      Console.ReadKey();
                    break;

                    case 2:
                    Console.Clear();
                    if(user.ToplamKurs.Count>0)
                    {
                    user.ListKurs();
                    System.Console.Write("O'chirmoqchi bo'lgan kursni id sini kiriting:");
                    int numberId;
                    bool tF=int.TryParse(Console.ReadLine(), out numberId);
                    if(user.IdTrueOrFalse(numberId))
                    {
                      user.RemoveKurs(numberId);
                    }
                    else
                    {
                      System.Console.WriteLine("Bunaqa id li kurs mavjud emas!");
                    }
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali kurslar mavjud emas!");
                    }
                      Console.ReadKey();
                    break;

                    case 3:
                    Console.Clear();
                    if(user.ToplamKurs.Count>0)
                    {
                    user.ListKurs();
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali kurslar mavjud emas!");

                    }
                    Console.ReadKey();
                    break;
                    case 4:
                    Console.Clear();
                    exitKurs=false;
                    break;
                  }
                }
              }

              break;
              case 1:
              List<string> Mentorlar=new List<string>(){"Mentor qo'shish","Mentorni o'zgartirish","Mentorni o'chirish","Mentorlar ro'yxati","Orqaga"};
              int cursorMentor=0;
              bool exitMentor=true;
              while(exitMentor)
              {
                Console.Clear();
                for(int i=0;i<Mentorlar.Count;i++)
                {
                  if(cursorMentor==i)
                  {
                    Console.BackgroundColor= ConsoleColor.White;
                    Console.ForegroundColor= ConsoleColor.Black;
                  }
                  System.Console.WriteLine(Mentorlar[i]);
                  Console.ResetColor();
                }
                var klMentor=Console.ReadKey(true);
                if(klMentor.Key==ConsoleKey.DownArrow)
                {
                  cursorMentor=(cursorMentor+1)% Mentorlar.Count;
                }
                else if(klMentor.Key==ConsoleKey.UpArrow)
                {
                  cursorMentor=(cursorMentor+Mentorlar.Count-1)% Mentorlar.Count;
                }
                else if(klMentor.Key==ConsoleKey.Enter)
                {
                  switch (cursorMentor)
                  {
                    case 0:
                    Console.Clear();
                    System.Console.Write("Mentor nomini kiriting: ");
                    string name = Console.ReadLine();
                    user.AddMentor(name);
                    Console.ReadKey();
                    break;

                    case 1:
                    Console.Clear();
                    if(user.ToplamMentor.Count>0)
                    {
                    user.ListMentor();
                    System.Console.Write("O'zgartirmoqchi bo'lgan mentorni id sini kiriting:");
                    int numberId;
                    bool tF=int.TryParse(Console.ReadLine(), out numberId);
                    if(user.IdTrueOrFalseMentor(numberId))
                    {
                      System.Console.Write("Yangi mentor nomini kiriring: ");
                      user.UpdateMentor(Console.ReadLine(), numberId);
                    }
                    else
                    {
                      System.Console.WriteLine("Bunaqa id li mentor mavjud emas!");
                    }
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali mentorlar mavjud emas!");
                    }
                      Console.ReadKey();
                    break;

                    case 2:
                    Console.Clear();
                    if(user.ToplamMentor.Count>0)
                    {
                    user.ListMentor();
                    System.Console.Write("O'chirmoqchi bo'lgan kursni id sini kiriting:");
                    int numberId;
                    bool tF=int.TryParse(Console.ReadLine(), out numberId);
                    if(user.IdTrueOrFalseMentor(numberId))
                    {
                      user.RemoveMentor(numberId);
                    }
                    else
                    {
                      System.Console.WriteLine("Bunaqa id li mentor mavjud emas!");
                    }
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali mentorlar mavjud emas!");
                    }
                      Console.ReadKey();
                    break;

                    case 3:
                    Console.Clear();
                    if(user.ToplamMentor.Count>0)
                    {
                    user.ListMentor();
                    }
                    else
                    {
                      System.Console.WriteLine("Afsuski hali mentorlar mavjud emas!");

                    }
                    Console.ReadKey();
                    break;
                    case 4:
                    Console.Clear();
                    exitMentor=false;
                    break;
                  }
                }
              }

              break;
              case 2:
              List<string> MarkazHaqida=new List<string>(){"Markaz haqida fikr qo'shish","Markaz haqida fikrni yangilash","Markaz haqida fikrni o'chirish","Orqaga"};
              int cursorMarkaz=0;
              bool exitMarkaz=true;
              while(exitMarkaz)
              {
                Console.Clear();
                for(int i=0;i<MarkazHaqida.Count;i++)
                {
                  if(cursorMarkaz==i)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                  }
                  System.Console.WriteLine(MarkazHaqida[i]);
                  Console.ResetColor();
                }

              var klMarkaz=Console.ReadKey(true);
              if(klMarkaz.Key==ConsoleKey.DownArrow)
              {
                cursorMarkaz=(cursorMarkaz+1)%MarkazHaqida.Count;
              }
              else if(klMarkaz.Key==ConsoleKey.UpArrow)
              {
                cursorMarkaz=(cursorMarkaz+MarkazHaqida.Count-1)%MarkazHaqida.Count;
              }
              else if(klMarkaz.Key==ConsoleKey.Enter)
              {
                switch (cursorMarkaz)
                {
                  case 0:
                  System.Console.Write("Markaz haqida ma'lumotni kiriting: ");
                  user.MarkazMalumoti(Console.ReadLine());
                  Console.ReadKey();
                  break;
                  case 1:
                  if(!string.IsNullOrEmpty(user.malumot))
                  {
                  System.Console.Write("Markaz haqida amaldagi ma'lumot:");
                  Console.WriteLine(user.GetMalumot()+"\n");
                  System.Console.Write("Markaz haqida yangi ma'lumotni kiriting: ");
                  user.MarkazMalumoti(Console.ReadLine());
                  }
                  else
                  {
                    System.Console.WriteLine("Markaz haqida hali ma'lumot mavjud emas!");
                  }
                  Console.ReadKey();
                  break;
                  case 2:
                  if(!string.IsNullOrEmpty(user.malumot))
                  {
                    user.RemoveMalumot();

                  }
                  else
                  {
                    System.Console.WriteLine("Markaz haqida hali ma'lumot mavjud emas!");
                  }
                  Console.ReadKey();
                  break;
                  case 3:
                  Console.Clear();
                  exitMarkaz=false;
                  break;

                }
              }
              }


              break;
              case 3:
              Console.Clear();
              user.ListKurs();
              System.Console.Write("Kurs id sini kiriting: ");
              int idKurs;
              bool IdTF=int.TryParse(Console.ReadLine(),out idKurs);
              Console.Clear();
              user.ListMentor();
              System.Console.Write("Mentor id sini kiriting: ");
              int idMentor;
              bool IdMentorTF=int.TryParse(Console.ReadLine(), out idMentor);
              user.GuruhAdd(idMentor,idKurs);

              Console.ReadKey();
              break;
              case 4:
              Console.Clear();
              if(user.kursVaMentors.Count>0)
              {
              user.ListKursVaMentor();
              }
              else
              {
                System.Console.WriteLine("Siz hali guruhlar e'lon qilmadingiz!");

              }
              Console.ReadKey();

              break;
              case 5:
              Console.Clear();
              if(user.arizalar.Count>0)
              {
              user.ListArizalar();
              }
              else
              {
                System.Console.WriteLine("Arizalar mavjud emas!");
              }
              Console.ReadKey();
              break;
              case 6:
              Console.Clear();
              exitAdmin=false;
              break;



            }
          }
        }

        break;
        case 1:
        Console.Clear();
        List<string> listOquvchi = new List<string>(){"Kurslar haqida ma'lumot","Mentorlar haqida ma'lumot","Markaz haqida ma'lumotni ko'rish","Ariza topshirish","Orqaga"};
        int cursorOquvchi=0;
        bool exitOquvchi=true;
        while(exitOquvchi)
        {
          Console.Clear();
          for(int i=0;i<listOquvchi.Count;i++)
          {
            if(cursorOquvchi==i)
            {
              Console.BackgroundColor = ConsoleColor.White;
              Console.ForegroundColor = ConsoleColor.Black;
            }
            System.Console.WriteLine(listOquvchi[i]);
            Console.ResetColor();
          }
          var klOquvchi=Console.ReadKey(true);
          if(klOquvchi.Key==ConsoleKey.DownArrow)
          {
            cursorOquvchi=(cursorOquvchi+1)%listOquvchi.Count;
          }
          else if(klOquvchi.Key == ConsoleKey.UpArrow)
          {
            cursorOquvchi=(cursorOquvchi+listOquvchi.Count-1)%listOquvchi.Count;
          }
          else if(klOquvchi.Key==ConsoleKey.Enter)
          {
            switch (cursorOquvchi)
            {
              case 0:
              Console.Clear();
              if(user.ToplamKurs.Count>0)
              {
              System.Console.WriteLine("Kurslar ro'yhati:");
              user.ListKurs();
              }
              else
              System.Console.WriteLine("Markazda hali kurslar mavjud emas!");
              Console.ReadKey();
              break;
              case 1:
              Console.Clear();
              if(user.ToplamMentor.Count>0)
              {
              System.Console.WriteLine("Mentorlar ro'yhati:");
              user.ListMentor();
              }
              else
              {
                System.Console.WriteLine("Markazda hali mentorlar mavjud emas!");
              }
              Console.ReadKey();

              break;
              case 2:
              Console.Clear();
              if(user.malumot!=string.Empty)
              {
              System.Console.Write("Markaz haqida ma'lumot: ");
              Console.WriteLine(user.GetMalumot());
              }
              else
              {
                System.Console.WriteLine("Markaz haqida ma'lumot mavjud emas!");
              }
              Console.ReadKey();
              break;
              case 3:
              Console.Clear();
              if(user.kursVaMentors.Count>0)
              {
                user.ListKursVaMentor();
                System.Console.Write("Guruh id sini kiriting: ");
                int id;
                bool IdTF=int.TryParse(Console.ReadLine(), out id);
                System.Console.Write("Ismingizni kiriting: ");
                user.YangiAriza(id,Console.ReadLine());
              }
              else
              {
                System.Console.WriteLine("MArkazda hali kurslar mavjud emas!");
              }
              Console.ReadKey();
              break;
              case 4:
              Console.Clear();
              exitOquvchi=false;
              break;
            }

          }

        }
        break;
        case 2:
        Console.Clear();
        exit=false;
        break;

      }
    }

    }
    }
    catch (System.Exception ex)
    {
      throw new Exception(ex.Message);
    }


  }


}