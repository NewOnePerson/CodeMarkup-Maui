﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class SwipeGestureRecognizer : Sharp.UI.ISwipeGestureRecognizer, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.SwipeGestureRecognizer MauiObject { get => (Microsoft.Maui.Controls.SwipeGestureRecognizer)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected SwipeGestureRecognizer(Microsoft.Maui.Controls.SwipeGestureRecognizer swipeGestureRecognizer)
        {
            MauiObject = swipeGestureRecognizer;
        }

        public SwipeGestureRecognizer()
        {
            MauiObject = new Microsoft.Maui.Controls.SwipeGestureRecognizer();
        }

        public SwipeGestureRecognizer(out SwipeGestureRecognizer swipeGestureRecognizer) : this()
        {
            swipeGestureRecognizer = this;
        }

        public SwipeGestureRecognizer(Action<SwipeGestureRecognizer> configure) : this()
        {
            configure(this);
        }

        public SwipeGestureRecognizer(out SwipeGestureRecognizer swipeGestureRecognizer, Action<SwipeGestureRecognizer> configure) : this()
        {
            swipeGestureRecognizer = this;
            configure(this);
        }

        public SwipeGestureRecognizer(Microsoft.Maui.SwipeDirection direction) : this()
        {  
            this.Direction = direction;
        }

        public SwipeGestureRecognizer(Microsoft.Maui.SwipeDirection direction, out SwipeGestureRecognizer swipeGestureRecognizer) : this()
        {  
            this.Direction = direction;;
            swipeGestureRecognizer = this;
        }

        public SwipeGestureRecognizer(Microsoft.Maui.SwipeDirection direction, Action<SwipeGestureRecognizer> configure) : this()
        {  
            this.Direction = direction;
            configure(this);
        }

        public SwipeGestureRecognizer(Microsoft.Maui.SwipeDirection direction, out SwipeGestureRecognizer swipeGestureRecognizer, Action<SwipeGestureRecognizer> configure) : this()
        {  
            this.Direction = direction;
            swipeGestureRecognizer = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator SwipeGestureRecognizer(Microsoft.Maui.Controls.SwipeGestureRecognizer mauiObject) => new SwipeGestureRecognizer(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.SwipeGestureRecognizer(SwipeGestureRecognizer obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty CommandProperty => Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandProperty;
        public static Microsoft.Maui.Controls.BindableProperty CommandParameterProperty => Microsoft.Maui.Controls.SwipeGestureRecognizer.CommandParameterProperty;
        public static Microsoft.Maui.Controls.BindableProperty DirectionProperty => Microsoft.Maui.Controls.SwipeGestureRecognizer.DirectionProperty;
        public static Microsoft.Maui.Controls.BindableProperty ThresholdProperty => Microsoft.Maui.Controls.SwipeGestureRecognizer.ThresholdProperty;
        public static Microsoft.Maui.Controls.BindableProperty AutomationIdProperty => Microsoft.Maui.Controls.Element.AutomationIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty ClassIdProperty => Microsoft.Maui.Controls.Element.ClassIdProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public System.Windows.Input.ICommand Command { get => MauiObject.Command; set => MauiObject.Command = value; }
        public object CommandParameter { get => MauiObject.CommandParameter; set => MauiObject.CommandParameter = value; }
        public Microsoft.Maui.SwipeDirection Direction { get => MauiObject.Direction; set => MauiObject.Direction = value; }
        public uint Threshold { get => MauiObject.Threshold; set => MauiObject.Threshold = value; }
        public event System.EventHandler<Microsoft.Maui.Controls.SwipedEventArgs> Swiped { add => MauiObject.Swiped += value; remove => MauiObject.Swiped -= value; }
        public string AutomationId { get => MauiObject.AutomationId; set => MauiObject.AutomationId = value; }
        public string ClassId { get => MauiObject.ClassId; set => MauiObject.ClassId = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Effect> Effects { get => MauiObject.Effects; }
        public System.Guid Id { get => MauiObject.Id; }
        public string StyleId { get => MauiObject.StyleId; set => MauiObject.StyleId = value; }
        public Microsoft.Maui.Controls.Element RealParent { get => MauiObject.RealParent; }
        public Microsoft.Maui.Controls.Element Parent { get => MauiObject.Parent; set => MauiObject.Parent = value; }
        public Microsoft.Maui.Controls.IEffectControlProvider EffectControlProvider { get => MauiObject.EffectControlProvider; set => MauiObject.EffectControlProvider = value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildAdded { add => MauiObject.ChildAdded += value; remove => MauiObject.ChildAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> ChildRemoved { add => MauiObject.ChildRemoved += value; remove => MauiObject.ChildRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantAdded { add => MauiObject.DescendantAdded += value; remove => MauiObject.DescendantAdded -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ElementEventArgs> DescendantRemoved { add => MauiObject.DescendantRemoved += value; remove => MauiObject.DescendantRemoved -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.ParentChangingEventArgs> ParentChanging { add => MauiObject.ParentChanging += value; remove => MauiObject.ParentChanging -= value; }
        public event System.EventHandler ParentChanged { add => MauiObject.ParentChanged += value; remove => MauiObject.ParentChanged -= value; }
        public event System.EventHandler<Microsoft.Maui.Controls.HandlerChangingEventArgs> HandlerChanging { add => MauiObject.HandlerChanging += value; remove => MauiObject.HandlerChanging -= value; }
        public event System.EventHandler HandlerChanged { add => MauiObject.HandlerChanged += value; remove => MauiObject.HandlerChanged -= value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }
        // ----- binding context -----

        public object BindingContext
        {
            get => MauiObject.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                MauiObject.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669