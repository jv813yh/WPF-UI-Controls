# WPF Custom Controls
This repository contains three custom controls that can be used in WPF applications. Each control provides unique functionality and is designed to enhance the user experience.
In the Windows folder there are examples of a suitable uses for each element, especially how it can be easily implemented. Examples use changing styles, using animations, reacting to events...

## 1. Custom Hamburger Menu Control
The Custom Hamburger Menu Control, also known as a navigation drawer, is a versatile control commonly used for navigation purposes in modern user interfaces. This control is highly customizable and can be integrated seamlessly into your WPF application.

### Features
* Dependency Properties: Leveraging the power of dependency properties for flexible customization.
* Animations: Smooth animations for a more engaging user experience.
* Styling: Customizable styling to match the look and feel of your application.

## 2. Custom Dropdown Menu Control
The Custom Dropdown Menu Control provides a user-friendly dropdown menu with various options, enhancing the navigation experience for users. This control supports SVG icons, making it easy to create visually appealing menus.

### Features
* SVG Icons: Integration of SVG icons for visually rich menu options.
* Dependency Properties: Utilization of dependency properties for customizable behavior.
* Template Bindings: Binding to control templates for dynamic content rendering.
* Popups: Integration of popups for smooth dropdown behavior.

## 3. Placeholder Text Box Control
The Placeholder Text Box Control enhances standard text boxes by providing a placeholder text feature, similar to popular web form inputs. This control is useful for improving user interaction and providing helpful hints.

### Features
* Dependency Properties: Utilizing dependency properties for flexible customization.
* Custom Control Inheritance: Extending existing controls to create custom functionality.
* Converters: Implementation of converters for dynamic content rendering.

## Usage
To use these controls in your WPF application, simply add the provided control classes to your project and integrate them into your XAML files. 

### Very simplified example
(Better usage examples can be found in the Windows folder)
``` xaml
<Window x:Class="MyApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:hmc="clr-namespace:HamburgerMenuControl;assembly=MyApp"
        xmlns:ddm="clr-namespace:DropDownMenuControl;assembly=MyApp"
        xmlns:plchld="clr-namespace:PlaceHolderTextBox;assembly=MyApp"
        Title="MyApp" Height="450" Width="800">
    <Grid>


        <!-- Custom Hamburger Menu -->
        <hmc:HamburgerMenuControl Grid.Column="0">

            <Border Background="White"
                    BorderBrush="LightGray"
                    BorderThickness="1">

                <StackPanel Orientation="Vertical">

                    <Button Content="Edit"
                            Click="OnEditClick"/>

                    <Button Content="Delete"
                            Click="OnDeleteClick"/>

                </StackPanel>
            </Border>
        </hmc:HamburgerMenuControl>

        <!-- Custom Dropdown Menu -->
        <ddm:DropDownMenuControl Grid.Column="1"
                Width="0"
                Background="#f2f2f2"
                BorderBrush="#dbdbdb"
                BorderThickness="0,0,1,0"
                OpenCloseDuration="0:0:0.4"
                IsOpen="{Binding IsChecked, ElementName=cbToggleMenu}">

           <nvgmenu:MyHamburgerMenu.MenuContent>

                    <StackPanel Orientation="Vertical"
                                Margin="5">

                        <nvgmenu:MyHamburgerMenuItem>
                            <TextBlock Text="Introduction"
                                       ToolTip="Brief description ..."/>
                        </nvgmenu:MyHamburgerMenuItem>

                        <nvgmenu:MyHamburgerMenuItem>
                            <TextBlock Text="Getting Started"
                                       ToolTip="Simple start ..."/>
                        </nvgmenu:MyHamburgerMenuItem>

                    </StackPanel>
                </nvgmenu:MyHamburgerMenu.MenuContent>
        </ddm:DropDownMenuControl>
        

        <!-- Placeholder Text Box -->
        <plchld:PlaceHolderTextBox Grid.Column="2"
                                   VerticalAlignment="Center"
                                   Width="300"
                                   Height="40"
                                   Padding="8 8 0 0"
                                   FontSize="16"
                                   PlaceHolder="Search"/>

    </Grid>
</Window>

```
