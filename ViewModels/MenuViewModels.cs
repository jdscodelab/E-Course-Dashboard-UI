using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ECourse_UI.ViewModels
{
    class MenuViewModels
    {

        //i will drop the download link for assets in the description
        private ResourceDictionary dictionary = Application.LoadComponent(new Uri("/ECourse UI;component/assets/icons.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        ObservableCollection<MenuModel> _menuItems { get; set; }

        public ObservableCollection<MenuModel> MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; }
        }

        public MenuViewModels()
        {
            _menuItems = new ObservableCollection<MenuModel>()
            {
                new MenuModel(){ IconData=(PathGeometry)dictionary["dashboard"], MenuName="Dashboard" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["allcourses"], MenuName="All courses" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["folder"], MenuName="Resources" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["profile"], MenuName="Friends" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["chats"], MenuName="Chats" },
                new MenuModel(){ IconData=(PathGeometry)dictionary["settings"], MenuName="Settings" }
            };
        }
    }
}