// Автор Кондаков Никита
// Класс Трапеция
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid //определение пространства имен Trapezoid
{
    public class Trap // класс тарпеция
    {
        private double ab_1;   // левая боковая сторона ab 
        private double bc_1;   // верхнее основание bc
        private double cd_1;   // права боковая сторона cd
        private double ad_1;   // нижнее основание ad

        //методы класса

        public Trap() // Конструктор без параметров
        {
            ab_1 = 1;
            bc_1 = 1;
            cd_1 = 1;
            ad_1 = 1;
        }
        public void set_trap(float ab, float bc, float cd, float ad) // Задать трапецию
        {
            set_ab(ab);
            set_bc(bc);
            set_cd(cd);
            set_ad(ad);
        }
        public void set_ab(float ab) // Задать ab
        {
            if (ab < 0) throw new ArgumentException("Invalid argument: ab");
            ab_1 = ab;
        }
        public void set_bc(float bc) // Задать bc
        {
            if (bc < 0) throw new ArgumentException("Invalid argument: bc");
            bc_1 = bc;
        }
        public void set_cd(float cd) // Задать cd
        {
            if (cd < 0) throw new ArgumentException("Invalid argument: cd");
            cd_1 = cd;
        }
        public void set_ad(float ad) // Задать ad
        {
            if (ad < 0) throw new ArgumentException("Invalid argument: ad");
            ad_1 = ad;
        }

        public double get_ab() // Получить сторону ab
        { return ab_1; }

        public double get_bc() // Получить сторону bc
        { return bc_1; }

        public double get_cd() // Получить сторону cd
        { return cd_1; }

        public double get_ad() // Получить сторону ad
        { return ad_1; }

        public double square() // Получить площадь трапеции
        { return (double)(0.5 * (bc_1 + ad_1) * Math.Sqrt(ab_1 * ab_1 - Math.Pow(((bc_1 - ad_1) / 2), 2))); }

        public double perimetr() // Получить периметр трапеции
        { return ab_1 + bc_1 + cd_1 + ad_1; }

    }
}
