using System;
using System.Collections.Generic;
using System.Drawing;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;
using System.IO;

namespace CheckInOutCode
{
    public partial class Form1 : MetroForm
    {
        string DBDir = @"C:\CheckIn"; // create strings to be used in copying the database file over
        string DB = @"C:\CheckIn\CheckIn.accdb";
        string AppSrc = Path.GetDirectoryName(Application.ExecutablePath);
        Timer SIWait5 = new Timer(); // create timers to control how long the Sign In and Sign Out messages are displayed.
        Timer SOWait5 = new Timer();

        public Form1()
        {
            CopyDB(); // Check to see if database is in location
            InitializeComponent();
            PSignin.Visible = false; // Make panels invisible so user can see the startup form
            PSignout.Visible = false;
            FNameNull.Visible = false;
            LNameNull.Visible = false;
            IDNull.Visible = false;
            GradeNull.Visible = false;
            TeacherNull.Visible = false;
            FNameSoNull.Visible = false;
            LNameSoNull.Visible = false;
            PSignedIn.Visible = false;
            PSignedOut.Visible = false;
            SIWait5.Tick += new EventHandler(SIWait5_Tick); // set timer actions
            SOWait5.Tick += new EventHandler(SOWait5_Tick);
            AddNewWindowButton(WindowButtons.Close); // add close button
            UpdateWindowButtonPosition(); // correct position 
        }

        public void CopyDB() // Checks to make sure database exists in directory, creates directory and copies DB over if needed
        {
            string DBsrc = AppSrc + @"\CheckIn.accdb"; // DB source in program files
            if (Directory.Exists(DBDir))
            {
                if (File.Exists(DB))
                {
                    return;
                }
                else
                {
                    File.Copy(DBsrc, DB);
                    return;
                }
            }
            else
            {
                Directory.CreateDirectory(DBDir);
                File.Copy(DBsrc, DB);
                return;
            }
        }

        public void AddNewWindowButton(WindowButtons button) // Method for adding WindowButtons (ex: Close window, minimize window, etc.) This method was copied from the MetroFramework source, but I needed the window buttons to go on the header panel instead.
        {
            if (windowButtonList == null)
                windowButtonList = new Dictionary<WindowButtons, MetroFormButton>();

            if (windowButtonList.ContainsKey(button))
                return;

            MetroFormButton newButton = new MetroFormButton();

            if (button == WindowButtons.Close)
            {
                newButton.Text = "r";
            }
            else if (button == WindowButtons.Minimize)
            {
                newButton.Text = "0";
            }
            else if (button == WindowButtons.Maximize)
            {
                if (WindowState == FormWindowState.Normal)
                    newButton.Text = "1";
                else
                    newButton.Text = "2";
            }

            newButton.Style = Style;
            newButton.Theme = MetroThemeStyle.Dark; // Changed from default
            newButton.Tag = button;
            newButton.Size = new Size(25, 20);
            newButton.Anchor = AnchorStyles.None; // Changed from default, I set all anchors to none for now, just so I didn't have to worry about those messing with the display
            newButton.TabStop = false;
            newButton.Click += WindowButton_Click;
            Header.Controls.Add(newButton); // Changed to add the buttons on the header layer, instead of form1, as the header panel would cover the window buttons 
            windowButtonList.Add(button, newButton);
        }

        private void BSignin_Click_1(object sender, EventArgs e) // Method for when someone clicks on the Sign In button on form1
        {
            PSignin.Visible = true; // Brings up Sign In panel
        }

        private void BSignout_Click(object sender, EventArgs e)  // Method for when someone clicks on the Sign Out button on form1
        {
            PSignin.Visible = true;
            PSignout.Visible = true; // Brings up Sign Out panel, Sign In panel had to be made visible too, as the Sign Out panel was on top of the Sign In panel
        }

