   M S B A M L   `   `   `  ����\  XAirConditionerShop_NguyenThanhNam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:AirConditionerShop_NguyenThanhNam!AirConditionerShop_NguyenThanhNam  5   	   4    .AirConditionerShop_NguyenThanhNam.DetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:AirConditionerShop_NguyenThanhNam     5   	   -   5          � Title$  DetailWindow��5   	   $	��450��6   $	��800��6+   ���	#FFD4F7D4 � WindowStartupLocation$ CenterScreen=�5	   	   $��Arial)�6.   $��14(�6A    � 
ResizeMode$ NoResize=�6O   .��5
      � .+�5   
   �� -   5         ��Name$ DetailWindowLabel��5      $&�� Create or Update Air Conditioner��6+   $��Center=�6V   $��0,27,0,0q�6s   $	��Top=�6�      LabelHeaderStyle#��[  5      �� 5   
   $��
Air Con ID��6   $
��Left=�6%   $��
59,130,0,0q�6@   $	��Top=�6T     
LabelStyle#��[ 5      �� 5   
   $��Air Con Name��6   $
��Left=�6'   $��
60,159,0,0q�6B   $	��Top=�6V   #��[ 5       J� RenderTransformOrigin$ 0.487,0.896&�61   �� 5   
   $��Warranty��6   $
��Left=�6#   $��
60,185,0,0q�6>   $	��Top=�6R   #��[ 5      $ 0.483,1.189&�61   �� 5   
   $��Sound Level��6   $
��Left=�6&   $��
59,214,0,0q�6A   $	��Top=�6U   #��[ 5      �� 5   
   $��Feature Function��6   $
��Left=�6+   $��
60,244,0,0q�6F   $	��Top=�6Z   #��[ 5      �� 5   
   -   5         ��Name$ AirConIDTextBox��5      $
��Left=�6+   $��178,134,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��410��6�     TextBoxStyle#��[ 5      $��22��68   �� 5   
   -   5        $ AirConNameTextBox��5      $
��Left=�6-   $��178,161,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��410��6�   #��[ 5      $��22��63   �� 5   
   -   5        $ WarrantyTextBox��5      $
��Left=�6+   $��178,189,0,0q�6F   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��410��6�   #��[ 5      $��22��63   �� 5   
   -   5        $ SoundLevelTextBox��5      $
��Left=�6-   $��178,218,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��410��6�   #��[ 5      $��22��63   �� 5   
   -   5        $ FeatureFunctionTextBox��5      $
��Left=�62   $��178,245,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��410��6�   #��[ 5       $��82��63   �� 5!   
   -   5         ��Name$ 
SaveButton��5!      $��Save Air Con��6%   $
��Left=�6<   $��619,134,0,0q�6W   $	��Top=�6l     ButtonStyle#��[ 6�   $��93��6�   6�   �� 5"   
   -	   5        $ CloseButton��5"      $��Close��6&   $
��Left=�66   $��619,189,0,0q�6Q   $	��Top=�6f   #��[ 6~   $��93��6�   6�   �� 5#   
   $��Quantity��6   $
��Left=�6#   $��
62,330,0,0q�6>   $	��Top=�6R   #��[ 5$      �� 5%   
   $��Price��6   $
��Left=�6    $��362,332,0,0q�6;   $	��Top=�6P   #��[ 5&      �� 5'   
   $��Supplier ID��6   $
��Left=�6&   $��
60,365,0,0q�6A   $	��Top=�6U   #��[ 5(      $ 0.791,-0.356&�61   �� 5)   
   -
   5        $ QuantityTextBox��5)      $
��Left=�6+   $��178,334,0,0q�6F   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��141��6�   #��[ 5*      $��22��63   �� 5+   
   -   5        $ PriceTextBox��5+      $
��Left=�6(   $��429,334,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��159��6�   #��[ 5,      $��22��63   �� 5-   
   -   5         ��Name$ SupplierIDComboBox��5-      $
��Left=�6/   $��178,365,0,0q�6J   $	��Top=�6_   $	��141��6w   5/      50      