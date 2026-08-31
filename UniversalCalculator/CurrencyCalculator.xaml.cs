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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyCalculator : Page
	{
		public CurrencyCalculator()
		{
			this.InitializeComponent();
		}

		private void CalculateButton_Click(object sender, RoutedEventArgs e)
		{
			double Input = double.Parse(inputBox.Text);
			double Output = 0;

			//US CONTROLS
			//US Dollar to US Dollar
			if(FromComboBox.SelectedIndex == 0 && ToComboBox.SelectedIndex == 0)
			{
				Output = (Input *  1);
				fromTextBlock.Text = Input + " US Dollars =";
				EqualsTextBlock.Text = Output + " US Dollars";
				Fact1TextBlock.Text = "1 USD = 1 USD";
				Fact2TextBlock.Text = "1 USD = 1 USD";
			}
			//US Dollar to Euro
			else if (FromComboBox.SelectedIndex == 0 && ToComboBox.SelectedIndex == 1)
			{
				Output = (Input * 0.85189982);
				fromTextBlock.Text = Input + " US Dollars =";
				EqualsTextBlock.Text = Output + " Euros";
				Fact1TextBlock.Text = "1 USD = 0.85189982 Euros";
				Fact2TextBlock.Text = "1 Euro = 1.1739732 USD";

			}
			//US Dollar to GBP
			else if (FromComboBox.SelectedIndex == 0 && ToComboBox.SelectedIndex == 2)
			{
				Output = (Input * 0.72872436);
				fromTextBlock.Text = Input + " US Dollars =";
				EqualsTextBlock.Text = Output + " British Pounds";
				Fact1TextBlock.Text = "1 USD = 0.72872436 GBP";
				Fact2TextBlock.Text = "1 GBP = 1.371907 USD";
			}
			//US Dollar to INR
			else if (FromComboBox.SelectedIndex == 0 && ToComboBox.SelectedIndex == 3)
			{
				Output = (Input * 74.257327);
				fromTextBlock.Text = Input + " US Dollars =";
				EqualsTextBlock.Text = Output + " Indian Rupees";
				Fact1TextBlock.Text = "1 USD = 74.257327 INR";
				Fact2TextBlock.Text = "1 INR = 0.011492628 USD";

			}

			//EUR CONTROLS
			//Euro to US Dollar
			if (FromComboBox.SelectedIndex == 1 && ToComboBox.SelectedIndex == 0)
			{
				Output = (Input * 1.1739732);
				fromTextBlock.Text = Input + " Euros =";
				EqualsTextBlock.Text = Output + " US Dollars";
				Fact1TextBlock.Text = "1 Euro = 1.1739732 USD";
				Fact2TextBlock.Text = "1 USD = 0.85189982 Euros";
			}
			//Euro to Euro
			else if (FromComboBox.SelectedIndex == 1 && ToComboBox.SelectedIndex == 1)
			{
				Output = (Input * 1);
				fromTextBlock.Text = Input + " Euros =";
				EqualsTextBlock.Text = Output + " Euros";
				Fact1TextBlock.Text = "1 Euro = 1 Euro";
				Fact2TextBlock.Text = "1 Euro = 1 Euro";
			}
			//Euro to GBP
			else if (FromComboBox.SelectedIndex == 1 && ToComboBox.SelectedIndex == 2)
			{
				Output = (Input * 0.8556672);
				fromTextBlock.Text = Input + " Euros =";
				EqualsTextBlock.Text = Output + " British Pounds";
				Fact1TextBlock.Text = "1 Euro = 0.8556672 GBP";
				Fact2TextBlock.Text = "1 GBP = 1.1686692 Euros";
			}
			//Euro to INR
			else if (FromComboBox.SelectedIndex == 1 && ToComboBox.SelectedIndex == 3)
			{
				Output = (Input * 87.00755);
				fromTextBlock.Text = Input + " Euros =";
				EqualsTextBlock.Text = Output + " Indian Rupees";
				Fact1TextBlock.Text = "1 Euro = 87.00755 INR";
				Fact2TextBlock.Text = "1 INR = 0.013492774 Euros";
			}

			//GBP CONTROLS
			//GBP to US Dollar
			if (FromComboBox.SelectedIndex == 2 && ToComboBox.SelectedIndex == 0)
			{
				Output = (Input * 1.371907);
				fromTextBlock.Text = Input + " British Pounds =";
				EqualsTextBlock.Text = Output + "US Dollars";
				Fact1TextBlock.Text = "1 GBP = 1.371907 USD";
				Fact2TextBlock.Text = "1 USD = 0.72872436 GBP";
			}
			//GBP to Euro
			else if (FromComboBox.SelectedIndex == 2 && ToComboBox.SelectedIndex == 1)
			{
				Output = (Input * 1.1686692);
				fromTextBlock.Text = Input + " British Pounds =";
				EqualsTextBlock.Text = Output + " Euros";
				Fact1TextBlock.Text = "1 GBP = 1.1686692 Euros";
				Fact2TextBlock.Text = "1 Euro = 0.8556672 GBP";
			}
			//GBP to GBP
			else if (FromComboBox.SelectedIndex == 2 && ToComboBox.SelectedIndex == 2)
			{
				Output = (Input);
				fromTextBlock.Text = Input + " British Pounds =";
				EqualsTextBlock.Text = Output + " British Pounds";
				Fact1TextBlock.Text = "1 GBP = 1 GBP";
				Fact2TextBlock.Text = "1 GBP = 1 GBP";
			}
			//GBP to INR
			else if (FromComboBox.SelectedIndex == 2 && ToComboBox.SelectedIndex == 3)
			{
				Output = (Input * 101.68635);
				fromTextBlock.Text =Input + " British Pounds =";
				EqualsTextBlock.Text = Output + " Indian Rupees";
				Fact1TextBlock.Text = "1 GBP = 101.68635 INR";
				Fact2TextBlock.Text = "1 INR = 0.0098339397 GBP";
			}

			//INR CONTROLS
			//INR to US Dollar
			if (FromComboBox.SelectedIndex == 3 && ToComboBox.SelectedIndex == 0)
			{
				Output = (Input * 0.011492628);
				fromTextBlock.Text = Input + " Indian Rupees =";
				EqualsTextBlock.Text = Output + "US Dollars";
				Fact1TextBlock.Text = "1 INR = 0.011492628 USD";
				Fact2TextBlock.Text = "1 USD = 74.257327 INR";
			}
			//INR to Euro
			else if (FromComboBox.SelectedIndex == 3 && ToComboBox.SelectedIndex == 1)
			{
				Output = (Input * 0.013492774);
				fromTextBlock.Text = Input + " Indian Rupees =";
				EqualsTextBlock.Text = Output + " Euros";
				Fact1TextBlock.Text = "1 INR = 0.013492774 Euros";
				Fact2TextBlock.Text = "1 Euro = 87.00755 INR";
			}
			//INR to GBP
			else if (FromComboBox.SelectedIndex == 3 && ToComboBox.SelectedIndex == 2)
			{
				Output = (Input * 0.0098339397);
				fromTextBlock.Text = Input + " Indian Rupees =";
				EqualsTextBlock.Text = Output + " British Pounds";
				Fact1TextBlock.Text = "1 INR = 0.0098339397 GBP";
				Fact2TextBlock.Text = "1 GBP = 101.68635 INR";
			}
			//INR to INR
			else if (FromComboBox.SelectedIndex == 3 && ToComboBox.SelectedIndex == 3)
			{
				Output = Input;
				fromTextBlock.Text = Input + " Indian Rupees =";
				EqualsTextBlock.Text = Output + " Indian Rupees";
				Fact1TextBlock.Text = "1 INR = 1 INR";
				Fact2TextBlock.Text = "1 INR = 1 INR";
			}
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
    }
}
