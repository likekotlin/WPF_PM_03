   M S B A M L   `   `   `  ����I  ESessia_2_PM_03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sessia_2_PM_03Sessia_2_PM_03  5      %    Sessia_2_PM_03.SupportUsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Sessia_2_PM_03     5        N� Title$  SupportUsersPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��200 �6   .+�5   
   �� $��2��6   $	��Top=�6(   $��28(�6A   $��	26,10,0,0q�6O   $
��Left=�6b   $	��774��6}   /-Поддержка пользователей6�   �� 5   
   $��5,54,0,0q�6   $��14(�6"   $
��Left=�60   $	��Top=�6K   .��6c   Выбор абонента:6t   �� 5   
   $��5,86,0,0q�6   $��14(�6"   $
��Left=�60   $	��Top=�6K   .��6c    Заявки абонента:6u   �� 5   
   -   5         ��Name$ 
ComboUsers��5      $��0��6'   $��
129,58,0,0q�64   $
��Left=�6H   $	��Top=�6c   $	��175��6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SupportGrid��5         AutoGenerateColumns .    
IsReadOnly . $��1��6U   $��0��6b   5      �� 5"   
   -   5         ��Name$ SupInfo��5"      $��1��6%   $��1��65   
������� �� TextAlignment$ Center=�6V   $*��$Информация о заявке��6m   $��14(�6�   $��5,0,5,0q�6�   5$      5%      