
namespace OquvMarkaz
{
    public class Kurs
    {
        public int id  { get; set; }
        public string name { get; set; }

        public static implicit operator Kurs(string v)
        {
            throw new NotImplementedException();
        }

    }
}