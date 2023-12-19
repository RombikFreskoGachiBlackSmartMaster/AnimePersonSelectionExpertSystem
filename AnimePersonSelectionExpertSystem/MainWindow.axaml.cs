using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ExpertSystemLaptopSelection;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SwitchTabItem(Start);
        InitializeGroupsRadioButtonAndRoute();
    }
    private void StartButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AA);
    private void BackGreetingButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(Start);
    private void BackAAButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AA);
    private void BackABButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AB);
    private void BackAB2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AB);
    private void BackAB3ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AB);
    private void BackACButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AC);
    private void BackAC2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AC);
    private void BackADButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AD);
    private void BackAD2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AD);
    private void BackAD5ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AD5);
    private void BackAD52ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AD5);
    private void BackAEButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AE);
    private void BackAE2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(AE);
    private void BackBAButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BA);
    private void BackBA2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BA);
    private void BackBA8ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BA8);
    private void BackBA82ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BA8);
    private void BackBBButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BB);
    private void BackBB2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BB);
    private void BackBCButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BC);
    private void BackBC2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BC);
    private void BackBC13ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BC13);
    private void BackBC132ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BC13);
    private void BackBDButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BD);
    private void BackBD2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BD);
    private void BackBD14ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BD14);
    private void BackBD142ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BD14);
    private void BackBEButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BE);
    private void BackBE2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BE);
    private void BackBE15ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BE15);
    private void BackBE152ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(BE15);
    private void BackCAButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CA);
    private void BackCA2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CA);
    private void BackCA3ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CA);
    private void BackCBButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CB);
    private void BackCB2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CB);
    private void BackCCButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CC);
    private void BackCC2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CC);
    private void BackCDButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CD);
    private void BackCD2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CD);
    private void BackCEButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE);
    private void BackCE2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE);
    private void BackCE3ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE);
    private void BackCE24ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE24);
    private void BackCE242ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE24);
    private void BackCE243ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(CE24);
    private void BackDAButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DA);
    private void BackDA2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DA);
    private void BackDBButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DB);
    private void BackDB2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DB);
    private void BackDCButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DC);
    private void BackDC2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DC);
    private void BackDDButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DD);
    private void BackDD2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DD);
    private void BackDEButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DE);
    private void BackDE2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(DE);
    private void BackEAButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EA);
    private void BackEA2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EA);
    private void BackEBButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EB);
    private void BackEB2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EB);
    private void BackEB29ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EB29);
    private void BackEB292ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EB29);
    private void BackEB293ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EB29);
    private void BackECButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EC);
    private void BackEC2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EC);
    private void BackEC22ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EC2);
    private void BackEC223ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EC2);
    private void BackEDButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(ED);
    private void BackED2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(ED);
    private void BackEEButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EE);
    private void BackEE1ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EE);
    private void BackEE2ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EE2);
    private void BackEE23ButtonClick(object sender, RoutedEventArgs args) => SwitchTabItem(EE2);

}