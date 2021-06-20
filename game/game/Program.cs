using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random ();
            int firstDice;
            int secondDice;
            float heroHP;
            int heroArmor;
            float bossHp;
            int bossArmor;            
            int bossDamage;
            int damageDeathCall;
            int damageBreathOfDeath;
            int damageCallOfFour;
            int damageApocalypse;
            int recoveryDarkRevival;

            Console.WriteLine("Зададим параметры перед игрой");
            Console.WriteLine("Введите количество хп героя");
            heroHP = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите количество брони героя");
            heroArmor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество хп босса");
            bossHp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество брони босса");
            bossArmor = Convert.ToInt32(Console.ReadLine());            
            Console.Clear();

            while (heroHP > 0 && bossHp > 0)
            {
                Console.WriteLine("Да начнётся битва");

                damageBreathOfDeath = rand.Next(30, 70);
                damageApocalypse = rand.Next(50, 100);                

                Console.WriteLine("Первый бросок");
                firstDice = rand.Next(1,6);

                switch (firstDice)
                {
                    case 1:
                        Console.WriteLine("Выпало число " + firstDice);
                        Console.WriteLine("Вы кастуете Призыв Смерти");

                        damageDeathCall = rand.Next(10, 50);
                        bossDamage = rand.Next(1, 70);
                        bossHp -= Convert.ToSingle(damageDeathCall) / 100 * bossArmor;
                        heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                        Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                        Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageDeathCall) / 100 * bossArmor + " урона");
                        Console.WriteLine("У босса осталось " + bossHp);
                        Console.WriteLine("ХП Героя " + heroHP);
                        break;
                    case 2:
                        Console.WriteLine("Выпало число " + firstDice);
                        Console.WriteLine("Пропускаете ход");

                        bossDamage = rand.Next(1, 70);
                        heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                        Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                        Console.WriteLine("У босса осталось " + bossHp);
                        Console.WriteLine("ХП Героя " + heroHP);
                        break;
                    case 3:
                        Console.WriteLine("Выпало число " + firstDice);
                        Console.WriteLine("Вы кастуете Призыв четырёх");

                        damageCallOfFour = rand.Next(20, 60);
                        bossDamage = rand.Next(1, 70);
                        bossHp -= Convert.ToSingle(damageCallOfFour) / 100 * bossArmor;
                        heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                        Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                        Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageCallOfFour) / 100 * bossArmor + " урона");
                        Console.WriteLine("У босса осталось " + bossHp);
                        Console.WriteLine("ХП Героя " + heroHP);
                        break;
                    case 4:
                        Console.WriteLine("Выпало число " + firstDice);
                        Console.WriteLine("Пропускаете ход");

                        bossDamage = rand.Next(1, 70);
                        heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                        Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                        Console.WriteLine("У босса осталось " + bossHp);
                        Console.WriteLine("ХП Героя " + heroHP);
                        break;
                    case 5:
                        Console.WriteLine("Выпало число " + firstDice);
                        Console.WriteLine("Вы кастуете Тёмное возрождение");

                        recoveryDarkRevival = rand.Next(0, 50);
                        bossDamage = rand.Next(1, 70);
                        heroHP += recoveryDarkRevival;
                        heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                        Console.WriteLine("Вы восстанавливаете " + recoveryDarkRevival + " ХП");
                        Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                        Console.WriteLine("У босса осталось " + bossHp);                        
                        Console.WriteLine("ХП Героя " + heroHP);
                        break;
                }

                Console.WriteLine("Второй бросок");
                secondDice = rand.Next(1,6);
                Console.WriteLine("Выпало число " + secondDice);

                if (firstDice == 1 && secondDice == 2)
                {
                    Console.WriteLine("Вы кастуете Дыхание смерти");

                    bossDamage = rand.Next(30, 90);
                    bossHp -= Convert.ToSingle(damageBreathOfDeath) / 100 * bossArmor;
                    heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                    Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                    Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageBreathOfDeath) / 100 * bossArmor + " урона");
                    Console.WriteLine("У босса осталось " + bossHp);
                    Console.WriteLine("ХП Героя " + heroHP);
                }
                else if (firstDice == 3 && secondDice == 4)
                {
                    Console.WriteLine("Вы кастуете Апокалипсис");

                    bossDamage = rand.Next(40, 120);
                    bossHp -= Convert.ToSingle(damageApocalypse) / 100 * bossArmor;
                    heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                    Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                    Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageApocalypse) / 100 * bossArmor + " урона");
                    Console.WriteLine("У босса осталось " + bossHp);
                    Console.WriteLine("ХП Героя " + heroHP);
                }
                else if (firstDice == 2 && secondDice == 1)
                {
                    Console.WriteLine("Вы кастуете Дыхание смерти");

                    bossDamage = rand.Next(30, 90);
                    bossHp -= Convert.ToSingle(damageBreathOfDeath) / 100 * bossArmor;
                    heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                    Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                    Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageBreathOfDeath) / 100 * bossArmor + " урона");
                    Console.WriteLine("У босса осталось " + bossHp);
                    Console.WriteLine("ХП Героя " + heroHP);
                }
                else if (firstDice == 4 && secondDice == 3)
                {
                    Console.WriteLine("Вы кастуете Апокалипсис");

                    bossDamage = rand.Next(40, 120);
                    bossHp -= Convert.ToSingle(damageApocalypse) / 100 * bossArmor;
                    heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                    Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                    Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageApocalypse) / 100 * bossArmor + " урона");
                    Console.WriteLine("У босса осталось " + bossHp);
                    Console.WriteLine("ХП Героя " + heroHP);
                }
                else
                {
                    switch (secondDice)
                    {
                        case 1:
                            Console.WriteLine("Вы кастуете Призыв смерти");

                            damageDeathCall = rand.Next(10, 50);
                            bossDamage = rand.Next(1, 70);
                            bossHp -= Convert.ToSingle(damageDeathCall) / 100 * bossArmor;
                            heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                            Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                            Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageDeathCall) / 100 * bossArmor + " урона");
                            Console.WriteLine("У босса осталось " + bossHp);
                            Console.WriteLine("ХП Героя " + heroHP);
                            break;
                        case 2:
                            Console.WriteLine("Пропускаете ход");

                            bossDamage = rand.Next(1, 70);
                            heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                            Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                            Console.WriteLine("У босса осталось " + bossHp);
                            Console.WriteLine("ХП Героя " + heroHP);
                            break;
                        case 3:
                            Console.WriteLine("Вы кастуете Призыв четырёх");

                            damageCallOfFour = rand.Next(20, 60);
                            bossDamage = rand.Next(1, 70);
                            bossHp -= Convert.ToSingle(damageCallOfFour) / 100 * bossArmor;
                            heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                            Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                            Console.WriteLine("Вы нанесли " + Convert.ToSingle(damageCallOfFour) / 100 * bossArmor + " урона");
                            Console.WriteLine("У босса осталось " + bossHp);
                            Console.WriteLine("ХП Героя " + heroHP);
                            break;
                        case 4:
                            Console.WriteLine("Пропускаете ход");

                            bossDamage = rand.Next(1, 70);
                            heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                            Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                            Console.WriteLine("У босса осталось " + bossHp);
                            Console.WriteLine("ХП Героя " + heroHP);
                            break;
                        case 5:
                            Console.WriteLine("Вы кастуете Тёмное Возрождение");

                            recoveryDarkRevival = rand.Next(0, 50);
                            bossDamage = rand.Next(1, 70);
                            heroHP += recoveryDarkRevival;
                            heroHP -= Convert.ToSingle(bossDamage) / 100 * heroArmor;

                            Console.WriteLine("Вы восстанавливаете " + recoveryDarkRevival + " ХП");
                            Console.WriteLine("Урон босса " + Convert.ToSingle(bossDamage) / 100 * heroArmor);
                            Console.WriteLine("У босса осталось " + bossHp);
                            Console.WriteLine("ХП Героя " + heroHP);
                            break;
                    }
                }                

                Console.WriteLine("Для продолжения нажмите enter");
                Console.ReadKey();
                Console.Clear();                
            }
            if (heroHP < 0)
            {
                Console.WriteLine("Босс победил");
            }
            else if (bossHp < 0)
            {
                Console.WriteLine("Победил Герой");
            }

            Console.ReadKey();
        }
    }
}
