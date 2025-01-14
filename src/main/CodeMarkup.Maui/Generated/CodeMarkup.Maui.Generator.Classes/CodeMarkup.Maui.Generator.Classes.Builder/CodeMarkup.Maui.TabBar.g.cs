﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Classes.Builder
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace CodeMarkup.Maui
{
	using CodeMarkup.Maui;

    public partial class TabBar : IList<Microsoft.Maui.Controls.ShellSection>
	{

        // ----- constructors -----

        public TabBar() { }

        public TabBar(out TabBar tabBar) 
        {
            tabBar = this;
        }

        public TabBar(System.Func<TabBar, TabBar> configure) 
        {
            configure(this);
        }

        public TabBar(out TabBar tabBar, System.Func<TabBar, TabBar> configure) 
        {
            tabBar = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellSection this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellSection item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellSection[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellSection> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellSection item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellSection item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellSection item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.ShellSection item) => this.Items.Add(item);

    }
}

#nullable restore
