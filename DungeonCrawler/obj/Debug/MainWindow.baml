   M S B A M L   `   `   `  ����I  EDungeonCrawler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DungeonCrawlerDungeonCrawler  5   	       DungeonCrawler.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DungeonCrawler     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
MainWindow��5	   	   $	��700��6   $	��800��6)   .��5
      � ��5   
   �� 5       �� ImageSource$ Photos/Background.jpg��6    � ColumnDefinitions 5   
   .+�5   
   �� -   5         ��Name$ TextBox��5      $
��Left=�6%   $��
10,357,0,0q�6@   $
��Wrap=�6T   $	��Top=�6h   $��89��6�   $	��325��6�    K� ZIndex$ 1��6�   $��Gabriola)�6�   
���   �$��18(�6�   $y�Hidden=�6�   ��5      �� 5      $, &Photos/Parchment 0.5 (Fixed Sides).png��6   5      �� 5   
   -   5         ��Name$ 
ExitButton��5      $
��Menu��6%   $
��Left=�64   $	��Top=�6O   $��33��6g   $��
751,10,0,0q�6r   $ 2��6�   ��6�   Z� ��5      �� 5      $ Photos/Exit_Button.png��6    j� Stretch$ Uniform=�6B   5      �� 5   
   -   5         ��Name$ Hub_Background��5      $
��Left=�6(   $	��713��6C   $��-1,-9,0,-3.2q�6P   $	��Top=�6f   $	��801��6~   $��Photos/DarkValley.jpg��6�   $
��Fill=�6�   $ -7��6�   �� 5   
   -   5        $
 Shop��5      $
��Shop��6   $
��Left=�6.   $��229,365,0,0q�6I   $	��Top=�6^   $��44��6v   ���	#FF4F4F4F
�������$ -1��6�   �� 5   
   -   5        $	 Eat��5      $	��Eat��6   $
��Left=�6,   $��306,250,0,0q�6G   $	��Top=�6\   $��32��6t   ���	#FF4F4F4F
�������$ -1��6�   �� 5   
   -   5        $��Move Out��5      $
��Left=�6$   $��483,350,0,330.8q�6?   $��Center=�6X   $��75��6s   ���	#FF4F4F4F
�������6�   �� 5   
   $��Health��6   $
��Left=�6!   $��50,8,0,0q�6<   $	��Top=�6N   �� 5   
   -   5        	 ��Name$	 Currency��5      $��Money Counter��6"   $
��Left=�6:   $��	10,57,0,0q�6U   $	��Top=�6h   $��99��6�   
�������$ 10��6�   ��6�   Z� 6�   �� 5    
   -   5        
 ��Name$
 
ShopWindow��5       $
��Left=�6(   $	��329��6C   $��148,135,0,0q�6P   $	��Top=�6e   $	��446��6}   
���   ����	#FF454545$y�Hidden=�6�   �� 5!   
   -	   5        $ ExitShop��5!      $��Button��6#   $
��Left=�64   $��566,143,0,0q�6O   $	��Top=�6d   $��18��6|   
���   �
���  ��$��16��6�   $y�Hidden=�6�   ��6�   Z� 6�   �� 5"   
   -
   5        $	 PotionCounter��5"      $��Potion Counter��6'   $
��Left=�6@   $��
159,11,0,0q�6[   $	��Top=�6o   
�������$ 10��6�   �� 5#   
   -   5        $ 	BuyPotion��5#      $��
Buy Potion��6$   $
��Left=�69   $��323,250,0,0q�6T   $	��Top=�6i   $��75��6�   $y�Hidden=�6�   �� 5$   
   -   5        $	 BuyPotionText��5$      $��	(20 Gold)��6'   $
��Left=�6;   $��330,269,0,0q�6V   $	��Top=�6k   
�������$y�Hidden=�6�   �� 5%   
   -   5        $ Dungeon_Picture��5%      $
��Left=�6)   $	��455��6D   $��-1,-9,-0.4,0q�6Q   $	��Top=�6g   $	��795��6   $��DungeonEntrance.png��6�   $
��Fill=�6�   $ -1��6�    J� RenderTransformOrigin$ 
0.48,0.784&�6�   $y�Hidden=�6�   �� 5&   
   -   5        $
 Item��5&      $��Items��6   $
��Left=�6/   $��165,554,0,0q�6J   $	��Top=�6_   $��75��6w   $��37��6�   $
��Bold"�6�   $ 1��6�   $y�Hidden=�6�   ��5'      �� 5(       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5)      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5*      $ 	#FF42B765��6#   $ 1Q�65   5+      5-      �� 5.   
   -   5        $ Attack��5.      $��Attack��6!   $
��Left=�62   $��
46,554,0,0q�6M   $	��Top=�6a   $��75��6y   $��37��6�   ���	#FF656565
���   �$
��Bold"�6�   $ 1��6�   $y�Hidden=�6�   ��5/      �� 50      $ 0.5,1&�6&   $ 0.5,0&�67   .��51      � $ Black��6#   $ 0Q�61   � 52      $ 	#FFB34B4B��6#   $ 1Q�65   53      55      �� 56   
   -   5        $ Spells��56      $��Spells��6!   $
��Left=�62   $��283,554,0,0q�6M   $	��Top=�6b   $��75��6z   $��37��6�   $
��Bold"�6�   $ 1��6�   $y�Hidden=�6�   ��57      �� 58      $ 0.5,1&�6&   $ 0.5,0&�67   .��59      � $ Black��6#   $ 0Q�61   � 5:      $ 	#FF4F84FF��6#   $ 1Q�65   5;      5=      � 5>   
   -   5         �Name$ 	HealthBar��5>      $
��Left=�6)   $��10��6D   $��24,8,0,0q�6P   $	��Top=�6b   $	��100��6z    � Value$	 101Q�6�   ��6�   Z� �� 5?   
   -   5        $ Health_Cross��5?      $
��Left=�6&   $��21��6A   $��9,4,0,0q�6M   $	��Top=�6^   $��19��6v   $��Photos/Health_Cross.png��6�   $
��Fill=�6�   $ 
0.116,1.21&�6�   �� 5@   
   -   5        $	 Health_Text��5@      $��Health��6%   $
��Left=�66   $��	50,01,0,0q�6Q   $	��Top=�6d   �� 5A   
   -   5        $	 
Magic_Text��5A      $
��Mana��6$   $
��Left=�63   $��	50,11,0,0q�6N   $	��Top=�6a   $ 1��6y   $��25��6�   $��40��6�   �� 5B   
   -   5        $	 Skeleton_Text��5B      $��Skeleton��6'   $
��Left=�6:   $��	653,0,0,0q�6U   $	��Top=�6h   $��27��6�   $ 1��6�   $y�Hidden=�6�   � 5C   
   -   5        $ SkeletonHealth��5C      $
��Left=�6.   $��10��6I   $��
629,10,0,0q�6U   $	��Top=�6i   $	��100��6�   $ 9Q�6�    � Maximum$ 9Q�6�   $y�Hidden=�6�   ��6�   Z� �� 5D   
   -   5        $ UI_Frame��5D      $
��Left=�6"   $	��229��6=   $	��Top=�6J   $	��395��6b   $��0,442,0,-4.6q�6n   $��Photos/UI Frame (1).png��6�   $
��Fill=�6�   $y�Hidden=�6�   �� 5E   
   -   5        $	 UI_Text��5E      $��Command Panel��6!   $
��Left=�69   $	��Top=�6T   $��
50,457,0,0q�6l   $	��285��6�   $
��Bold"�6�   $��Italic$�6�   $��20(�6�   $��Center=�6�   $y�Hidden=�6�    J� Effect 5G      3  -System.Windows.Media.Effects.DropShadowEffect  5H      ��5J      �� 5K      $ 0.5,1&�6&   $ 0.5,0&�67   .��5L      � $ Black��6#   $ 0Q�61   � 5M      $ 	#FF794747��6#   $ 1Q�65   5N      5P      � 5Q   
   -   5        $ ManaBar��5Q      $
��Left=�6'   $��10��6B   $��	24,19,0,0q�6N   $	��Top=�6a   $	��100��6y   $	 101Q�6�   ���	#FF2D45C5��6�   Z� 6�   �� 5R   
   -   5        $ Move_Out��5R      $��Move Out��6#   $
��Left=�66   $��463,330,0,0q�6Q   $	��Top=�6f   $��60��6~   
����������	#FF4B4545$ -2��6�   �� 5S   
   -   5        $

 Menu��5S      $
��Left=�6"   $	��401��6=   $��
80,114,0,0q�6J   $	��Top=�6^   $	��629��6v   $y�Hidden=�6�   $ 1��6�   ��5T      �� 5U      $ Photos/Scroll.png��6   5W      �� 5X   
   -   5        $ 	Exit_Menu��5X      $
��Exit��6$   $
��Left=�63   $	��Top=�6N   $	��479��6f   $��148,392,0,0q�6r   $��54��6�   $y�Hidden=�6�   $ 2��6�   ��5Y      �� 5Z      $, &Photos/Parchment 0.5 (Fixed Sides).png��6   5\      �� 5]   
   -   5        $ Settings_Menu��5]      $��Settings��6(   $
��Left=�6;   $	��Top=�6V   $	��479��6n   $��148,295,0,0q�6z   $��54��6�   $y�Hidden=�6�   $ 2��6�   ��5^      �� 5_      $, &Photos/Parchment 0.5 (Fixed Sides).png��6   5a      �� 5b   
   -   5        $ Resume_Menu��5b      $��Resume��6&   $
��Left=�67   $	��Top=�6R   $	��479��6j   $��148,191,0,0q�6v   $��54��6�   $y�Hidden=�6�   $ 2��6�   ��5c      �� 5d      $, &Photos/Parchment 0.5 (Fixed Sides).png��6   5f      �� 5g   
   -   5        $ Potion��5g      $�� ��6!   $
��Left=�6,   $��
136,11,0,0q�6G   $	��Top=�6[   $��18��6s   $��20��6�   
���   ���6~   Z� ��5h      �� 5i      $ Photos/Potion.png��6   5k      �� 5l   
   -    5         ��Name$ S_Slider��5l      $
��Left=�6#   $��283,269,0,0q�6>   $	��Top=�6S   $	��196��6k   $	 100Q�6w   $ 5��6�   $y�Hidden=�6�   �� 5m   
   -!   5        $
 Option��5m      $
��Left=�6$   $	��211��6?   $��213,181,0,0q�6L   $	��Top=�6a   $	��336��6y   $y�Hidden=�6�   $ 4��6�   ��5n      �� 5o      $ Photos/UI Frame (1).png��6   5q      �� 5r   
   -"   5        $	 Sound_Option��5r      $��Sound��6&   $
��Left=�66   $��359,248,0,0q�6Q   $	��Top=�6f   ���	#FF7A4747$
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   $ 5��6�   �� 5s   
   -#   5        $ M_Slider��5s      $
��Left=�6#   $��283,327,0,0q�6>   $	��Top=�6S   $	��196��6k   $	 100Q�6�   $ -1Q�6�   $y�Hidden=�6�   $ 5��6�   ��6w   Z� 6�   �� 5t   
   -$   5        $	 Music_Option��5t      $��Music��6&   $
��Left=�66   $��360,309,0,0q�6Q   $	��Top=�6f   ���	#FF7A4747$
��Bold"�6�   $��Italic$�6�   $y�Hidden=�6�   $ 5��6�   �� 5u   
   -%   5        $	 Text_Option��5u      $��Options��6%   $
��Left=�67   $��241,196,0,0q�6R   $	��Top=�6g   $	��282��6   $��Center=�6�   $��20(�6�   $
��Bold"�6�   $y�Hidden=�6�   $ 5��6�    5v        5w      ��5y      �� 5z      $ 0.5,1&�6&   $ 0.5,0&�67   .��5{      � $ Black��6#   $ 0Q�61   � 5|      $ 	#FF794747��6#   $ 1Q�65   5}      5      �� 5�   
   -&   5        $ Exit_Option��5�      $�� ��6&   $
��Left=�61   $	��Top=�6L   $��14��6d   $��516,242,0,0q�6o   $��15��6�   $y�Hidden=�6�   $ 5��6�   ��5�      �� 5�      $ Photos/Exit_Button.png��6   5�      �� 5�   
   -'   5        $ Return��5�      $��Return��6!   $
��Left=�62   $��	24,36,0,0q�6M   $	��Top=�6`   $��53��6x   $y�Hidden=�6�   ��6�   Z� ��5�      �� 5�      $, &Photos/Parchment 0.5 (Fixed Sides).png��6   5�      �� 5�   
   -(   5        $
 Spell_Menu1��5�      $
��Left=�6)   $	��256��6D   $��136,109,0,0q�6Q   $	��Top=�6f   $	��468��6~   $y�Hidden=�6�   $ 6��6�   ��5�      
� 5�      .��5�      � $ Black��6#   $ 0Q�61   � 5�      $ 	#FC1461E2��6#   $ 1Q�65   5�      5�      �� 5�   
   -)   5        $
 Spell_Menu2��5�      ���	#FF092442$
