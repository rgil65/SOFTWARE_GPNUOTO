﻿using System.Windows;
using MahApps.Metro.Controls;
using System.Windows.Controls;
using System;
using GalaSoft.MvvmLight.Ioc;
using GPNuoto.ViewModel;
using GPNuoto.Model;

namespace GPNuoto
{
    /// <summary>
    /// Description for SelezionaDataDaCalendarioView.
    /// </summary>
    public partial class AggiungiDataAttivitaView : MetroWindow
    {
        /// <summary>
        /// Initializes a new instance of the SelezionaDataDaCalendarioView class.
        /// </summary>
        /// 
        private UserControl WindowPosizionamento;
        

        public AggiungiDataAttivitaView(UserControl WForCenter)
        {
            WindowPosizionamento = WForCenter;
            InitializeComponent();
            this.DataContext = new SelezioneIntervalloTempoModel();
            
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Point relativePoint = WindowPosizionamento.TransformToAncestor(Application.Current.MainWindow)
                          .Transform(new Point(0, 0));


            this.Left = relativePoint.X - (this.ActualWidth - WindowPosizionamento.ActualWidth)/2.0;
            this.Top = relativePoint.Y - (this.ActualHeight - WindowPosizionamento.ActualHeight) / 2.0;


        }

     
        private void btnChiudiCalendario_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConferma_Click(object sender, RoutedEventArgs e)
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<AddSingoloIngresso>(new AddSingoloIngresso((SelezioneIntervalloTempoModel)this.DataContext));
            this.Close();
        }
    }
}