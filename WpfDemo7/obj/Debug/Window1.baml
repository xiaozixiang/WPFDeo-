   M S B A M L   `   `   `  ����  WpfDemo7    WpfDemo7.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Window1��5   	   $	��300��6   $��334.328��6&    � Triggers 5      :� 5   
    :� 
SourceName$ 
BeginStory��6    :� RoutedEvent$ Button.Click��60   .[�5      �� -   5         ��Name$ beingstroyboard��5      .��5      �� -   5        .��5	      W�  �� 
TargetName$ Picture2��6&    �� TargetProperty$ Opacity�6G    W� From$ 1X�6k   	 W� To$ 0X�6t   	 g� Duration$	 0:0:10D�6{   5
      5      5      :� 5   
   $ pasue��6   $ Button.Click��6*   .[�5      ?� 
 �� BeginStoryboardName$
 beingstroyboard��6   6F   5      :� 5   
   $ Recover��6   $ Button.Click��6,   .[�5      �� $
 beingstroyboard��6   6G   5      :� 5   
   $
 Stop��6   $ Button.Click��6)   .[�5      �� $
 beingstroyboard��6   6E   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $��20 �6   .+�5   
   � .+�5      �� $��Resources/1.png��6   $
��Fill=�6-   6>   �� 5      -   5        $��Picture2��5   =   $��Resources/3.jpg��6   $
��Fill=�6-   6O   5       �� 5!   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5"      �� -   5        $��
BeginStory��5"       $��5q�6   .��62   
StratStory6>   �� 5#      -   5        $��pasue��5#       $��5q�6   .��6-   
PasueStory69   �� 5$      -   5        $��Recover��5$       $��5q�6   .��6/   RecoverStory6=   �� 5%      -   5        $
��Stop��5%       $��5q�6   .��6,   	StopStory67   5&      � 5'   
   -   5        $��progressbar��5'   0   $��2��6   $��20��6$    � Minimum$ 0Q�6C    � Maximum$ 1Q�6O   6]   5(      5)      