��Left=�6:   $	��309��6U   $��
105,83,0,0q�6b   $	��Top=�6v   $	��536��6�   $ 5��6�   $y�Hidden=�6�   �� 5�   
   -*   5        $ Fireball��5�      $�� ��6#   $
��Left=�6.   $	��Top=�6I   $��44��6a   $��229,143,0,0q�6l   $��48��6�   $y�Hidden=�6�   $ 6��6�   ��5�      �� 5�      $ Photos/Fireball.png��6   $ Uniform=�6?   5�      �� 5�   
   -+   5        $ Icespear��5�      $�� ��6#   $
��Left=�6.   $��463,143,0,0q�6I   $	��Top=�6^   $��50��6v   $��48��6�   $y�Hidden=�6�   $ 6��6�   ��5�      �� 5�      $ Photos/IceSpear.png��6   $ Uniform=�6?   5�      �� 5�   
   -,   5        $ ThunderStorm��5�      $�� ��6'   $
��Left=�62   $��463,269,0,0q�6M   $	��Top=�6b   $��50��6z   $��44��6�   $y�Hidden=�6�   $ 6��6�   ��5�      �� 5�      $ Photos/ArcaneBarrage.png��6   5�      �� 5�   
   --   5        $ 
Earthquake��5�      $�� ��6%   $
��Left=�60   $��229,263,0,0q�6K   $	��Top=�6`   $��44��6x   $��50��6�   $y�Hidden=�6�   $ 6��6�   ��5�      �� 5�      $ Photos/EarthQuake.png��6   5�      �� 5�   
   -.   5         ��Name$ 	Inventory��5�      $
��Left=�6%   $	��235��6@   $��255,114,0,0q�6M   $	��Top=�6b   $	��228��6z   $y�Hidden=�6�   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ Black��6#   $ 0Q�61   � 5�      $ 	#FFB94545��6#   $ 1Q�65   5�      .@�5�      �� -/   5        $ PotionSwift��5�      $��Potion of Swiftness��6*   $
��Bold"�6H   $��Italic$�6Z   $	��218��6m   $��40��6y   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ 	#FFE0DB2E��6'   $ 1Q�69   5�      5�      �� 5�      -0   5        $ PotionTough��5�      $��Toughness Potion��6*   $
��Bold"�6E   $��Italic$�6W   $	��218��6j   $��40��6v   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ 	#FF2CAD32��6'   $ 1Q�69   5�      5�      �� 5�      -1   5        $ 
PotionMana��5�      $��Mana Potion��6)   $
��Bold"�6?   $��Italic$�6Q   $��40��6d   $	��218��6p   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ 	#FF44EEF1��6'   $ 1Q�69   5�      5�      �� 5�      -2   5        $ 
EscapeRope��5�      $��Escape Rope��6)   $
��Bold"�6?   $��Italic$�6Q   $��40��6d   $	��218��6p   ��5�      �� 5�      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ Black��6'   $ 0Q�65   � 5�      $ 	#FFE20EE4��6'   $ 1Q�69   5�      5�      5�      � 5�   
   -3   5        $ GiantSpiderHealth��5�      $
��Left=�61   $��10��6L   $��
629,10,0,0q�6X   $	��Top=�6l   $	��100��6�   $ 16Q�6�   $ 15Q�6�   $y�Hidden=�6�   ��6�   Z� �� 5�   
   -4   5        $	 GiantSpiderText��5�      $��Giant Spider��6)   $
��Left=�6@   $��	643,1,0,0q�6[   $	��Top=�6n   $��27��6�   $ 1��6�   $y�Hidden=�6�   �� 5�   
   -5   5        $	 	GhoulText��5�      $��Ghoul��6#   $
��Left=�63   $��	658,1,0,0q�6N   $	��Top=�6a   $��27��6y   $ 1��6�   $y�Hidden=�6�   � 5�   
   -6   5        $ GhoulHealth��5�      $
��Left=�6+   $��10��6F   $��
629,11,0,0q�6R   $	��Top=�6f   $	��100��6~   $ 20Q�6�   $ 20Q�6�   $y�Hidden=�6�   ��6�   Z� �� 5�   
   -7   5        $	 Score��5�      $��Score:��6   $
��Left=�60   $��9,74,0,0q�6K   $	��Top=�6]   $��99��6u   
�������$ 10��6�   ��6�   Z� 6�   �� 5�   
   -8   5        $ SkeletonMonster��5�      $
��Left=�6)   $	��206��6D   $��566,121,0,0q�6Q   $	��Top=�6f   $	��206��6~   $!��Photos/Cloaked Skeleton.png��6�   $y�Hidden=�6�   �� 5�   
   -9   5        $ SpiderMonster��5�      $
��Left=�6'   $	��144��6B   $��479,181,0,0q�6O   $	��Top=�6d   $	��144��6|   $��Photos/PurpleSpider.png��6�   $y�Hidden=�6�   �� 5�   
   -:   5        $ GhoulMonster��5�      $
��Left=�6&   $	��213��6A   $��463,127,0,0q�6N   $	��Top=�6c   $	��213��6{   $��Photos/Ghoul.png��6�   $y�Hidden=�6�   5�      5�      