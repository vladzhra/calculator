using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace decemberapp
{
    public partial class MainPage : ContentPage
    {
        double Nombre1;
        double Nombre2;
        String Signe;
        bool IsFinish;
        bool IsCalculContinue;

        public MainPage()
        {
            InitializeComponent();
        }

        void OneClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "1";
            Result.Text = Result.Text + "1";
        }

        void TwoClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "2";
            Result.Text = Result.Text + "2";
        }

        void ThreeClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "3";
            Result.Text = Result.Text + "3";
        }

        void FourClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "4";
            Result.Text = Result.Text + "4";
        }

        void FiveClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "5";
            Result.Text = Result.Text + "5";
        }

        void SixClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "6";
            Result.Text = Result.Text + "6";
        }

        void SevenClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "7";
            Result.Text = Result.Text + "7";
        }

        void EightClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "8";
            Result.Text = Result.Text + "8";
        }

        void NineClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "9";
            Result.Text = Result.Text + "9";
        }

        void ZeroClicked(object sender, EventArgs e)
        {
            NewCalcul();
            InProgress.Text = InProgress.Text + "0";
            Result.Text = Result.Text + "0";
        }

        void PercentageClicked(object sender, EventArgs e)
        {

            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            CalculContinue();
            InProgress.Text = InProgress.Text + "÷";
            if (Result.Text == string.Empty)
                return;
            try
            {
                if (IsCalculContinue)
                {
                    Nombre2 = double.Parse(Result.Text);
                }
                else
                {
                    Nombre1 = double.Parse(Result.Text);
                    IsCalculContinue = true;
                }
                Signe = "÷";
            }
            catch { }

            Result.Text = String.Empty;
        }

        void LessClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            CalculContinue();
            InProgress.Text = InProgress.Text + "-";
            if (Result.Text == string.Empty)
                return;

            try
            {
                if (IsCalculContinue)
                {
                    Nombre2 = double.Parse(Result.Text);
                }
                else
                {
                    Nombre1 = double.Parse(Result.Text);
                    IsCalculContinue = true;
                }
                Signe = "-";
            }
            catch { }

            Result.Text = String.Empty;
        }

        void PlusClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            CalculContinue();
            InProgress.Text = InProgress.Text + "+";
            if (Result.Text == string.Empty)
                return;

            try
            {
               if (IsCalculContinue)
                {
                    Nombre2 = double.Parse(Result.Text);                     
                }
                else
                {
                    Nombre1 = double.Parse(Result.Text);
                    IsCalculContinue = true;
                }
                Signe = "+";
            }
            catch { }

            Result.Text = String.Empty;
        }

        void CommaClicked(object sender, EventArgs e)
        {
            InProgress.Text = InProgress.Text + ",";
            Result.Text = Result.Text + ",";
            if (InProgress.Text == string.Empty || InProgress.Text.Last() == ',') ;
        }

        void CalculClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "=";

            CalculContinue();
            IsFinish = true;
            Result.Text = Nombre1.ToString();
        }

        void CalculContinue()
        {
            double.TryParse(Result.Text, out Nombre2);

            switch (Signe)
            {
                case "+":
                    Nombre1 = (Nombre1 + Nombre2);
                    break;
                case "x":
                    Nombre1 = (Nombre1 * Nombre2);
                    break;
                case "-":
                    Nombre1 = (Nombre1 - Nombre2);
                    break;
                case "÷":
                    Nombre1 = (Nombre1 / Nombre2);
                    break;
                case "^":
                    Nombre1 = Math.Pow(Nombre1, Nombre2);
                    break;
            }
            Nombre2 = 0;
            Signe = String.Empty;
            if (IsCalculContinue)
            InProgress.Text = Nombre1.ToString();
        }

        void MultiplyClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            CalculContinue();
            InProgress.Text = InProgress.Text + "x";

            try
            {
                if (IsCalculContinue)
                {
                    Nombre2 = double.Parse(Result.Text);                     
                }
                else
                {
                    Nombre1 = double.Parse(Result.Text);
                    IsCalculContinue = true;
                }
                Signe = "x";
            }
            catch { }

            Result.Text = String.Empty;
        }

        void ClearClicked(object sender, EventArgs e)
        {
            IsFinish = false;
            Nombre1 = 0;
            Nombre2 = 0;
            Signe = String.Empty;
            Result.Text = String.Empty;
            InProgress.Text = String.Empty;
            IsCalculContinue = false;
        }

        void NewCalcul()
        {
            if (IsFinish)
            {
                IsFinish = false;
                Nombre1 = 0;
                Nombre2 = 0;
                Signe = String.Empty;
                Result.Text = String.Empty;
                InProgress.Text = String.Empty;
                IsCalculContinue = false;
            }
        }

        void PowerClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == null || InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            CalculContinue();
            InProgress.Text = InProgress.Text + "^";

            try
            {
                if (IsCalculContinue)
                {
                    Nombre2 = double.Parse(Result.Text);
                }
                else
                {
                    Nombre1 = double.Parse(Result.Text);
                    IsCalculContinue = true;
                }
                Signe = "^";
            }
            catch { }

            Result.Text = String.Empty;
        }
    }
}
