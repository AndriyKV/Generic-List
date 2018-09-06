using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            List<string> smurfs = new List<string>() { "Papa", "Loser", "Brainy", "Sloppy"};
            smurfs.Add("Lucky"); //добавляємо елемент
            smurfs.AddRange(new string[] { "Sweepy", "Lazy", "Jokey" }); //добавляємо кілька(масив) смурфів
            smurfs.Insert(0, "Smurfette"); //добавляємо Смурфетту першою у списку
            smurfs.RemoveAt(2); //видаляємо 3-го смурфа(Невдаху) із списку
            smurfs.Remove("Lazy"); //видаляємо Лінивого смурфа із списку (bool)
            smurfs.Sort(); //сортуэмо смурфыв по алфавіту
                        
            foreach (string s in smurfs)//перебираємо та виводимо список Смурфів на консоль
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(smurfs.IndexOf("Smurfette"));//виводимо індекс Сурфетти у списку
            Console.WriteLine(smurfs.BinarySearch("Smurfette"));////також виводимо індекс Сурфетти, але список має бути відсортований
            #endregion
            #region 2
            Console.WriteLine("-------------------------");
            //2 випадок, інший конструктор, вказуємо об'єм списку(capacity) = збільшуємо продуктивність та зменшуємо витрати на виділення пам'яті при додаванні елементів
            List<Doctor> doctors = new List<Doctor>(13);
            doctors.Add(new Doctor() { who = "William Hartnell" });
            doctors.Add(new Doctor() { who = "Patrick Troughton" });
            doctors.Add(new Doctor() { who = "Jon Pertwee" });
            doctors.Add(new Doctor() { who = "Tom Baker" });

            foreach (Doctor d in doctors)
            {
                Console.WriteLine(d.who);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
