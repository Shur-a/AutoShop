   M S B A M L   `   `   `  ����C  ?AutoShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AutoShop.WindowsAutoShop.Windows  5   	   9!clr-namespace:AutoShop.ConvertersAutoShop.Converters  5	   	        AutoShop.Windows.AddWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AutoShop.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,conv!clr-namespace:AutoShop.Converters  5	   	     � 
ResizeMode$  NoResize=�5
   	    � Title$ 	AddWindow��5   	   $	��450��6   $	��800��6(    � DataContext 5   	   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+ � 	Resources 5      ,  &AutoShop.Converters.ImagePathConverter   imageConverter��%   &	          5   
   6"   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��299 �6   �� 5      .+�5   
   �� $	��165��6   $	��Top=�6   $
��Left=�64   $��2��6O   $��SemiBold"�6_   $��20(�6u   $#��Добавьте деталь��6�   �� 5   
   -   5        $��75��5      $	��Top=�6   $
��Left=�64   $��
Назад��6O   
�������$��	10,10,0,0q�6�   $��26��6�   �� 5   
   -   5        $��ImageAdd��5   5   $	��290��6   $	��Top=�6   $��4,80,5,0q�6�   ��6E   �� *	PathImage+ �� 	Converter# [  6�   �� 5   
   $��1��6   $��Center=�6%   .+�5      �� -   5        $��
DetailName��5   .   $	��470��6   $��30��6"   $��Right=�6@   $��5q�6\   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$2 ,Введите название детали��6g   �� 5      -   5        $��ModelCar��5   .   $	��470��6   $��30��6"   $��Right=�6>   $��5q�6Z   $6 0Введите модель автомобиля��6e   �� 5      -   5        $��price��5   Y   $	��470��6   $��30��6"   $��Right=�6f   $��5q�6�   $4 .Введите стоимость детали��6�   �� 5      -   5        $��Count��5   Y   $	��470��6   $��30��6"   $��Right=�6f   $��5q�6�   $8 2Введите количество деталей��6�   �� 5       -   5        $��YearofreleaseCar��5    d   $	��470��6   $��30��6"   $��Right=�6|   $��5q�6�   $? 9Введите год выпуска автомобиля��6�   �� 5!      -   5        $��CarSelected��5!   /   $	��470��6   $��30��6#   $��Right=�6B   $��5q�6^   	 �� DisplayMemberPath$
	 Name��6i   $+ %Выберите автомобиль��6�   �� 5"      
 �� Orientation$
 
Horizontal=�6   .+�5#      �� -	   5        $��Добавить фото��5#      $��	30,0,30,0q�61   $	��Top=�6D   ���#0074e4$��32��6�   �� 5$      -
   5        $	��150��5$      $#��Добавить деталь��6%   $��Bottom=�6Q   ���#0074e46l   5%      5'      5(      5)      