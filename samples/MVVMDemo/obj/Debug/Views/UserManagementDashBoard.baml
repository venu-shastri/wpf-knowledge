   M S B A M L   `   `   `  ����C  ?MVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVMDemo.ViewsMVVMDemo.Views  5      ,    &MVVMDemo.Views.UserManagementDashBoard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MVVMDemo.Views     5      .��5	      ]� ��. .+�5
   
   � $��20q�6   $
��Left=�6     � RowDefinitions  5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60    � ColumnDefinitions 5      �� 5      $
��auto �6#   62   �� 5      $
��auto �6#   62   +�5      �� 5      $��2q�6   
�������$��0��6=   $��0��6J   
UserName6d   �� 5      $��2q�6   
�������$��1��6=   $��0��6J   
Password6d   �� 5      $��2q�6   
�������$��2��6=   $��0��6J   Email6a   �� 5      $��2q�65   $	��100��6@   $��0��6L   $��1��6Y   ��6   ��  �� Path$
 Name�6k   �� 5      $��2q�69   $	��100��6D   $��1��6P   $��1��6]   ��6   �� $ Password�.��6m   5      �� 5      $��2q�66   $	��100��6A   $��2��6M   $��1��6Z   ��6   �� $ Email�6l   �� 5       $	��100��6   $��3��6%   $��0��62   $��Register��6B   ��6U   �� $ AddNewUserCommand�6�   �� 5!      $	��100��6   $��3��6%   $��1��62   $��Clear��6B   6T   5#      �� 5$   
   
�������$��10q�6$   $
��Left=�61   $	��250��6G   ._�5%      �� .+�5&      �� $��18(�6   $
��Bold"�6*   Select User6I   �� 5'      -   5         ��Name$ userListCombo��5'       �� DisplayMemberPath$
 Name��6a   ��62   �� $ UserDataModelList�6|   5(      5)      �� 5*   
   $��10q�6   
�������._�5+      �� .+�5,      �� $��18(�6   $
��Bold"�6*   Selected User Details6S   �� 5-         userDataModelDataTemplate#��[  5.   !   ��5-   !   ��  �� ElementName$ userListCombo��$ SelectedItem�5.   l   5/      50      51      52      