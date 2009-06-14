﻿using doru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using CounterStrikeLive.Service;

namespace CounterStrikeLive
{
    
    public partial class MapSelect : ChildWindow
    {
        
        public MapSelect()
        {
            
            InitializeComponent();
            Loaded += new RoutedEventHandler(MapSelect_Loaded);            
        }
        
        
        
        public string MapName
        {
            get
            {
                if (ListBox1.SelectedItem == null) return (ListBox1.Items[0] as Service.Map).MapName;
                return (ListBox1.SelectedItem as Service.Map).MapName;
            }
        }

        void MapSelect_Loaded(object sender, RoutedEventArgs e)
        {
            
            ListBox1.ItemsSource = Config._This._Maps;
            
            //Common._XmlSerializer.Deserialize(
            //ListBox1.DataContext
        }
        
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox1.SelectedItem == null)
                ListBox1.SelectedIndex = 1;
            
            this.DialogResult = true;
        }

        
    }
}
