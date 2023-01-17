using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Harjoitus26
{

    public partial class Window3 : Window
    {
        //Muuttujat
        Fighter Pelaaja;
        public string ClassSelected = Window2.Class;
        public string EnemyMessages;
        public string PlayerMessages;
        public string DeathMessage;
        public string SpawnMessage;
        public Random Randomi = new Random();
        public int RandomEnemy;
        public Window3()
        {
            InitializeComponent();
            Create();
            GenerateEnemy();
            Update();
        }

        //Luodaan pelaaja hahmo, niiden arvojen perusteella mitkä pelaaja asetti hahmonluonti ikkunassa
        public void Create()
        {
            if (ClassSelected == "Fighter")
            {
                BitmapImage bi3 = new BitmapImage(); //Luodaan kuvalle muuttuja
                bi3.BeginInit(); //Aktivoidaan kuva muuttuja
                //Jos pelaaja valitsi mies sukupuolen, asetetaan pelaajan hahmon kuva miespuoliseksi
                if (Window2.Sex == "Male")
                {
                    bi3.UriSource = new Uri("https://i.pinimg.com/originals/0b/14/8f/0b148f31fdd97d8c61103a5ca5330d73.png", UriKind.Absolute); //Annetaan kuva muuttujalle lähde 
                }
                //Muuten asetetaan pelaajan hahmonkuva naispuoliseksi
                else
                {
                    bi3.UriSource = new Uri("https://preview.redd.it/kkv0fd5w0bo51.png?width=640&crop=smart&auto=webp&s=8177e1ffbd1996cc4f042007eefbdda135727cca", UriKind.Absolute); //Annetaan kuva muuttujalle lähde 
                }
                bi3.EndInit();  //Lopettaa kuvan aktivoimisen
                PlayerImage.Stretch = Stretch.Fill; //Venyttää valitun kuvaa kunnes se täyttää kuva objektin ikkunassa
                PlayerImage.Source = bi3; //Valitaan kuva objektille kuva muuttuja
                //Luodaan pelaaja olio ja asetetaan sen konstruktori arvoihin ne arvot, jotka pelaaja valitsi hahmonluonti ikkunassa
                Pelaaja = new Fighter(Window2.ChrName, Window2.STR, Window2.CON, Window2.DEX, Window2.WIS, Window2.INT, Window2.Sex, Window2.Race);
            }
            Pelaaja.Initiate(); //Tämä metodi asettaa pelaajan luokan perus arvot
            CharacterName.Text = Pelaaja.Name;
            Sex.Text = Pelaaja.Sex;
            Race.Text = Pelaaja.Race;
            //  Pelaaja.PlayerUpdate(); //Metodi joka päivittää 
        }

        //Vihulaisten luonnin ja randomisoinnin metodi
        private void GenerateEnemy()
        {
            BitmapImage bi3 = new BitmapImage(); //Luodaan kuvalle muuttuja
            bi3.BeginInit(); //Aktivoidaan kuva muuttuja
            RandomEnemy = Randomi.Next(1, 100);
            //Mitä korkeampi pelaaja olion taso on, sitä haastavampia vihulaisia luodaan
            if (Pelaaja.LEVEL < 4)
            {
                if (RandomEnemy > 25)
                {
                    Enemy.Goblin();
                }

                else if (RandomEnemy < 25)
                {
                    Enemy.Orc();
                }
            }
            else if (Pelaaja.LEVEL < 10)
            {
                if (RandomEnemy < 50)
                {
                    Enemy.Goblin();
                }

                else if (RandomEnemy > 50)
                {
                    Enemy.Orc();
                }
            }
            if (Enemy.Name == "Goblin")
            {
                bi3.UriSource = new Uri("https://www.aidedd.org/dnd/images/goblin.jpg", UriKind.Absolute); //Annetaan kuva muuttujalle lähde 
            }

            else if (Enemy.Name == "Orc")
            {
                bi3.UriSource = new Uri("https://www.aidedd.org/dnd/images/orc.jpg", UriKind.Absolute); //Annetaan kuva muuttujalle lähde 
            }
            bi3.EndInit();  //Lopettaa kuvan aktivoimisen
            EnemyImage.Stretch = Stretch.Fill; //Venyttää valitun kuvaa kunnes se täyttää kuva objektin ikkunassa
            EnemyImage.Source = bi3; //Valitaan kuva objektille kuva muuttuja
            EnemyName.Text = Enemy.Name;
        }

        //Päivitetään pelaajan ja vihulaisen arvot ja taistelun viestit ikkunassa, joka kierroksella
        private void Update()
        {
            Pelaaja.PlayerUpdate();
            Enemy.EnemyUpdate();
            StrengthTotal.Text = Convert.ToString(Pelaaja.STR);
            DexterityTotal.Text = Convert.ToString(Pelaaja.DEX);
            ConstitutionTotal.Text = Convert.ToString(Pelaaja.CON);
            IntelligenceTotal.Text = Convert.ToString(Pelaaja.INT);
            WisdomTotal.Text = Convert.ToString(Pelaaja.WIS);
            FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            Health.Text = Convert.ToString(Pelaaja.HP);
            Mana.Text = Convert.ToString(Pelaaja.MANA);
            Class.Text = Convert.ToString(Pelaaja.CLASS);
            Accuracy.Text = Convert.ToString(Pelaaja.ATK);
            MeleeDamage.Text = Convert.ToString(Pelaaja.DMG);
            Armor.Text = Convert.ToString(Pelaaja.ARMOR);
            Level.Text = "Level: " + Convert.ToString(Pelaaja.LEVEL);
            Experience.Text = "Experience: " + Convert.ToString(Pelaaja.EXP);
            Gold.Text = "Gold: " + Convert.ToString(Pelaaja.Gold);

            EnemyStrength.Text = Convert.ToString(Enemy.STR);
            EnemyDexterity.Text = Convert.ToString(Enemy.DEX);
            EnemyConstitution.Text = Convert.ToString(Enemy.CON);
            EnemyWisdom.Text = Convert.ToString(Enemy.WIS);
            EnemyIntelligence.Text = Convert.ToString(Enemy.INT);
            EnemyHealth.Text = Convert.ToString(Enemy.HP);
            EnemyMana.Text = Convert.ToString(Enemy.MANA);
            EnemyAccuracy.Text = Convert.ToString(Enemy.ATK);
            EnemyMeleeDamage.Text = Convert.ToString(Enemy.DMG);
            EnemyArmor.Text = Convert.ToString(Enemy.ARMOR);
            EnemyLevel.Text = "Level: " + Convert.ToString(Enemy.Level);

            //Tämä toteutuu jos vihulais olion elämä pisteet laskee alle yhden, eli kuolee
            if (Enemy.HP < 1)
            {
                Pelaaja.EXP += Enemy.Exp;
                Pelaaja.Gold += Enemy.Gold;
                DeathMessage = "Enemy has died, player gains: " + Enemy.Exp + " Experience Points, and Loots: " + Enemy.Gold + " Gold Pieces";
                Pelaaja.LEVELUP();
                Pelaaja.HP = Pelaaja.baseHP;
                Pelaaja.MANA = Pelaaja.baseMANA;
                GenerateEnemy();
                SpawnMessage = "You've encountered a new enemy: " + Enemy.Name;
                Update();
            }
            //Tämä toteutuu jos pelaaja olion elämä pisteet menevät alle yhden, eli kuolee
            else if (Pelaaja.HP < 1)
            {
                Messages.Text = "You've died!" + "\r\n" + "Game Over!";
                return;
            }

            else
            {
                Messages.Text = PlayerMessages + "\r\n" + EnemyMessages + "\r\n" + DeathMessage + "\r\n" + SpawnMessage;
            }
            SpawnMessage = "";
            EnemyMessages = "";
            PlayerMessages = "";
            DeathMessage = "";
        }

        //Tämä metodi toteutetaan kun pelaaja painaa Attack nappia, ja se käynnistää "kierroksen", jossa käydään läpi pelaaja olion ja vihulais olion hyökkäykset
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Tämä toteutuu jos Pelaaja olio on kuollut, ja palauttaa pelion päävalikkoon
            if (Pelaaja.HP <= 0)
            {
                Pelaaja = null;
                Window2.ChrName = "";
                Window2.STR = 0;
                Window2.CON = 0;
                Window2.DEX = 0;
                Window2.WIS = 0;
                Window2.INT = 0;
                Window2.Sex = null;
                Window2.FreeStats = 60;
                Window Win1 = new MainWindow();
                Win1.Show();
                Close();
            }
            //Muuten käydään läpi pelaaja ja vihulais olion hyökkäys metodit, ja sen jälkeen päivitetään ikkunan näkymä
            else if (Pelaaja.HP > 0)
            {
                PlayerAttack();
                EnemyAttack();
                Update();
            }
        }

        //Metodi joka laskee osuuko Vihulais olio pelaajaan, ja kuinka paljon vahinkoa hyökkäys tekee jos osuu
        private void EnemyAttack()
        {
            if (Enemy.Hit(Pelaaja.ARMOR))
            {
                if (Enemy.DiceRoll >= Enemy.CritChance - Enemy.CRIT)
                {
                    EnemyMessages += " Enemy Attack Roll: DiceRoll: " + Enemy.DiceRoll + " Enemy Attack " + Enemy.ATK + " =  Total Attack: " + Enemy.AttackRoll + " 20! CRITICAL HIT! Ignores Armor " + Pelaaja.ARMOR + " = Enemy Hits!" + "\r\n";
                    EnemyMessages += " Enemy Attack Does: " + (Enemy.DMG * 2 - Pelaaja.PhysRES) + " Points of Damage " + "\r\n";
                }
                else
                {
                    EnemyMessages += " Enemy Attack Roll: DiceRoll " + Enemy.DiceRoll + " Enemy Attack " + Enemy.ATK + " = Total Attack: " + Enemy.AttackRoll + " VS Player Armor " + Pelaaja.ARMOR + " = Enemy Hits!" + "\r\n";
                    EnemyMessages += " Enemy Attack Does: " + (Enemy.DMG - Pelaaja.PhysRES) + " Points of Damage " + "\r\n";
                }
                Pelaaja.HP = Enemy.Attack(Pelaaja.HP, Pelaaja.PhysRES);
            }

            else
            {
                EnemyMessages += " Enemy Attack Roll: DiceRoll " + Enemy.DiceRoll + " Enemy Attack " + Enemy.ATK + " =  Total Attack: " + Enemy.AttackRoll + " VS Player Armor " + Pelaaja.ARMOR + " = Enemy Misses" + "\r\n";
            }
        }

        //Metodi joka laskee osuuko pelaaja olio vihulais olioon, ja kuinka paljon vahinkoa hyökkäys tekee jos osuu
        private void PlayerAttack()
        {
            if (Pelaaja.Hit(Enemy.ARMOR))
            {
                if (Pelaaja.DiceRoll >= Pelaaja.CritChance - Pelaaja.CRIT)
                {
                    PlayerMessages += " Player Attack Roll: DiceRoll: " + Pelaaja.DiceRoll + " Player Attack: " + Pelaaja.ATK + " = Total Attack: " + Pelaaja.AttackRoll + " CRITICAL HIT! Ignores Armor " + Enemy.ARMOR + " = Player Hits!" + "\r\n";
                    PlayerMessages += " Player Attack Does: " + (Pelaaja.DMG * 2 - Enemy.PhysRES) + " Points of Damage" + "\r\n";
                }
                else
                {
                    PlayerMessages += " Player Attack Roll: DiceRoll: " + Pelaaja.DiceRoll + " Player Attack: " + Pelaaja.ATK + " = Total Attack: " + "VS Enemy Armor " + Enemy.ARMOR + " = Player Hits!" + "\r\n";
                    PlayerMessages += " Player Attack Does: " + (Pelaaja.DMG - Enemy.PhysRES) + " Points of Damage" + "\r\n";
                }
                Enemy.HP = Pelaaja.Attack(Enemy.HP, Enemy.PhysRES);
            }

            else
            {
                PlayerMessages += " Player Attack Roll: DiceRoll: " + Pelaaja.DiceRoll + " Player Attack: " + Pelaaja.ATK + " = Total Attack: " + " VS Enemy Armor " + Enemy.ARMOR + " = Player Misses!" + "\r\n";
            }
        }

        //Metodit arvojen nostamiseen, jos pelaajalle on vapaana arvopisteitä tason noususta
        private void PlusStr_Click(object sender, RoutedEventArgs e)
        {
            if (Pelaaja.FreeStats > 0)
            {
                Pelaaja.STR++;
                Pelaaja.FreeStats -= 1;
                StrengthTotal.Text = Convert.ToString(Pelaaja.STR);
                FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            }
            else
                Messages.Text += "No free stat points, level up more noob!";
        }


        private void PlusDex_Click(object sender, RoutedEventArgs e)
        {
            if (Pelaaja.FreeStats > 0)
            {
                Pelaaja.DEX++;
                Pelaaja.FreeStats -= 1;
                DexterityTotal.Text = Convert.ToString(Pelaaja.DEX);
                FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            }
            else
                Messages.Text += "No free stat points, level up more noob!";
        }

        private void PlusCon_Click(object sender, RoutedEventArgs e)
        {
            if (Pelaaja.FreeStats > 0)
            {
                Pelaaja.CON++;
                Pelaaja.FreeStats -= 1;
                ConstitutionTotal.Text = Convert.ToString(Pelaaja.CON);
                FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            }
            else
                Messages.Text += "No free stat points, level up more noob!";
        }

        private void PlusInt_Click(object sender, RoutedEventArgs e)
        {
            if (Pelaaja.FreeStats > 0)
            {
                Pelaaja.INT++;
                Pelaaja.FreeStats -= 1;
                IntelligenceTotal.Text = Convert.ToString(Pelaaja.INT);
                FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            }
            else
                Messages.Text += "No free stat points, level up more noob!";
        }

        private void PlusWis_Click(object sender, RoutedEventArgs e)
        {
            if (Pelaaja.FreeStats > 0)
            {
                Pelaaja.WIS++;
                Pelaaja.FreeStats -= 1;
                WisdomTotal.Text = Convert.ToString(Pelaaja.WIS);
                FreeStatPoints.Text = Convert.ToString(Pelaaja.FreeStats);
            }
            else
                Messages.Text += "No free stat points, level up more noob!";
        }

        //Metodi Quit eli lopetus nappulalle, joka palauttaa pelin päävalikkoon
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Quit();
        }

        //Metodi Joka palauttaa peli näkymän päävalikkoon, mutta myös alustaa pelaaja olion, jotta sama olio ei tule käyttöön,
        //jos pelaaja aloittaa uuden pelisession samassa ohjelman instanssissa
        private void Quit()
        {
            Pelaaja = null;
            Window2.ChrName = "";
            Window2.STR = 0;
            Window2.CON = 0;
            Window2.DEX = 0;
            Window2.WIS = 0;
            Window2.INT = 0;
            Window2.Sex = null;
            Window2.FreeStats = 60;
            Window Win1 = new MainWindow();
            Win1.Show();
            Close();
        }
    }
}
