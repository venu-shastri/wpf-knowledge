## UI Types

- Rich UI : Desktop UI , OS Dependent , UI thread can access System resources (FileSystem, Threads,Sockets,registry), Thick Client

  - windows OS : VB, Delphi , WinForms , WPF , MFC
  - IOS : Swift  + XCode
  - Android : Kotlin , JAVA

- Reachable UI : Web Ui (HTML, CSS , JAVASCRIPT , ASP.net, Asp.net MVC , JSP,PHP) 

- Rich Internet Application UI  ; Rich content reachable (Flash,Active-x,Silverlight , Java Fx) , Reachable Content as Rich  (HTML 5.0 + CSS 3.0 , PWA )

- Hybrid UI : Mobile Apps  (Cordova,Ionic )

  

#### UI Rendering - Windows Operating System

---

- Graphic Drivers API
  - Direct - X (Microsoft Game Developers)
    - Vector Graphics (Resolution Independent)
    - Hardware Acceleration (GPU , Graphics Cards (Nvidia G-Force))
    - Advanced Graphic Operation (3D, Animation ,Effects) 
  - GDI 
    - Raster Graphics (Resolution Dependent)
    - Software Acceleration
    - No Support for 3D,Animation.......
- Abstraction over Graphic Drivers API
  - MFC -> GDI
  - VB -> GDI
  - Winform - GDI
  - WPF - Direct-X

### WPF

---

> Managed API for Direct-x
>
> - PresentationCore.dll
> - PresenatationFramewrok.dll
> - WindowsBase.dll
> - System.XAML.dll



### WPF Authoring

---

- Code Only (from Scratch)
- Code with Markup
- Code with Compiled Markup

### Rich UI Composition

----

> WPF Controls can render Rich UI Composition : Text + Media(Audio,Video,Bitmaps) + Graphics (2D,3D ,Shapes)
>
> "ContentControl"  : Base class supports RichUiComposition



### Layout Controls

---

> Arrange UIControls
>
> Built-in Layout Controls
>
> - StackPanel
> - GridPanel
> - Canvas
> - DockPanel
> - WrapPanel



##### XAML

---

Extensible Application Markup Language : XML document used describe wpf UI obejcts



#### WPF Building Blocks

---

1. XAML
2. Markup Extensions
3. Dependency Property System
4. Styles
5. Triggers
6. Databinding
7. Command Pattern
8. Template (Control,Data,Error)
9. Resource Dictionaries
10. MVVM Pattern



#### Markup  Extensions

---

>  Object - returns a value 
>
> Class Derived from Base Class - System.MarkupExtension
>
> XAML :-  {MarkupExtension}
>
> 
>
> ```C#
> public class TestExtension:System.Window.Markup.MarkupExtension{
>     public override object ProvideValue(.....){
>         return "Hello";
>     }
> }
> 
> .xaml
>     
>     <Button Content="{TestExtension}"></Button>
>     // TestExtension obj=new TestExtension();
>     //object value=obj.ProvideValue()
>     // Button.Content=value
>     
> ```
>
> 



## Styles

> Define skin(theme) for control type
>
> Style is a collection Of Setters
>
> Setter -> Dependency Property and Value

```xml
		<Button  Content="Button1" Margin="10" x:Name="button1"></Button>
        <Button  Content="Button2" Margin="10" x:Name="button2"></Button>
        <Button  Content="Button3" Margin="10" x:Name="button3"></Button>
        <Button  Content="Button4" Margin="10" x:Name="button4"></Button>
        <Button  Content="Button5" Margin="10" x:Name="button5"></Button>
```



```C#
//Code
Style _buttonStyle = new Style();

            Setter _heightSetter = new Setter();
            _heightSetter.Property = Button.HeightProperty; //Dependency Property
            _heightSetter.Value = 30d;

            Setter _widthSetter = new Setter(Button.WidthProperty, 100d);
            Setter _fontSizeSetter = new Setter(Button.FontSizeProperty, 12d);
            Setter _foreGroundSetter = new Setter(Button.ForegroundProperty, Brushes.Blue);

            _buttonStyle.Setters.Add(_heightSetter);
            _buttonStyle.Setters.Add(_widthSetter);
            _buttonStyle.Setters.Add(_fontSizeSetter);
            _buttonStyle.Setters.Add(_foreGroundSetter);
            _buttonStyle.Setters.Add(_heightSetter);

            this.button1.Style = _buttonStyle;
            this.button2.Style = _buttonStyle;
            this.button3.Style = _buttonStyle;
            this.button4.Style = _buttonStyle;
            this.button5.Style = _buttonStyle;
```



```XML
  <Button  Content="Button1" Margin="10" x:Name="button1">
            <Button.Style>
                <Style TargetType="Button">
                    <Style.Setters>
                        <Setter Property="Height" Value="30"></Setter>
                        <Setter Property="Width" Value="100"></Setter>
                        <Setter Property="FontSize" Value="12"></Setter>
                        <Setter Property="Foreground" Value="Blue"></Setter>
                    </Style.Setters>
                </Style>
            </Button.Style>
</Button>
```



