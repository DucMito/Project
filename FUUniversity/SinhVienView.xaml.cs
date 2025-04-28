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
    /// Interaction logic for SinhVienView.xaml
    /// </summary>
    public partial class SinhVienView : Window
    {
        private readonly SinhVienService _sinhVienService;
        private SinhVien _selectedSinhVien;

        public SinhVienView(SinhVienService sinhVienService)
        {
            InitializeComponent();
            _sinhVienService = sinhVienService;
            LoadSinhViens();
        }

        private void LoadSinhViens()
        {
            SinhVienGrid.ItemsSource = null;
            SinhVienGrid.ItemsSource = _sinhVienService.GetAll();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var sinhVien = new SinhVien
            {
                Ten = TenTextBox.Text,
                Lop = LopTextBox.Text,
                Khoa = KhoaTextBox.Text,
                DiemTrungBinh = decimal.TryParse(DiemTrungBinhTextBox.Text, out decimal diemTrungBinh) ? diemTrungBinh : (decimal?)null
            };

            _sinhVienService.Add(sinhVien);
            LoadSinhViens();
            ClearFields();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedSinhVien == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để cập nhật.");
                return;
            }

            _selectedSinhVien.Ten = TenTextBox.Text;
            _selectedSinhVien.Lop = LopTextBox.Text;
            _selectedSinhVien.Khoa = KhoaTextBox.Text;
            _selectedSinhVien.DiemTrungBinh = decimal.TryParse(DiemTrungBinhTextBox.Text, out decimal diemTrungBinh) ? diemTrungBinh : (decimal?)null;

            _sinhVienService.Update(_selectedSinhVien);
            LoadSinhViens();
            ClearFields();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedSinhVien == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                return;
            }

            _sinhVienService.Delete(_selectedSinhVien.MaSinhVien);
            LoadSinhViens();
            ClearFields();
        }

        private void SinhVienGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedSinhVien = (SinhVien)SinhVienGrid.SelectedItem;
            if (_selectedSinhVien != null)
            {
                TenTextBox.Text = _selectedSinhVien.Ten;
                LopTextBox.Text = _selectedSinhVien.Lop;
                KhoaTextBox.Text = _selectedSinhVien.Khoa;
                DiemTrungBinhTextBox.Text = _selectedSinhVien.DiemTrungBinh?.ToString();
            }
        }

        private void ClearFields()
        {
            TenTextBox.Text = string.Empty;
            LopTextBox.Text = string.Empty;
            KhoaTextBox.Text = string.Empty;
            DiemTrungBinhTextBox.Text = string.Empty;
            _selectedSinhVien = null;
        }
    }
}
