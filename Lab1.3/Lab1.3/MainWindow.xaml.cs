using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    private void planetListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        if (planetListBox.SelectedItem != null)
        {
            string selectedPlanet = ((System.Windows.Controls.ListBoxItem)planetListBox.SelectedItem).Content.ToString();
            string planetInfo = GetPlanetInfo(selectedPlanet);
            planetInfoTextBox.Text = planetInfo;
        }
    }

    private string GetPlanetInfo(string planet)
    {
        switch (planet)
        {
            case "Меркурий":
                return "Меркурий - ближайшая к Солнцу планета в солнечной системе. Названа в честь древнеримского бога торговли — быстрого Меркурия, поскольку она движется по небу быстрее других планет. Её период обращения вокруг Солнца составляет всего 87,97 земных суток — самый короткий среди всех планет Солнечной системы.";
            case "Венера":
                return "Венера - вторая планета от Солнца, самая яркая на небе после Луны. Венерианский год составляет 224,7 земных суток. Она имеет самый длинный период вращения вокруг своей оси среди всех планет Солнечной системы и вращается в направлении, противоположном направлению вращения большинства планет.";
            case "Земля":
                return "Земля - третья по удалённости от Солнца планета Солнечной системы. Самая плотная, пятая по диаметру и массе среди всех планет Солнечной системы и крупнейшая среди планет земной группы.";
            case "Марс":
                return "Марс - четвертая планета от Солнца, называемая 'Красной планетой'. Атмосфера планеты сильно разрежена, магнитное поле слабое. Ось Марса наклонена под углом 25,2 градуса, поэтому зиму сменяет весна, лето — осень.";
            case "Юпитер":
                return "Юпитер - пятая планета от Солнца и самая большая в Солнечной системе. Это газовый гигант с массой в два с половиной раза больше массы всех других планет Солнечной системы вместе взятых, но меньше одной тысячной массы Солнца. Юпитер - третий по яркости природный объект в ночном небе Земли после Луны и Венеры.";
            case "Сатурн":
                return "Сатурн - шестая планета по удалённости от Солнца и вторая по размерам планета в Солнечной системе после Юпитера. Сатурн классифицируется как газовая планета-гигант. ";
            case "Уран":
                return "Уран - седьмая планета от Солнца, ледяной гигант. Уран – самая холодная планета Солнечной системы с минимальной температурой -224 °C.Средний радиус Урана составляет 25 362 ± 7 километров, то есть около 4 радиусов Земли.";
            case "Нептун":
                return "Нептун - восьмая и самая дальняя от Солнца планета Солнечной системы. Его масса превышает массу Земли в 17,2 раза и является третьей среди планет Солнечной системы, а по экваториальному диаметру Нептун занимает четвёртое место, превосходя Землю в 3,9 раза.";
            default:
                return "Информация не найдена.";
        }
    }
}
}
