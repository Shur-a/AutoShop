   M S B A M L   `   `   `  ����C  ?AutoShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AutoShop.RegistrationAutoShop.Registration  5      ,    &AutoShop.Registration.RegistrationPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:AutoShop.Registration     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  RegistrationPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Регистрация��6   $��SemiBold"�6&   $��22(�6<   $��2��6J   $��Center=�6^   $��Center=�6{   �� 5   
   -   5        $��
EnterLogin��5   T   
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин��6%   $��2��6g   $��1��6{   $	��Top=�6�   $��12q�6�   $	��180��6�   $��30��6�   .��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 5��66   5       5!      .��6!   5"      G� 5$   
   -   5        $��EnterPassword��5$   Y   
�������$! Введите пароль��6)   $��2��6n   $��1��6�   $��Bottom=�6�   $��12q�6�   $	��180��6�   $��30��6�    5%      ��%^   '��       �� 5&      " ��6   .�5'      ��  �@��CornerRadius$ 5��65   5(      5)      5*      �� 5,   
   -   5        $��RegisBT��5,      $	��168��6   $��30��6B   $��2��6N   $��2��6[   $��Bottom=�6o   ���#1e90ff$*��$Зарегистрироваться��6�   
�������$��14(�6�    � Cursor$
 Hand��6�    5-      ��%^   '��       �� 5.      " ��6   .�5/      ��  �@��CornerRadius$ 5��65   50      51      52      �� 53   
   -   5        $��
BackButton��53      $	��100��6   $��25��6H   $��3��6U   $��2��6b   $��Center=�6v   ���#1e90ff$��
Назад��6�   
�������$��12(�6�   $
 Hand��6�    54      ��%^   '��       �� 55      " ��6   .�56      ��  �@��CornerRadius$ 5��65   57      58      59      5<      5=      