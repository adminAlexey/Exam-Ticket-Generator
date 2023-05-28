using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class NewQuestions
    {
        public static List<string> newQuestions()//добавление нового вопроса
        {
            return new List<string>();
        }

        public static void printQuestions(List<List<string>> list)//печать списка вопросов
        {
            foreach (var questions in list)
            {
                foreach (var item in questions)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        static void Start()
        {
            List<List<string>> list = new List<List<string>>();//список вопросов 

            list.Add(newQuestions());
            
            list[0].Add("Questions1");
            list[0].Add("Answer1");
            list[0].Add("Answer2");
            list[0].Add("Answer3");
            list[0].Add("Answer4");

            printQuestions(list);
        }
    }
}
