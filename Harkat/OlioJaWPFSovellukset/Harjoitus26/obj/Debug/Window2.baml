   M S B A M L   `   `   `  ����F  BHarjoitus26, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Harjoitus26Harjoitus26  5   	       Harjoitus26.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Harjoitus26     5   	     � Title$  CharacterCreation��5   	   $
��1080��6#   $
��1920��61    � WindowState$ 	Maximized=�6>    � WindowStartupLocation$ CenterScreen=�6V   .��5	      � ��5
   
   �� 5       �� ImageSource${ uhttps://www.gamersdecide.com/sites/default/files/styles/news_images/public/best-background-for-every-class-main_1.jpg��6   .+�5   
   �� -   5         ��Name$
 Exit��5      $��	Exit Game��6   $
��Left=�63   $��
39,801,0,0q�6N   $	��Top=�6b   $	��440��6z   $	��123��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $	 Red��6#   $ 0.787Q�6/   � 5      $ 	#FFFA0000��6#   $ 0.069Q�65   5      ��5      
� 5      .��5      � $ Black��6#   $ 0.578Q�61   � 5      $ 	#FFD1C213��6#   $ 0.318Q�65   5      5      �� 5   
   -   5        	 ��Name$	 CharacterInfo��5      $
��Left=�6,   $	��598��6G   $��	10,10,0,0q�6T   $	��Top=�6g   $	��361��6   .+�5      �� -   5        
 ��Name$
 	ClassText��5      $
��Wrap=�6+   $��Character Name��6?   $��Copperplate Gothic Bold)�6U   $��36(�6z   $��0,0,-2.667,0q�6�   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5       � $ Black��6'   $ 0.277Q�65   � 5!      $ 	#FF1503FF��6'   $ 0.672Q�69   5"      5$      �� 5%      -   5         ��Name$ ClassSelection��5%      $
��Left=�6/   $	��Top=�6J   $	��246��6b   $��40��6n    �� 
IsReadOnly . $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5&      �� 5'      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5(      � $ Black��6'   $ 0Q�65   � 5)      $ 	#FF009AF3��6'   $ 0.359Q�69   5*      .@�5,      �� $��Fighter��6   $��36(�61   $��Copperplate Gothic Bold)�6?   ��5-      �� 5.      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5/      � $ Black��6+   $ 0.339Q�69   � 50      $ White��6+   $ 1Q�69   51      53      54      �� 55      -   5        $
 NameText��55      $
��Wrap=�6*   $��Character Name��6>   $��Copperplate Gothic Bold)�6T   $��36(�6y   ��56      �� 57      $ 0.5,1&�6*   $ 0.5,0&�6;   .��58      � $ Black��6'   $ 0Q�65   � 59      $ 	#FFED0000��6'   $ 0.672Q�69   5:      5<      �� 5=      -   5         ��Name$ CharacterNameInput��5=      $��96��62    �� TextWrapping$
 Wrap=�6>   $��Copperplate Gothic Bold)�6R   $��36(�6w   $��0,0,0.333,0q�6�   $��Character name comes here��6�   .��6�   ��5>      �� 5?      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5@      � $ Black��6'   $ 0Q�65   � 5A      $ White��6'   $ 1Q�65   5B      .��5C   &   5D      �� 5E      -   5        $
 CharacterSexText��5E      $
��Wrap=�62   $��Copperplate Gothic Bold)�6F   $��36(�6k   $��0,0,-0.667,0q�6y   ��5F      �� 5G      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5H      � $ Black��6'   $ 0Q�65   � 5I      $ 	#FFA9ED00��6'   $ 0.672Q�69   5J      �� 5K   )   $�Character Sex��6-   �� 6D   .F�5L      �� -   5        $ SexSelection��5L      $
��Left=�65   $	��Top=�6P   $	��246��6h   $��40��6t    . ��5M      �� 5N      $ 0.5,1&�62   $ 0.5,0&�6C   .��5O   "   � $ Black��6/   $ 0Q�6=   � 5P   "   $ White��6/   $ 1Q�6=   � 5Q   "   $ 	#FF68FF00��6/   $ 0.374Q�6A   5R      .@�5T      �� $
��Male��6'   $��36(�66   $��Copperplate Gothic Bold)�6D   ��5U      �� 5V   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5W   &   � $ Black��63   $ 0Q�6A   � 5X   &   $ 	#FF05AAF8��63   $ 1Q�6E   � 5Y   &   $ 	#FF04A6F3��63   $ 0.299Q�6E   5Z   #   5\      �� 5]      $��Female��6'   ��5^      �� 5_   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5`   &   � $ Black��63   $ 0Q�6A   � 5a   &   $ 	#FFF907F4��63   $ 0.439Q�6E   5b   #   5d      5e      5f      6'   �� 5g      -	   5        $ RaceText��5g      $��42��6(   $
 Wrap=�64   $��Copperplate Gothic Bold)�6H   $��36(�6m   $��0,0,-0.667,0q�6{   $��Character Race��6�    �� SelectionOpacity$ 15Q�6�   .��6�   ��5h      �� 5i      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5j      � $ Black��6'   $ 0Q�65   � 5k      $ 	#FFFCFF00��6'   $ 1Q�69   5l      .��5m   &   5n      �� 5o      -
   5        $ RaceSelection��5o      $
��Left=�6.   $	��Top=�6I   $	��246��6a   $��40��6m    . $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5p      �� 5q      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5r      � $ Black��6'   $ 0.319Q�65   � 5s      $ White��6'   $ 1Q�65   5t      .@�5v      �� $��Human��6   $��36(�6/   $��Copperplate Gothic Bold)�6=   ��5w      �� 5x      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5y      � $ Black��6+   $ 0Q�69   � 5z      $ 	#FFD7DBDD��6+   $ 0.918Q�6=   5{      5}      �� 5~      $��Dwarf��6   ��5      �� 5�      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5�      � $ Black��6+   $ 0.319Q�69   � 5�      $ 	#FFC46F00��6+   $ 1Q�6=   5�      5�      5�      5�      �� 5�   
   -   5        $	 
StatsPanel��5�      $
��Left=�6)   $	��981��6D   $��
611,40,0,0q�6Q   $	��Top=�6e   $	��568��6}   .+�5�      �� -   5        $
 CharacterStatsText��5�      $
