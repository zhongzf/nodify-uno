﻿using System;
using System.Collections.Generic;
using System.Windows;

namespace Nodifier
{
    public interface IEditor
    {
        IActionsHistory History { get; }

        IReadOnlyCollection<IGraphDecorator> Decorators { get; }

        Point ViewportLocation { get; set; }
        double ViewportZoom { get; set; }
        Size ViewportSize { get; }
        Rect ElementsExtent { get; }
        Rect DecoratorsExtent { get; }

        IEditorSettings Settings { get; }

        void FocusLocation(Point location);
        void FitToScreen(Rect? area = null);
        void ZoomIn();
        void ZoomOut();

        void SelectAll();
        void SelectArea(Rect area);
        void UnselectAll();
        void UnselectArea(Rect area);

        /// <summary>
        /// Called when the view is loaded. Here you can access the size of the elements.
        /// </summary>
        event EventHandler Initialized;
    }
}