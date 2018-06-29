using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Markup;
using mshtml;


namespace WebBrowser_Version_2.Views
{
    /// <summary>
    /// Interaction logic for IndexPage.xaml
    /// </summary>
    public partial class IndexPage : Page
    {
        String _HomeUrl = "https://www.google.com";
 


        public IndexPage()
        {
            InitializeComponent();
        }

        // The Selected Value in the ComboBox has Been Changed
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // The mWebBrowser has been Loaded
        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            mWebBrowser.Navigate(_HomeUrl);

        }

        // The mWebBrowser has Completely Loaded a page
        private void WebBrowser_LoadCompleted(object sender, NavigationEventArgs e) {

            setCustomStyleSheet(" body {zoom: 120%; }");
        }

       

        // For the BackButton
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (mWebBrowser.CanGoBack)
            {
                mWebBrowser.GoBack();

            }
        }

        // For the HomeButton
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToHomePage();
        }

        // For the UpButton
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (mWebBrowser.CanGoForward)
            {
                mWebBrowser.GoForward();
            }
        }
        



        // Helper methods
        private void NavigateToHomePage()
        {
            mWebBrowser.Navigate(_HomeUrl);
        }

        private HTMLDocument getHtmlDocument(WebBrowser mWebBrowser)
        {
            HTMLDocument _htmlDocument = mWebBrowser.Document as HTMLDocument;

            return _htmlDocument;

        }
        private void setCustomStyleSheet(String styleString)
        {
            IHTMLStyleSheet customCSS = getHtmlDocument(mWebBrowser).createStyleSheet();

            customCSS.cssText = styleString;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            mWebBrowser.Navigate("https://www.google.com/#q=" + mSearchTextBox.Text.ToString());
        }

        private void mSearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            mSearchTextBox.Text = "";
        }

        private void mSearchTextBox_OnMouseDirectlyOver(object sender, DependencyPropertyChangedEventArgs e)
        {
            mSearchTextBox.Text = "";
        }

        private void mSearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
