﻿using System;
using System.Collections.Generic;
using System.IO;
using Windows.UI.Xaml.Media;

namespace Wox.Plugin
{

    public class ContextMenuResult
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string Glyph { get; set; }

        public string FontFamily { get; set; }

        public string AcceleratorKey { get; set; }

        public string AcceleratorModifiers { get; set; }

        /// <summary>
        /// return true to hide wox after select result
        /// </summary>
        public Func<ActionContext, bool> Action { get; set; }

        public override string ToString()
        {
            return Title + SubTitle;
        }
    }
}