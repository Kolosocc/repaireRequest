   M S B A M L   `   `   `  ����I  ERepairRequests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RepairRequestsRepairRequests  5   	       RepairRequests.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RepairRequests     5   	     � Title$-  'Учет заявок на ремонт��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ RequestsDataGrid��5         AutoGenerateColumns .  $��10q�5         SelectionMode$ Single=�5         SelectionUnit$ FullRow=�5         
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заявки��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6Y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *	RequestId+6Y     5      $# Дата добавления��6%   $
 Auto 6{   	 6>   �� *	DateAdded+
 �� StringFormat$
 {0:dd.MM.yyyy}��6{     5      $ Тип техники��6%   $
 Auto 6\   	 6:   �� *EquipmentType+6\     5      $ Модель��6%   $ * 6O   	 65   �� *Model+6O     5      $ ФИО клиента��6%   $
 Auto 6Y   	 6:   �� *
ClientName+6Y     5      $ Статус��6%   $
 Auto 6P   	 65   �� *Status+6P   5      �� 5   
   -   5        $#��Добавить заявку��5      $
��Left=�5      $��Bottom=�5      $��10q�5       $	��120��5!      �� 5"   
   -   5         ��Name$ EditRequestButton��5'      $-��'Редактировать заявку��5"      $��Right=�5$      $��Bottom=�5%      $��10q�5&      $y�	Collapsed=�5(      $	��120��5)      5+      5,      