using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Final_window : Form
    {
        public List<Results> Results; //для вывода сохраненного файла
        public int countCorrectAnswers = 0;
        public Final_window()
        {
            InitializeComponent();
        }
        void FileLoad()
        {
            if (File.Exists("topResult.bin"))
            {
                BinaryFormatter openFormatter = new BinaryFormatter();
                FileStream openFileStream = new FileStream("topResult.bin", FileMode.Open, FileAccess.Read);
                Results = (List<Results>)openFormatter.Deserialize(openFileStream);
                openFileStream.Close();
            }
        }

        void CountCorrect(List<QuestionAnswer> questionAnswers, List<string> answers, string name)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (questionAnswers[i].Answer1.Key == answers[i])
                {
                    if (questionAnswers[i].Answer1.Correct)
                    {
                        countCorrectAnswers++;
                    }
                }
                if (questionAnswers[i].Answer2.Key == answers[i])
                {
                    if (questionAnswers[i].Answer2.Correct)
                    {
                        countCorrectAnswers++;
                    }
                }
                if (questionAnswers[i].Answer3.Key == answers[i])
                {
                    if (questionAnswers[i].Answer3.Correct)
                    {
                        countCorrectAnswers++;
                    }
                }
            }
            finalScore.Text = countCorrectAnswers.ToString() + "/" + questionAnswers.Count.ToString();
            Results results = new Results()
            {
                Name = name,
                Count = countCorrectAnswers
            };

            Results.Add(results); //добавление текущего рез-а
            Results = Results.OrderByDescending(x => x.Count).ToList();//сортировка результатов
            dataGridView1.DataSource = Results;
        }

        void SaveFile()
        {
            BinaryFormatter saveFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("topResult.bin", FileMode.OpenOrCreate, FileAccess.Write);
            saveFormatter.Serialize(fileStream, Results);
            fileStream.Close();
        }

        public Final_window (List<QuestionAnswer>questionAnswers,List<string> answers,string name)
        {
            InitializeComponent();
            Results = new List<Results>();

            FileLoad();

            CountCorrect(questionAnswers,answers, name);

            SaveFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("topResult.bin"))
            {
                File.Delete("topResult.bin");
            }
            dataGridView1.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
    }
}
