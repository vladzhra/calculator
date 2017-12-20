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

            if (InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "÷";
            if (Result.Text == string.Empty)
                return;
            try
            {
                Nombre1 = double.Parse(Result.Text);
                Signe = "÷";
            }
            catch { }

            Result.Text = String.Empty;
        }

        void LessClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "-";
            if (Result.Text == string.Empty)
                return;

            try
            {
                Nombre1 = double.Parse(Result.Text);
                Signe = "-";
            }
            catch { }

            Result.Text = String.Empty;




        }



        void PlusClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "+";
            if (Result.Text == string.Empty)
                return;

            try
            {
                Nombre1 = double.Parse(Result.Text);
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
            InProgress.Text = InProgress.Text + "=";
            try
            {
                Nombre2 = double.Parse(Result.Text);
            }
            catch { }

            double.TryParse(Result.Text, out Nombre2);

            switch (Signe)
            {
                case "+":
                    Result.Text = (Nombre1 + Nombre2).ToString();
                    break;

                case "x":
                    Result.Text = (Nombre1 * Nombre2).ToString();
                    break;

                case "-":
                    Result.Text = (Nombre1 - Nombre2).ToString();
                    break;

                case "÷":
                    Result.Text = (Nombre1 / Nombre2).ToString();
                    break;

                case "^":
                    //var number = Nombre1;
                    //for (int i = 0; i < Nombre2; i++)
                    //    {
                    //    Nombre1 = number + Nombre1;
                    //    }
                    Nombre1 = Math.Pow(Nombre1, Nombre2);
                    Result.Text = Nombre1.ToString();
                    break;
                    Result.Text = String.Empty;
            }

            IsFinish = true;

        }

        void MultiplyClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "x";


            try
            {
                Nombre1 = double.Parse(Result.Text);
                Signe = "x";
            }
            catch { }



            Result.Text = String.Empty;
        }

        void ClearClicked(object sender, EventArgs e)
        {
            InProgress.Text = String.Empty;
            Result.Text = String.Empty;
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
            }
        }

        void PowerClicked(object sender, EventArgs e)
        {
            if (InProgress.Text == string.Empty || InProgress.Text.Last() == 'x' || InProgress.Text.Last() == '+' || InProgress.Text.Last() == '-' || InProgress.Text.Last() == '÷' || InProgress.Text.Last() == '^')
                return;
            InProgress.Text = InProgress.Text + "^";

            

            try
            {
                Nombre1 = double.Parse(Result.Text);
                Signe = "^";
            }
            catch { }

            Result.Text = String.Empty;

         

        }
    }
}

