﻿//Weekly Comic Listing
//Copyright (C) 2014  Adam Sills

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ComicList {
    /// <summary>
    /// Interaction logic for CreditsDialog.xaml
    /// </summary>
    public partial class CreditsDialog : UserControl {
        public event EventHandler Close = delegate { };

        public CreditsDialog() {
            InitializeComponent();
        }

        private void Button_Click( object sender, RoutedEventArgs e ) {
            Close( this, EventArgs.Empty );
        }

        private void Hyperlink_RequestNavigate( object sender, RequestNavigateEventArgs e ) {
            Process.Start( e.Uri.ToString() );
        }
    }
}
