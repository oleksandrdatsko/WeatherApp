   M S B A M L   `   `   `  ����E  AWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WeatherApp.ViewsWeatherApp.Views  5   	   "    WeatherApp.Views.WeatherView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WeatherApp.Views     5   	   -   5          � Title$  WeatherView��5   	   $��371.2��6   $	��350��6,   ���	#FFEEECEA$��14(�6O    � 
ResizeMode$ CanMinimize=�5	   	    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�5
   	    � WindowStartupLocation$ CenterScreen=�6(    � WindowStyle$
 None=�6M    � Icon$5 //WeatherApp;component/Resources/OpenWeather.png��5   &   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/   	 �� 
StartPoint$	 0.5,0&�6S   .��5      � 
 � Color$
 Black��6    � Offset$ 0.916Q�6)   � 5      $
 	#FF007B9A��6   $ 0.176Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��184 �6   �� 5      $	��184 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   �� $��0��6   $��0��6%   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   $��0,0,10,0q�6{   .+�5!      �� -   5         ��Name$ RefreshWeatherBtn��5!      $��25��60   $��25��6;   $��0q�6G   ���	#FF007B9A.��5"      �� .+�5#      �� $;��5/WeatherApp;component/Resources/icons8-refresh-64.png��6    � ToolTip$ Refresh��6[   5$      5%      �� 5&      -   5        $ SettingsWeatherBtn��5&      $��25��61   $��25��6<   $��0q�6H   ���	#FF007B9A.��5'      �� .+�5(      �� $<��6/WeatherApp;component/Resources/icons8-settings-64.png��6   $ Settings��6\   5)      5*      �� 5+      -   5        $ AboutWeatherBtn��5+      $��25��6.   $��25��69   $��0q�6E   ���	#FF007B9A$ About��6p   .��5,      �� .+�5-      �� $8��2/WeatherApp;component/Resources/icons8-info-64.png��6   5.      5/      �� 50      -   5        $ CloseWeatherBtn��50      $��25��6.   $��25��69   $��0q�6E   ���	#FFF70303��51      �� 52      $ 0.5,1&�6*   $	 0.5,0&�6;   .��53      � $
 Black��6'   $
 0.01Q�65   � 54      $
 	#FFD35611��6'   $ 0.325Q�69   � 55      $
 	#FF7D2F04��6'   $ 0.851Q�69   56      .��58      �� .+�59      �� $:��4/WeatherApp;component/Resources/icons8-delete-96.png��6   $ Close��6Z   5:      5;      5<      �� 5>   
   -   5         ��Name$ 
currentDay��5>      $��20(�6V   $��Center=�6d   $��15q�6   $��0��6�   $��1��6�   ��6(   ��  �� Path$ 
CurrentDay� �� Mode$ OneWay=�6�   �� 5?   
   -   5        $ currentDate��5?      $��20(�6W   $��Center=�6e   $��1��6�   $��1��6�   $��Right=�6�   $��15q�6�   ��6)   �� $ CurrentDate�$ OneWay=�6�   �� 5A   
   -   5        $ currentLocation��5A      $��20(�6`   $��0��6n   $��2��6~   $��Center=�5B      $��15q�6/   $
��Left=�6;   $��2��5C      ��5A   -   �� $ CurrentLocation�$ OneWay=�5C      �� 5E   
   -	   5        $ currentTemp��5E      $��0��6W   $��3��6g   $��55(�6t    �� Padding$ 10q�6�   ��6)   �� $ CurrentTemp�$ OneWay=�6�   �� 5G   
   -
   5         ��Name$ currentWeatherImg��5G      $��1��6+   $��3��6;   $��Center=�6~   $��Center=�5H      $��UniformToFill=�6-    �� StretchDirection$
 Both=�6F   ��5G   H   �� $ CurrentWeatherImg�$ OneWay=�5H   F   �� 5J   
   $��0��6   $��4��6%   $��15q�62   .+�5K      �� $ 
Horizontal=�6   .+�5L      �� -   5        $ tempHigh��5L      $��High : ��6.   �� 5M      -   5        $ tempHighVal��5M      $��10,0,0,0q�6_   $��Center=�6q   ��61   �� $ TempHighVal�$ OneWay=�6q   5N      �� 5O      $ 
Horizontal=�6   .+�5P      �� -   5        $ tempLow��5P      $��Low :  ��6-   $
��Left=�6<   �� 5Q      -   5        $ 
tempLowVal��5Q      $��10,0,0,0q�6^   $��Right=�6p   ��60   �� $ 
TempLowVal�$ OneWay=�6p   5R      5T      �� 5V   
   $��1��6   $��4��6%   $��Center=�62   $��Center=�6M   .+�5W      �� -   5        $ currentWeatherName��5W      $��20(�6i   $
��Wrap=�6w   $��0,0,5,0q�6�   ��64   �� $ CurrentWeatherName�$ OneWay=�6�   �� 5X      $ 
Horizontal=�6   .+�5Y      �� -   5        $ currentHumidity��5Y      $��Humidity : ��65   �� 5Z      -   5        $ currentHumidityVal��5Z      ��68   �� $ CurrentHumidityVal�$ OneWay=�5[      �� 5\      $ 
Horizontal=�6   .+�5]      �� -   5        $ currentWind��5]      $��Wind : ��61   �� 5^      -   5        $ currentWindVal��5^      ��64   �� $ CurrentWindVal�$ OneWay=�5_      �� 5`      $ 
Horizontal=�6   .+�5a      �� -   5        $ currentWindDirection��5a      $��Direction : ��6:   �� 5b      -   5        $ currentWindDirectionVal��5b      ��6=   �� $ CurrentWindDirectionVal�$ OneWay=�5c      5d      �� 5f   
   $ 
Horizontal=�6   $��0��6.   $��5��6>   $��2��6K   $��
10,10,0,10q�6_   .+�5g      �� -   5        $ lastRefresh��5g      $��Last Refresh : ��6-   $��10(�6D   �� 5h      -   5        $ lastRefreshTimeStamp��5h      $��10(�6n   ��66   �� $ LastRefreshTimeStamp�$ OneWay=�6n   5i      5j      5k      