   M S B A M L   `   `   `  ����D  @Project22, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project22	Project22  5   	       Project22.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project22     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��80 �6   �� 5      $��10 �6   �� 5      $��80 �6   �� 5      $��10 �6   �� 5      $��80 �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ ConvertButton��5      $��1��6(   $��3��68   $"��Конвертировать��6E   �� 5   
   -   5         ��Name$ 
StringText��5       �� TextAlignment$ Center=�6&    �� TextWrapping$
 Wrap=�6=   $�� ��6Q   $��1��6Y   $��1��6i   �� 5   
   -   5         ��Name$ ConvertResultTextBlock��5      $
��Wrap=�64    �� TextAlignment$ Center=�6H   $�� ��6_   $��1��6g   $��5��6w   5      5      