   M S B A M L   `   `   `  ����X  TWiredBrainCoffee.CustomersApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:WiredBrainCoffee.CustomersApp.Model#WiredBrainCoffee.CustomersApp.Model  5   	   M+clr-namespace:WiredBrainCoffee.CustomersAppWiredBrainCoffee.CustomersApp  5   	   _4clr-namespace:WiredBrainCoffee.CustomersApp.Controls&WiredBrainCoffee.CustomersApp.Controls  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	   .    (WiredBrainCoffee.CustomersApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Cmodel1clr-namespace:WiredBrainCoffee.CustomersApp.Model     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WiredBrainCoffee.CustomersApp     5   	   Icontrols4clr-namespace:WiredBrainCoffee.CustomersApp.Controls     5   	   9system&clr-namespace:System;assembly=mscorlib     5	   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5!   
   �� ���#F05A28 �� Orientation$ 
Horizontal=�5"      $��0��5#      $��0��5$      $��3��5%      .+�5&      �� $��/images/logo.png��6   $��90��6.   $��5q�6:   �� 5'        applicationTitle#��[ 6   $��30(�5(      $��	ExtraBold"�5)      
�������$��Bottom=�5+      $��20q�5,      �� 5-      $��Version 1.0.0��6   ���#333333$��Bottom=�5/      $��0 0 0 25q�50      51      � 5:   
   -   5         �Name$ gridCustomerList��5<      $��1��5:      $��0��5;        customerListBackgroundBrush#��[ 5=       5A      �� 5B      $
��Auto �6    �� 5C      $��* �6    .+�5F      �� $��0��6   $ 
Horizontal=�6&   .+�5G      �� -   5        $
��Left=�5G      $��Center=�5H      $��10q�5I      $��30��5J      $��30��5K      .��5M      �� $ 
Horizontal=�6!   .+�5N      �� -   5         ��Name$ leftRightIconImg��5N       $"��assets/icons/arrow_right.png��6:   $��20��6`   $��20��6l   5O      5P      �� 5Q      $
��Left=�6   $��Center=�5R      $��10q�5S      $��65��5T      $��30��5U      ��5V      �� *AddCustomerCommand+.��5W      �� $ 
Horizontal=�6!   .+�5X      �� $!��assets/icons/add_friend.png��6    $��20��6E   $��20��6Q   �� 5Y      $	��Add��6$   $��5 0 0 0q�6/   5Z      5[      �� 5\      $
��Left=�6   $��Center=�5]      $��10q�5^      $��65��5_      $��30��5`      ��5a      �� *DeleteCustomerCommand+.��5b      �� $ 
Horizontal=�6!   .+�5c      �� $��assets/icons/delete4.png��6    $��20��6B   $��20��6N   �� 5d      $��Delete��6$   $��5 0 0 0q�62   5e      5f      5g      �� 5h      $��1��6   ��6$   ��  �� Path$ 	Customers�	 �� Mode$	 OneWay=�
 �� SelectedItem
 5i      �� $ SelectedCustomer�$	 TwoWay=���5j      �� 5k      .R�5l      �� $ 
Horizontal=�6%   .+�5m      �� $
��Bold"�6U   ��6(   �� $ 	FirstName�$	 OneWay=�6U   �� 5n      $��5 0 0 0q�6T   ��6(   �� $ LastName�$	 OneWay=�6T   �� 5o      $��(Developer)��6(   $��5 0 0 0q�6;    J� Opacity$	 0.5Q�6L   y�5p   (   �� $ IsDeveloper�$	 OneWay=� �� 	Converter# [  5q      5r      5t      5v      B   <WiredBrainCoffee.CustomersApp.Controls.CustomerDetailControl  5x   
   $��1��6)   $��1��66      Customer 5y   )   �� $ SelectedCustomer�$	 OneWay=�y�5z   )   �� $ IsCustomerSelected�$	 OneWay=�# [  5|      5}      