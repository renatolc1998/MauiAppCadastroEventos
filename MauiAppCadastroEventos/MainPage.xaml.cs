using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
                                    
            dtpck_datainicio.MinimumDate = DateTime.Now;            
            dtpck_datatermino.MinimumDate = dtpck_datainicio.Date;
            dtpck_datatermino.MaximumDate = dtpck_datainicio.Date.AddDays(6);


        }

        private async void bnt_avancar_Clicked(object sender, EventArgs e)
        {
            try 
            {
                Evento h = new Evento
                {
                    Nome = txt_nome.Text,
                    DataInicio = dtpck_datainicio.Date,
                    DataTermino = dtpck_datatermino.Date,
                    QntParticipantes = (int)Convert.ToInt64(stp_participantes.Value),
                    Local = txt_local.Text,

                };

                await Navigation.PushAsync(new SecondaryPage() {BindingContext = h});
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "Preencha novamente!");
            }

        }

        private void dtpck_datainicio_DataSelected(object sender, DateChangedEventArgs e) 
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_datatermino.MinimumDate = data_selecionada_checkin.Date;
            dtpck_datatermino.MaximumDate = data_selecionada_checkin.Date.AddDays(6);
        }
    }

}
