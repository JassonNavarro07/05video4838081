namespace _05video4838081
{
    ///<Summary>
    ///<Createddate>29/05/2024</createddate>
    ///<company></company>
    ///<lastmodificationdate>02/06/2024</lastmodificationdate>
    ///<lastmodificationdescription>
    ///
    ///</lastmodificationdescription>
    ///<lastmodifierautor>Jasson Navarro</lastmodifierautor>
    ///</Summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presioname de nuevo";
        }
    }

}