#### reusability -in xaml

----

> Local Resource Management - using - Resource Dictionaries
>
> Resource : Reusable Object
>
> Resource Dictionary is-a Dictionary
>
> Every  Control - Derived from "FrameworkElement" Base Class will get its own ResourceDictionary
>
> How to Access ?
>
> ```
> Window _window=new Window(); // Derived From FrameworkElement
> _window.Resources.Add(<key>,<value>);
> 
> <Window>
>   <Window.Resources>
>   	<ResourceDictionary>
>   			<!-- Add Objects -->
>   			<Style x:key="buttonStyle"></Style>
>   	</ResourceDictionary>	
>   </Window.Resources>
> <Window>
> ```
>
> ```xml
> <Window x:Class="CodeWithCompiledMarkup.StylesDemo"
>       .......
>         Title="StylesDemo" Height="450" Width="800">
>     <Window.Resources>
>         <ResourceDictionary>
>             <Style x:Key="buttonStyle" TargetType="Button">
>                 <Style.Setters>
>                     <Setter Property="Height" Value="30"></Setter>
>                     <Setter Property="Width" Value="100"></Setter>
>                     <Setter Property="FontSize" Value="12"></Setter>
>                     <Setter Property="Foreground" Value="Blue"></Setter>
>                 </Style.Setters>
>             </Style>
>         </ResourceDictionary>
>     </Window.Resources>
>     <StackPanel>
>         <Button  Content="Button1" Style="{StaticResource ResourceKey=buttonStyle}" Margin="10" x:Name="button1"></Button>
>         <Button  Content="Button2" Style="{StaticResource ResourceKey=buttonStyle}" Margin="10" x:Name="button2"></Button>
>         <Button  Content="Button3" Style="{StaticResource ResourceKey=buttonStyle}" Margin="10" x:Name="button3"></Button>
>         <Button  Content="Button4" Style="{StaticResource ResourceKey=buttonStyle}" Margin="10" x:Name="button4"></Button>
>         <Button  Content="Button5" Style="{StaticResource ResourceKey=buttonStyle}" Margin="10" x:Name="button5"></Button>
>         <StackPanel>
>             <StackPanel.Resources>
>                 <ResourceDictionary>
>                     <Style x:Key="buttonStyle" TargetType="Button">
>                         <Style.Setters>
>                             <Setter Property="Height" Value="30"></Setter>
>                             <Setter Property="Width" Value="100"></Setter>
>                             <Setter Property="FontSize" Value="12"></Setter>
>                             <Setter Property="Foreground" Value="Red"></Setter>
>                         </Style.Setters>
>                     </Style>
>                 </ResourceDictionary>
>             </StackPanel.Resources>
>             <Button  Content="Button6" Margin="10" x:Name="button6" Style="{StaticResource ResourceKey=buttonStyle}"></Button>
>             <Button  Content="Button7" Margin="10" x:Name="button7" Style="{StaticResource ResourceKey=buttonStyle}"></Button>
>             <Button  Content="Button8" Margin="10" x:Name="button8" Style="{StaticResource ResourceKey=buttonStyle}"></Button>
>             <Button  Content="Button9" Margin="10" x:Name="button9" Style="{StaticResource ResourceKey=buttonStyle}"></Button>
>             <Button  Content="Button10" Margin="10" x:Name="button10" Style="{StaticResource ResourceKey=buttonStyle}"></Button>
>         </StackPanel>
>               
>     </StackPanel>
> </Window>
> ```
>
> 



### How to address Resources?

> Resources : xaml , images , icons 
>
> Addressing Scheme : PACK URI 
>
> - Absolute Pack Uri
> - Relative Pack Uri



#### Resource Locations - "build action of resource"

- The current assembly.
- A referenced assembly.
- A location relative to an assembly.
- The application's site of origin.





| Build Action              | Description                                                  |
| ------------------------- | ------------------------------------------------------------ |
| **ApplicationDefinition** | The file that defines your application. When you first create a project, this is *App.xaml** |
| **Page**                  | Compile a XAML file to a binary .baml file for faster loading at run time. and embed  .baml file content to assembly (.exe) |
| **Resource**              | Specifies to embed the file in an assembly manifest resource file with the extension *.g.resources*. (images,icons) |
| **Content**               | A file marked as **Content**  will be copied to application directory .These files are included as part of the application directory  when it's deployed. |



#### Triggers

---

> Object -> enables us to set property of an Control based on conditions
>
> Conditions 
>
> 1. Value of another property
> 2. event
> 3. Value of Databinding Expression
>
> Types of Triggers
>
> - PropertyTrigger
> - EventTrigger
> - DataTrigger
>
> Triggers usually used in style and templates.

```C#
<Style.Triggers>
             <!-- Property Trigger-->
            <Trigger Property="IsMouseOver" Value="true">
                <Trigger.Setters>
                    <Setter Property="Width" Value="150"></Setter>
                    <Setter Property="Height" Value="50"></Setter>
                  </Trigger.Setters>
            </Trigger>
</Style.Triggers>
```

