// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Themes;
    using SynapseGaming.SunBurn.Framework.Primitives;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "0.9.3.0")]
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private Image logo;
        
        private TextBlock e_2;
        
        private StackPanel e_3;
        
        private ComboBox combo;
        
        private Button button1;
        
        private Button button2;
        
        private Button button3;
        
        private TextBlock buttonResult;
        
        private TextBox textBox;
        
        private CheckBox checkBox;
        
        private TabControl e_4;
        
        private ProgressBar e_17;
        
        private Button imageButton;
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            FontManager.Instance.AddFont("Segoe UI", 13.33333F, FontStyle.Regular, "Segoe_UI_10_Regular");
            this.FontSize = 13.33333F;
            this.SetResourceReference(SoundManager.SoundsProperty, "Sounds");
            this.InitializeElementResources(this);
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(110F, GridUnitType.Pixel);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            this.e_0.RowDefinitions.Add(row_e_0_1);
            ColumnDefinition col_e_0_0 = new ColumnDefinition();
            this.e_0.ColumnDefinitions.Add(col_e_0_0);
            // e_1 element
            this.e_1 = new StackPanel();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Background = new SolidColorBrush(new Color(0, 0, 0, 255));
            // logo element
            this.logo = new Image();
            this.e_1.Children.Add(this.logo);
            this.logo.Name = "logo";
            this.logo.HorizontalAlignment = HorizontalAlignment.Center;
            BitmapImage logo_bm = new BitmapImage();
            logo_bm.TextureAsset = "Images/EmptyKeysLogoTextSmall";
            ImageManager.Instance.AddImage("Images/EmptyKeysLogoTextSmall");
            this.logo.Source = logo_bm;
            this.logo.Stretch = Stretch.None;
            this.logo.SetResourceReference(Image.SourceProperty, "logoEmptyKeys");
            // e_2 element
            this.e_2 = new TextBlock();
            this.e_1.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_2.VerticalAlignment = VerticalAlignment.Center;
            this.e_2.Foreground = new Color(211, 211, 211, 255);
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            this.e_2.FontFamily = new FontFamily("Segoe UI");
            this.e_2.FontSize = 20F;
            this.e_2.FontStyle = FontStyle.Bold;
            this.e_2.SetResourceReference(TextBlock.TextProperty, "TitleResource");
            // e_3 element
            this.e_3 = new StackPanel();
            this.e_0.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            Grid.SetRow(this.e_3, 1);
            // combo element
            this.combo = new ComboBox();
            this.e_3.Children.Add(this.combo);
            this.combo.Name = "combo";
            this.combo.Width = 200F;
            this.combo.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.combo.ItemsSource = this.Get_combo_Items();
            // button1 element
            this.button1 = new Button();
            this.e_3.Children.Add(this.button1);
            this.button1.Name = "button1";
            this.button1.Height = 30F;
            this.button1.Width = 200F;
            this.button1.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button1.Content = "1";
            this.button1.CommandParameter = "Click Button 1";
            Binding binding_button1_Command = new Binding("ButtonCommand");
            this.button1.SetBinding(Button.CommandProperty, binding_button1_Command);
            // button2 element
            this.button2 = new Button();
            this.e_3.Children.Add(this.button2);
            this.button2.Name = "button2";
            this.button2.Height = 30F;
            this.button2.Width = 200F;
            this.button2.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button2.Content = "2";
            this.button2.CommandParameter = "Click Button 2";
            Binding binding_button2_Command = new Binding("ButtonCommand");
            this.button2.SetBinding(Button.CommandProperty, binding_button2_Command);
            this.button2.SetResourceReference(Button.StyleProperty, "buttonStyle");
            // button3 element
            this.button3 = new Button();
            this.e_3.Children.Add(this.button3);
            this.button3.Name = "button3";
            this.button3.Height = 30F;
            this.button3.Width = 200F;
            this.button3.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.button3.FontFamily = new FontFamily("Segoe UI");
            this.button3.FontSize = 20F;
            this.button3.FontStyle = FontStyle.Bold;
            this.button3.Content = "3";
            this.button3.CommandParameter = "Click Button 3";
            Binding binding_button3_Command = new Binding("ButtonCommand");
            this.button3.SetBinding(Button.CommandProperty, binding_button3_Command);
            // buttonResult element
            this.buttonResult = new TextBlock();
            this.e_3.Children.Add(this.buttonResult);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.HorizontalAlignment = HorizontalAlignment.Center;
            Binding binding_buttonResult_Text = new Binding("ButtonResult");
            this.buttonResult.SetBinding(TextBlock.TextProperty, binding_buttonResult_Text);
            // textBox element
            this.textBox = new TextBox();
            this.e_3.Children.Add(this.textBox);
            this.textBox.Name = "textBox";
            this.textBox.Width = 200F;
            this.textBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            Binding binding_textBox_Text = new Binding("TextBoxText");
            this.textBox.SetBinding(TextBox.TextProperty, binding_textBox_Text);
            // checkBox element
            this.checkBox = new CheckBox();
            this.e_3.Children.Add(this.checkBox);
            this.checkBox.Name = "checkBox";
            this.checkBox.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.checkBox.HorizontalAlignment = HorizontalAlignment.Center;
            this.checkBox.Content = "Check Box";
            // e_4 element
            this.e_4 = new TabControl();
            this.e_3.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Height = 150F;
            this.e_4.Width = 400F;
            this.e_4.ItemsSource = this.Get_e_4_Items();
            // e_17 element
            this.e_17 = new ProgressBar();
            this.e_3.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            this.e_17.Height = 30F;
            this.e_17.Width = 400F;
            this.e_17.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_17.Value = 39F;
            // imageButton element
            this.imageButton = new Button();
            this.e_3.Children.Add(this.imageButton);
            this.imageButton.Name = "imageButton";
            this.imageButton.Height = 68F;
            this.imageButton.Width = 57F;
            ImageBrush imageButton_Background = new ImageBrush();
            BitmapImage imageButton_Background_bm = new BitmapImage();
            imageButton_Background_bm.TextureAsset = "Images/SunBurn";
            ImageManager.Instance.AddImage("Images/SunBurn");
            imageButton_Background.ImageSource = imageButton_Background_bm;
            this.imageButton.Background = imageButton_Background;
        }
        
        private void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_combo_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // item1 element
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Name = "item1";
            item1.Content = "Item 1";
            items.Add(item1);
            // item2 element
            ComboBoxItem item2 = new ComboBoxItem();
            item2.Name = "item2";
            item2.Content = "Item 2";
            items.Add(item2);
            // item3 element
            ComboBoxItem item3 = new ComboBoxItem();
            item3.Name = "item3";
            item3.Content = "Item 3";
            items.Add(item3);
            return items;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_4_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_5 element
            TabItem e_5 = new TabItem();
            e_5.Name = "e_5";
            e_5.Header = "Tab 1";
            // e_6 element
            StackPanel e_6 = new StackPanel();
            e_5.Content = e_6;
            e_6.Name = "e_6";
            // e_7 element
            ListBox e_7 = new ListBox();
            e_6.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.Height = 100F;
            e_7.ItemsSource = this.Get_e_7_Items();
            items.Add(e_5);
            // e_14 element
            TabItem e_14 = new TabItem();
            e_14.Name = "e_14";
            e_14.Content = "Tab 2 Content";
            e_14.Header = "Tab 2";
            items.Add(e_14);
            // e_15 element
            TabItem e_15 = new TabItem();
            e_15.Name = "e_15";
            e_15.Content = "Tab 3 Content";
            e_15.Header = "Tab 3";
            items.Add(e_15);
            // e_16 element
            TabItem e_16 = new TabItem();
            e_16.Name = "e_16";
            e_16.Content = "Tab 4 Content";
            e_16.Header = "Tab 4";
            items.Add(e_16);
            return items;
        }
        
        private System.Collections.ObjectModel.ObservableCollection<object> Get_e_7_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_8 element
            ListBoxItem e_8 = new ListBoxItem();
            e_8.Name = "e_8";
            e_8.Content = "Selection 1";
            items.Add(e_8);
            // e_9 element
            ListBoxItem e_9 = new ListBoxItem();
            e_9.Name = "e_9";
            e_9.Content = "Selection 2";
            items.Add(e_9);
            // e_10 element
            ListBoxItem e_10 = new ListBoxItem();
            e_10.Name = "e_10";
            e_10.Content = "Selection 3";
            items.Add(e_10);
            // e_11 element
            ListBoxItem e_11 = new ListBoxItem();
            e_11.Name = "e_11";
            e_11.Content = "Selection 4";
            items.Add(e_11);
            // e_12 element
            ListBoxItem e_12 = new ListBoxItem();
            e_12.Name = "e_12";
            e_12.Content = "Selection 5";
            items.Add(e_12);
            // e_13 element
            ListBoxItem e_13 = new ListBoxItem();
            e_13.Name = "e_13";
            e_13.Content = "Selection 6";
            items.Add(e_13);
            return items;
        }
    }
}
