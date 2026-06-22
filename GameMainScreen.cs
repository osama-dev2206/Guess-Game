using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Game
{
    public partial class frmGameMainScreen : Form
    {

        void IntiliazeGameInfo() // update the game Info of form 
        {
            labEndRange.Text=Core.GameInfo.EndRange.ToString();
            labStartRange.Text =Core.GameInfo.StartRange.ToString();
            labNumOfRounds.Text =Core.GameInfo.NumOfRounds.ToString();
        }
        public frmGameMainScreen()
        {
            InitializeComponent();
            IntiliazeGameInfo();
        }

        private void GameMainScreen_FormClosing(object sender, FormClosingEventArgs e) // closing the form event
        {
            //  Application.Exit(); // end the program
            Application.OpenForms[0].Show() ; // to open the frmGameSettingsForm 
        }

    void ShowMessageAccprdoingToStatus(Core.enCurrentRoundStatus status) // show message according to status 
        {
            if (status == Core.enCurrentRoundStatus.eWin)
                MessageBox.Show("The Number You Have Guessed Was Correct!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else if (status == Core.enCurrentRoundStatus.eLose)
                MessageBox.Show("The Number You Have Guessed Was Wrong!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void UpdateGameInfo()// update the core game info 
        {
                //Core.GameInfo.EndRange= Convert.ToInt32(labEndRange.Text);
               // Core.GameInfo.StartRange = Convert.ToInt32(labStartRange.Text);
               Core.GameInfo.NumOfRounds = Convert.ToInt32(labNumOfRounds.Text);
        }

        bool IsGameEnded(int remaning)
        {
            return (remaning == 0) ? true : false; 
        }

        void UpdateRound()
        {
            int remaning = Convert.ToInt32(labNumOfRounds.Text);
            remaning--;

            if (IsGameEnded(remaning))this.Close();
    

            labNumOfRounds.Text = remaning.ToString(); // update the form info  
            UpdateGameInfo(); // update the core round value 
      
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool IsNumber = true; // to make sure that the input is number 

            if ((IsNumber = int.TryParse(UserInput.Text,out _)) &&!String.IsNullOrEmpty(UserInput.Text) && !string.IsNullOrWhiteSpace(UserInput.Text) ) // missed : check if it is number or not
            {
                ShowMessageAccprdoingToStatus(Core.CheckUserAnswer(Convert.ToInt32(UserInput.Text)));

                UpdateRound(); // decrement the round 
            }
            else
            {
               if(IsNumber==false) MessageBox.Show("The Number Isn't Valid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

              else  MessageBox.Show("The Input Cann't Be Empty!!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
