   M S B A M L   `   `   `  ����F  BHarjoitus25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Harjoitus25Harjoitus25  5   	       Harjoitus25.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Harjoitus25     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��10,0,3.333,-0.333q�6    J� RenderTransformOrigin$ 0.5,0.5&�6&   ��5
   
   �� 5       �� ImageSource$� �https://upload.wikimedia.org/wikipedia/fi/thumb/7/79/J%C3%A4%C3%A4kiekon_SM-liiga_logo_2013.svg/1200px-J%C3%A4%C3%A4kiekon_SM-liiga_logo_2013.svg.png��6    j� Stretch$ Uniform=�6�   .+�5   
   �� -   5         ��Name$ JoukkueenValinta��5      $
��Left=�6-   $��	25,29,0,0q�6H   $	��Top=�6[   $	��120��6s   .@�5      �� $��Jokerit��6   $��24(�6-   $��Engravers MT)�6;   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5      $ 	#FFFC0000��6'   $ 0.488Q�69   5      5      �� 5      $	��TPS��6   $��24(�6)   $��Engravers MT)�67   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ Black��6'   $ 0Q�65   � 5      $	 Red��6'   � 5      $ 	#FF7DE000��6'   $ 0.681Q�69   5      5      �� 5      $��Tappara��6   $��24(�6-   $��Engravers MT)�6;   ��5       �� 5!      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5"      � $ Black��6'   $ 0Q�65   � 5#      $ 	#FF00FFED��6'   $ 0.638Q�69   5$      5&      �� 5'      $��Kärpät��6   $��22(�6,   $��Engravers MT)�6:   ��5(      �� 5)      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5*      � $ Black��6'   $ 0Q�65   � 5+      $ 	#FFED00FF��6'   $	 0.6Q�69   5,      5.      5/      &   System.Windows.Controls.DataGrid  50   
   -   5        	  Name$	 PelaajaGrid��50      $
��Left=�6@   $��
178,26,0,0q�6[   $	��Top=�6o   $	��404��6�   $��Cooper Black)�6�   ���	#FF1081EF
   CanUserReorderColumns
 .     CanUserDeleteRows .     AutoGenerateColumns .     RowBackground
 �   �   AlternatingRowBackground �	#FFFF3E04��6(   �� ��6  Z� ��51      �� 52      $ 0.5,1&�6&   $ 0.5,0&�67   .��53      � $ Black��6#   $ 0Q�61   � 54      $	 Red��6#   $ 0.565Q�6/   55         Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58         
FontFamily$ Bodoni MT Black)�6B   ,  &System.Windows.Controls.DataGridColumn   Header$ Etunimi��6_      
Foreground
 �  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�      CanUserResize .     
IsReadOnly .    SortMemberPath$ Etunimi��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Etunimi+6�     59      
 �  ��$ Bodoni MT Black)�6T   $ Sukunimi��6q    .   . $
 Auto 6�   $ Sukunimi��6�    6%   �� *
Sukunimi+6�     5:      $ PelaajaNumero��6j   $ PelaajaNumero��6�   $ Bodoni MT Black)�6�    6%   �� *PelaajaNumero+   ClipboardContentBinding 6G   Z� 6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5;      $ Valitse��6G    .   6)   �� *	Valittuna+ 6n   �� *	Valittuna+5=      �� 5>   
   $
��Left=�6   $	��308��60   $��	25,89,0,0q�6=   $	��Top=�6P   $	��137��6h   .+�5?      �� -   5         ��Name$ EtunimiBlock��5?      $
��Wrap=�6.   $��Etunimi��6B   ���	#FFE20707$
��Bold"�6h   �� 5@      -   5         ��Name$ EtunimiTeksti��5@      $��23��6-    �� TextWrapping$
 Wrap=�69   $��Etunimi��6M   
���  ��6\   �� 5A      -   5        $ SukunimiBlock��5A      $
��Wrap=�6/   $��Sukunimi��6C   ���	#FFFF0404$
��Bold"�6j   �� 5B      -   5        $ SukunimiTeksti��5B      $��23��6.   $
 Wrap=�6:   $��Sukunimi��6N   ���	#FFFF01016^   �� 5C      -   5        $ PelaajaNumeroBlock��5C      $
��Wrap=�64   $��PelaajaNumero��6H   
���  ��$
��Bold"�6n   �� 5D      -   5        $ PelaajaNumeroTeksti��5D      $��23��63   $
 Wrap=�6?   $��PelaajaNumero��6S   
���  ��6�   �� 5E      -	   5         ��Name$ LisääPelaaja��5E      $��Lisää Pelaaja��6+   ��5F      �� 5G      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5H      � $ Black��6'   $ 0Q�65   � 5I      $ 	#FFF80D0D��6'   $ 1Q�69   � 5J      $ 	#FFD80B0B��6'   $ 1Q�69   � 5K      $	 Red��6'   $ 0.491Q�63   � 5L      $ 	#FF780606��6'   5M      5O      �� 5P      -
   5        $ TallennaPelaajat��5P      $��Tallenna��6/   ��5Q      �� 5R      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5S      � $ Black��6'   $ 0Q�65   � 5T      $	 Red��6'   $ 0.475Q�63   5U      5W      �� 5X      -   5        $ Lataa��5X      $��Lataa��6$   ��5Y      �� 5Z      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5[      � $ Black��6'   $ 0Q�65   � 5\      $	 Red��6'   $ 0.532Q�63   5]      5_      �� 5`      -   5        $ PoistaPelaaja��5`      $��Poista Pelaaja��6,   ��5a      �� 5b      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5c      � $ Black��6'   $ 0Q�65   � 5d      $	 Red��6'   $ 0.466Q�63   5e      5g      �� 5h      -   5        $ Viestit��5h      $
��Wrap=�6)   $	��123��6=   $��Bodoni MT Black)�6J   ���	#FFEB0909$��0,0,0.333,0q�6~   5i      �� 5j   
   -   5         ��Name$ JoukkueKuva��5j      $
��Left=�6%   $	��125��6@   $��
610,29,0,0q�6M   $	��Top=�6a   $	��146��6y   $ 0.494,0.503&�6�   5k      �� 5l   
   $
��Left=�6   $��	10,61,0,0q�6/   $
��Wrap=�6B   $��Syötä Pelaajan Tiedot��6V   $	��Top=�6s   $	��152��6�   $��16(�6�   $��28��6�   ���	#FFFA03036�   5n      5o      