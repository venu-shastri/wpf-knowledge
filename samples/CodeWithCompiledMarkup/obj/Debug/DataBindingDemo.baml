   M S B A M L   `   `   `  ����Q  MCodeWithCompiledMarkup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CodeWithCompiledMarkupCodeWithCompiledMarkup  5   	   U/clr-namespace:CodeWithCompiledMarkup.Converters!CodeWithCompiledMarkup.Converters  5   	   ,    &CodeWithCompiledMarkup.DataBindingDemo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CodeWithCompiledMarkup     5   	   F
converters/clr-namespace:CodeWithCompiledMarkup.Converters     5   	     � Title$  DataBindingDemo��5	   	   $	��450��6!   $	��800��6.    � 	Resources 5
      <   6CodeWithCompiledMarkup.Converters.SliderValueConverter 
  svcRef:   4CodeWithCompiledMarkup.Converters.NameValueConverter 
 nvcRef�� 5   
   %:   &	        &	        5      6?     5      6=   5      .��5      �� .+�5   
   �� -   5         ��Name$ zoomControl��5   ,    � Minimum$ 10Q�6    � Maximum$	 100Q�6   $��50q�6A    �� TickPlacement$ BottomRight=�5       �� TickFrequency$ 5Q�6-    �� IsSnapToTickEnabled . 6�   �� 5   
   -   5         ��Name$ 
canvasArea��5   !   
����  ���5      �� 	 �� ElementName$	 zoomControl��
 �� Path$
 Value� �� Mode$ OneWay=� �� 	Converter# [  ��5      �� $	 zoomControl��$
 Value�$ OneWay=�# [  5   @   �� 5   
   $��50q�6   $	��100��6   ��5      �� $	 zoomControl��$
 Value�$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�# [  5    ?   �� 5"   
   -   5         ��Name$ 	firstName��5"      $	��100��6%   $��10q�61   6?   �� 5#   
   -   5        $ 
middleName��5#      $	��100��6&   $��10q�62   6@   �� 5$   
   -   5        $ lastName��5$      $	��100��6$   $��10q�60   6>   �� 5&   
   -   5        $ fullNale��5&      $	��100��6$   .��60   ��5'      `� 5(       `� 	Converter# [ 6   1�5)      �� 5*      $	 	firstName��6"   $

 Text�6:   6H   �� 5+      $	 
middleName��6"   $

 Text�6;   6I   �� 5,      $	 lastName��6"   $

 Text�69   6G   5.      .��5/      50      51      52      