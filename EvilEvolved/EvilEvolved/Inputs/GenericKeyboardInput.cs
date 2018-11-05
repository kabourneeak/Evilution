﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilutionClass
{
    public class GenericKeyboardInput : GenericInput
    {
        public enum GenericKeyboardInputType { unknown, KeyPressed, KeyReleased };

        public GenericKeyboardInput() : base("keyboard_input")
        {
            this.IsWKeyPress = false;
            this.IsAKeyPress = false;
            this.IsSKeyPress = false;
            this.IsDKeyPress = false;
            this.keyboardInputType = GenericKeyboardInputType.unknown;

        }

        //Properties
        public bool IsWKeyPress { get; set; }
        public bool IsAKeyPress { get; set; }
        public bool IsSKeyPress { get; set; }
        public bool IsDKeyPress { get; set; }


        public GenericKeyboardInputType keyboardInputType { get; set; }
    }
}
