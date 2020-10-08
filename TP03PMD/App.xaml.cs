using System;
using TP03PMD.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP03PMD
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new
            Views.Aluno.MainPage());
        }
        static Aluno alunoModel;
        public static Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new Aluno();
                }
                return alunoModel;
            }
        }
    }
}
