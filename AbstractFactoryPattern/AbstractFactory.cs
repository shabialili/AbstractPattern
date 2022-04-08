using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface Button
    {
        void Paint();
    }
    class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("WinButton");
        }
    }
    class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("MacButton");
        }
    }
    interface CheckBox
    {
        void Paint();
    }
    class WinCheckBox : CheckBox
    {
        public void Paint()
        {
            Console.WriteLine("WinCheckBox");
        }
    }
    class MacCheckBox : CheckBox
    {
        public void Paint()
        {
            Console.WriteLine("MacCheckBox");
        }
    }
    interface GUIFactory
    {
        Button CreateButton();
        CheckBox CreateCheckBox();
    }
    class WinFactory : GUIFactory
    {
        public Button CreateButton() => new WinButton();
        public CheckBox CreateCheckBox() => new WinCheckBox();
    }
    class MacFactory : GUIFactory
    {
        public Button CreateButton() => new MacButton();
        public CheckBox CreateCheckBox() => new MacCheckBox();
    }
    class Applcation
    {
        private GUIFactory factory;
        private Button button;
        public Applcation(GUIFactory factory)
        {
            this.factory = factory;
        }
        public void CreatUI()
        {
            button = factory.CreateButton();
        }
        public void Paint()
        {
            button.Paint();
        }
    }
}
