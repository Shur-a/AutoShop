   M S B A M L   `   `   `  ����C  ?AutoShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AutoShop.RegistrationAutoShop.Registration  5      %    AutoShop.Registration.EnterPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:AutoShop.Registration     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	EnterPage��5
       � 	Resources 5         MyImage  MyImage2��%f   &	        &	 (     �� 5   
   $��/image/eye.png��6    �� 5   
   $��/image/eye_2.png��6!   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Вход��6   $��SemiBold"�6   $��22(�65   $��2��6C   $��Center=�6W   $��Center=�6t   �� 5    
   -   5        $��
EnterLogin��5    T   
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин��6%   $��2��6g   $��1��6{   $	��Top=�6�   $��12q�6�   $	��180��6�   $��30��6�   .��6�    5"       �� 
TargetType �� Property �� Value��%^   '��       �� 5#      " ��6   .�5$      ��  �@��CornerRadius$ 5��66   5%      5&      .��6!   5'      G� 5(   
   -   5        $��EnterPassword��5(   Z   
�������$! Введите пароль��6*   $��2��6o   $��1��6�   $��Bottom=�6�   $��12q�6�   $	��180��6�   $��30��6�    5)      ��%^   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 5��65   5,      5-      5.      �� 51   
   -   5        $��EnterBT��51      $	��160��6   $��30��6B   $��2��6N   $��2��6[   $��Bottom=�6o   ���#1e90ff$��
Войти��6�   
�������$��14(�6�    � Cursor$
 Hand��6�   $��120,0,120,0q�6�    52      ��%^   '��       �� 53      " ��6   .�54      ��  �@��CornerRadius$ 5��65   55      56      57      �� 59   
   -   5        $��RegistBT��59   4   $	��130��6(   $��20��6D   $��3��6P   $��2��6]   $��Center=�6q   ���#1e90ff$*��$Зарегистрироваться��6�   
�������$��10(�6�   $��134,0,134,0q�6�   $
 Hand��6�    5:      ��%^   '��       �� 5;      " ��6   .�5<      ��  �@��CornerRadius$ 5��65   5=      5>      5?      5A      5B      