   M S B A M L   `   `   `  ����X  TWiredBrainCoffee.CustomersApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:WiredBrainCoffee.CustomersApp.Controls&WiredBrainCoffee.CustomersApp.Controls  5      B    <WiredBrainCoffee.CustomersApp.Controls.CustomerDetailControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:WiredBrainCoffee.CustomersApp.Controls     5      -   5          >�Name$
  root��5   7    � 	Resources 5	         myTxtBoxStyle �� 
TargetType  txtBoxStyle �� BasedOn �� Property �� Value��%]   &	        7  �� 5
   
   " ��6&   8   .�5      ��  � ��$
 10 0q�6'   5      5      .��5      �� .+�5   
   �� $��	Firstname��6   $��	5 10 10 0q�6$   �� 5   
   #��[  6   ��5      ��  �� ElementName$
 root�� �� Path$ Customer.FirstName� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5   
   $��Lastname��6   $��	5 10 10 0q�6#   �� 5   
   #��[  6   ��5      �� $
 root��$ Customer.LastName�$ TwoWay=�$	 PropertyChanged=��� 5   
   $��Is developer��6   $��10 20 10 10q�6*   
 d� 	IsChecked
 5      �� $
 root��$ Customer.IsDeveloper�$ TwoWay=�5      5      