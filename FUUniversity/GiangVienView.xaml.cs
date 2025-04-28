using FUUniversity.models;
using FUUniversity.service;
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
using System.Windows.Shapes;

namespace FUUniversity
{
    /// <summary>
    /// Interaction logic for GiangVienView.xaml
    /// </summary>
    public partial class GiangVienView : Window
    {
        private readonly GiangVienService _giangVienService;
        private GiangVien _selectedGiangVien;

        public GiangVienView(GiangVienService giangVienService)
        {
            InitializeComponent();
            _giangVienService = giangVienService;
            LoadGiangViens();
        }

        private void LoadGiangViens()
        {
            GiangVienGrid.ItemsSource = null;
            GiangVienGrid.ItemsSource = _giangVienService.GetAll();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var giangVien = new GiangVien
            {
                Ten = TenTextBox.Text,
                ChuyenNganh = ChuyenNganhTextBox.Text
            };

            _giangVienService.Add(giangVien);
            LoadGiangViens();
            ClearFields();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedGiangVien == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên để cập nhật.");
                return;
            }

            _selectedGiangVien.Ten = TenTextBox.Text;
            _selectedGiangVien.ChuyenNganh = ChuyenNganhTextBox.Text;

            _giangVienService.Update(_selectedGiangVien);
            LoadGiangViens();
            ClearFields();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedGiangVien == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên để xóa.");
                return;
            }

            _giangVienService.Delete(_selectedGiangVien.MaGiangVien);
            LoadGiangViens();
            ClearFields();
        }

        private void GiangVienGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedGiangVien = (GiangVien)GiangVienGrid.SelectedItem;
            if (_selectedGiangVien != null)
            {
                TenTextBox.Text = _selectedGiangVien.Ten;
                ChuyenNganhTextBox.Text = _selectedGiangVien.ChuyenNganh;
            }
        }

        private void ClearFields()
        {
            TenTextBox.Text = string.Empty;
            ChuyenNganhTextBox.Text = string.Empty;
            _selectedGiangVien = null;
        }
    }
}
