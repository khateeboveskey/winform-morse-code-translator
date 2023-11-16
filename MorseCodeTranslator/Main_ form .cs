using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;

namespace MorseCodeTranslator
{
    public partial class frmMain : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=morse_code_translator;UID=root;password= ");
        public Point mouseLocation;
        private SoundPlayer dotSoundPlayer;
        private SoundPlayer dashSoundPlayer;
        public frmMain()
        {
            InitializeComponent();
            dotSoundPlayer = new SoundPlayer(Properties.Resources.dotSound);
            dashSoundPlayer = new SoundPlayer(Properties.Resources.dashSound);
        }

      
        private string lastText = "";
        private void pbBtnPlay_Click(object sender, EventArgs e)
        {
            // to not to repeat the last text and to not to store empty translations
            if (lastText != txtInput.Text && txtMorseCode.Text.Count() > 0)
            {
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO `history` (`englishText`, `morseCodeText`, `date`, `time`) VALUES ('" + txtInput.Text + "','" + txtMorseCode.Text + "'  ,  '" + currentDate + "', '" + currentTime + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                lastText = txtInput.Text;
            }
            string morseCode = txtMorseCode.Text.Trim();
            foreach (char c in morseCode)
            {
                if (c == '.')
                {
                    // Play the dot sound
                    dotSoundPlayer.PlaySync();
                    Thread.Sleep(15); // Delay between each Morse code letter
                }
                else if (c == '-')
                {
                    // Play the dash sound
                    dashSoundPlayer.PlaySync();
                    Thread.Sleep(15); // Delay between each Morse code letter
                }
                else if (c == '/')
                {
                    // Delay between letters
                    Thread.Sleep(150);
                }
                else if (c == ' ')
                {
                    // Delay between letters
                    Thread.Sleep(350);
                }
            }
        }
        private string TranslateFromMorseCode(string morseCode)
        {
            Dictionary<string, char> reverseMorseCodeMap = new Dictionary<string, char>()
    {
      {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
        {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
        {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
        {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
        {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
        {"--..", 'Z'}, {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'},
        {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'},
        {"----.", '9'}, {"-.--.", '('}, {"-....-", '-'}, {"..-.-", '¿'},
        {".-...", '&'},{"--..--", ','}, {"..--..", '?'}, {".----.", '\''}, {"-.--.-", ')'},
        {"---...", ':'}, {"-.-.--", '!'}, {"...-..-", '$'}, {"-...-", '='},
        {"-.-.-.", ';'}, {"-..-.", '/'}, {"--...-", '¡'}, {"..--.-", '_'},
        {".--.-.", '@'}, {".-..-.", '\"'}, {".-.-.-", '.'}, {".-.-.", '+'},

    };

            StringBuilder englishTextBuilder = new StringBuilder();
            string[] words = morseCode.Split(new[] { " / " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string[] letters = word.Split(' ');

                foreach (string letter in letters)
                {
                    if (reverseMorseCodeMap.ContainsKey(letter))
                    {
                        englishTextBuilder.Append(reverseMorseCodeMap[letter]);
                    }
                  
                }

                englishTextBuilder.Append(" ");
            }

            return englishTextBuilder.ToString().Trim();
        }



        private string TranslateToMorseCode(string input)
        {
            Dictionary<char, string> morseCodeMap = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
        {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
        {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
        {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
        {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
        {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
        {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
        {'9', "----."}, { '(',   "-.--."}, {'-',   "-....-"},  {'¿',   "..-.-"} , {'&'   ,".-..."},
        {',',   "--..--"},  {'?',   "..--.."},  {'\'',  ".----."}   ,{')',  "-.--.-"},
        { ':',  "---..."},  { '!',  "-.-.--"}   ,{ '$', "...-..-"} ,  { '='  ,"-...-"},
        { ';',  "-.-.-."},  { '/',  "-..-."} , { '¡', "--...-"},
        { '_',  "..--.-"}, { '@',  ".--.-."} ,{ '+', ".-.-."} , { '"'  ,".-..-."},
        { '.'  ,".-.-.-"}
    };

            input = input.ToUpper();

            StringBuilder morseCodeBuilder = new StringBuilder();
            bool endsWithSpecial = true;
            foreach (char c in input)
            {
                if (morseCodeMap.ContainsKey(c))
                {
                    morseCodeBuilder.Append(morseCodeMap[c] + " ");
                    endsWithSpecial = false;
                }
                else
                {
                    if (c == ' ' || c == '\n')
                    {
                        // Don't add / if the last character was /
                        if (endsWithSpecial)
                        {
                            continue;
                        }
                        morseCodeBuilder.Append("/ ");
                        endsWithSpecial = true;
                    }
                }
            }

            return morseCodeBuilder.ToString().Trim();
        }
        //Add a flag to track whether the text change is due to user input or programmatic update
       // private bool isUserInput = true;
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            lblCopyState1.Text = "";
            string input = txtInput.Text;
            string morseCode = TranslateToMorseCode(input);

            // Unlink the event handler temporarily
            txtMorseCode.TextChanged -= txtMorseCode_TextChanged;
            txtMorseCode.Text = morseCode;

            // Link the event handler again
            txtMorseCode.TextChanged += txtMorseCode_TextChanged;


        }

        private void txtMorseCode_TextChanged(object sender, EventArgs e)
        {
            pbDone.Visible = false;
            lblCopyState2.Text = "";
            string input = txtMorseCode.Text;
            string humanLang = TranslateFromMorseCode(input);
            // Unlink the event handler temporarily
            txtInput.TextChanged -= txtInput_TextChanged;
            txtInput.Text = humanLang;

            // Link the event handler again
            txtInput.TextChanged += txtInput_TextChanged;
        }
    

     
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Get the current position of the mouse pointer on the screen
                Point mousePos = Control.MousePosition;
                // Offset the mouse position by the stored negative X and Y coordinates
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                // Update the form's position
                Location = mousePos;
            }
        }



        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void pbBtnHistory_Click(object sender, EventArgs e)
        {
            frmHistory form = new frmHistory();
            form.Show();

        }

        private void pbBtnMorseAbout_Click(object sender, EventArgs e)
        {
            if (txtMorseCode.Text.Count() > 0)
            {
                frmGuide form = new frmGuide(txtInput.Text, txtMorseCode.Text);
                form.Show();
            }
            else
            {
                frmGuide form = new frmGuide(txtInput.Text = "Hello World", txtMorseCode.Text = ".... . .-.. .-.. --- / .-- --- .-. .-.. -..");
                form.Show();
            }

        }

        private void pbBtnWhoAreWe_Click(object sender, EventArgs e)
        {
            frmWhoWe form = new frmWhoWe();
            form.Show();
        }

     
        private void pbCopyEnglish_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Count() > 0)
            {
                Clipboard.SetText(txtInput.Text);
                pictureBox7.Visible = true;
                lblCopyState1.Text = "Copied!";
            }
        }

        private void pbCopyMorseCode_Click(object sender, EventArgs e)
        {
            if(txtMorseCode.Text.Count() > 0)
            {
            Clipboard.SetText(txtMorseCode.Text);
            pbDone.Visible = true;
            lblCopyState2.Text = "Copied!";
            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }     
    }
            
        
    

    
