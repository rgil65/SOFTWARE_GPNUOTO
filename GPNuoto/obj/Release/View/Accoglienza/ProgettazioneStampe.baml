   M S B A M L   `   `   `  ����   GPNuoto!    GPNuoto.ProgettazioneStampe   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0ignorehttp://www.galasoft.ch/ignore       � DataContext  �� *
Ricevuta+   Locator �� Source# [  .��� .+�.� $��10,10,10,10q�.��/�  /� 
PageHeight$ 14.8cm�� /� 	PageWidth$
 21cm�� /� PagePadding$ 0.5cm,0,0.5cm,0q� /� 
Background
 ����� /� 
FontFamily$ Calibri)� /� FontSize$ 14(� /� ColumnWidth$ 999999��.T��� 	 �� BorderThickness$	 0q�
 �� BorderBrush

 �� �� �� Columns ��  �� Width$
 15cm ��� $	 4cm �.��� .��� .���  �� TextAlignment$
 Left=�.��� .r��� $��Report/logoxricevute.png��$	��8cm��$
��Left=�$	��Top=�$��0q���  �� Margin$ 10,0,0,0q�.�J� .*�.*�P.I. 02570240271�� (&Via G. Di Vittorio 15, 30034 Mira (VE)�� Tel. 041 422019�� segreteria@gpnuotomira.it�� .�J� $ 	0,1cm,0,0q�.*�.*��� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve.�Ricevuta n.  �� ��� *NumeroRicevuta+ �� $�/�� �� ��� *Pagamento.DataPagamento+ �� StringFormat$ {0:yyyy}�� �� ConverterCulture$ it-IT��J� .*�.*���  preserve.�Data: �� ��� *Pagamento.DataPagamento+$ {0:dd/MM/yyyy}��$ it-IT���� $	 0q�

 �   � �� $	 7cm ��� $ 12.8cm �.��� .��� .��� �� .���  �� $	 3cm ��� $
 10cm �.��� .��� .��� .�J� .*�RICEVUTO DA:�� .�J� .*�.*��� ��� *Anagrafica.Cognome+ �� Mode$ OneWay=� ��  preserve��� *Anagrafica.Nome+$ OneWay=��� �� ��� *Anagrafica.Indirizzo+$ OneWay=� �� $�-�� �� ��� *Anagrafica.CAP+$ OneWay=� �� ��� *ComuneResidenza+$ OneWay=��� �� $
�C.F.�� �� ��� *Anagrafica.CodiceFiscale+$ OneWay=��� .��� .��� .�J� .*�LA SOMMA DI:�� .�J� $
��Bold"�.*�.*��� ��� *Pagamento.ImportoPagato+$ C��$ it-IT��$ OneWay=��� .���  �� 
ColumnSpan$ 2��.�J� $ 0,10,0,0q�.*�.*��� .F��� $
��Wrap=����� *Pagamento.Descrizione+�� .��� .�J� $ 0,10,0,0q�.*�
PAGAMENTO:�� .�J� $ 0,10,0,0q�.*�.*��� ��� *)'Pagamento.ModalitaPagamento.Descrizione+$ OneWay=��� .��� �� $ Center=�.�J� .*�.*��� .�FIRMA�� �� ��� *Pagamento.User+$ OneWay=