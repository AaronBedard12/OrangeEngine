using System;
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

namespace OrangeEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }
        private async void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            int thickness;

            if (sender == openProjectButton)
            {
                if (createProjectButton.IsChecked == true)
                {
                    thickness = -800;
                    createProjectButton.IsChecked = false;

                    while (thickness < 0)
                    {
                        browserContent.Margin = new Thickness(thickness, 0, 0, 0); // Adjust Thickness as needed
                        thickness += 40;
                        await Task.Delay(10); // Add a small delay to allow the UI to update
                    }
                }
                openProjectButton.IsChecked = true;
            }
            else
            {
                if (openProjectButton.IsChecked == true)
                {
                    thickness = 0;
                    openProjectButton.IsChecked = false;

                    while (thickness > -825)
                    {
                        browserContent.Margin = new Thickness(thickness, 0, 0, 0); // Adjust Thickness as needed
                        thickness -= 40;
                        await Task.Delay(10); // Add a small delay to allow the UI to update
                    }
                }
                createProjectButton.IsChecked = true;
            }
        }
    }
}