>
>
>Note:- Trigger setters takes precedence over style setters .....Local value takes precedence over  style and trigger setters.



### DataBinding

---

> Connector between two property Values
>
> Source Property: CLR property , DependencyProperty
>
> Target Property : DependencyProperty

ex:

```C#
public class Button{

//DependencyProperty
public static DependencyProperty WidthProperty =DependencyProperty.Register(......);
//CLR Property
public double Width{ }

}
```

#### What is DependencyProperty

---

- Dependency Property can be used to extend the functionality of a Control/Class Property
  - Compute the value of Property based on the value of input providers
  - Enables metadata Support
    - default value 
    - Change Notification
    - Value Corrections

### DataBinding in WPF

---

- use Binding class

  - Mode
  - ElementName
  - Source
  - Path
  - UpdateSourceTrigger
  - Converter
    - IValueConverter - Binding
    - IMultiValuecConverter - MultiBinding (Multiple Source ....Single Target)
  - Validation and ErrorFeedback
    - ValidationRule abstarct class
    - ErrorFeedBack  -> ErrorTemplate (Template -> Presentation)
    - Vaidation.HasError : Value indicates control state
    - Validation.Errors : Latest Error
    - Validation.ErrorTemplate : instance of ControlTemplate

- Define Source object and source Property (Path)

- Set Target Object Dependency Property using **SetBinding** method 

  ```XMl
   <Slider Minimum="10" Maximum="100" x:Name="zoomControl" Margin="50" 
                  TickPlacement="BottomRight" TickFrequency="5" IsSnapToTickEnabled="true" ValueChanged="zoomControl_ValueChanged"></Slider>
          <Rectangle Fill="Blue"  x:Name="canvasArea"></Rectangle>
  
  
  ```

  

```C#
//Code
Binding sliderValueToRectangleWidthConnector = new Binding();
            //Source Information
            sliderValueToRectangleWidthConnector.Source = this.zoomControl;
            sliderValueToRectangleWidthConnector.Path = new PropertyPath("Value");

            //Target
            this.canvasArea.SetBinding(Rectangle.WidthProperty, sliderValueToRectangleWidthConnector);
            this.canvasArea.SetBinding(Rectangle.HeightProperty, sliderValueToRectangleWidthConnector);
```

#### Binding as a MarkupExtension

```xml
 <Slider Minimum="10" Maximum="100" x:Name="zoomControl" Margin="50" 
                TickPlacement="BottomRight" TickFrequency="5" IsSnapToTickEnabled="true" ValueChanged="zoomControl_ValueChanged"></Slider>
        <Rectangle Fill="Blue"  x:Name="canvasArea"
                   Height="{Binding ElementName=zoomControl,Path=Value,Mode=OneWay}"
                   Width="{Binding ElementName=zoomControl,Path=Value,Mode=OneWay}" ></Rectangle>
```



#### Coverters

```C#
public class SliderValueConverter : IValueConverter
    {
        //Value Bind from Source---->Target
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            .....
        }

        //Value Bind From Target To Source
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           ......
        }
    }

 public class NameValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            ....
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            .....
        }
    }
}
```

```xml
<ResourceDictionary>
            <converters:SliderValueConverter x:Key="svcRef"></converters:SliderValueConverter>
            <converters:NameValueConverter x:Key="nvcRef"></converters:NameValueConverter>
 </ResourceDictionary>

//Single Value Binding

  <TextBox Margin="50" Width="100"
                 Text="{Binding 
            ElementName=zoomControl,
            Path=Value,
            Mode=TwoWay,
            UpdateSourceTrigger=PropertyChanged,
            Converter={StaticResource ResourceKey=svcRef}}"></TextBox>

//MultiValue Binding

<TextBox x:Name="firstName" Width="100" Margin="10"></TextBox>
        <TextBox x:Name="middleName" Width="100" Margin="10"></TextBox>
        <TextBox x:Name="lastName" Width="100" Margin="10"></TextBox>

        <TextBox x:Name="fullNale" Width="100">
            <TextBox.Text>
                <MultiBinding Converter="{StaticResource ResourceKey=nvcRef}">
                    <MultiBinding.Bindings>
                        <Binding ElementName="firstName" Path="Text"></Binding>
                        <Binding ElementName="middleName" Path="Text"></Binding>
                        <Binding ElementName="lastName" Path="Text"></Binding>
                    </MultiBinding.Bindings>
                </MultiBinding>
            </TextBox.Text>
        </TextBox>
```



#### DataContext

---

- Source for Data-Binding  to resolve source properties
- {Binding Path=PropertyName}  ** **Do not provide source object information****
- DataContext property get inherited from "FrameworkElement"
- Value of the DataContext Property of root element will pass down through the all the child and descendent nodes.

#### INotifyPropertyChanged in WPF

---

> Used to notify wpf Binding Target about change in the source property value....

#### AdornedElementPlaceholder

> Represents the element used in a [ControlTemplate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.controltemplate?view=netcore-3.1) to specify where a decorated control is placed relative to other elements in the [ControlTemplate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.controltemplate?view=netcore-3.1).