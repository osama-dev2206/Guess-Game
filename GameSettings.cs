using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Game
{
    public partial class frmGameSettings : Form
    {
        void IntilizeGameRound()
        {
            Core.GameInfo.StartRange = Convert.ToInt32(UDStartOfRange.Value);
            Core.GameInfo.EndRange= Convert.ToInt32(UDEndOfRange.Value);
            Core.GameInfo.NumOfRounds= Convert.ToInt32(UDNumOfRounds.Value);
        }

        public frmGameSettings()
        {
            InitializeComponent();
            IntilizeGameRound(); 
        }


        private void btnStartGame_Click(object sender, EventArgs e)      // start button 
        {
            this.Hide();
            frmGameMainScreen game = new frmGameMainScreen();
            game.Show(); 

            if(!game.Visible)this.Show(); // show the game settings info again 
        }


                                            // On Change Values Event //
        void ChangeGameInfo(NumericUpDown TheSelcetedNumericUpDown) // change game info according to controls change
        {
            switch(TheSelcetedNumericUpDown.Tag.ToString())
            {
                case "TNumOfRounds":
                    Core.GameInfo.NumOfRounds = Convert.ToInt32(UDNumOfRounds.Value);
                    break;

                case "TStartOfRange":
                    Core.GameInfo.StartRange = Convert.ToInt32(UDStartOfRange.Value);
                    break;

                case "TEndOfRange":
                    Core.GameInfo.EndRange = Convert.ToInt32(UDEndOfRange.Value);
                    break;
            }
        }

        void ValditTheEndRange() // end cann't be less than or equal the start
        {
      
            UDEndOfRange.Minimum = UDStartOfRange.Value + 1;
        }

        private void UDNumOfRounds_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown ud = sender as NumericUpDown;
            ChangeGameInfo(ud);
            ValditTheEndRange();

        }




    }
}
