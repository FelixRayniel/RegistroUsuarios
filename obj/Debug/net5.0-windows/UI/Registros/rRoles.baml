   M S B A M L   `   `   `  ����K  GRegistroUsuarios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RegistroUsuarios.UI.RegistrosRegistroUsuarios.UI.Registros  5   	   *    $RegistroUsuarios.UI.Registros.rRoles   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:RegistroUsuarios.UI.Registros     5   	     � Title$  Registro de Roles��5   	   $	��271��6#   $	��546��60   .��5	      �� -   5         ��Name$ 	Contenido��5	       �� Orientation$ Vertical=�6$   $��	0,0,10,10q�6;   .+�5
   
   �� -   5         ��Name$ RolLabel��5
      $��Rol ID: ��6"   �� 5   
   -   5         ��Name$ RolIDTextBox��5      $��22��6(   $	��259��64   $
��Left=�6A   $��5,0,0,0q�6s   ��6\   �� *RolID+6s   �� 5   	   $ 
Horizontal=�6   .+�5      �� -   5        $��BuscarButton��5      $��94��6*   $��36��6P   $��Center=�6\   $��300,-30,0,0q�6y   .��5      �� $��/Resources/zoom1.png��6   68   5      5      �� 5   
   -   5        $ 
FechaLabel��5      $��Fecha: ��6$   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Fecha��5      $��25��6$   $	��259��60   $
��Left=�6<   $��5,0,0,0q�6v      SelectedDate 6W   �� *Fecha+6v   �� 5   
   -   5        $ DescripcionLabel��5      $��Descripcion: ��6*   $��26��6B   �� 5   
   -   5        $ DescripcionTextBox��5      $��22��6.   $	��259��6:   $
��Left=�6G   $��5,0,0,0q�6   ��6b   �� *Descripcion+6   �� 5   
   -	   5        $ ButtonPanel��5      $ 
Horizontal=�6*   $��38��6C   $��0,10,0,0q�6O   $��Center=�6a   $��Center=�6|   .+�5      �� -
   5         ��Name$ NuevoButton��5      $��34��6*   $��93��66   .��5      �� $ 
Horizontal=�6   .+�5      �� $��/Resources/New.png��6   �� 5      $��Nuevo��6   5      5      �� 5!      -   5        $ GuardarButton��5!      $��34��6,   $��93��68   $��5,0,0,0q�6C   .��5"      �� $ 
Horizontal=�6   .+�5#      �� $��/Resources/SaveAdd.png��6   �� 5$      $��Guardar��6   5%      5&      �� 5(      -   5        $ EditarButton��5(      $��34��6+   $��93��67   $��5,0,0,0q�6B   .��5)      �� $ 
Horizontal=�6   .+�5*      �� $��/Resources/Edit.png��6   �� 5+      $��Editar��6   5,      5-      �� 5/      -   5        $ EliminarButton��5/      $��34��6-   $��93��69   $��5,0,0,0q�6D   .��50      �� $ 
Horizontal=�6   .+�51      �� $��/Resources/delete.png��6   �� 52      $��Eliminar��6   53      54      56      57      58      