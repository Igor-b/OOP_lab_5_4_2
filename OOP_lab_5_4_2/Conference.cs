using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_5_4_1
{
    abstract class Conference
    {
        private string _name;
        private string _place;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Place
        {
            get => _place;
            set => _place = value;
        }

        public virtual string UkrainianI(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                if (ch[i] == 'і')
                {
                    ch[i] = 'i';
                }

                if (ch[i] == 'І')
                {
                    ch[i] = 'I';
                }
            }

            return new string(ch);
        }
    }
}
