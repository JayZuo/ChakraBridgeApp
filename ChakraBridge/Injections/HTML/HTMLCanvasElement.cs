﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChakraBridge
{
    class HTMLCanvasElement : HTMLElement, IHTMLCanvasElement
    {
        private Window window;
        private ICanvasRenderingContext2D context;

        internal HTMLCanvasElement(IWindow window)
            : base(window)
        {
            this.window = (Window)window;

            this.height = this.clientHeight;
            this.width = this.clientWidth;
        }

        public int height { get; }

        public int width { get; }

        public object getContext(string contextType)
        {
            if (contextType == "2d") {
                if (this.context == null) {
                    this.context = new CanvasRenderingContext2D(this.window, this);
                }
                return this.context;
            }
            return null;
        }
    }
}