        private void NextPso_Click(object sender, EventArgs e)  // Method for when someone clicks on the Submit button on the Sign Out panel
        {
            FNameSoNull.Visible = false; // Hides red text in case user entered in the required data
            LNameSoNull.Visible = false;
            if (string.IsNullOrWhiteSpace(FNameSO.Text)) // Checks to make sure user entered in data for their First Name on the Sign Out panel
            {
                FNameSoNull.Visible = true; // Shows red text telling user to enter information into the First Name text box if they haven't
            }
            else
            { SOContinueLName(); } // Checks to make sure user entered info for last name
        }

        private void SOContinueLName() // method to make sure user entered in data for their Last Name on the Sign Out panel
        {
            if (string.IsNullOrWhiteSpace(LNameSO.Text)) // Checks to make sure user entered in a value for their First Name on the Sign Out panel
            {
                LNameSoNull.Visible = true; // Shows red text telling user to enter information into the Last Name text box if they haven't
            }
            else
            { SOContinue(); } // If user entered data in all feilds, program will continue
        }

        private void SOContinue() // method to add a Sign Out time to a student
        {
            string SOFName = FNameSO.Text; // Takes user's data enterted into the text box, and adds it as a string
            string SOLName = LNameSO.Text;
            string Date = DateTime.Now.ToString("MM.dd.yyy"); // Create strings needed to add data to a database
            string Time = DateTime.Now.ToString("h:mm:ss");
            OleDbConnection conn = new OleDbConnection(); 
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\CheckIn\CheckIn.accdb";
            try
            {
                conn.Open(); // Opens database connection
                String SOTime = "Update Table1 set [Time out] = '" + Time + "' Where [First Name] = '" + SOFName + "' and [Last Name] = '" + SOLName + "' and [Date] = '" + Date + "'"; // Adds the current time to the Time out field on the database
                OleDbCommand cmd = new OleDbCommand(SOTime, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) // I mainly used this for debugging, however, if Faculty at South sees this message, they now to switch to paper until the problem is resolved
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
                FNameSO.Clear(); // Clears Text fields so other users cannot see what the previous user inputted
                LNameSO.Clear();
                PSignedIn.Visible = true;
                PSignout.Visible = true;
                PSignin.Visible = true;
                PSignedOut.Visible = true;
                SOWait5.Interval = 5000; // Show the Signed Out message for 5 seconds
                SOWait5.Start();
            }
        }

        private void SOWait5_Tick(object sender, EventArgs e) // After 5 seconds, the program will go back to the main screen
        {
            PSignedIn.Visible = false;
            PSignout.Visible = false;
            PSignin.Visible = false;
            PSignedOut.Visible = false;
            SOWait5.Stop();
        }

        private void PsoBack_Click(object sender, EventArgs e) // Method for the action when a user clicks on the Back button on the Sign Out panel
        {
            FNameSO.Clear(); // Clears text fields
            LNameSO.Clear();
            PSignout.Visible = false; // Shows main screen
            PSignin.Visible = false;
        }

        private void NextPsi_Click(object sender, EventArgs e) // Method for the action when a user clicks on the Submit button on the Sign In panel
        {
            FNameNull.Visible = false; // Hides red text in case user entered in the required data
            LNameNull.Visible = false;
            IDNull.Visible = false;
            GradeNull.Visible = false;
            TeacherNull.Visible = false;
            if (string.IsNullOrWhiteSpace(PsiFName.Text)) // Checks to make sure user entered in a value for their First Name on the Sign In panel
            {
                FNameNull.Visible = true; // Shows red text telling user to enter information into the First Name text box if they haven't
            }
            else
            { ContinueLName(); } // If user entered data in the First Name text box, program will check data for the Last Name
        }

        private void ContinueLName() // Method for making sure user enterted in data for the Last Name field on the Sign In panel
        {
            if (string.IsNullOrWhiteSpace(PsiLName.Text)) // Checks to make sure user entered in a value for their Last Name on the Sign In panel
            {
                LNameNull.Visible = true; // Shows red text telling user to enter information into the Last Name text box if they haven't
            }
            else
            { ContinueID(); } // If user entered data in the Last Name text box, program will check data for the ID
        }

