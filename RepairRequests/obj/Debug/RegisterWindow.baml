   M S B A M L   `   `   `  ����I  ERepairRequests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RepairRequestsRepairRequests  5   	   #    RepairRequests.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RepairRequests     5   	     � Title$  RegisterWindow��5   	   $	��206��6    $	��800��6-   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Логин:��6   $��0��6!   $��0��6.   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��0��6(   $��1��65   $��5q�6E   �� 5   
   $��Пароль:��6   $��1��6"   $��0��6/   G� 5   
   -   5         G�Name$ PasswordBox��5      $��1��6+   $��1��68   $��5q�6H   �� 5   
   $*��$Подтвердите пароль:��6   $��2��6.   $��0��6;   G� 5   
   -   5        $ ConfirmPasswordBox��5      $��2��62   $��1��6?   $��5q�6O   �� 5   
   -   5        $*��$Зарегистрироваться��5      $��3��6K   $��1��6X   $��Right=�6h   $	��120��6�   $��5q�6�   5      5       