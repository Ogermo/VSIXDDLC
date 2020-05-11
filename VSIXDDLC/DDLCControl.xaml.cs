namespace VSIXDDLC
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;
    using System.Threading;
    using System.Threading.Tasks;


    /// <summary>
    /// Interaction logic for DDLCControl.
    /// </summary>
    public partial class DDLCControl : UserControl
    {
        TextBlock dialogue;
        int time = 30;

        /// <summary>
        /// Initializes a new instance of the <see cref="DDLCControl"/> class.
        /// </summary>
        public DDLCControl()
        {
            this.InitializeComponent();
            createTextBlock();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]

        public void createTextBlock()
        {
            dialogue = new TextBlock();
            dialogue.Width = 400;
            dialogue.Text = "Glad to see you again";
            dialogue.TextWrapping = TextWrapping.WrapWithOverflow;
            dialogue.FontSize = 18;
            dialogue.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            dialogue.Margin = new System.Windows.Thickness(10, 3, 0, 0);

            stackPanel.Children.Add(dialogue);

        }

        public async void dialogueWriter(string str)
        {
            stackPanel.Visibility = Visibility.Visible;
            buttonPanel.Visibility = Visibility.Collapsed;

            dialogue.Text = "";
            foreach (char c in str)
            {
                await Task.Delay(time);
                dialogue.Text += c;
            }
            await Task.Delay(2000);
            stackPanel.Visibility = Visibility.Collapsed;
            buttonPanel.Visibility = Visibility.Visible;
        }

        private void buttonTalk_Click(object sender, RoutedEventArgs e)
        {
            dialogueWriter("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDccccc ccccccccccccccc ccccccccccfff fffffffffffffffffffffffffff");
        }
        private void buttonAnger_Click(object sender, RoutedEventArgs e)
        {
            dialogueWriter("I'm angry with you!");
        }
        private void buttonCheer_Click(object sender, RoutedEventArgs e)
        {
            dialogueWriter("This is working! Good job!");
        }

    }
}