﻿using Microsoft.AspNetCore.Components;

namespace Arcemi.SaveGameEditor.Components
{
    public interface ITabController
    {
        void ForceRefresh();
        void Attach(ITabControl tab);
        void Detach(ITabControl tab);
    }
    public interface ITabControl
    {
        string Name { get; }
        int Index { get; set; }
        RenderFragment Content { get; }
    }
}
