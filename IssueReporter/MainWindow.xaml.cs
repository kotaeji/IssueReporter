using System.Windows;
using System.Windows.Controls;

namespace IssueReporter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StatusText.Text = "Ready";
        }

        private void SetStatus(string message)
        {
            StatusText.Text = message;
        }

        private void NewIssue_Click(object sender, RoutedEventArgs e)
        {
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            PriorityCombo.SelectedIndex = 0; // High
            CategoryCombo.SelectedIndex = 0;
            MachineIdTextBox.Clear();
            LocationTextBox.Clear();
            ReporterTextBox.Clear();
            AttachmentsList.Items.Clear();
            NavList.SelectedIndex = 1;
            SetStatus("New issue form cleared");
        }

        private void SaveDraft_Click(object sender, RoutedEventArgs e)
        {
            // Skeleton: no persistence yet
            SetStatus("Draft saved (skeleton — not persisted)");
            MessageBox.Show(
                "Save Draft is a skeleton action. Persistence will be added later.",
                "IssueReporter",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter a Title before submitting.",
                    "IssueReporter",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                TitleTextBox.Focus();
                return;
            }

            SetStatus("Submitted (skeleton — not sent)");
            MessageBox.Show(
                "Submit is a skeleton action. Backend integration will be added later.",
                "IssueReporter",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Attach_Click(object sender, RoutedEventArgs e)
        {
            // Skeleton: add a placeholder attachment name
            string placeholder = "attachment_" + (AttachmentsList.Items.Count + 1) + ".txt";
            AttachmentsList.Items.Add(placeholder);
            SetStatus("Attachment added (placeholder): " + placeholder);
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            SetStatus("Refreshed");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "IssueReporter 1.0.0\n\nDesktop issue reporting skeleton.\nOpen and build on Windows with Visual Studio (.NET Framework 4.8).",
                "About IssueReporter",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void NavSettings_Click(object sender, RoutedEventArgs e)
        {
            NavList.SelectedIndex = 4;
        }

        private void NavTemplates_Click(object sender, RoutedEventArgs e)
        {
            NavList.SelectedIndex = 3;
        }

        private void NavList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NavList == null || StatusText == null)
                return;

            var item = NavList.SelectedItem as ListBoxItem;
            if (item != null)
            {
                string name = item.Tag as string
                    ?? (item.Content as string)
                    ?? "Unknown";
                SetStatus("Navigated to " + name);
                // Skeleton: only New Issue form is implemented in the main pane
            }
        }
    }
}
