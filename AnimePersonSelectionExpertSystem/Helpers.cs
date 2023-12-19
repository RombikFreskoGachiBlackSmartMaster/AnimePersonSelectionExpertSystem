using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ExpertSystemLaptopSelection;

public partial class MainWindow : Window
{
    /// <summary>
    /// Отражает какому TabItem соответсвует набор радиокнопок 
    /// </summary>
    private Dictionary<TabItem, List<RadioButton>> GroupsRadioButton = new();
    /// <summary>
    /// Показывает на какой странице сейчас находимся
    /// </summary>
    private TabItem CurrentItem;

    /// <summary>
    /// Необходим для того, чтобы определить какой радиокнопке соответствует какой маршрут
    /// </summary>
    private Dictionary<RadioButton, TabItem> Route = new ();
    private void SwitchTabItem(TabItem tabItem){
        MainTabControl.Items.Clear();
        MainTabControl.Items.Add(tabItem);
        CurrentItem = tabItem;
    }
    private void SwitchTabItemWithRadioButton(object sender, RoutedEventArgs args){
        if(!GroupsRadioButton.ContainsKey(CurrentItem))
            return;
        foreach(RadioButton selectRadioButton in GroupsRadioButton[CurrentItem])
            if((bool)selectRadioButton.IsChecked)
                SwitchTabItem(Route[selectRadioButton]);
    }
    private void InitializeGroupsRadioButtonAndRoute(){
        //1 -  AA
        Route.Add(AA2, AB);
        Route.Add(AA16, CA);
        GroupsRadioButton.Add(AA, new List<RadioButton>{AA2, AA16});
        //2 -  AB
        Route.Add(AB3, AC);
        Route.Add(AB6, AE);
        Route.Add(AB9, BB);
        GroupsRadioButton.Add(AB, new List<RadioButton>{AB3, AB6, AB9});
        //3 -  AC
        Route.Add(AC4, AD);
        Route.Add(AC5, AD5);
        GroupsRadioButton.Add(AC, new List<RadioButton>{AC4, AC5});
        //4 -  AD
        Route.Add(AD35, REZ35);
        Route.Add(AD36, REZ36);
        GroupsRadioButton.Add(AD, new List<RadioButton>{AD35, AD36});
        //5 -  AD5
        Route.Add(AD37, REZ37);
        Route.Add(AD38, REZ38);
        GroupsRadioButton.Add(AD5, new List<RadioButton>{AD37, AD38});
        //6 -  AE
        Route.Add(AE7, BA);
        Route.Add(AE8, BA8);
        GroupsRadioButton.Add(AE, new List<RadioButton>{AE7, AE8});
        //7 -  BA
        Route.Add(BA39, REZ39);
        Route.Add(BA40, REZ40);
        GroupsRadioButton.Add(BA, new List<RadioButton>{BA39, BA40});
        //8 -  BA8
        Route.Add(BA41, REZ41);
        Route.Add(BA42, REZ42);
        GroupsRadioButton.Add(BA8, new List<RadioButton>{BA41, BA42});
        //9 -  BB
        Route.Add(BB10, BC);
        Route.Add(BB13, BC13);
        GroupsRadioButton.Add(BB, new List<RadioButton>{BB10, BB13});
        //11 -  BC
        Route.Add(BC11, BD);
        Route.Add(BC12, BE);
        GroupsRadioButton.Add(BC, new List<RadioButton>{BC11, BC12});
        //12 -  BC13
        Route.Add(BC14, BD14);
        Route.Add(BC15, BE15);
        GroupsRadioButton.Add(BC13, new List<RadioButton>{BC14, BC15});
        //10 -  BD
        Route.Add(BD43, REZ43);
        Route.Add(BD44, REZ44);
        GroupsRadioButton.Add(BD, new List<RadioButton>{BD43, BD44});
        //14 -  BE
        Route.Add(BE45, REZ45);
        Route.Add(BE46, REZ46);
        GroupsRadioButton.Add(BE, new List<RadioButton>{BE45, BE46});
        //13 -  BD14
        Route.Add(BD47, REZ47);
        Route.Add(BD48, REZ48);
        GroupsRadioButton.Add(BD14, new List<RadioButton>{BD47, BD48});
        //15 -  BE15
        Route.Add(BE49, REZ49);
        Route.Add(BE50, REZ50);
        GroupsRadioButton.Add(BE15, new List<RadioButton>{BE49, BE50});
        //16 -  CA
        Route.Add(CA17, CB);
        Route.Add(CA20, CE);
        Route.Add(CA24, CE24);
        GroupsRadioButton.Add(CA, new List<RadioButton>{CA17, CA20, CA24});
        //17 -  CB
        Route.Add(CA18, CC);
        Route.Add(CA19, CD);
        GroupsRadioButton.Add(CB, new List<RadioButton>{CA18, CA19});
        //18 -  CC
        Route.Add(CC51, REZ51);
        Route.Add(CC52, REZ52);
        GroupsRadioButton.Add(CC, new List<RadioButton>{CC51, CC52});
        //19 -  CD
        Route.Add(CD53, REZ53);
        Route.Add(CD54, REZ54);
        GroupsRadioButton.Add(CD, new List<RadioButton>{CD53, CD54});
        //20 -  CE
        Route.Add(CE21, DA);
        Route.Add(CE22, DB);
        Route.Add(CE23, DC);
        GroupsRadioButton.Add(CE, new List<RadioButton>{CE21, CE22, CE23});
        //21 -  DA
        Route.Add(DA55, REZ55);
        Route.Add(DA57, REZ57);
        GroupsRadioButton.Add(DA, new List<RadioButton>{DA55, DA57});
        //22 -  DB
        Route.Add(DB56, REZ56);
        Route.Add(DB58, REZ58);
        GroupsRadioButton.Add(DB, new List<RadioButton>{DB56, DB58});
        //23 -  DC
        Route.Add(DC59, REZ59);
        Route.Add(DC60, REZ60);
        GroupsRadioButton.Add(DC, new List<RadioButton>{DC59, DC60});
        //24 -  CE24
        Route.Add(CE25, DD);
        Route.Add(CE28, EB);
        Route.Add(CE29, EB29);
        GroupsRadioButton.Add(CE24, new List<RadioButton>{CE25, CE28, CE29});
        //25 -  EB
        Route.Add(EB73, REZ73);
        Route.Add(EB74, REZ74);
        GroupsRadioButton.Add(EB, new List<RadioButton>{EB73, EB74});
        //26 -  EB29
        Route.Add(EB30, EC);
        Route.Add(EB31, ED);
        Route.Add(EB32, EC2);
        GroupsRadioButton.Add(EB29, new List<RadioButton>{EB30, EB31, EB32});
        //27 -  DD
        Route.Add(DD26, DE);
        Route.Add(DD27, EA);
        GroupsRadioButton.Add(DD, new List<RadioButton>{DD26, DD27});
        //28 -  DE
        Route.Add(DE62, REZ62);
        Route.Add(DE61, REZ61);
        GroupsRadioButton.Add(DE, new List<RadioButton>{DE62, DE61});
        //29 -  EA
        Route.Add(EA63, REZ63);
        Route.Add(EA64, REZ64);
        GroupsRadioButton.Add(EA, new List<RadioButton>{EA63, EA64});
        //30 -  EC
        Route.Add(EC71, REZ71);
        Route.Add(EC72, REZ72);
        GroupsRadioButton.Add(EC, new List<RadioButton>{EC71, EC72});
        //31 -  ED
        Route.Add(ED69, REZ69);
        Route.Add(ED70, REZ70);
        GroupsRadioButton.Add(ED, new List<RadioButton>{ED69, ED70});
        //32 -  EC2
        Route.Add(EC33, EE);
        Route.Add(EC34, EE2);
        GroupsRadioButton.Add(EC2, new List<RadioButton>{EC33, EC34});
        //33 -  EE
        Route.Add(EE67, REZ67);
        Route.Add(EE68, REZ68);
        GroupsRadioButton.Add(EE, new List<RadioButton>{EE67, EE68});
        //33 -  EE2
        Route.Add(EE65, REZ65);
        Route.Add(EE66, REZ66);
        GroupsRadioButton.Add(EE2, new List<RadioButton>{EE65, EE66});


    
    }
    
}
