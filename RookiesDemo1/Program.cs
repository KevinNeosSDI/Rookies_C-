namespace HelloWorld
{
    class Program
    {
        static void IfStatement(int age)
        {
            if (age > 0 && age < 5)
            {
                Console.WriteLine("je suis petit");
            } else if ( age == 5 || age == 33 )
            {
                Console.WriteLine("j'ai 5 ou 33 ans");
            }


            if (age <= 18)
            {
                Console.WriteLine("mineur");
            }
            else if (age < 21)
            {
                Console.WriteLine("mineur en Amérique");
            }
            else if (age == 32)
            {
                Console.WriteLine("vous avez 32 ans");
            }
            else if (age != 66)
            {
                Console.WriteLine("je ne suis pas 66");
            }
            else
            {
                Console.WriteLine("majeur");
            }
        }

        static void SwitchStatement()
        {
            int caseSwitch = new Random().Next(1, 9);
            Console.WriteLine("caseSwitch = {0}", caseSwitch);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1 tutu");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Value didn't match earlier. Default opération");
                    break;
            }
        }



        static void WhileCompteur()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Compteur while = " + i);
                i = i + 3;
            }

            Console.WriteLine("dehors Compteur while final = " + i);
        }

        static void ForCompteur()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tutu");
                Console.WriteLine("Compteur for = " + i);
            }
            Console.WriteLine("fin de boucle for");

        }

        static void ForeachCompteur()
        {
            char[] message = { 'H', 'E', 'L', 'L', 'O' };

            foreach (char c in message)
            {
                Console.WriteLine("lettre = " + c);
            }


        }

        static void DoWhileCompteur()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Compteur dowhile = " + i);
                i = i + 1;
            } while (i < 10);
        }


        static void WhileWithBreak()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Compteur while = " + i);
                if (i == 5)
                {
                    break;
                }
                i += 1;
            }

            Console.WriteLine("BREAK = " + i);
        }

        static void ForWithContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Compteur = " + i);
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("hello");
            }

        }


        static void ArrayExemple()
        {
            int[] userAge = { 21, 23, 22, 25, 24, 26, 20 };

            int[] userAge2;
            userAge2 = new[] { 21, 22, 23, 24, 25 };

            int[] userAge3 = new int[5];

            userAge3[0] = 1;
            userAge3[1] = 2;
            userAge3[2] = 3;
            userAge3[3] = 4;
            userAge3[4] = 5;

            Console.WriteLine("Length userAge = {0}", userAge.Length);

            // Parcourir un array
            //for (int i = 0; i < userAge.Length; i++)
            //{
            //    Console.WriteLine("Array Value = {0} at index {1}", userAge[i], i);
            //}

            ////Propriétés

            //Console.WriteLine("Le nombre d'élément est = " + userAge.Length);

            ////Méthode Sort

            //for (int i = 0; i < userAge.Length; i++)
            //{
            //    Console.WriteLine("Array Value = {0} at index {1}", userAge[i], i);
            //}

            //Array.Sort(userAge);
            //Console.WriteLine("\n\nSort\n\n");

            //for (int i = 0; i < userAge.Length; i++)
            //{
            //    Console.WriteLine("Array Value = {0} at index {1}", userAge[i], i);
            //}

            //// Methode Copy

            //int[] source = { 12, 1, 5, -2, 16, 14 };
            //int[] dest = { 1, 2, 3, 4 };

            //Array.Copy(source, dest, 4);

            //for (int i = 0; i < source.Length; i++)
            //{
            //    Console.WriteLine("Array Value = {0} at index {1}", source[i], i);
            //}

            //Console.WriteLine("\n\nTAB2\n\n");

            //for (int i = 0; i < dest.Length; i++)
            //{
            //    Console.WriteLine("Array Value = {0} at index {1}", dest[i], i);
            //}

            //// Methode IndexOf()

            int[] numbers = { 10, 30, 44, 21, 51, 21, 61, 24, 21, 14, 3000 };

            numbers[10] = 300;
            //numbers[12] = 50; crée une execption OutOfRange

            int ans = Array.IndexOf(numbers, 21);
            Console.WriteLine("ans = {0}", ans);

            ans = Array.IndexOf(numbers, 3000);
            Console.WriteLine("ans = {0}", ans);
        }

        static void StringExemple()
        {
            //string message = "Hello world";

            //Console.WriteLine(message);

            //message = message + " je me nomme kevin";
            //message += " et j'habite à Paris";

            //Console.WriteLine(message);

            //// Length
            //Console.WriteLine("La longeur de message est = {0}", message.Length);

            // SubString

            //string ex1 = "Hello World";

            //string newEx1 = ex1.Substring(2, 5);

            //Console.WriteLine(ex1);
            //Console.WriteLine(newEx1);

            // Equals

            //string ex2 = "tutu";

            //Console.WriteLine(ex2.Equals("toto"));
            //Console.WriteLine(ex2.Equals("tutu"));

            //// Split

            //string names = "Peter, John; Andy, David";
            //string[] separator = { ", ", "; " };
            //string[] substrings = names.Split(separator, StringSplitOptions.None);

            //for (int i = 0; i < substrings.Length; i++)
            //{
            //    Console.WriteLine(substrings[i]);
            //}

        }


        static void ListExemple()
        {
            List<string> list = new List<string>();

            // ADD
            list.Add("tutu");
            list.Add("tueedededu");
            list.Add("tutded");
            list.Add("tut&");
            list.Add("taaaaa");

            // Count / Parcourir une list
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //list.Add("iiiii");
            //list.Add("uuu");
            //list.Add("yyyy");

            //foreach (string value in list)
            //{
            //    Console.WriteLine(value);
            //}

            // Insert

            List<int> userAgeList = new List<int> { 11, 21, 31, 41, 51 };

            //foreach (int value in userAgeList)
            //{
            //    Console.WriteLine(value);
            //}

            userAgeList.Insert(2, 51);

            //foreach (int value in userAgeList)
            //{
            //    Console.WriteLine(value);
            //}

            //// Remove
            userAgeList.Remove(51);
            //foreach (int value in userAgeList)
            //{
            //    Console.WriteLine(value);
            //}

            //// RemoveAt

            userAgeList.RemoveAt(3);
            //foreach (int value in userAgeList)
            //{
            //    Console.WriteLine(value);
            //}

            //// Contains

            //bool res = userAgeList.Contains(45);

            //Console.WriteLine(res);

            //// Clear

            //userAgeList.Clear();
            //foreach (int value in userAgeList)
            //{
            //    Console.WriteLine(value);
            //}
        }


        static void ValuetypeTest(int value)
        {
            value = 1000;
        }

        static void ReferenceTypeTest(ref string tutu)
        {
            Console.WriteLine(tutu);
            tutu = "Jean";
        }

        static void mul(int nb1, int nb2)
        {
            int res = 0;
            bool minor = false;
            
            if (nb1 == 0 || nb2 == 0)
            {
                Console.WriteLine(res);
                return;
            } 

            if (nb1 < 0)
            {
                minor = true;
                nb1 *= -1;
            }
            if (nb2 < 0)
            {
                if (minor == true)
                {
                    minor = false;
                } else
                    minor = true;
                nb2 *= -1;
            }

            for (int i = 0; i < nb1; i++)
            {
                res = res + nb2;
            }

            if (minor == true)
                res = res * -1;
            Console.WriteLine(res);
        }

        static void FindBigNumberInArray(int[] array)
        {

        }
        static void FindBigNumberInList(List<int> list)
        {

        }


        public class Perso
        {
            public string Name { get; }
            public string Email { get; }

            public Perso(string name, string email) => (Name, Email) = (name, email);
        }


        static int returnNB(int tutu)
        {
            Console.WriteLine("nb = {0}", tutu);

            int res = tutu + 10;
            return res;
        }
        static void Main(string[] args)
        {

            //float money = 23.2F;
            //double test = 3000.3;
            //char letter = 'B';
            //bool verif = true;

            int nb = 10; // déclaration
                         //int nb2 = 30;

            //nb = nb + 10;
            //Console.WriteLine(nb);
            //nb = nb - 30;
            //Console.WriteLine(nb);
            //nb = 30;
            //nb = nb / 3;
            //Console.WriteLine(nb);

            //nb = nb % 2;
            //Console.WriteLine(nb);
            //nb = 10;
            //nb = nb * 2; // 20


            ////nb = nb + 10;
            //nb += 10;
            ////nb = nb + 1;
            ////nb += 1;
            //nb++;
            //nb--;
            //nb--;

            // IF ELSE 
            //nb = 33;
            //Console.WriteLine(nb);
            //IfStatement(nb);
            // IF ELSE 


            // SWITCH / CASE

            //SwitchStatement();

            // SWITCH / CASE

            // Boucle for
            // ForCompteur();
            //Boucle for

            // Boucle WHile
            //WhileCompteur();
            // Boucle WHile

            // Boucle ForEach
            //ForeachCompteur();
            // Boucle ForEach

            // DOWHile
            //DoWhileCompteur();
            // DOWHILE

            // COntinue
            //ForWithContinue();
            // COntinue

            // BREAK
            //WhileWithBreak();
            // BREAK

            // EXO1
            //mul(-3, -2);
            // EXO1


            // Array
            // ArrayExemple();
            // Array

            // String
            //StringExemple();
            // String

            // List
            //ListExemple();
            // List


            //Console.WriteLine("Hello from Neos-SDI");
            //Console.WriteLine("valeur de retour {0}", returnNB(nb));
            //string t = "toto";
            //int number = 0;


            //ValuetypeTest(number);
            //Console.WriteLine(number);

            //ReferenceTypeTest(ref t);
            //Console.WriteLine(t);

        }
    }
}

