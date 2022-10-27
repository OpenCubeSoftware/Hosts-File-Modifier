namespace HostsFileModifier
{
    public partial class HostsFileForm : Form
    {
        private Controller controller;
        private bool showAdvanced;

        public HostsFileForm()
        {
            InitializeComponent();
            controller = new Controller();
            showAdvanced = false;
            textBoxIP.Visible = showAdvanced;
            ipLabel.Visible = showAdvanced;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string ip = textBoxIP.Text;
            string result = controller.addAddressToHostsFile(address, ip != "" ? ip : "127.0.0.1");
            if (result == "success") {
                txtAddress.Text = "";
                MessageBox.Show("Address added successfully");
            } else if (result == "error") {
                MessageBox.Show("Error adding address to file");
            }
        }

        private void advancedButton_Click(object sender, EventArgs e)
        {
            if (showAdvanced) {
                showAdvanced = false;
                advancedButton.Text = "Advanced";
                textBoxIP.Visible = false;
                ipLabel.Visible = false;
                this.Size = new Size(332, 157);

            } else {
                showAdvanced = true;
                advancedButton.Text = "Hide advanced";
                textBoxIP.Visible = true;
                ipLabel.Visible = true;
                this.Size = new Size(332, 195);
            }
        }


    }
}