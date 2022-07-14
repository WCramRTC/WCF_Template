using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharClient.ServiceReference1;

namespace CharClient
{
    public partial class Form1 : Form
    {

        CharacterServiceClient csc = new CharacterServiceClient();
        Character character = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Retrieve Character
        private void RetrieveCharacter(string name)
        {
            character = csc.GetChar(name);
        }
        
        // Display Methods
        private void Display(Character c)
        {
            if( character != null)
            {
                richTextBox1.Text =
                    "Name: " + c._name + "\n" +
                    "Age: " + c._age + "\n" +
                    "Race: " + c._race + "\n" +
                    "Job: " + c._job + "\n";
            }
        }

        private void DisplayList(Character[] charList)
        {

            if (charList != null)
            {
                richTextBox1.Text = "";
                foreach (Character c in charList)
                {
                    richTextBox1.AppendText("\n\nName: " + c._name + "\n" +
                        "Age: " + c._age + "\n" +
                        "Race: " + c._race + "\n" +
                        "Job: " + c._job + "\n");
                        
                }

            }

        } // End DisplayList()

        private void btnRetrieveCharacter_Click(object sender, EventArgs e)
        {
            string name = txtRetrieveName.Text;

            if( name != string.Empty)
            {
                RetrieveCharacter(name);
                Display(character);

            }

        }

        private void btnListOfCharacters_Click(object sender, EventArgs e)
        {
            csc.PopulateList();
            Character[] list = csc.ListOfCharacters();
            DisplayList(list);
        }
    }
}
