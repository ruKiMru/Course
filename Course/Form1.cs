using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Form1 : Form
    {
        public List<QuestionAnswer> QuestionAnswers { get; set; } //свойства
        public int index = 0;
        public List<string> NumberOfAnswers { get; set; }
        public string Name { get; set; }
        void CheckedAnswer()
        {
            if (radioButton1.Checked)           //запоминаем правильный ответ
            {
                NumberOfAnswers.Add(radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                NumberOfAnswers.Add(radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                NumberOfAnswers.Add(radioButton3.Text);
            }
        }
        void IsEnd()
        {
            if (index == QuestionAnswers.Count)
            {
                Final_window final_Window = new Final_window(QuestionAnswers, NumberOfAnswers, Name);
                final_Window.Show();
                Visible = false;
            }
        }
        void Actions()
        {
            infoGroupBox.Visible = true;
            questionGroupBox.Visible = false;
            infoLabel.Text = QuestionAnswers[index].Information;
            index++;
        }
        public Form1()
        {
            InitializeComponent();
            questionGroupBox.Parent = this;
            infoGroupBox.Parent = this;
            NumberOfAnswers = new List<string>();
            QuestionAnswers = new List<QuestionAnswer>()
            {
                new QuestionAnswer("Слово «экономика» обозначает правила, законы ведения домашнего хозяйства \n(«экос» — дом и «номос» — правило, закон). Сейчас оно имеет более широкое значение. \nТак называют всю хозяйственную деятельность людей, а также науку, которая её изучает. \nНо в целом, экономика – это хозяйство.",
                                    "Что такое экономика?",
                                    new Answer("Экономика - это деньги", false), 
                                    new Answer("Экономика - промышленность",false),
                                    new Answer("Экономика - хозяйство",true) //1
                                   ),
                new QuestionAnswer("Удовлетворение некоторых наших потребностей обеспечивает природа. \nВоздух, вода, тепло и свет солнца, красота окружающего мира — \nвсё это мы получаем непосредственно от природы. \nЛюбовь и заботу близких, дружбу, помощь в трудную минуту мы получаем, общаясь с другими людьми. \nЭкономика нам даёт то, чего нет в природе. \nХлеб и сахар, одежда и обувь, дома и автомобили — это то, что даёт экономика.",
                                    "Без чего не может работать экономика?",
                                    new Answer("Без цен", false),
                                    new Answer("Без денег",true),
                                    new Answer("Без плана",false) //2
                                   ),
                new QuestionAnswer("Деньги – это всеобщая мера стоимости. Они бывают бумажные и металлические и даже пластиковые. \nС помощью них мы можем покупать необходимые нам вещи, покупая игрушку мы совершаем обмен, \nпродавец получает деньги, а мы игрушку.",
                                    "К каким деньгам пришли люди, перепробовав много вариантов?",
                                    new Answer("К резиновым", false),
                                    new Answer("К шерстяным",false),
                                    new Answer("К металлическим",true) //3
                                   ),
                new QuestionAnswer("Большое количество стран, как и в старые времена, пользуются собственными деньгами. \nК примеру, в Казахстане – тэнге, в Белоруссии – белорусский рубль. \nТем не менее, есть государства, которые отказались от собственных денег и ввели валюту, \nодинаковую сразу для нескольких стран. \nК примеру, евро принимается к оплате в разных странах Европы: \nАвстрии, Германии, Испании, Франции и многих других.",
                                    "Как называется валюта России?", 
                                    new Answer("Тенге", false),
                                    new Answer("Рубль",true), //4
                                    new Answer("Доллар",false)
                                   ),
                new QuestionAnswer("Для удовлетворения разнообразных потребностей люди производят товары и услуги. \nТовары — это вещи, с помощью которых люди удовлетворяют свои потребности. \nЭто продукты труда, изготовленные для обмена, продажи: \nпродукты питания, одежда, обувь, мебель, компьютеры, автомобили и многое другое. \nТоварами нас обеспечивают такие отрасли экономики, \nкак промышленность, сельское хозяйство и строительство.",
                                    "Что даёт нам сельское хозяйство?",  
                                    new Answer("Продукты питания (молоко, хлеб, овощи) ", true),
                                    new Answer("Компьютерную технику",false),
                                    new Answer("Дома",false) //5
                                   ),
                new QuestionAnswer("Услуги — это работа, которую выполняют люди, чтобы удовлетворить чьи-нибудь потребности. \nНам нужно постричься в парикмахерской, отремонтировать обувь, \nкомпьютер или автомобиль в мастерской, \nдоехать в другой район города, посмотреть фильм в кинотеатре. Это услуги.",
                                    "Работа, которую люди выполняют, чтобы удовлетворять потребности других людей — это...", //Это услуги
                                    new Answer("Подарки", false),
                                    new Answer("Покупки",false),
                                    new Answer("Услуги",true) //6
                                   ),
                new QuestionAnswer("Что бы иметь деньги, каждый человек должен потрудиться, заработать их. \nПрофессия - деятельность человека, то, чем человек занимается. \nДля получения профессии нужно хорошо учиться, не лениться. Все профессии важны и нужны.",
                                    "Какая из нижеперечисленных профессий относится к сфере услуг?",
                                    new Answer("Инженер", false),
                                    new Answer("Парикмахер",true),
                                    new Answer("Химик",false) //7
                                   ),
                new QuestionAnswer("Бюджет – это деньги, которые есть у человека, но предусмотрены на определенные расходы. \nДаже само слово «бюджет» произошло от старонормандского bougette, что означает кошель, \nсумку или кожаный мешок. \nЛюбой бюджет состоит из доходов и расходов.",
                                    "Как взрослые люди пополняют свой бюджет?",
                                    new Answer("Работая", true),
                                    new Answer("Играя",false),
                                    new Answer("Отдыхая",false) //8
                                   ),
                new QuestionAnswer("Банк – это такой магазин. Продает и покупает деньги. \nСамо слово банк пошло с итальянского - banca – лавка, на которой деньги меняли. \nА если меняла жульничал и обманывал - то делали ему банкрупт - \nломали у всех на глазах его доску и изгоняли с рынка. Отсюда слово банкрот. \nВ банк можно отнести свои деньги и сделать вклад, тогда банк вернёт эти деньги с процентами.",
                                    "Чем занимается банк?",
                                    new Answer("Раздаёт деньги", false),
                                    new Answer("Печатает деньги",false),
                                    new Answer("Хранит деньги",true) //9
                                   ),
                new QuestionAnswer("Если вам нужна крупная сумма денег, чтобы, например, купить дачу с земельным участком, \nквартиру, автомобиль или съездить отдохнуть за границу, \nвы можете взять в банке деньги взаймы или в кредит, \nа потом постепенно возвращать их банку с процентами. \nКредит – это вклад, только процент платят не вам, а вы платите процент банку.",
                                    "Почему банку нужно выплачивать кредит с процентами?",
                                    new Answer("Потому что банк хочет больше денег", false),
                                    new Answer("Это плата за пользование деньгами",true),
                                    new Answer("Этот процент забирает государство",false) //10
                                   ),
            };
        }


        private void info_Click(object sender, EventArgs e)
        {
            infoGroupBox.Text = "";
            infoGroupBox.Visible = false;
            questionGroupBox.Visible = true;
            questionLabel.Text = QuestionAnswers[index-1].Question;
            questionGroupBox.Text = $"Вопрос {index+1}";
            radioButton1.Text = QuestionAnswers[index-1].Answer1.Key;
            radioButton2.Text = QuestionAnswers[index-1].Answer2.Key;
            radioButton3.Text = QuestionAnswers[index-1].Answer3.Key;
            //pictureBox1.BackgroundImage = Image.FromFile($@"C:\Users\user\source\repos\Course\Course\Images\{index}.png");
        }

        private void question_Click(object sender, EventArgs e)
        {
            Actions();

            CheckedAnswer();

            IsEnd();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            textBox1.MaxLength = 19;
            Name = textBox1.Text;
            panel1.Visible = false;
            infoLabel.Text = QuestionAnswers[index].Information;
            index++;
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
        }
    }
}
