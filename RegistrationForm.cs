using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// this allows program to read ext file

// Programmer: Lisa Duong
// Due Date: 5/5/20
// Assignment: Individual assignment 4
namespace Duong_4
{
    public partial class MainForm : Form
    {
        //constants
        double liveActionPrice = 79.95;
        double animationPrice = 99.95;
        string maxClasses = "Maximum of 4 classes allowed for registration";
        // listbox max value
        private int[] aSelectedIndexes = new int[5];
        public MainForm()
        {
            InitializeComponent();
            // array list
            List<string> statusList = new List<string>() { "Actor", "Producer", "Director", "Animator",
                "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };
            // passes list to method
            DisplayList(statusList);
            // display labels
            liveActionPricelabel.Text = liveActionPrice.ToString("c");
            animationPriceLabel.Text = animationPrice.ToString("c");
            maxRegistrationLabel.Text = maxClasses;
            // live action classes are default
            liveActionClasses();
            pricePerClassLabel.Text = "Price per class:\n" + liveActionPrice.ToString("c");
            numberClassesLabel.Text = "# of classes \nselected: 0";
            totalPriceLabel.Text = "Total price of \nregistration: $0.00";
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void checkChange(object sender, EventArgs e)
        {
            //count classes, update totals
            string classSelected = "";
            int classesCount = 0;
            for (int counter = 0; counter < classesListBox.Items.Count; counter++)
            {
                if (classesListBox.GetSelected(counter))
                {
                    classSelected += classesListBox.Items[counter];
                    classesCount++;
                }
            }
            double totalPriceLive = classesCount * liveActionPrice;
            double totalPriceAnimation = classesCount * animationPrice;

            if (liveActionRadioButton.Checked)
            {
                totalPriceLabel.Text = "Total price of \nregistration: " + totalPriceLive.ToString("c");
            }
            else
            {
                totalPriceLabel.Text = "Total price of \nregistration: " + totalPriceAnimation.ToString("c");
            }
            numberClassesLabel.Text = "# of classes \nselected: " + classesCount;
            if (liveActionRadioButton.Checked)
            {
                // clear listbox and then add list depending on selected radiobutton
                classesListBox.Items.Clear();
                liveActionClasses();
                pricePerClassLabel.Text = "Price per class:\n" + liveActionPrice.ToString("c");
            }
            else
            {
                classesListBox.Items.Clear();
                animationClasses();
                pricePerClassLabel.Text = "Price per class:\n" + animationPrice.ToString("c");
            }

        }

        private void DisplayList(List<string> sList)
        {
            // displays each string
            foreach (string str in sList)
            {
                statusComboBox.Items.Add(str);
            }
        }
        private void liveActionClasses()
        {
            // method to read ext file
            StreamReader InputFile;
            InputFile = File.OpenText("LiveActionClasses.txt");
            while (!InputFile.EndOfStream)
            {
                classesListBox.Items.Add(InputFile.ReadLine());
            }
        }
        private void animationClasses()
        {
            StreamReader InputFile;
            InputFile = File.OpenText("AnimationClasses.txt");
            while (!InputFile.EndOfStream)
            {
                classesListBox.Items.Add(InputFile.ReadLine());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void dobLabel_Click(object sender, EventArgs e)
        {

        }

        private void dobMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // count number of classes selected
            string classSelected = "";
            int classesCount = 0;
            for (int counter = 0; counter < classesListBox.Items.Count; counter++)
            {
                if (classesListBox.GetSelected(counter))
                {
                    classSelected += classesListBox.Items[counter];
                    classesCount++;
                }
            }
            double totalPriceLive = classesCount * liveActionPrice;
            double totalPriceAnimation = classesCount * animationPrice;

            if (liveActionRadioButton.Checked)
            {
                totalPriceLabel.Text = "Total price of \nregistration: " + totalPriceLive.ToString("c");
            }
            else
            {
                totalPriceLabel.Text = "Total price of \nregistration: " + totalPriceAnimation.ToString("c");
            }
            numberClassesLabel.Text = "# of classes \nselected: " + classesCount;
            // restrict user to only select 4 classes, if more than 4 selected, messagebox message pops up and
            // selected item is deselected
            bool bfound;
            int iSelectedIndex;

            if (this.classesListBox.SelectedItems.Count < 5)
            {
                for (int iselectedcount = 0; iselectedcount < this.classesListBox.SelectedIndices.Count; iselectedcount++)
                {
                    aSelectedIndexes[iselectedcount] = this.classesListBox.SelectedIndices[iselectedcount];
                }
            }
            else
            {
                MessageBox.Show("You can only select 4 classes for registration.");

                for (int iselectedcount = 0; iselectedcount < this.classesListBox.SelectedIndices.Count; iselectedcount++)
                {
                    bfound = false;
                    iSelectedIndex = this.classesListBox.SelectedIndices[iselectedcount];

                    for (int iarraycount = 0; iarraycount < aSelectedIndexes.GetUpperBound(0); iarraycount++)
                    {
                        if (aSelectedIndexes[iarraycount] == iSelectedIndex)
                        {
                            bfound = true;
                        }
                    }

                    if (bfound == false)
                    {
                        this.classesListBox.SetSelected(iSelectedIndex, false);
                        return;
                    }
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear inputs
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dobMaskedTextBox.Text = "";
            statusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            classesListBox.ClearSelected();
            cashRadioButton.Checked = true;
            emailCheckBox.Checked = false;
        }

        private void ctrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string classSelected = "";
            int classesCount = 0;
            for (int counter = 0; counter < classesListBox.Items.Count; counter++)
            {
                if (classesListBox.GetSelected(counter))
                {
                    classSelected += classesListBox.Items[counter] + "\n";
                    classesCount++;
                }
            }
            // check if fields are empty
            string errorMessage = "Error Message";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("You must fill out first name.", errorMessage, buttons, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("You must fill out last name.", errorMessage, buttons, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("You must fill out email address.", errorMessage, buttons, MessageBoxIcon.Error);
            }
            // cannot get system to check masked textbox
            else if (string.IsNullOrWhiteSpace(dobMaskedTextBox.Text))
            {
                MessageBox.Show("You must fill out date of birth.", errorMessage, buttons, MessageBoxIcon.Error);
            }
            else if (classesCount == 0)
            {
                MessageBox.Show("You must select at least one class.", errorMessage, buttons, MessageBoxIcon.Error);
            }
            else
            {
            // display contents into messagebox
            // this is for live action
            // add messagebox title, icon and button
                string title = "Registration Summary";
                if (liveActionRadioButton.Checked && cashRadioButton.Checked && emailCheckBox.Checked)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: Yes", title, buttons, MessageBoxIcon.Information);
                    //output info to a ext. file
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text +
                        "\nRegistrant name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text 
                    + "\nEmail Address: " + emailTextBox.Text + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: Yes\n");
                    outputfile.Close();
                }
                if (liveActionRadioButton.Checked && cashRadioButton.Checked && emailCheckBox.Checked == false)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: No", title, buttons, MessageBoxIcon.Information);
                    //output info to a ext. file
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: No\n");
                    outputfile.Close();
                }
                if (liveActionRadioButton.Checked && checkRadioButton.Checked && emailCheckBox.Checked)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: Yes", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: Yes\n");
                    outputfile.Close();
                }
                if (liveActionRadioButton.Checked && checkRadioButton.Checked && emailCheckBox.Checked == false)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: No", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + liveActionRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: No\n");
                    outputfile.Close();
                }
                // this is for animation
                if (animationRadioButton.Checked && cashRadioButton.Checked && emailCheckBox.Checked)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: Yes", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: Yes\n");
                    outputfile.Close();
                }
                if (animationRadioButton.Checked && cashRadioButton.Checked && emailCheckBox.Checked == false)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: No", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + cashRadioButton.Text
                    + "\nEmail receipt requested: No\n");
                    outputfile.Close();
                }
                if (animationRadioButton.Checked && checkRadioButton.Checked && emailCheckBox.Checked)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: Yes", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: Yes\n");
                    outputfile.Close();
                }
                if (animationRadioButton.Checked && checkRadioButton.Checked && emailCheckBox.Checked == false)
                {
                    MessageBox.Show("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: No", title, buttons, MessageBoxIcon.Information);
                    StreamWriter outputfile;
                    outputfile = File.AppendText("RegistrationData.txt");
                    //output user inputs
                    outputfile.WriteLine("Registration Summary" + "\nRegistration date: " + dateMaskedTextBox.Text + "\nRegistrant name: "
                    + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\nEmail Address: " + emailTextBox.Text
                    + "\nDate of Birth: " + dobMaskedTextBox.Text + "\nStatus of Registrant: " + statusComboBox.Text
                    + "\nClass type: " + animationRadioButton.Text + "\nNumber of classes selected: " + classesCount
                    + "\nClasses selected:\n" + classSelected + "Payment type: " + checkRadioButton.Text
                    + "\nEmail receipt requested: No\n");
                    outputfile.Close();
                }
            }

        }

        private void dateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit message box
            string message1 = "Are you sure you wish to exit the program?";
            string title1 = "Close Window";
            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No) {
                // Do nothing  
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display about form
            var aboutform = new AboutForm();
            aboutform.Show();
        }
    }
}
