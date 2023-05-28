using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            
        }

        private void Export_Click(object sender, EventArgs e)
        {
            int count = 0;

            string templateFileName = @"D:\Учеба\Научная практика третий курс\template.docx";
            string pathLogo = @"D:\Учеба\Научная практика третий курс\logo.jpg"; 

            string header = Header.Text;
            string faculty = Faculty.Text;
            string department = Department.Text;
            string discipline = Discipline.Text;
            string studyYear = StudyYear.Text;
            string departmentChief = DepartmentChief.Text;

            Word.Application app = new Word.Application();//создали приложение
            Document doc = app.Documents.Add(templateFileName,Visible: false);//создали документ
            Range range = doc.Range();

            InlineShape pictureShape = range.InlineShapes.AddPicture(pathLogo);

            List<string> questions = new List<string>();
            for (int r = 0; r < listQuestions.Lines.Length; r++)
            {
                if (listQuestions.Lines[r] != "")
                {
                    questions.Add(listQuestions.Lines[r]);
                }
            }
            if (QuestionsCount.Value * TicketsCount.Value != questions.Count)
            {
                MessageBox.Show("Количество вопросов не подходит под заданные параметры количества билетов и количества вопросов внутри каждого билета");
            }
            //рандомизировать список
            Random random = new Random();
            List<string> questions2 = questions.OrderBy(x => random.Next()).ToList();

            ReplaceWordStub("{header}", header, doc);
            ReplaceWordStub("{faculty}", faculty, doc);
            ReplaceWordStub("{department}", department, doc);
            ReplaceWordStub("{studyYear}", studyYear, doc);
            ReplaceWordStub("{discipline}", discipline, doc);

            //создать здесь шаблон
            Object begin = Type.Missing;
            Object end1 = Type.Missing;
            Object start, stop;
            range = doc.Range(ref begin, ref end1);

            range.Select();
            range.Copy();

            for (int i = 1; i < TicketsCount.Value; i++)
            {                
                ReplaceWordStub("{number}", i.ToString(), doc);
                string question = "";
                for (int j = 1; j < QuestionsCount.Value; j++)
                {
                    count++;
                    question = "\r" + j + ". " + questions2.ElementAt(count - 1) + "{text}";
                    ReplaceWordStub("{text}", question, doc);
                }
                count++;
                question = "\r" + QuestionsCount.Value + ". " + questions2.ElementAt(count - 1);
                ReplaceWordStub("{text}", question, doc);

                //вставить шаблон
                stop = doc.Content.End;
                start = doc.Content.End - 1;
                range = doc.Range(ref start, ref stop);
                range.Select();
                range.Paste();
            }

            doc.SaveAs(@"D:\result.docx");
            doc.Close();//закрыли документ
            app.Quit();//закрыли приложение
            MessageBox.Show("Успешно!","Сообщение");
        }

        private void ReplaceWordStub(string stubToReplace, string text, Document doc)
        {
            Range range = doc.Range();
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
