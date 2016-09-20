using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.POS.Host
{
    class MultiChoiceMenu
    {

        private string _menuTitle;
        private List<MenuOption> options;
        private bool quit = false;



        public MultiChoiceMenu(string title)
        {
            _menuTitle = title;
            options = new List<MenuOption>();
        }

        public void Quit()
        {
            quit = true;
        }

        public void Display()
        {
            char keypress = '0';
            while (!quit)
            {

                Console.Out.WriteLine($"==={_menuTitle}===");
                foreach (var o in options)
                {
                    Console.Out.WriteLine($"{o.Keypress}) {o.OptionText}");
                }

                keypress = Console.ReadKey().KeyChar;

                foreach (var o in options)
                {
                    if (keypress == o.Keypress)
                    {
                        o.selected();
                    }
                }
            }
            quit = false;

        }

        public MultiChoiceMenu AddOption(char character, string optionText, OptionDelegate selected)
        {
            var temp = new MenuOption(character, optionText, selected);
            options.Add(temp);
            return this;
        }



        private class MenuOption
        {
            char keypress;
            string optionText;
            public OptionDelegate selected;

            public MenuOption(char c, string o, OptionDelegate s)
            {
                Keypress = c;
                OptionText = o;
                selected = s;
            }

            public char Keypress
            {
                get
                {
                    return keypress;
                }

                set
                {
                    keypress = value;
                }
            }

            public string OptionText
            {
                get
                {
                    return optionText;
                }

                set
                {
                    optionText = value;
                }
            }
        }

    }
}

