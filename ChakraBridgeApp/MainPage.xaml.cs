using ChakraBridge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChakraBridgeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ChakraHost host = new ChakraHost();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            var javascriptFunction = @"function executeScript(){var now = new Date(new Date().getTime() - (7*24*60*60*1000)); return ('0'+now.getDate()).substr(-2)+'-'+('0'+(now.getMonth()+1)).substr(-2)+'-'+now.getFullYear();} executeScript();";
            try
            {
                ChakraHost dateHost = new ChakraHost();
                string dateValue = dateHost.RunScript(javascriptFunction);
                var finalDate = DateTime.ParseExact(dateValue, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                datePicker.Date = finalDate.Date;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}