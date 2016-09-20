using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.POS.Host
{
    class EntryMenu
    {
        private string _menuTitle;
        private string _inputText;
        private string _userInput;

        public EntryMenu(string menuTitle, string inputText)
        {
            _menuTitle = menuTitle;
            _inputText = inputText;
        }

        public string MenuTitle
        {
            get
            {
                return _menuTitle ?? "";
            }

            set
            {
                _menuTitle = value;
            }
        }

        public string InputText
        {
            get
            {
                return _inputText ?? "";
            }

            set
            {
                _inputText = value;
            }
        }

        public string UserInput
        {
            get
            {
                Display();
                return _userInput;
            }

        }



        private string Display()
        {
            Console.Out.WriteLine($"==={_menuTitle}===\n{_inputText}");
            _userInput = Console.In.ReadLine();
            return _userInput;
        }


    }
}
