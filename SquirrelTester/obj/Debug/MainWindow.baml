   M S B A M L   `   `   `  ����J  FSquirrelTester, Version=1.1.16.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SquirrelTesterSquirrelTester  5   	       SquirrelTester.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SquirrelTester     5   	     � Title$  Mystic Program V 1.1.16��5   	   $	��220��6)   $	��800��66   $��Snap ITC)�6C    � 
ResizeMode$ NoResize=�6Y   ��5	      �� 5
   
    �� ImageSource$Z TC:\Users\jschudel\source\repos\SquirrelTester\SquirrelTester\graveyard-1-630x480.png��6    j� Stretch$
 Fill=�6x   6�   .��5      ��  �� Padding$ 10q�6   ._�5   
   �� .+�5      �� -   5         ��Name$ 
_textBlock��5      $4��.Will you dare to click the Mysterious Button??��6-   $��25(�6c   $��20q�6s   
���  ��6   � 5      $��75��6   $	��700��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5         ��Name$ 
InfoButton��5      $��0 0 10 0q�6H   $��0��6Z   $
��Info��6j   $��50(�6z    � Cursor$
 Hand��6�   	 J� Effect	 5      -  'System.Windows.Media.Effects.BlurEffect  5      ��5      �� 5      
 �� 
TargetType"
 ��6    .�5      ��  �� Property � �� �� Value �	#FF4D00006;   �� 5        � �� 5!   "   �� 5"   &    �� 
TargetType" ��66   .R�5#   *   �� #��z��61   ._�5$   .   �� $��Center=�6?   $��Center=�6\   5%   +   5&   '   5(       �� Triggers 5)      P� 5*   "    P� Property �@J�IsMouseOver P� Value . . �5+   &   ��  � ��
 �  ��6C   5,   #   5.      50      �� 52      -   5        $ MysteriousButton��52      $��1��6T   $��25(�6d   $
 Hand��6r    �� 	ClickMode$ Press=�6�   .��53      �� 
Mysterious�� 54   $   Button55      ��56      �� 57      "
 ��6    .�58      ��  � �� �	#FF4D00006;   �� 59       � �� 5:   "   �� 5;   &   " ��66   .R�5<   *   �� #��z��61   ._�5=   .   �� $��Center=�6?   $��Center=�6\   5>   +   5?   '   5A       5B      P� 5C   "    �@J�IsMouseOver . . �5D   &   ��  � ��
 �  ��6C   5E   #   5G      	 5I        5J      5L      �� 5N      -   5        $ CancelButton��5N      $��10 0 0 0q�6L   $��2��6^   $��Close��6n   $��50(�6~   $
 Hand��6�   ��5O      �� 5P      "
 ��6    .�5Q      ��  � �� �	#FF4D00006;   �� 5R       � �� 5S   "   �� 5T   &   " ��66   .R�5U   *   �� #��z��61   ._�5V   .   �� $��Center=�6?   $��Center=�6\   5W   +   5X   '   5Z       5[      P� 5\   "    �@J�IsMouseOver . . �5]   &   ��  � ��
 �  ��6U   5^   #   5`      	 5b        5c      5e      5g      5h      5i      5j      