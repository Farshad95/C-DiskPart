   M S B A M L   `   `   `  ����D  @VHD-TOOLS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:VHD_TOOLS	VHD_TOOLS  5   	       VHD_TOOLS.NewDiskWiz   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:VHD_TOOLS     5   	     � Title$  
NewDiskWiz��5   	   $	��377��6   $	��464��6)   .��5	      � $��0,0,2,-1q�6   $	��337��6   $	��Top=�6*   .+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Options��6%   $��20,37.04,10,0q�66   $��152.96��6M   $	��Top=�6]   .��5      � .+�5      �� -   5         ��Name$ FormatChkBox��5   6   $��Format��6L   $	��Top=�6]   $��
10,10,78,0q�6u   � 5      -   5         �Name$ 
FormatGrid��5      {�.  $
��Left=�6=   $	��189��6X   .+�5      �� $��Format Type:��6   $��	19,26,0,0q�63   $��29��6F   $	��Top=�6R   $
��Left=�6�   $	��175��6�   	� 5      -   5         	�Name$
 ntfs��5   "    	� 	GroupName$ 
FormatType��60   $��19��6G   $��23.095,0,-5,16.851q�6S   $��Bottom=�6o   $
��Left=�6�   $��170.905��6�   .��6�   NTFS6�   	� 5      -   5        $ fat32��5   "   $ 
FormatType��61   $��23.095,0,-5,38.383q�6H   $
��Left=�6d   $��170.905��6   $��17��6�   $��Bottom=�6�   .��6�   FAT326�   	� 5      -   5        $ exfat��5   "   $ 
FormatType��61   $��23.095,55,0,56q�6H   $
��Left=�6`   $��170.905��6{   .��6�   exFAT6�   5      �� 5      $��
File Type:��6   $��189,10,43,0q�6-   $��27.761��6B   $	��Top=�6R   	� 5      -   5        $ 	FixedSize��5      $ FileType��61   $��199.822,62.43,19,48.598q�6F   .��6�   
Fixed Size6�   	� 5      -   5        $ ExpandableSize��5      $ FileType��67   $��199.822,42.761,19,0q�6L   $��19.669��6i   $	��Top=�6y   .��6�   Expandable Size6�   �� 5      $��	Size:(MB)��6   $��24��6,   $��
0,0,128,10q�68   $��Bottom=�6L   $��Right=�6g   $��65��6�   �� 5      -	   5         ��Name$ 	ImageSize��5      $��Right=�6-   $��19��6I   $��Bottom=�6U   $��80��6p   $��	0,0,48,10q�6{   6�   5      5      �� 5   
   $
��Save��6   $
��Left=�6   $��25��6:   $	��Top=�6F   $��39��6^   $��
20,200,0,0q�6i   �� 5    
   -
   5        $ Input_txtbx��5       $��27��6'   $��
59,203,0,0q�63   $	��Top=�6G   $
��Left=�6_   $	��286��6z   �� 5!   
   -   5         ��Name$ 	Browsebtt��5!      $��Browse��6$   $
��Left=�6M   $��27��6h   $	��Top=�6t   $��94��6�   $��350,203,0,0q�6�   �� 5"   
   -   5        $ Savebtt��5"      {�.  $
��Left=�6J   $	��119��6e   $��325,252,0,0q�6q   $��75��6�   $	��Top=�6�   .��5#      � .+�5$      �� $��
floppy.ico��6   �� 5%      $
��Save��6   $��30.25��6'   5&      5'      5*      5+      