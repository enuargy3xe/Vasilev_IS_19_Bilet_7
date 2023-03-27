using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace Vasilev_IS_19_Bilet_7
{
    public partial class Form1 : Form
    {
        Word._Application oWord = new Word.Application(); //Создание объекта Word

        //Модель данных Представлений
        public class Perfomance
        {
            public string Title { get; set; }
            public decimal Price { get; set; }

            public Perfomance(string _title,decimal _price)
            {
                this.Title = _title;
                this.Price = _price;
            }
        }

        public decimal selectedPerfomancePrice; //Цена представления
        public int percentBySelectedPlace = 0; //Стоимость за места
        public int ticketsAmount; //Количество билетов
        public string selectedPerfomanceName; //Наименование представления

        public Bitmap perfomanceImage; //Изображение в зависимости от представления

        public string savePath = null;

        public Form1()
        {
            InitializeComponent();

            amountInput.Controls[0].Visible = false; //Отключение стрелок для NumericUpDown

            //Лист Представлений
            List<Perfomance> listOfPerfomance = new List<Perfomance>();

            listOfPerfomance.Add(new Perfomance("Красная шапочка", 700));
            listOfPerfomance.Add(new Perfomance("Летучий корабль", 1200));
            listOfPerfomance.Add(new Perfomance("Лебединое озеро", 1600));
            listOfPerfomance.Add(new Perfomance("Донкихот", 2100));
            listOfPerfomance.Add(new Perfomance("Алые паруса", 900));
            listOfPerfomance.Add(new Perfomance("Щелкунчик", 650));

            //Привязка данных из листа представлений к ComboBox
            var bindingSrc = new BindingSource();
            bindingSrc.DataSource = listOfPerfomance;

            perfomanceSelector.DataSource = bindingSrc;
            perfomanceSelector.DisplayMember = "Title"; //Отображаемое наименование элемента
            perfomanceSelector.ValueMember = "Price"; //Значение для элемента
            

            
        }

        private void perfomanceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получение новго объекта класса из combobox
            Perfomance selectedPerfomance = (Perfomance)perfomanceSelector.SelectedItem;
            selectedPerfomancePrice = selectedPerfomance.Price;
            selectedPerfomanceName = selectedPerfomance.Title;

            //Получение изображения по названию представления
            try
            {
                perfomanceImage = new Bitmap(Image.FromFile(Environment.CurrentDirectory + "\\..\\.\\Resources\\" + selectedPerfomanceName + ".jpg"));
            }
            catch
            {
                //Попытка получения изображения с другим расширением
                perfomanceImage = new Bitmap(Image.FromFile(Environment.CurrentDirectory + "\\..\\.\\Resources\\" + selectedPerfomanceName + ".jpeg"));
            }
        }

        //VIP места
        private void VipRB_CheckedChanged(object sender, EventArgs e)
        {
            percentBySelectedPlace = 50;
        }

        //Партер
        private void ParterRB_CheckedChanged(object sender, EventArgs e)
        {
            percentBySelectedPlace = 7;
        }

        //Балкон
        private void BalconRB_CheckedChanged(object sender, EventArgs e)
        {
            percentBySelectedPlace = 20;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!AmountCheck(amountInput.Value)) //Вызов метода для валидации поля ввода количества билетов
            {
                MessageBox.Show("Не верно заполнено количество билетов");
            }
            else
            {
                try
                {
                    ticketsAmount = Convert.ToInt32(amountInput.Value);
                }
                catch
                {
                    MessageBox.Show("Не верно заполнено количество билетов");
                }
            }
            

            outPutLabel.Text = CalculateSumm(selectedPerfomancePrice, percentBySelectedPlace, ticketsAmount).ToString();
            pictureBox1.Image = perfomanceImage;
        }

        public static decimal CalculateSumm(decimal price,int percentByPlace,int amount)
        {
            decimal summ = 0;
            int discount = 0;

            //Расчет скидки исходя из количества билетов
            if(amount > 10 && amount <= 15)
            {
                discount = 5;
            }
            else if(amount > 15 && amount <= 20)
            {
                discount = 7;
            }
            else if(amount > 20 && amount <= 30)
            {
                discount = 10;
            }
            else if(amount > 30)
            {
                discount = 25;
            }

            summ = amount * price; //Сумма без скидок и учета Особых мест
            summ += summ / 100 * percentByPlace; //Сумма с учетом выбранного места
            summ -= summ / 100 * discount; //Сумма с учетом скидки за количество билетов

            return summ;
        }

        private Word._Document GetDoc(string path)
        {
            Word._Document oDoc = oWord.Documents.Add(path); //Получение экземпляра документа
            SetBookmarks(oDoc); //Вызов метода для установки закладок
            return oDoc;
        }

        private void SetBookmarks(Word._Document oDoc) //Установка значений для закладок в Word документе
        {
            Random rnd = new Random();
            string uniqNumber = rnd.Next(1, 101).ToString() + "_" + rnd.Next(1001, 9999).ToString(); //Присвоение значения уникального номера
            string summ = CalculateSumm(selectedPerfomancePrice, percentBySelectedPlace, ticketsAmount).ToString();

            oDoc.Bookmarks["uniqueNumber"].Range.Text = rnd.Next(1, 101).ToString() + "_" + rnd.Next(1001, 9999).ToString();
            oDoc.Bookmarks["receipTitle"].Range.Text = selectedPerfomanceName;
            oDoc.Bookmarks["receipSumm"].Range.Text = summ;
            oDoc.Bookmarks["receipDate"].Range.Text = Convert.ToString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            //Запись путя для сохранения чека с учетом названия новго чека
            savePath = Environment.CurrentDirectory + "\\..\\Receips\\" + uniqNumber + "_" + DateTime.Now.ToShortDateString() + "_" + summ + ".docx";
        }

        private void confirmReceipButton_Click(object sender, EventArgs e)
        {

            Word._Document oDoc = GetDoc(Environment.CurrentDirectory + "\\..\\Receips\\чек.docx");
            oDoc.SaveAs(FileName: savePath);
            oDoc.Close();
            Process.Start(savePath); //Открытие сохраненного чека
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        public static bool AmountCheck(decimal amount) //Проверка введеных значений в поле ввода количества
        {
            bool result = true;

            if(amount < 1) //Проверка значение на 0 или отрицательное число
            {
                result = false;
            }
            if(amount > 100) //Максимальное значение
            {
                result = false;
            }
            if(amount != Math.Round(amount)) //Проверка на целостность числа
            {
                result = false;
            }

            return result;
        }

        private void UploadImage() //Метод для добавления изображения
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выбрать изображение";
            openFileDialog.Filter = "Все поддерживаемые форматы изображений|*.jpg;*.jpeg;*.png|" +
                            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                             "Portable Network Graphic (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap receivedImage = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    string svPath = Environment.CurrentDirectory + "\\..\\Resources\\" + System.IO.Path.GetFileName(openFileDialog.FileName);
                    using (receivedImage)
                    {
                        receivedImage.Save(svPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выбор изображения был отменен");
            }
        }


    }
}
