﻿namespace CodeMarkup.Maui
{
    public interface IHotReloadHandler
    {
        public bool ReplaceVisualElement(Microsoft.Maui.Controls.VisualElement oldElement, Microsoft.Maui.Controls.VisualElement newElement);
    }
}