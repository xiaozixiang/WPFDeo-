   M S B A M L   `   `   `  ����  WpfDemo5Image    WpfDemo5Image.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Window1��5   	   $	��300��6   $	��600��6&    � 	Resources 5         BeginStoryBoard g� DesiredFrameRate �� ElementName �� Path �� 
TargetName �� TargetProperty W� From	 W� To	 g� AutoReverse
 g� Duration��%H  &	        �� 5   
   .��5      ��  6   �� $ begin��$
 Text�.��5      W� $ Elipses��6*   $ (Canvas.Left)�6J   $ 0X�6t   $	 500X�6}   	 . $
 0:0:5D�6�   6�   W� 5	      $ Elipses��6*   $ (Canvas.Top)�6J   $	 300X�6s   $ 0X�6~   	 . $
 0:0:3D�6�   6�   5
      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5       �� ResourceKey$ BeginStoryBoard��6!   6A   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   
�������._�5      �� }�. .+�5      A� -   5        $��Elipses��5   I   $��20��6   $��20��6&   
���  ��
���  ��6[   5      5      �� 5   
   $��1��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5       �� SetTimeline6%   �� 5!      -   5        $��begin��5!   <   $��5,0,0,0q�6   $��80��6'   $��60��62   6K   5"      �� 5#   
   $��2��6   $��40��6   $��开始故事版��6*   $��Center=�6:    5$      :� 5%      $ Button.Click��6   .[�5&      �� $ BeginStoryBoard��6%   6E   5'      5)      5*      5+      