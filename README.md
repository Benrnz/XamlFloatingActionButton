# Xaml Floating Action Button
A Floating Action Button implementation designed for Xamarin Forms XAML for Android

Based on James Montemagno's Floating Action Button examples here: https://github.com/jamesmontemagno/FloatingActionButton-for-Xamarin.Android

## Known Issues
* When the list of objects being bound to contains duplicates the FAB will display weird hiding and showing behaviour.

## How to use it
Best place to start is to clone this repo and take a look at how its used.  

At this stage the control is not encapsulated in any way other than copying the necessary files from this example into your App.
Steps
-----
1. Include the Nuget Package Refractored.FloatingActionButton. This example uses v1.3.
2. Copy the following code classes into your PCL: `FloatingActionButtonSize.cs`, `FloatingActionButtonView.cs`
3. Copy the following files into your Droid project: `FloatingActionButtonViewRenderer.cs`. Also copy the image `ic_add.png` into `/Resources/drawable_*`
4. Use the FAB in Xaml as demonstrated below:
`
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:fabTest1="clr-namespace:FABTest1;assembly=FABTest1"
             x:Class="FABTest1.Page1">
    <AbsoluteLayout VerticalOptions="FillAndExpand"
                    HorizontalOptions="FillAndExpand">
        <StackLayout AbsoluteLayout.LayoutFlags="All"
                     AbsoluteLayout.LayoutBounds="0,0,1,1">
            <Label Text="FAB Test 1"
                   VerticalOptions="Center"
                   HorizontalOptions="Center" />
            <ListView x:Name="MainList" 
                      ItemsSource="{Binding MyItems}"
                      VerticalOptions="FillAndExpand"/>
        </StackLayout>
        <fabTest1:FloatingActionButtonView x:Name="Fab" 
                                           AbsoluteLayout.LayoutFlags="PositionProportional" 
                                           AbsoluteLayout.LayoutBounds="1,1,AutoSize,AutoSize"
                                           ImageName="ic_add.png"
                                           ColorNormal="#ff3498db"
                                           ColorPressed="Black"
                                           ColorRipple="#ff3498db"
                                           Command="{Binding FabExecuteCommand}"
                                           ParentList="{Binding Source={x:Reference MainList}, Path=.}"/>
       
    </AbsoluteLayout>
</ContentPage>
`

## Far from perfect
There's more than a few rough edges here.  If you'd like to help improve it, be my guest.
I'm also going to explore the new-ish https://components.xamarin.com/view/xamandroidsupportdesign. This may or may not make this better. 
