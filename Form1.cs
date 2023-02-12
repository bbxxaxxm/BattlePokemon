using BattlePokemon;
using System.Threading;
using System.Windows.Forms;

namespace BattlePokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedHero;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Snorlax());
            pokemons.Add(new Zamazenta());
            pokemons.Add(new Arceus());
            pokemons.Add(new Alakazam());

            monster = new ZacianBattle();
            pictureBox2.Image = monster.getImage();
            textBoxHPmon.Text = monster.getHP().ToString();
            textBoxNameMon.Text = monster.getName();
            textBoxATKmon.Text = monster.getAtk().ToString();
            textBoxDEmon.Text = monster.getDefense().ToString();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            selectedHero = pokemons[0];
            if (selectedHero.getHP() <= 0)
            {
                MessageBox.Show("You're Dead.");
            }
            else
            {
                pictureBox1.Image = selectedHero.getImage();
                textBoxName.Text = selectedHero.getName();
                textBoxHP.Text = selectedHero.getHP().ToString();
                textBoxATK.Text = selectedHero.getAtk().ToString();
                textBoxDE.Text = selectedHero.getDefense().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedHero = pokemons[1];
            if (selectedHero.getHP() <= 0)
            {
                MessageBox.Show("You're Dead.");
            }
            else
            {
                pictureBox1.Image = selectedHero.getImage();
                textBoxName.Text = selectedHero.getName();
                textBoxHP.Text = selectedHero.getHP().ToString();
                textBoxATK.Text = selectedHero.getAtk().ToString();
                textBoxDE.Text = selectedHero.getDefense().ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (selectedHero.getHP() > 0)
            {

                int damage = (selectedHero.getAtk() - monster.getDefense());
                monster.takeDamage(damage);
                textBoxHPmon.Text = monster.getHP().ToString();

                if (monster.getHP() <= 0)
                {
                    textBoxHPmon.Text = "0";
                    MessageBox.Show("Monster Win");
                }
                else
                {
                    int enemyDamage = (monster.getAtk() - selectedHero.getDefense());
                    selectedHero.takeDamage(enemyDamage);
                    textBoxHP.Text = selectedHero.getHP().ToString();
                }
            }
            else
            {
                MessageBox.Show("Your Pokemon has no HP left.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedHero = pokemons[2];
            if (selectedHero.getHP() <= 0)
            {
                MessageBox.Show("You're Dead.");
            }
            else
            {
                pictureBox1.Image = selectedHero.getImage();
                textBoxName.Text = selectedHero.getName();
                textBoxHP.Text = selectedHero.getHP().ToString();
                textBoxATK.Text = selectedHero.getAtk().ToString();
                textBoxDE.Text = selectedHero.getDefense().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedHero = pokemons[3];
            if (selectedHero.getHP() <= 0)
            {
                MessageBox.Show("You're Dead.");
            }
            else
            {
                pictureBox1.Image = selectedHero.getImage();
                textBoxName.Text = selectedHero.getName();
                textBoxHP.Text = selectedHero.getHP().ToString();
                textBoxATK.Text = selectedHero.getAtk().ToString();
                textBoxDE.Text = selectedHero.getDefense().ToString();
            }
        }


    }
}