        private void ContinueID() // Method for making sure user enterted in data for the ID field
        {
            if (string.IsNullOrWhiteSpace(PsiID.Text)) // Checks to make sure user entered in a value for their ID on the Sign In panel
            {
                IDNull.Visible = true; // Shows red text telling user to enter information into the ID text box if they haven't
            }
            else
            { ContinueGrade(); } // If user entered data in the Last Name text box, program will make sure user selected a grade
        }

        private void ContinueGrade() // Method for making sure user selected a grade
        {
            if (!(G6.Checked || G7.Checked || G8.Checked)) // Checks to make sure user selected a grade
            {
                GradeNull.Visible = true; // Shows red text telling user to select a grade if they haven't
            }
            else
            { ContinueTeach(); } // If user selected a grade, program will make sure user selected a teacher to see
        }

        private void ContinueTeach() // Method for making sure user selected a teacher  
        {
            if (string.IsNullOrWhiteSpace(TchCh.GetItemText(TchCh.SelectedItem))) // Checks to make sure user selected a teacher
            {
                TeacherNull.Visible = true; // Shows red text telling user to select a teacher if they haven't
            }
            else
            { ContinueSI(); } // If user has entered in all required data on the Sign In panel, program will add their data to the DB
        }

        private void ContinueSI() // Method for adding users input to a database
        {
            string FName = PsiFName.Text; // Creates strings needed for inputting data into DB
            string LName = PsiLName.Text;
            string ID = PsiID.Text;
            string Grade = "";
            if (G6.Checked)
            {
                Grade = G6.Text;
            }
            if (G7.Checked)
            {
                Grade = (G7.Text);
            }
            if (G8.Checked)
            {
                Grade = (G8.Text);
            }
            string Teacher = TchCh.GetItemText(TchCh.SelectedItem);
            string Date = DateTime.Now.ToString("MM.dd.yyy");
            string Time = DateTime.Now.ToString("h:mm:ss");
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\CheckIn\CheckIn.accdb";
            try
            {
                conn.Open(); // Connects to database
                String WriteChkIn = "INSERT INTO Table1([Date],[First Name],[Last Name],[Student ID],Grade,[Here to see],[Time In])" +
                    "VALUES('" + Date + "','" + FName + "','" + LName + "','" + ID + "','" + Grade + "','" + Teacher + "','" + Time + "')"; // Enters users info into DB
                OleDbCommand cmd = new OleDbCommand(WriteChkIn, conn);
                cmd.ExecuteNonQuery();
                PsiFName.Clear(); // Clears fields on Sign In panel so the next user doesn't see the previous user's input
                PsiLName.Clear();
                PsiID.Clear();
                G6.Checked = false;
                G7.Checked = false;
                G8.Checked = false;
                TchCh.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message); // I mainly used this for debugging, however, if Faculty at South sees this message, they now to switch to paper until the problem is resolved
            }
            finally
            {
                conn.Close();
            }
            PSignout.Visible = true; 
            PSignedIn.Visible = true;
            SIWait5.Interval = 5000; 
            SIWait5.Start(); // Displays Signed Out panel for 5 seconds
        }

        private void SIWait5_Tick(object sender, EventArgs e)
        {
            PSignedIn.Visible = false; // Goes to main page (form1) after 5 seconds
            PSignout.Visible = false;
            PSignin.Visible = false;
            SIWait5.Stop();
        }

        private void PsiBack_Click(object sender, EventArgs e) // Method for action taken when a user clicks the Back button on the Sign In panel
        {
            PsiFName.Clear(); // Clears fields so next user doesn't see the previous users input
            PsiLName.Clear();
            PsiID.Clear();
            G6.Checked = false;
            G7.Checked = false;
            G8.Checked = false;
            TchCh.SelectedItem = null;
            PSignin.Visible = false; // Displays main page
            PSignout.Visible = false;
        }
    }
}

