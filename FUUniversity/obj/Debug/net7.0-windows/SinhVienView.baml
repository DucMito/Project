   M S B A M L   `   `   `  ����  FUUniversity    FUUniversity.SinhVienView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quản Lý Sinh Viên��5   	   $	��400��6#   $	��600��60   .��5      � .+�5   
   �� $��Tên:��6   $��	10,10,0,0q�6   $	��Top=�62   $
��Left=�6J   �� 5   
   -   5         ��Name$ 
TenTextBox��5      $��
10,30,10,0q�6&   $	��Top=�6:   $��25��6R   �� 5	   
   $��Lớp:��6   $��	10,70,0,0q�6   $	��Top=�62   $
��Left=�6J   �� 5
   
   -   5        $ 
LopTextBox��5
      $��
10,90,10,0q�6&   $	��Top=�6:   $��25��6R   �� 5   
   $��Khoa:��6   $��
10,130,0,0q�6    $	��Top=�64   $
��Left=�6L   �� 5   
   -   5        $ KhoaTextBox��5      $��10,150,10,0q�6'   $	��Top=�6<   $��25��6T   �� 5   
   $��Điểm Trung Bình:��6   $��
10,190,0,0q�6+   $	��Top=�6?   $
��Left=�6W   �� 5   
   -   5        $ DiemTrungBinhTextBox��5      $��10,210,10,0q�60   $	��Top=�6E   $��25��6]   �� 5   
   -   5        $��Thêm��5      $��10,250,500,0q�6    $	��Top=�66   6N   �� 5   
   -   5        $��Cập Nhật��5      $��241,250,241,0q�6$   $	��Top=�6;   6S   �� 5   
   -   5        $
��Xóa��5      $��458,250,10,0q�6   $	��Top=�65   6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SinhVienGrid��5      $��10,300,10,10q�6)      AutoGenerateColumns$ False��6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Sinh Viên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
MaSinhVien+  5      $
 Tên��6%    62   �� *Ten+  5      $ Lớp��6%    62   �� *Lop+  5      $
 Khoa��6%    63   �� *Khoa+  5      $ Điểm Trung Bình��6%    6>   �� *DiemTrungBinh+5      5      5       