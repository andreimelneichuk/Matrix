   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  b ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes     WpfApp1.Calculator   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1     ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2       N� Title$  
Calculator�� � 	Resources    Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonTemplate1 �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� Value �� Property  ButtonTemplate2 	 FocusVisual �� StrokeDashArray 
 TextBox.Static.Background  ComboBoxEditableTextBox �� 
TargetType ��Name  ComboBox.Static.Background �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border  ComboBox.Static.Glyph ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border  ComboBox.MouseOver.Glyph * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background +  'ComboBox.Pressed.Editable.Button.Border  ! ComboBox.Disabled.Background " ComboBox.Disabled.Border # ComboBox.Disabled.Glyph )$ %ComboBox.Disabled.Editable.Background %% !ComboBox.Disabled.Editable.Border 0& ,ComboBox.Disabled.Editable.Button.Background ,' (ComboBox.Disabled.Editable.Button.Border ( ComboBoxToggleButton F�Name ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value ) ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency5  /Microsoft.Windows.Themes.SystemDropShadowChrome  Name    Color! �� MaxDropDownHeight" �� ElementName# �� ClearTypeHint$ ��Name% ��Name& ��Name-  'System.Windows.Input.KeyboardNavigation'   DirectionalNavigation( d�Name) d� 	IsChecked* �� Mode+ ��Name, �� 
IsReadOnly- P� 
SourceName. ]� 
Conditions/ �� Property * ComboBoxTemplate#0 �� SelectionBoxItemStringFormat1 �� ContentStringFormat2 �� SelectionBoxItemTemplate3 �� SelectionBoxItem4 J� IsHitTestVisible5 �� Triggers��%|$  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     7   7  7  7  7  7  7  &	 �    7   7  7  7  7  7  7  &		 �    &	
 3    &	 H    &	 �    &	     &	 &    &	 ;    &	 P    &	 e    &	 |    &	 �    &	 �    &	     &	     &	 ,    &	 A    &	 �    &	 �    &	 
	    &	 	    &	 4	    &	 I	    &	 ^	    &	  �	    &	! �	    &	" �	    &	# �	    &	$ 
    &	% !
    &	& 6
    &	' M
    &	( d
    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 # 7 ! 7 " 7 $ 7 % 7 & 7 ' &	) �    7 ( 7 
 7  &	* _    7 ( '�� O     7 	 7  7  7 * 7 ) �� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.R��� $ border��$ 30��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P� 	 �@��IsDefaulted$

 true��. ��� $ border��# � �� � ��P� 	 �@J�IsMouseOver$

 true��. ��� $ border��8    � ���� $ border��8   � ��P� 	 � ��$

 true��. ��� $ border��8   � ���� $ border��8   � ��P� 	 � {�$
 false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� " ��.R��� $ border��$ 10��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P� 	 �@��IsDefaulted$

 true��. ��� $ border��# � �� � ��P� 	 �@J�IsMouseOver$

 true��. ��� $ border��8    � ���� $ border��8   � ��P� 	 � ��$

 true��. ��� $ border��8   � ���� $ border��8   � ��P� 	 � {�$
 false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� .���  � �� �� .R��� $��2q�$	 1 2R�#��� ��$
 true��$��1���� $ 	#FFFFFFFF���� " ��.���  �@�OverridesDefaultStyle$
 true����  �@J�	AllowDrop$
 true����  � ��$ 0����  � ��$ 0����  �@�FocusVisualStyle Z� ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled$ False����  � �� �� " ��.R��� $ PART_ContentHost��
������ $|�false��$��Hidden=�$��Hidden=��� $	 0,1&�$	 0,0&�.��� $ 	#FFF0F0F0��$	 0.0Q�� $ 	#FFE5E5E5��$	 1.0Q��� $ 	#FFACACAC���� $ 	#FF606060���� $ 	#FFFFFFFF���� $ 	#FFABADB3���� $ Transparent���� $ Transparent���� $	 0,1&�$	 0,0&�.��� $ 	#FFECF4FC��$	 0.0Q�� $ 	#FFDCECFC��$	 1.0Q��� $ 	#FF7EB4EA���� $ 	#FF000000���� $ 	#FFFFFFFF���� $ 	#FF7EB4EA���� $	 0,1&�$	 0,0&�.��� $ 	#FFEBF4FC��$	 0.0Q�� $ 	#FFDCECFC��$	 1.0Q��� $ 	#FF7EB4EA���� $	 0,1&�$	 0,0&�.��� $ 	#FFDAECFC��$	 0.0Q�� $ 	#FFC4E0FC��$	 1.0Q��� $ 	#FF569DE5���� $ 	#FF000000���� $ 	#FFFFFFFF���� $ 	#FF569DE5���� $	 0,1&�$	 0,0&�.��� $ 	#FFDAEBFC��$	 0.0Q�� $ 	#FFC4E0FC��$	 1.0Q��� $ 	#FF569DE5���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFBFBFBF���� $ 	#FFFFFFFF���� $ 	#FFBFBFBF���� $ Transparent���� $ Transparent���� " d�.���  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � |�$ false����  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot��$ 10��8��  8�� #��z��$
 true��._��� $ splitBorder��
������ $��1q�$��Right=�$��0q�$
 true��#��� r�._�F� $ arrow��F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�$��0q�$��Center=� ^�  ��  �� *
IsEditable+ �� " �� true��  �� *IsMouseOver+ �� *Self+	 false��  �� *	IsPressed+ �� *Self+	 false��  �� *	IsEnabled+ �� *Self+ true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P� 	 �@J�IsMouseOver$

 true��. ��� $ arrow��8   � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8 	  � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8 
  � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P� 	 � ��$

 true��. ��� $ arrow��8   � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P� 	 � {�$
 false��. ��� $ arrow��8   � ��^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ���� " ��.R�� $ templateRoot��$
 true�� �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup��$
 true��$��2��$��Bottom=�#��� .����� *IsDropDownOpen+ �� *TemplatedParent+.��  $ shadow��$  Transparent��#��z! ���� *ActualWidth+$" templateRoot��._��� $ dropDownBorder��#��� ��#��� ��$��1q�._��� $ DropDownScrollViewer��.��� $
 grid��$# Enabled=�.+��� $$ canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $% 
opaqueRect������ *
Background+$" dropDownBorder������ *ActualHeight+$" dropDownBorder������ *ActualWidth+$" dropDownBorder���� $& ItemsPresenter��$' 	Contained=�# z d� $( toggleButton��#��z��#��z��#��z��$��2��8��  ) �� *IsDropDownOpen+$* TwoWay=� �� *TemplatedParent+�� $ border��8�� #��z��._��� $+ PART_EditableTextBox��#��z��#��z��8�� #��z��, �� *
IsReadOnly+ �� *TemplatedParent+ P� 	 � {�$
 false��. ��� $ border�� �@J�Opacity$
 0.56Q�P� 	 �@J�IsKeyboardFocusWithin$

 true��. ���  � ��
 �   �P� $- 
PART_Popup��	 �@�HasDropShadow$

 true��. ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P� 	 �@��HasItems$
 false��. ��� $ dropDownBorder�� � ��$ 95��]� . �� / �@��
IsGrouping$
 true���� "/ �@%�IsVirtualizingWhenGrouping$ false��./���  � ��$ false��P� $- DropDownScrollViewer��	 � ��$
 false��. ��� $ 
opaqueRect�� �� *VerticalOffset+$" DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$" DropDownScrollViewer�� �@��Left�� " ��.R�� $ templateRoot��$
 true�� �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup��$
 true��$��2��$��1q�$��Bottom=�#��� .����� *IsDropDownOpen+$* TwoWay=� �� *TemplatedParent+.��  $ shadow��$  Transparent��#��z! ���� *ActualWidth+$" templateRoot��._��� $ dropDownBorder��#��� ��#��� ��$��1q�._��� $ DropDownScrollViewer��.��� $
 grid��$# Enabled=�.+��� $$ canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $% 
opaqueRect������ *
Background+$" dropDownBorder������ *ActualHeight+$" dropDownBorder������ *ActualWidth+$" dropDownBorder���� $& ItemsPresenter��$' 	Contained=�# z d� $( toggleButton��#��z��#��z��#��z��$��2��8��  ) �� *IsDropDownOpen+$* TwoWay=� �� *TemplatedParent+�� $ contentPresenter��#1 z0 #��z2 #��z3 #��z��#��z��$4 false��#��z��# z #��z�� P� $- 
PART_Popup��	 �@�HasDropShadow$

 true��. ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P� 	 �@��HasItems$
 false��. ��� $ dropDownBorder�� � ��$ 95��]� . �� / �@��
IsGrouping$
 true���� "/ �@%�IsVirtualizingWhenGrouping$ false��./���  � ��$ false��P� $- DropDownScrollViewer��	 � ��$
 false��. ��� $ 
opaqueRect�� �� *VerticalOffset+$" DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$" DropDownScrollViewer�� �@��Left�� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ 6,3,5,3q���  � ��$
 true����  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled$ False����  � ��8  5 P� 	 �@��
IsEditable$

 true��. ���  � ��$ false����  � ��$ 2q���  � ��8  .��� 
�������$
��1291��$	��889��6 J� RenderTransformOrigin$6 0.555,0.588&�$��Center=�$��Center=� �� �� $��0* �.+��� -   #���  $
��Left=�$��74,0,0,0q�$��Center=�$	��180��$	��404�����	#FF3742FA
�������$��48(�$��Microsoft YaHei Light)�$��Center=�$��Center=�$��Hidden=�.���� $	��120��$-��'/Resources/🦆 icon _close circle_.png��$
��Fill=�$	��120���� #���  $
��Left=�$��	814,0,0,0q�$��Center=�$	��180��$	��405�����	#FF3742FA
�������$��48(�$��Microsoft YaHei Light)�.���� $	��120��$,��&Resources/🦆 icon _close circle_.png��$
��Fill=�$	��120���� $��Center=�$��0,64,0,0q�$
��Wrap=�$	��Top=�$��80(�$	��842��$	��200��$��Microsoft YaHei Light)�7 �� TextAlignment$7 Center=��� $�Калькулятор���� $� ���� �� $�матриц���� -   #���  $)��#Получить результат��$��Center=�$��	0,700,0,0q�$	��Top=�$��98��$	��364�����	#FF2638D4
�������$
��35.5(�$��Microsoft YaHei UI)��� -   $	��272��$��113.5��$��Center=�$��Center=�$��STHupo)�$��72(�#���  ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q�.@��� $	��—��$��Center=�#���  �� $	��✚��$��Center=�
���   ��� $��×��$��Center=