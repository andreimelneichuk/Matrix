   M S B A M L   `   `   `  ����W  SAPE.WPF.Controls.DynamicGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:APE.WPF.Controls.DynamicGridAPE.WPF.Controls.DynamicGrid  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;    5APE.WPF.Controls.DynamicGrid.DynamicGridSampleControl  �� 
TargetType �� Property �� Value �� 
TargetType � 	Resources   Key.   (APE.WPF.Controls.DynamicGrid.GridHelpers   RowCount �� RelativeSource �� AncestorType   ColumnCount�   �APE.WPF.Controls.DynamicGrid.DynamicGridControl`3[[APE.WPF.Controls.DynamicGrid.SampleGridItem, APE.WPF.Controls.DynamicGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   GridHeaders  GridPanelTemplate  GridPanelContainerStyle
 �� DataType   GridRows J� SnapsToDevicePixels   GridColumns   	DataItems ��Name �� Triggers �� Binding �� Value �� 
TargetName   BooleanToVisibilityConverter �� 	Converter�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      8d2http://schemas.microsoft.com/expression/blend/2008  5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :dynamicGrid*clr-namespace:APE.WPF.Controls.DynamicGrid  5      %l  '         7  7  7  7  7  7  7  �� 5
      "    6   .�5      ��  � ��
 �����6"   �� 5       � ��$ 1q�6&   �� 5   
    � �� 5      �� 5      "   6    5      ���� 5       BooleanToVisibilityConverter  67   �� 5      GridPanelTemplate  .R�5   	   �  6   �� *
RowCount+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL� 5      �� *ColumnCount+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL�5   	   �� 5      GridPanelContainerStyle  .�5       ��  � �� 69   �� *Row+�� 5!   	    � �� 6'   �� *Column+5"   	   5#      .R�5%      �� #��z��5'      #��z��5(      #��z��5)      ._�5+      � .+�5-   	   �� #��z	 6   8��  8�� ��5/   
   �� 50      (��       6   *dynamicGrid:DynamicGridHeader+)$#
 dynamicGrid:DynamicGridHeader��.R�51      �� ��6   �� *	Content+��52      �� *HeaderTemplate+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL���53      �� *HeaderTemplateSelector+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL�54      56   
   �� 59   	   #��z 6   8�� ��5;   
   �� 5<      (��       6   *dynamicGrid:DynamicGridHeader+)$#
 dynamicGrid:DynamicGridHeader��.R�5>      �� $��0,1,0,0q�6   
������� . 6a   5@      ��5C   
   �� 5D      .�5E      ��  � �� 6'   �� *Row+�� 5F       � �� 6*   �� *Column+�� 5G       � �� 6.   �� *ColumnCount+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL�5H      5J   
   �� 5M   	   #��z 6   8�� ��5O   
   �� 5P      (��       6   *dynamicGrid:DynamicGridHeader+)$#
 dynamicGrid:DynamicGridHeader��.R�5R      �� $��1,0,0,0q�6   
�������6F   5T      ��5W   
   �� 5X      .�5Y      ��  � �� 6'   �� *Row+�� 5Z   *    � �� 6H   �� *Column+�� 5[       � �� 6+   �� *
RowCount+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL�5\      5_   
   �� 5b   	   #��z 6   8�� 8�� ��5d   
   �� 5e      (��       6   *!dynamicGrid:DynamicGridDataItem+)$%
 dynamicGrid:DynamicGridDataItem��.R�5f      �� $ Content��6   ��6.   �� *	Content+��5g      �� *DataItemTemplate+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL���5h      �� *DataItemTemplateSelector+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL� 5i      �� 5k       6   �� *	Content+ 65   Z� .a�5l      �� $ Content��6    � y�$ Hidden=�6@   5m      5o      5q   
   �� 5t   	   y�6   �� *IsBusy+8  ��5u      �� *WaitLayerTemplate+ �� *FindAncestor+$* $dynamicGrid:DynamicGridSampleControlL�5v   	   5w      5x      5z      5{      5|      