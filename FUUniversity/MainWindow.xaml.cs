using FUUniversity.models;
using FUUniversity.repository;
using FUUniversity.service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUUniversity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageGiangVien_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FPTUniversityDBContext())
            {
                IGiangVienRepository giangVienRepository = new GiangVienRepository(context);

                var giangVienService = new GiangVienService(giangVienRepository);

                GiangVienView giangVienView = new GiangVienView(giangVienService);
                giangVienView.Show();
            }
        }

        private void ManageSinhVien_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FPTUniversityDBContext())
            {
                ISinhVienRepository sinhVienRepository = new SinhVienRepository(context);

                var sinhVienService = new SinhVienService(sinhVienRepository);

                SinhVienView sinhVienView = new SinhVienView(sinhVienService);
                sinhVienView.Show();
            }
        }
    }
}