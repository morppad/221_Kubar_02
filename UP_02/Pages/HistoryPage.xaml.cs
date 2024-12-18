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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static _221_Kubar_02.Connection;
namespace _221_Kubar_02.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage(Partners p)
        {
            InitializeComponent();

            try
            {
                HisrodyGrid.ItemsSource = GetContext().PartnerProducts.Where(x => x.PartnerID==p.PartnerID).ToList();
                Partner.Text=p.CompanyName;
            }
            catch
            {
                
                MessageBox.Show("Ошибка загрузки истории, возможно вы не выбрали, партнера");
                
            }

        }

    }
}
