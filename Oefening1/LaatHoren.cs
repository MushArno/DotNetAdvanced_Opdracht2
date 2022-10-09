namespace Oefening1
{
    public partial class LaatHoren : Form
    {
        public LaatHoren()
        {
            InitializeComponent();
        }

        private void btnLaatHoren_Click(object sender, EventArgs e)
        {
            string link = "";
            string uitspraak = "";
            bool checkBox = false;
            if (CheckBoxKoe.Checked)
            {
                Koe koe = new Koe();
                link = koe.getGeluid();
                uitspraak = koe.Zegt();
                checkBox = true;
            }
            else if (CheckBoxSlang.Checked)
            {
                Slang slang = new Slang();
                link = slang.getGeluid();
                uitspraak = slang.Zegt();
                checkBox = true;
            }
            else if (CheckBoxVarken.Checked) {
                Varken varken = new Varken();
                link = varken.getGeluid();
                uitspraak = varken.Zegt();
                checkBox = true;
            }
            else { 

            }

            if (checkBox == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + link);
                player.Play();
                MessageBox.Show(uitspraak);
            }            
        }

        
    }
}