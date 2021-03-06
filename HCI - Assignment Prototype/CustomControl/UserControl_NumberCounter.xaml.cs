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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI___Assignment_Prototype.CustomControl
{
    /// <summary>
    /// Interaction logic for UserControl_NumberCounter.xaml
    /// </summary>
    public partial class UserControl_NumberCounter : UserControl
    {
        public UserControl_NumberCounter()
        {
            InitializeComponent();
        }


        #region Label Property
        public string Label
        {
            get { return (string)GetValue(LabelPropertyProperty); }
            set { SetValue(LabelPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelPropertyProperty =
            DependencyProperty.Register("LabelProperty", typeof(string), typeof(UserControl_NumberCounter), new PropertyMetadata("", LabelPropertyChangeCallBack));

        private static void LabelPropertyChangeCallBack(DependencyObject dependence, DependencyPropertyChangedEventArgs e)
        {
            var d = dependence as UserControl_NumberCounter;
            d.TextBlock_Label.Text = (string)e.NewValue;
        }
        #endregion

        #region SubLabelProperty
        public string SubLabel
        {
            get { return (string)GetValue(SubLabelProperty); }
            set { SetValue(SubLabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubLabelProperty =
            DependencyProperty.Register("SubLabel", typeof(string), typeof(UserControl_NumberCounter), new PropertyMetadata("", SubLabelPropertyChangeCallBack));

        private static void SubLabelPropertyChangeCallBack(DependencyObject dependence, DependencyPropertyChangedEventArgs e)
        {
            var d = dependence as UserControl_NumberCounter;
            d.TextBlock_SubLabel.Text = (string)e.NewValue;
        }

        #endregion

        #region Number Property



        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(UserControl_NumberCounter), new PropertyMetadata(0, NumberEditCallBack));

        private static void NumberEditCallBack(DependencyObject dependence, DependencyPropertyChangedEventArgs e)
        {
            var d = dependence as UserControl_NumberCounter;
            d.TextBlock.Text = ((int)e.NewValue).ToString();
        }




        #endregion

        #region MinimumProperty



        public int Minimum {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty , value); }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum" , typeof(int) , typeof(UserControl_NumberCounter) , new PropertyMetadata(0));

     

        #endregion

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            Number++;
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e) {
            if (Number == Minimum) return;
            Number--;
        }
    }
}

