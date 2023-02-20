// Автор Кондаков Никита

using System;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Trapezoid //определение пространства имен Trapezoid

{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window// Window - определение класса MainWindow, который наследуется от класса Window.
                                            // Класс Window представляет базовый класс для создания окон приложений Windows.
    {
        public MainWindow()  //конструктор класса MainWindow.
        {
            InitializeComponent(); // метод, который инициализирует компоненты, определенные в XAML-разметке.
        }

        private void Button_Click(object sender, RoutedEventArgs e) //обработчик события нажатия кнопки.
        {
            try //начало блока try-catch для обработки исключений.
            {
                // поле ввода белое - если верно введены данные
                textbox_ab.Background = Brushes.White;
                textbox_bc.Background = Brushes.White;
                textbox_cd.Background = Brushes.White;
                textbox_ad.Background = Brushes.White;

                Trap t1 = new Trap(); // создание нового экземпляра класса Trap.

                t1.set_ab(float.Parse(textbox_ab.Text)); // Обращение к содержимому поля ввода AB
                t1.set_bc(float.Parse(textbox_bc.Text)); // Обращение к содержимому поля ввода BC
                t1.set_cd(float.Parse(textbox_cd.Text)); // Обращение к содержимому поля ввода CD
                t1.set_ad(float.Parse(textbox_ad.Text)); // Обращение к содержимому поля ввода AD

                double per = t1.perimetr(); //вызов метода perimetr() объекта t1 и сохранение результата в переменную per.
                label_per.Content = per.ToString("0.#"); // установка значения свойства Content для элемента Label.

                double sqr = t1.square(); //вызов метода square() объекта t1 и сохранение результата в переменную sqr.
                label_sqr.Content = sqr.ToString("0.#"); // установка значения свойства Content для элемента Label.

                listbox_all.Items.Add("Периметр трапеции=" + per.ToString("0.#") + "; Площадь трапеции= " + sqr.ToString("0.#")); // добавление строки в элемент ListBox.
            }

            catch (ArgumentException) // обработка исключения типа ArgumentException.
            {
                textbox_ab.Background = Brushes.Red; // при ошибке поле ввода красное
                textbox_bc.Background = Brushes.Red; // при ошибке поле ввода красное
                textbox_cd.Background = Brushes.Red; // при ошибке поле ввода красное
                textbox_ad.Background = Brushes.Red; // при ошибке поле ввода красное

                listbox_all.Items.Add("Неверно введенные данные"); // добавление строки в элемент ListBox.
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) // обработчки меню ( о авторе)
        {
            MessageBox.Show("Автор: Кондаков Никита Сергеевич");
        }

        private void button_clear_Click(object sender, RoutedEventArgs e) //обработчик события очистки полей
        {
            listbox_all.Items.Clear(); //очистка листбокса
            label_sqr.Content = ""; //очистка лейбла
            label_per.Content = ""; //очистка лейбла
            textbox_ab.Clear(); //очистка текстбокса
            textbox_bc.Clear(); //очистка текстбокса
            textbox_cd.Clear(); //очистка текстбокса
            textbox_ad.Clear(); //очистка текстбокса
        }
    }
}
