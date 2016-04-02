﻿using System;
using Xamarin.Forms;

namespace FABTest1
{
    public class FloatingActionButtonView : View
    {
        public static readonly BindableProperty ImageNameProperty = BindableProperty.Create<FloatingActionButtonView, string>(p => p.ImageName, string.Empty);
        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        public static readonly BindableProperty ColorNormalProperty = BindableProperty.Create<FloatingActionButtonView, Color>(p => p.ColorNormal, Color.White);
        public Color ColorNormal
        {
            get { return (Color)GetValue(ColorNormalProperty); }
            set { SetValue(ColorNormalProperty, value); }
        }

        public static readonly BindableProperty ColorPressedProperty = BindableProperty.Create<FloatingActionButtonView, Color>(p => p.ColorPressed, Color.White);
        public Color ColorPressed
        {
            get { return (Color)GetValue(ColorPressedProperty); }
            set { SetValue(ColorPressedProperty, value); }
        }

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof (Command), typeof (FloatingActionButtonView), null, BindingMode.OneWay);
        public Command Command
        {
            get { return (Command) GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

		// Experimental - Hiding and showing the FAB correctly is dependent on the objects in the list being unique
        public static readonly BindableProperty ParentListProperty = BindableProperty.Create(nameof(ParentList), typeof(ListView), typeof(FloatingActionButtonView), null, BindingMode.TwoWay);
        public ListView ParentList
        {
            get { return (ListView) GetValue(ParentListProperty); }
            set { SetValue(ParentListProperty, value); }
        }

        public static readonly BindableProperty ColorRippleProperty = BindableProperty.Create<FloatingActionButtonView, Color>(p => p.ColorRipple, Color.White);
        public Color ColorRipple
        {
            get { return (Color)GetValue(ColorRippleProperty); }
            set { SetValue(ColorRippleProperty, value); }
        }

        public static readonly BindableProperty SizeProperty = BindableProperty.Create<FloatingActionButtonView, FloatingActionButtonSize>(p => p.Size, FloatingActionButtonSize.Normal);
        public FloatingActionButtonSize Size
        {
            get { return (FloatingActionButtonSize)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly BindableProperty HasShadowProperty = BindableProperty.Create<FloatingActionButtonView, bool>(p => p.HasShadow, true);
        public bool HasShadow
        {
            get { return (bool)GetValue(HasShadowProperty); }
            set { SetValue(HasShadowProperty, value); }
        }

        public delegate void ShowHideDelegate(bool animate = true);
        public delegate void AttachToListViewDelegate(ListView listView);

        public ShowHideDelegate Show { get; set; }
        public ShowHideDelegate Hide { get; set; }
        public Action<object, EventArgs> Clicked { get; set; }
    }
}

