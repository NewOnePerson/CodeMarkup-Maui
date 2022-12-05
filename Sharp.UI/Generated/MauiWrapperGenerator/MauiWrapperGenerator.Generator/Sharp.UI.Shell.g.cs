﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class Shell : Microsoft.Maui.Controls.Shell, Sharp.UI.IShell, IList<Microsoft.Maui.Controls.ShellItem>, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Shell() { }


        public Shell(out Shell shell) 
        {
            shell = this;
        }

        public Shell(Action<Shell> configure) 
        {
            configure(this);
        }

        public Shell(out Shell shell, Action<Shell> configure) 
        {
            shell = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellItem this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.ShellItem item) => this.Items.Add(item);
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellItem item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellItem[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellItem> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellItem item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellItem item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellItem item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
