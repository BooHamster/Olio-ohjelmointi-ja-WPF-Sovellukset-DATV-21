   M S B A M L   `   `   `  ����F  BHarjoitus21, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Harjoitus21Harjoitus21  5   	       Harjoitus21.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Harjoitus21     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFFBFBFB��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $
��234* �6   �� 5      $
��187* �6   .+�5   
   �� $
��Left=�6   $��57��6+   $��	639,1,0,0q�67   $	��Top=�6J   $��79��6b   $^��Xhttps://cdn.gerdmans.com/content/images/thumbs/0101016_kundkorg-bolmen-27-liter-rod.jpeg��6m   �� 5   
   $��OstosKärry��6   $
��Left=�6%   $��
448,10,0,0q�6@   $	��Top=�6T   {�.  $��Cooper Black)�6~   ���	#FFFF0F0F$	��157��6�   $��34��6�   $��24(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   5      5       &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ TuoteListaGrid��5!      $
��Left=�6C   $��	10,63,0,0q�6^   $	��Top=�6q   $	��387��6�   $��Cooper Black)�6�   ���	#FFF21515���	#FF1081EF   CanUserReorderColumns .     CanUserDeleteRows .  	   AutoGenerateColumns	 .  ��6+   �� ��62  Z� 
   RowBackground
 5"      �� 5#      $ 0.5,1&�6&   $ 0.5,0&�67   .��5$      � $ Black��6#   $ 0Q�61   � 5%      $ 	#FFEAEAEA��6#   $ 1Q�65   � 5&      $ 	#FFAFAFAF��6#   $ 0.961Q�65   5'         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*         
FontFamily$ Cooper Black)�6?   ,  &System.Windows.Controls.DataGridColumn   Header$ Tuote��6Y      
Foreground
 �  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6y      CanUserResize .     
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nimi+6�     5+      
 �  ��$ Cooper Black)�6Q   $ Hinta��6k    .   . $
 Auto 6�    6%   �� *Hinta+6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5,      $ Valitse��6G    .     SortMemberPath$ 	Valittuna��6n    6)   �� *	Valittuna+6n   5.      �� 5/   
   -   5         ��Name$ PoistaTuotteet��5/      $��Poista Valitut Tuotteet��6)   $
��Left=�6K   $��184,127,0,0q�6f   $��1��6{   $	��Top=�6�   $	��163��6�   $��45��6�   $��Cooper Black)�6�   
���  ����50      �� 51      $ 0.5,1&�6&   $ 0.5,0&�67   .��52      � $ Black��6#   $ 0Q�61   � 53      $ White��6#   $ 1Q�61   54      56      �� 57   
   -   5        $ SiirräOstosKoriin��57      $��Tuotteet OstosKärryyn��6,   $
��Left=�6L   $��
10,127,0,0q�6g   $��1��6{   $	��Top=�6�   $	��160��6�   $��45��6�   $��Cooper Black)�6�    J� RenderTransformOrigin$ 0.379,0.516&�6�   
���  ����58      �� 59      $ 0.5,1&�6&   $ 0.5,0&�67   .��5:      � $ Black��6#   $ 0Q�61   � 5;      $ White��6#   $ 1Q�61   5<      5>        5?   
   -   5        $ OstosLista_Grid��5?      $
��Left=�6D   $��
414,63,0,0q�6_   $	��Top=�6s   $	��369��6�   $��Cooper Black)�6�   ���	#FFF21515���	#FF1081EF .   .  	 .  ��6,   �� ��6�   Z� 
 5@      �� 5A      $ 0.5,1&�6&   $ 0.5,0&�67   .��5B      � $ Black��6#   $ 0Q�61   � 5C      $ White��6#   $ 1Q�61   � 5D      $ 	#FF999999��6#   $ 0.969Q�65   5E       5G        5H      $ Cooper Black)�6?   $ 
TuoteLista��6Y   
 �  ��$
 Auto 6~    .   .  6%   �� *Nimi+6�     5I      
 �  ��$ Cooper Black)�6Q   $ Hinta��6k    .   . $
 Auto 6�    6%   �� *Hinta+6�     5J      $ Valitse��6G    .  $ 	Valittuna��6n    6)   �� *	Valittuna+6n   5L      �� 5M   
   -   5         ��Name$ Viestit��5M      $
��Left=�6%   $��530,127,0,0q�6@   $��1��6U   $
��Wrap=�6b   $��Viestit��6v   $	��Top=�6�   $	��253��6�   $��57��6�   $��Cooper Black)�6�   �� 5N   
   $��
TuoteLista��6   $
��Left=�6%   $��	10,10,0,0q�6@   $	��Top=�6S   {�.  $��Cooper Black)�6}   ���	#FFFF0F0F$	��304��6�   $��34��6�   $��24(�6�   ��5O      �� 5P      $ 0.5,1&�6&   $ 0.5,0&�67   .��5Q      � $ Black��6#   $ 0Q�61   � 5R      $ White��6#   $ 1Q�61   5S      ��5U      �� 5V      $ 0.5,1&�6&   $ 0.5,0&�67   5X      �� 5Y   
   -   5        $ OstaTuotteet��5Y      $��Osta Tuotteet��6'   $
��Left=�6?   $��362,127,0,0q�6Z   $��1��6o   $	��Top=�6|   $	��163��6�   $��45��6�   $��Cooper Black)�6�   
���  ����5Z      �� 5[      $ 0.5,1&�6&   $ 0.5,0&�67   .��5\      � $ Black��6#   $ 0Q�61   � 5]      $ White��6#   $ 1Q�61   5^      5`      �� 5a   
   -   5        $ Summa��5a      $
��Left=�6#   $��
600,79,0,0q�6>   $��1��6R   $
��Wrap=�6_   $	��Top=�6s   $	��183��6�   $��43��6�   
���  ����5b      �� 5c      $ 0.5,1&�6&   $ 0.5,0&�67   .��5d      � $ Black��6#   $ 0Q�61   � 5e      $ White��6#   $ 1Q�61   5f      5h      �� 5i   
   $
��Left=�6   $��
414,79,0,0q�6/   $��1��6C   $
��Wrap=�6P   $��LoppuSumma:��6d   $	��Top=�6w   $��43��6�   $	��181��6�   $��Cooper Black)�6�   $��24(�6�   
���  ����5j      �� 5k      $ 0.5,1&�6&   $ 0.5,0&�67   .��5l      � $ Black��6#   $ 0Q�61   � 5m      $ White��6#   $ 1Q�61   5n      5p      5q      5r      