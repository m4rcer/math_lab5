using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            float x0 = 0;
            float xn = 1f;
            float y0 = 0;


            var eilerPoints1 = Eiler(10, x0, xn, y0);
            var eilerPoints2 = Eiler(50, x0, xn, y0);
            var eilerPoints3 = Eiler(500, x0, xn, y0);

            var rungeKuttPoints1 = RungeKutt(10, x0, xn, y0);
            var rungeKuttPoints2 = RungeKutt(50, x0, xn, y0);
            var rungeKuttPoints3 = RungeKutt(500, x0, xn, y0);

            string format = "{00.00;-00.00}";


            SeriesCollection series = new SeriesCollection(); //отображение данных на график. Линии и т.д.
            ChartValues<double> zp = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in eilerPoints1) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp.Add(item.Item2);
                        date.Add(item.Item1);
                    }
                }
                catch(Exception e)
                {

                }
            }
            cartesianChart1.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart1.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line.Title = "Y";
            line.Values = zp;

            ChartValues<double> zp2 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date2 = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in rungeKuttPoints1) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp2.Add(item.Item2);
                        date2.Add(item.Item1);
                    }
                }
                catch (Exception e)
                {

                }
            }
            cartesianChart1.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart1.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date2.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line2 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line2.Title = "Y";
            line2.Values = zp2;

            series.Add(line); //Добавляем линию на график
            series.Add(line2); //Добавляем линию на график
            cartesianChart1.Series = series; //Отрисовываем график в интерфейсе





            SeriesCollection series2 = new SeriesCollection(); //отображение данных на график. Линии и т.д.
            ChartValues<double> zp3 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date3 = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in eilerPoints2) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp3.Add(item.Item2);
                        date3.Add(item.Item1);
                    }
                }
                catch (Exception e)
                {

                }
            }
            cartesianChart2.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart2.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date3.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line3 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line3.Title = "Y";
            line3.Values = zp3;

            ChartValues<double> zp4 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date4 = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in rungeKuttPoints2) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp4.Add(item.Item2);
                        date4.Add(item.Item1);
                    }
                }
                catch (Exception e)
                {

                }
            }
            cartesianChart2.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart2.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date4.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line4 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line4.Title = "Y";
            line4.Values = zp4;

            series2.Add(line3); //Добавляем линию на график
            series2.Add(line4); //Добавляем линию на график
            cartesianChart2.Series = series2; //Отрисовываем график в интерфейсе





            SeriesCollection series3 = new SeriesCollection(); //отображение данных на график. Линии и т.д.
            ChartValues<double> zp5 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date5 = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in eilerPoints3) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp5.Add(item.Item2);
                        date5.Add(item.Item1);
                    }
                }
                catch (Exception e)
                {

                }
            }
            cartesianChart3.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart3.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date3.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line5 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line5.Title = "Y";
            line5.Values = zp5;

            ChartValues<double> zp6 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<double> date6 = new List<double>(); //здесь будут храниться значения для оси X
            foreach (var item in rungeKuttPoints3) //Заполняем коллекции
            {
                try
                {
                    if (!double.IsInfinity(item.Item2))
                    {
                        zp6.Add(item.Item2);
                        date6.Add(item.Item1);
                    }
                }
                catch (Exception e)
                {

                }
            }
            cartesianChart3.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart3.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "X",
                Labels = date6.Select(x => decimal.Round((decimal)x, 2).ToString()).ToArray()
            });

            LineSeries line6 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line6.Title = "Y";
            line6.Values = zp6;

            series3.Add(line5); //Добавляем линию на график
            series3.Add(line6); //Добавляем линию на график
            cartesianChart3.Series = series3; //Отрисовываем график в интерфейсе
        }


        (double, double)[] Eiler(int n, float x0, float xn, float y0)
        {
            List<(double, double)> result = new List<(double, double)>();

            double
                 x = x0,
                 y = y0;

            var h = getH(n, x0, xn);

            for (int i = 0; i < n + 1; i++)
            {
                result.Add((x, y));
                y = y + h * f(x, y);
                x += h;
            }

            return result.ToArray();
        }

        (double, double)[] RungeKutt(int n, float x0, float xn, float y0)
        {
            List<(double, double)> result = new List<(double, double)>();

            double
                 x = x0,
                 y = y0;

            var h = getH(n, x0, xn);

            for (int i = 0; i < n + 1; i++)
            {
                result.Add((x, y));
                var k1 = h * f(x, y);
                var k2 = h * f(x + h / 2, y + k1 / 2);
                var k3 = h * f(x + h / 2, y + k2 / 2);
                var k4 = h * f(x + h, y + k3);
                y = y + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x += h;
            }

            return result.ToArray();
        }


        double f(double x, double y)
        {
            return Math.Pow(Math.E, y);
        }

        float getH(int n, float x0, float xn)
        {
            return (xn - x0) / n;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
