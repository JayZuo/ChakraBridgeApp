﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChakraBridge
{
    public interface IElement : INode
    {
        int clientHeight { get; }
        int clientLeft { get; }
        int clientTop { get; }
        int clientWidth { get; }
        bool hasAttribute(string attName);
        string getAttribute(string attributeName);
        void setAttribute(string name, string value);
    }
}