��Wrap=�64   $ ��Character Stats Allocation��6H   $��Copperplate Gothic Bold)�6j   $��36(�6�   $��0,0,10,0q�6�   $��85��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   � 5�      $ Black��6'   $ 0.355Q�65   5�      ��5�      �� 5�      $ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5�      � $ Black��6'   $ 1Q�65   � 5�      $ 	#FFED0000��6'   $ 0.772Q�69   5�      5�      �� 5�      -   5        $
 StrengthText��5�      $
��Wrap=�6.   $��Strength��6B   $��Copperplate Gothic Bold)�6R   $��36(�6w   $��0,0,10,0q�6�   $��54��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFDCE4FF��6'   $ 0.319Q�69   � 5�      $ 	#FFFB0707��6'   $
 0.94Q�69   5�      5�      �� 5�      -   5        $ Strength��5�      $��91��6(   $
 Wrap=�64   $��Copperplate Gothic Bold)�6H   $��36(�6m   $��	0,0,388,0q�6{   .��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   5�      .��5�   &   5�      �� 5�      -   5        $
 DexText��5�      $
��Wrap=�6)   $��	Dexterity��6=   $��Copperplate Gothic Bold)�6N   $��36(�6s   $��0,0,10,0q�6�   $��52��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFC0F2C7��6'   $ 0.404Q�69   � 5�      $ 	#FF06EF28��6'   $ 0.672Q�69   5�      5�      �� 5�      -   5        $ 	Dexterity��5�      $��91��6)   $
 Wrap=�65   $��Copperplate Gothic Bold)�6I   $��36(�6n   $��	0,0,388,0q�6|   .��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   5�      .��5�   &   5�      �� 5�      -   5        $
 ConstitutionText��5�      $
��Wrap=�62   $��Constitution��6F   $��Copperplate Gothic Bold)�6Z   $��36(�6   $��0,0,10,0q�6�   $��54��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFA38ED1��6'   $ 0Q�69   � 5�      $ 	#FF1200FF��6'   $ 0.825Q�69   5�      5�      �� 5�      -   5        $ Constitution��5�      $��91��6,   $
 Wrap=�68   $��Copperplate Gothic Bold)�6L   $��36(�6q   $��	0,0,388,0q�6   .��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   5�      .��5�   &   5�      �� 5�      -   5        $
 IntelligenceText��5�      $
��Wrap=�62   $��Intelligence��6F   $��Copperplate Gothic Bold)�6Z   $��36(�6   $��0,0,10,0q�6�   $��54��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFFFA400��6'   $ 0Q�69   � 5�      $ 	#FFFFDB00��6'   $ 0.672Q�69   5�      5�      �� 5�      -   5        $ Intelligence��5�      $��91��6,   $
 Wrap=�68   $��Copperplate Gothic Bold)�6L   $��36(�6q   $��	0,0,388,0q�6   .��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   5�      .��5�   &   5�      �� 5�      -   5        $
 
WisdomText��5�      $
��Wrap=�6,   $��Wisdom��6@   $��Copperplate Gothic Bold)�6N   $��36(�6s   $��0,0,10,0q�6�   $��54��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFECF2F6��6'   $ 0Q�69   � 5�      $ 	#FF06E0FF��6'   $ 0.672Q�69   5�      5�      �� 5�      -   5        $ Wisdom��5�      $��93��6&   $
 Wrap=�62   $��Copperplate Gothic Bold)�6F   $��36(�6k   $��	0,0,388,0q�6y   .��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ White��6'   $ 1Q�65   5�      .��5�   &   5�      �� 5�      -   5        $
 StatPointsText��5�      $
��Wrap=�60   $��Free Stat Points:��6D   $��89��6]   $��Copperplate Gothic Bold)�6i   $��36(�6�    J� RenderTransformOrigin$ 	0.5,0.874&�6�   $��0,0,10,0q�6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFFF00D3��6'   $ 0Q�69   � 5�      $ White��6'   $ 1Q�65   � 5�      $ 	#FFB62F71��6'   $ 0.701Q�69   5�      5�      �� 5�      -   5        $
 FreeStatPoints��5�      $
��Wrap=�60   $��89��6D   $��Copperplate Gothic Bold)�6P   $��36(�6u   $ 	0.5,0.874&�6�   $��0,0,10,0q�6�   $��Available stat points:��6�   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFACA300��6'   $ 0.466Q�69   � 5�      $ 	#FFF6F100��6'   $ 0.519Q�69   5�      5�      5�      �� 5�   
   -   5        $ CreateCharacter��5�      $��Create Character��6*   $
��Left=�6E   $��
39,613,0,0q�6`   $	��Top=�6t   $	��440��6�   $	��123��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ Black��6#   $ 0Q�61   � 5�      $	 Red��6#   $ 0.787Q�6/   � 5�      $ 	#FFFA0000��6#   $ 0.069Q�65   5      ��5     
� 5     .��5     � $ Black��6#   $ 0.578Q�61   � 5     $ 	#FFD1C213��6#   $ 0.881Q�65   5     5     �� 5	  
   -   5        $
 StrengthTotal��5	     $
��Left=�6+   $��969,175,0,0q�6F   $
��Wrap=�6[   $	��Top=�6o   $��87��6�   $	��152��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5
     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ Black��6#   $ 0Q�61   � 5     $	 Red��6#   $ 0.332Q�6/   5     5     �� 5  
   -   5        $ Allocate��5     $��Allocate Stat Points��6#   $
��Left=�6B   $��1218,40,0,0q�6]   $	��Top=�6r   $	��485��6�   $��85��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ Black��6#   $ 0Q�61   � 5     $ 	#FFED0000��6#   $ 0.569Q�65   5     ��5     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ Black��6#   $ 0.022Q�61   � 5     $ 	#FFC7C7C5��6#   $ 0.686Q�65   5     5     �� 5  
   -   5        $
 DexterityTotal��5     $
��Left=�6,   $��969,325,0,0q�6G   $
��Wrap=�6\   $	��Top=�6p   $��87��6�   $	��152��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5      �� 5!     $ 0.5,1&�6&   $ 0.5,0&�67   .��5"     � $ Black��6#   $ 0Q�61   � 5#     $	 Red��6#   $ 0.324Q�6/   5$     5&     �� 5'  
   -   5        $
 ConstitutionTotal��5'     $
��Left=�6/   $��969,468,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $��87��6�   $	��152��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5(     �� 5)     $ 0.5,1&�6&   $ 0.5,0&�67   .��5*     � $ Black��6#   $ 0Q�61   � 5+     $ 	#FFFF0202��6#   $ 0.304Q�65   5,     5.     �� 5/  
   -   5        $
 IntelligenceTotal��5/     $
��Left=�6/   $��969,612,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $��87��6�   $	��152��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��50     �� 51     $ 0.5,1&�6&   $ 0.5,0&�67   .��52     � $ Black��6#   $ 0Q�61   � 53     $ 	#FFFF0202��6#   $ 0.354Q�65   54     56     �� 57  
   -   5        $
 WisdomTotal��57     $
��Left=�6)   $��969,758,0,0q�6D   $
��Wrap=�6Y   $	��Top=�6m   $��87��6�   $	��152��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��58     �� 59     $ 0.5,1&�6&   $ 0.5,0&�67   .��5:     � $ Black��6#   $ 0Q�61   � 5;     $	 Red��6#   $ 0.287Q�6/   5<     5>     �� 5?  
   -    5        $
 Messages��5?     $
��Left=�6&   $��1179,151,0,0q�6A   $
��Wrap=�6W   $	��Top=�6k   $	��404��6�   $	��524��6�   $��Copperplate Gothic Bold)�6�   $��36(�6�   ��5@     �� 5A     $ 0.5,1&�6&   $ 0.5,0&�67   .��5B     � $ Black��6#   $ 0Q�61   � 5C     $ 	#FFF60505��6#   $ 0.394Q�65   5D     5F     5H     5I     