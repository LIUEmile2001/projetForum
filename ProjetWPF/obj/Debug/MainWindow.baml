   M S B A M L   `   `   `  ����D  @ProjetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProjetWPF	ProjetWPF  5   	       ProjetWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ProjetWPF     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      $	��100 �6   6+   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��Projet FILM��6   $��2��6'   $��Center=�6;   $��50(�6X   
���   �6{   �� 5   
   $��1��6   
����·�$��Choix du genre du film��66   $��20(�6T   $	��Top=�6b   6|   �� 5   
   -   5        $��cboGenreFilm��5   D   $��1��6X   $	��180��6e   $��25��6q   $��Right=�6}   $	��Top=�6�   ��5      �� 5      .R�5      �� .+�5      �� ��6$   �� 67   5      5       5"      �� 5#   
   $��20(�6   
����·�$	��Top=�67   $��Center=�6O   $��Ajouter un nouveau genre��6l   $��1��6�   $��1��6�   6�   �� 5$   
   $��1��6   $��Center=�6!   $��Bottom=�6>   $��Liste des films��6Y   $��25(�6p   
����·�6�   �� 5%   
   $��1��6   $��1��6%   $��Bottom=�62   .+�5&      � .+�5'      �� $��Saisir le nom du genre��6   6<   �� 5(      -   5        $��txtGenre��5(   &   $	��100��6   68   5)      5*      �� 5-   
   -   5        $��lstFilms��5-   ?   $��2��6O   ��5.      �� 5/      .R�50      ��  �� Orientation$ 
Horizontal=�6!   .+�51      �� $��50��6=   $��50��6H   ��6    �� *	PhotoFilm+6V   �� 52      $��50��6?   ��6$   �� *	TitreFilm+6L   �� 53      $��50��6?   ��6$   �� *	NbEntrees+6L   �� 54      $	��100��6R   ��6$   �� *LeRealisateur.NomRealisateur+6`   �� 55      $��50��6U   ��6$   �� *!LeRealisateur.PrenomRealisateur+6b   56      57      59      �� 5:   
   $��Ajouter un genre��6   $��20��6,   $��1��68   $��2��6H   6W   �� 5;   
   $��2��6   $��1��6!   $��Bottom=�61   $��Ajouter un nouveau film��6L   $��Center=�6k   $��20(�6�   
����·�6�   �� 5=   
   $��3��6   $��Liste des acteurs��6!   
����·�$��Center=�6O   $��15(�6l   6|   �� 5>   
   -   5        $��
lstActeurs��5>   A   $��3��6S   $��50��6`   ��5?      �� 5@      .R�5A      �� .+�5B      �� ��6    �� *PhotoActeur+6A   5C      5D      5G      �� 5I   
   $��3��6   $��3��6"   .+�5J      �  � Orientation$ Vertical=�6   .+�5K      �� $��Saisir le nom du film��6   6;   �� 5L      -   5        $��txtFilm��5L      6+   �� 5M      $)��#Saisir le nombre d'entrées du film��6   6H   �� 5N      -   5        $��txtNbEntreesFilm��5N      64   �� 5O      $#��Saisir le nom du réalisateur��6   6B   �� 5P      -   5        $��txtRealisateur��5P      62   �� 5Q      $&�� Saisir le prenom du réalisateur��6   6E   �� 5R      -	   5        $��txtPrenomRealisateur��5R      68   5S      5T      �� 5V   
   -
   5        $��lstActeursSelectionner��5V   +    �� SelectionMode$ Multiple=�6   $��4��6I   $��1��6V   ��5W      �� 5X      .R�5Y      �� .+�5Z      �� ��6    �� *PhotoActeur+6A   5[      5\      5^      5_      5`      