﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWejścioweOkno.xaml
    /// </summary>
    public partial class DaneWejścioweOkno : Window
    {
        public double Szczerosc
        {
            get
            {
                return Convert.ToDouble(szeroksc.Text);
            }
        }
        //public double wyskosc
        //{
        //    get => Convert.ToDouble(szeroksc.Text);

        //}
        public double wyskosc => Convert.ToDouble(szeroksc.Text);
        public DaneWejścioweOkno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
