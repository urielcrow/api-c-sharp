   M S B A M L   `   `   `  ????O  KPildorasInformaticas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PildorasInformaticasPildorasInformaticas  5   	   %    PildorasInformaticas.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PildorasInformaticas     5   	   -   5          ?Name$  
MAinWindow??5   	    ? Title$ 
MainWindow??5   	   $	??600??6   $	??800??6)   $y?Visible=?6P   .??5	      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5        $??	miListBox??5   ~   $
??Left=?6   $	??147??6-   $??	66,21,0,0q?6:   $??0??6M   $	??Top=?6Z   $	??301??6r   6?   ?? 5   
   $	??id:??6   $
??Left=?6   $??
408,16,0,0q?69   $??0??6M   $	??Top=?6Z    J? RenderTransformOrigin$ 0.487,-0.781&?6r   ?? 5   
   $??Marca:??6   $
??Left=?6!   $??
519,17,0,0q?6<   $??0??6P   $	??Top=?6]   ?? 5   
   $??Modelo:??6   $
??Left=?6"   $??
408,46,0,0q?6=   $??0??6Q   $	??Top=?6^   ?? 5   
   -   5        $
??miId??5      $
??Left=?6    $??
433,22,0,0q?6;   $??0??6O   $
??Wrap=?6\   $	??...??6p   $	??Top=?6{   ?? 5   
   -   5        $??miMarca??5      $
??Left=?6#   $??
566,23,0,0q?6>   $??0??6R   $
??Wrap=?6_   $	??...??6s   $	??Top=?6~   $	??225??6?   ?? 5   
   -   5        $??miModelo??5      $
??Left=?6$   $??
464,51,0,0q?6?   $??0??6S   $
??Wrap=?6`   $	??...??6t   $	??Top=?6   $	??225??6?   ?? 5   
   -   5        $??Mostrar Lista??5      $
??Left=?6)   $??519,211,0,0q?6D   $	??Top=?6Y   $??75??6q   6|   ?? 5   
   -   5        $??Ocultar Lista??5      $
??Left=?6)   $??622,211,0,0q?6D   $	??Top=?6Y   $??75??6q   6|   ?? 5   
   -   5        $??
miListBox2??5      $??Stretch=?6$   $??1??6I   ??5      ?? 5      .R?5      ? $??2q?6    ? ColumnDefinitions 5!      ?? 5"      $??* ?6/   6;   ?? 5#      $??* ?6/   6;   ?? 5$      $??* ?6/   6;   ?? 5%      $??* ?6/   6;   ?? 5&      $??* ?6/   6;   .+?5)      ?? $??0??6$   $??Center=?6H   ??64   ?? *id+6H   ?? 5*      $??1??6$   ??64   ?? *brand+?? 5+      $??2??6$   ??64   ?? *model+?? 5,      $??3??6$   ??64   ?? *serie+?? 5-      $??4??6$   $??Center=?64   ?? 5.      $??
btnMostrar??6%   -	   5        $??4??5.   J   $??Mostrar??6Z   $
??Left=?6l   $
??auto??6?   
 ? Tag 67   ?? *id+6?    ?? 5/      $??	btnDelete??6%   -
   5        $??4??5/   I   $??Eliminar??6Y   $
??Left=?6l   $
??auto??6?    66   ?? *id+6?   50      52      53      55      ?? 59   
   -   5        $??
miListBox3??59      $
??Left=?6$   $	??100??6?   $??	10,10,0,0q?6L   $??1??6_   $	??Top=?6l   $	??772??6?   $y?Hidden=?6?   .@?5:      ?? $D??>Aqui ponemos los datos a mostarr e nlug a rdeu naventana modal??6   5;      5=      5@      