   M S B A M L   `   `   `  ����  FUUniversity     FUUniversity.GiangVienView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quản Lý Giảng Viên��5   	   $	��400��6$   $	��600��61   .��5      � .+�5   
   �� $��Tên:��6   $��	10,10,0,0q�6   $	��Top=�62   $
��Left=�6J   �� 5   
   -   5         ��Name$ 
TenTextBox��5      $��
10,30,10,0q�6&   $	��Top=�6:   $��25��6R   �� 5	   
   $��Chuyên Ngành:��6   $��	10,70,0,0q�6(   $	��Top=�6;   $
��Left=�6S   �� 5
   
   -   5        $ ChuyenNganhTextBox��5
      $��
10,90,10,0q�6.   $	��Top=�6B   $��25��6Z   �� 5   
   -   5        $��Thêm��5      $��10,130,423,0q�6    $	��Top=�66   6N   �� 5   
   -   5        $��Cập Nhật��5      $��228,130,228,0q�6$   $	��Top=�6;   6S   �� 5   
   -   5        $
��Xóa��5      $��427,130,10,0q�6   $	��Top=�65   6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GiangVienGrid��5      $��10,180,10,10q�6*      AutoGenerateColumns$ False��6@      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Giảng Viên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *MaGiangVien+  5      $
 Tên��6%    62   �� *Ten+  5      $ Chuyên Ngành��6%    6;   �� *ChuyenNganh+5      5      5      