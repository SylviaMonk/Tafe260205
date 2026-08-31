using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private async void BtnCalculate_Click(object sender, RoutedEventArgs e)
		{
			double P;
			double annualRate;
			int years;
			int months;

			// ----  PRINCIPAL ----
			try
			{
				P = double.Parse(txtPrincipal.Text);
			}
			catch (FormatException)
			{
				var dialog = new MessageDialog(
					"Please enter a valid number for the Principal borrowed.", "Input Error");
				await dialog.ShowAsync();
				return;  
			}

			// ----  YEARS ----
			try
			{
				years = int.Parse(txtYears.Text);
			}
			catch (FormatException)
			{
				var dialog = new MessageDialog(
					"Please enter a valid whole number for Years.", "Input Error");
				await dialog.ShowAsync();
				return;
			}

			// ----  MONTHS  ----
			try
			{
				if (string.IsNullOrWhiteSpace(txtMonths.Text))
					months = 0;                        
				else
					months = int.Parse(txtMonths.Text);
			}
			catch (FormatException)
			{
				var dialog = new MessageDialog(
					"Please enter a valid whole number or leave it empty.", "Input Error");
				await dialog.ShowAsync();
				return;
			}

			// ----  ANNUAL INTEREST RATE ----
			try
			{
				annualRate = double.Parse(txtAnnualRate.Text);
			}
			catch (FormatException)
			{
				var dialog = new MessageDialog(
					"Please enter a valid number for the Annual Interest Rate.", "Input Error");
				await dialog.ShowAsync();
				return;
			}

			
			double i = (annualRate / 100) / 12;   // monthly interest rate
			int n = (years * 12) + months;        // total number of months

			
			double M = (P * i * Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n) - 1);

			// ---- Ouput ----
			txtMonthlyRate.Text = i.ToString("0.0000");   // monthly interest rate
			txtRepayment.Text = M.ToString("0.00");       // monthly repayment
		}
		
		      // Exit button
		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}


	}
}