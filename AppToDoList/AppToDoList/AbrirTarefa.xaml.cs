using AppToDoList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppToDoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbrirTarefa : ContentPage
    {
        public AbrirTarefa()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Tarefa t = new Tarefa
            {
                Id = Convert.ToInt16(lbl_id.Text),
                Descricao = txt_descricao.Text,
                Valor_Estimado = txt_valorestimado.Text,
                Valor_Pago = txt_valorpago.Text


            };

            await App.Database.Update(t);

            await DisplayAlert("Sucesso", "Atualizado no Banco de Dados", "Feito");

            await Navigation.PushAsync(new Listagem());
        }
    }
}