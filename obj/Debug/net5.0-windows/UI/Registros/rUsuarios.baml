   M S B A M L   `   `   `  ����K  GRegistroUsuarios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RegistroUsuarios.UI.RegistrosRegistroUsuarios.UI.Registros  5   	   -    'RegistroUsuarios.UI.Registros.rUsuarios   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:RegistroUsuarios.UI.Registros     5   	     � Title$  Registro de Usuarios��5   	   $	��475��6&   $	��548��63   .��5	      ��  �� Orientation$ Vertical=�6   $��0,0,10,6q�6(   .+�5
   
   �� -   5         ��Name$ UsuarioIDLabel��5
      $��Usuario ID: ��6(   �� 5   
   -   5         ��Name$ UsuarioIDTextBox��5      $��22��6,   $	��259��68   $
��Left=�6E   $��5,0,0,0q�6{   ��6`   �� *	UsuarioID+6{   �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $��BuscarButton��5      $��94��6*   $��36��6P   $��Center=�6\   $��300,-30,0,0q�6y   .��5      �� $��/Resources/zoom1.png��6   68   5      5      �� 5   
   -   5        $ FechaIngresoLabel��5      $��Fecha de Ingreso: ��6+   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ FechaIngresoDatePicker��5      $��25��66   $	��259��6B   $
��Left=�6N   $��5,0,0,0q�6�      SelectedDate 6j   �� *FechaIngreso+6�   �� 5   
   -   5        $ 
AliasLabel��5      $��Alias: ��6$   $��26��66   �� 5   
   -   5        $ AliasTextBox��5      $��22��6(   $	��259��64   $
��Left=�6A   $��5,0,0,0q�6t   ��6\   �� *Alias+6t   �� 5   
   -   5        $ NombresLabel��5      $��Nombre Completo: ��6&   $��26��6B   �� 5   
   -	   5        $ NombresTextBox��5      $��22��6*   $	��259��66   $
��Left=�6C   $��5,0,0,0q�6x   ��6^   �� *	Nombres+6x   �� 5   
   -
   5        $ 
EmailLabel��5      $��Email: ��6$   $��26��66   �� 5   
   -   5        $ EmailTextBox��5      $��22��6(   $	��259��64   $
��Left=�6A   $��5,0,0,0q�6t   ��6\   �� *Email+6t   �� 5   
   -   5        $ 
ClaveLabel��5      $��Clave: ��6$   $��26��66   �� 5   
   -   5        $ ClaveTextBox��5      $��22��6(   $	��259��64   $
��Left=�6A   $��5,0,0,0q�6t   ��6\   �� *Clave+6t   �� 5   
   -   5        $ RolLabel��5      $��Rol: ��6"   $��26��62   �� 5   
   -   5         ��Name$ RolComboBox��5      $	��259��6(   $
��Left=�6U   $��5,0,0,0q�6p    �� SelectedValue 64   �� *RolID+6p   �� 5   
   -   5         ��Name$ ActivoCheckBox��5      $��Activo��6+   $
��Left=�6<   $��7,20,0,0q�6t   	 d� 	IsChecked	 6W   �� *Activo+6t   �� 5"   
   $ 
Horizontal=�6   $��38��6.   $��0,10,0,0q�6:   $��Center=�6L   $��Center=�6g   .+�5$      �� -   5        
 ��Name$
 NuevoButton��5$      $��34��6*   $��93��66   .��5%      �� $ 
Horizontal=�6   .+�5&      �� $��/Resources/user.ico��6   �� 5'      $��Nuevo��6   5(      5)      �� 5+      -   5        $
 GuardarButton��5+      $��34��6,   $��93��68   $��5,0,0,0q�6C   .��5,      �� $ 
Horizontal=�6   .+�5-      �� $��/Resources/user_add.ico��6   �� 5.      $��Guardar��6   5/      50      �� 52      -   5        $
 EditarButton��52      $��34��6+   $��93��67   $��5,0,0,0q�6B   .��53      �� $ 
Horizontal=�6   .+�54      �� $��/Resources/user_edit.ico��6   �� 55      $��Editar��6   56      57      �� 59      -   5        $
 EliminarButton��59      $��34��6-   $��93��69   $��5,0,0,0q�6D   .��5:      �� $ 
Horizontal=�6   .+�5;      �� $ ��/Resources/user_delete.ico��6   �� 5<      $��Eliminar��6   5=      5>      5@      5B      5C      