   M S B A M L   `   `   `  ����\  XAirConditionerShop_NguyenThanhNam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:AirConditionerShop_NguyenThanhNam!AirConditionerShop_NguyenThanhNam  5   	   2    ,AirConditionerShop_NguyenThanhNam.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:AirConditionerShop_NguyenThanhNam     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���	#FFD4F7D4 � WindowStartupLocation$ CenterScreen=�5	   	   $��Arial)�6.   $��14(�6A    � 
ResizeMode$ NoResize=�6O   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AirConsDataGrid��5      $��37,126,185,29q�6,      AutoGenerateColumns$ False��6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *AirConditionerId+  5      $ Air Con Name��6%   $	 140 6;    6G   �� *AirConditionerName+  5      $ Warranty��6%   $ 70 67    6B   �� *
Warranty+  5      $ Sound Level��6%   $ 70 6:    6E   �� *SoundPressureLevel+  5      $ Fearture Function��6%   $ 70 6@    6K   �� *FeatureFunction+  5      $ Quantity��6%   $ 70 67    6B   �� *
Quantity+  5      $ Price($)��6%   $ 70 67    6B   �� *DollarPrice+  5      $ Supplier Id��6%   $ 70 6:    6E   �� *
SupplierId+  5      $ Supplier Name��6%   $ 70 6<    6G   �� *Supplier.SupplierName+5      �� 5   
   -   5        	 ��Name$	 SearchButton��5      $��Search Air Conditioner��6'   $
��Left=�6H   $��	36,57,0,0q�6c   $	��Top=�6v      ButtonStyle#��[  6�   $	��168��6�   6�   �� 5   
   -   5        
 ��Name$
 FeatureTextBox��5      $
��Left=�6*   $��
344,59,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��120��6�     TextBoxStyle#��[ 6�   $��38��6�   �� 5   
   $��Feature Function��6   $
��Left=�6+   $��
223,64,0,0q�6F   $	��Top=�6Z     
LabelStyle#��[ 6r   �� 5   
   $��Quantity��6   $
��Left=�6#   $��
584,66,0,0q�6>   $	��Top=�6R   #��[ 6j   �� 5   
   -   5        $
 QuantityTextBox��5      $
��Left=�6+   $��
651,59,0,0q�6F   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   #��[ 6�   $��38��6�   �� 5   
   -   5        $	 CreateButton��5      $��Create Air Con��6'   $
��Left=�6@   $��651,126,0,0q�6[   $	��Top=�6p   #��[  6�   $	��120��6�   6�   �� 5    
   -   5        $	 DeleteButton��5       $��Delete Air Con��6'   $
��Left=�6@   $��651,278,0,0q�6[   $	��Top=�6p   #��[  6�   $	��120��6�   6�   �� 5!   
   -   5        $	 UpdateButton��5!      $��Update Air Con��6'   $
��Left=�6@   $��651,200,0,0q�6[   $	��Top=�6p   #��[  6�   $	��120��6�   6�   �� 5"   
   -	   5        $	 
QuitButton��5"      $
��Quit��6%   $
��Left=�64   $��651,365,0,0q�6O   $	��Top=�6d   #��[  6|   $	��120��6�   6�   �� 5#   
   -
   5        $	 OperatorButton��5#      $	��And��6)   $
��Left=�67   $��38��6R   $��
502,59,0,0q�6^   $	��Top=�6r   $��61��6�   #��[  6�   $��Normal"�6�   6�   �� 5$   
   -   5         ��Name$ 
HelloLabel��5$      $��Hello, ��6$   $
��Left=�66   $��	36,16,0,0q�6Q   $	��Top=�6d   #��[ 6|   5%      5&      