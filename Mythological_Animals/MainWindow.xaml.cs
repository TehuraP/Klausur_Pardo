using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mythological_Animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

         

            ViewModel vm = new ViewModel();
            vm.GodData = new System.Collections.ObjectModel.ObservableCollection<GodModel>();
            vm.GodDataFromCode = new System.Collections.ObjectModel.ObservableCollection<GodModel>();

            GodModel g1 = new GodModel();
            g1.Name = "Zeus";
            g1.Description = "With the assistance of Hades and Poseidon, Zeus overthrew his father, Cronus, king of the Titans, and became the chief deity in a new pantheon comprising mostly his siblings and children.";
            g1.Photo = "zeus.png";
            GodModel g2 = new GodModel();
            g2.Name = "Hera";
            g2.Description = "The queen goddess of Olympus, Hera was both sister and wife to Zeus. Though she is often depicted as reserved and austere, she was mercilessly vindictive when it came to her husband’s extramarital adventures.";
            g2.Photo = "hera.png";
            GodModel g3 = new GodModel();
            g3.Name = "Apollo";
            g3.Description = "The twin brother of Artemis, Apollo was among the most important of the gods. Son of Zeus, he disseminated the will of his divine compatriots through various means, notably oracles";
            g3.Photo = "apollo.png";
            GodModel g4 = new GodModel();
            g4.Name = "Hermes";
            g4.Description = " He was a pastoral figure, responsible for protecting livestock, and was also associated with fertility, music, luck, and deception.";
            g4.Photo = "hermes2.png";
            GodModel g5 = new GodModel();
            g5.Name = "Aphrodite";
            g5.Description = "Aphrodite was the goddess of love, sex, and beauty. Unsurprisingly for a love goddess, she was said to have emerged from the foam generated when the severed testicles of her father, Uranus, were thrown into the sea by his son, the Titan Cronus.";
            g5.Photo = "aphrodite2.png";
            GodModel g6 = new GodModel();
            g6.Name = "Poseidon";
            g6.Description = "Poseidon is best known as the Greek sea god, but he was also the god of horses and of earthquakes.";
            g6.Photo = "poseidon.png";
            GodModel g7 = new GodModel();
            g7.Name = "Hestia";
            g7.Description = "Hestia was the Greek virgin goddess of the hearth, home, and hospitality. In Greek mythology, she is the eldest daughter of Cronus and Rhea";
            g7.Photo = "hestia.png";
            GodModel g8 = new GodModel();
            g8.Name = "Demeter";
            g8.Description = "Demeter, an agricultural goddess, was mother to Persephone, who was abducted by the underworld god Hades to be his bride.";
            g8.Photo = "demeter.png";
            GodModel g9 = new GodModel();
            g9.Name = "Hades";
            g9.Description = "Hades ruled the world of the dead, with which he was sometimes synonymous. ";
            g9.Photo = "hades.png";
            GodModel g10 = new GodModel();
            g10.Name = "Artemis";
            g10.Description = "Artemis was the fleet-footed goddess of the hunt. Often depicted in painting and sculpture with a deer or a hunting dog, she was both huntress and protectress of the living world.";
            g10.Photo = "artemis.png";
            GodModel g12 = new GodModel();
            g12.Name = "Athena";
            g12.Description = "Athena was the goddess of reason, wisdom, and war. She famously sprung fully formed from the forehead of Zeus. A major figure in the Odyssey, in which she instructed Odysseus, she also guided Perseus and Heracles through their trials. ";
            g12.Photo = "athena.png";
            GodModel g13 = new GodModel();
            g13.Name = "Hephaestus";
            g13.Description = "Hephaestus is the Greek god of blacksmiths, metalworking, carpenters, craftsmen, artisans, sculptors, metallurgy, fire (compare, however, with Hestia), and volcanoes.";
            g13.Photo = "hephaestus.png";
            GodModel g14 = new GodModel();
            g14.Name = "Ares";
            g14.Description = "Ares was the god of bloodlust. Though his fellow deities weren’t particularly fond of him, the Spartans had no problems, er, donating some prisoners of war to his worship";
            g14.Photo = "ares.png";
            GodModel g15 = new GodModel();
            g15.Name = "Dionysus";
            g15.Description = "Dionysus was a son of Zeus born to a mortal mother. When Zeus accidentally killed her, he sewed the young Dionysus into his thigh and, when the young god emerged, passed him to the care of the maenads.";
            g15.Photo = "dionysus.png";

            vm.GodDataFromCode.Add(g1);
            vm.GodDataFromCode.Add(g2);
            vm.GodDataFromCode.Add(g3);
            vm.GodDataFromCode.Add(g4);
            vm.GodDataFromCode.Add(g5);
            vm.GodDataFromCode.Add(g6);
            vm.GodDataFromCode.Add(g7);
            vm.GodDataFromCode.Add(g8);
            vm.GodDataFromCode.Add(g9);
            vm.GodDataFromCode.Add(g10);
            vm.GodDataFromCode.Add(g12);
            vm.GodDataFromCode.Add(g13);
            vm.GodDataFromCode.Add(g14);
            vm.GodDataFromCode.Add(g15);

            vm.NewGod = new GodModel();
          //  vm.AddGod();

            this.DataContext = vm;
            vm.FillGodsFromDB();

            vm.MythData = new System.Collections.ObjectModel.ObservableCollection<MythModel>();
            vm.MythDataFromCode = new System.Collections.ObjectModel.ObservableCollection<MythModel>();

            MythModel mii = new MythModel();
            mii.Name = "Some Myth";
            mii.Description = "And then eveyone died";
            mii.Photo = "ruin.png";
            vm.NewMyth = new MythModel();
            vm.MythDataFromCode.Add(mii);

            vm.FillMythsFromDB();


            MythModel m1 = new MythModel();
            m1.Name = "Pandora's Box";
            m1.Description = "Pandora was the first human woman, created by Hephaestus on the orders of Zeus and endowed by the different gods with some of her greatest qualities and virtues, but also including the ability to seduce and lie. Its creation obeys the desire of the king of Olympus to take revenge on Prometheus and his people.\r\n\r\n The god made Pandora and Prometheus' brother Epimetheus meet, and eventually led to marriage. But Pandora also received a box for her husband, in which all the evils of the world were locked, with instructions never to open it. \r\n\r\n However, one of the gifts that Pandora had received was that of curiosity. One day, the woman opened the box to see what was inside, something that would cause all the evils to come out of the box and spread throughout the world. Scared, Pandora closed the box, but there was only hope. So Pandora dedicated herself to offering hope to men, in order to help them endure the evils and vicissitudes of the world. ";
            m1.Photo = "pandora.png";
            MythModel m2 = new MythModel();
            m2.Name = "The birth of Aphrodite";
            m2.Description = "Gaea, mother Earth, herself gave birth to Uranus, the heavens.Together with him she would beget and give birth to numerous children, who, however, would be buried in their mother due to the hatred and fear that Uranus had for her offspring.\r\n\r\n One day the youngest son, Cronos(a titan who would become the father of the Olympian gods, whom he would devour), with the help of a sickle provided by his mother, castrated his father Uranus by cutting off his genitals.The remains of said genitalia fell into the sea, where the blood and semen would mix with the waters, forming a foam from which a deity, Aphrodite, would eventually be born, already fully adult from birth.";
            m2.Photo = "birthaphrodite.jpg";
            MythModel m3 = new MythModel();
            m3.Name = "The Origin of Medusa";
            m3.Description = "Medusa was once a beautiful young woman, a priestess of Athena whose beauty was admired by all who looked at her and who enjoyed multiple suitors. One day the god Poseidon observed the young woman and fell in love with her. The god of the seas decided to kidnap Medusa and take her against her will in the temple of Athens. This fact provoked the wrath of Athena, who decided to curse the woman by transforming her beautiful hair into angry snakes, in addition to making anyone who stared into her eyes from now on to turn to stone. ";
            m3.Photo = "medusa.png";
            MythModel m4 = new MythModel();
            m4.Name = "The fall of Icarius";
            m4.Description = "Icarus was the son of Daedalus, a wise old man of great knowledge who was able to build the labyrinth in which King Minos locked the minotaur. Said king, to prevent anyone from ever knowing how to find the way out of the labyrinth, decided to lock the sage and Icarus for life in a tower.\r\n\r\nDaedalus dreamed of escaping from his prison, but he could not escape by land or sea. Eventually he came to the conclusion that he could escape through the air, and in this way he made two large pairs of wax wings out of wax and bird feathers. Before leaving, the wise Daedalus warned Icarus not to fly too high or too fast, as the wax wings would not hold.\r\n\r\nBoth began the flight, escaping from their confinement. But Icarus, seeing the beauty of the Sun, ignored the indications of his father and flew higher and higher, trying to get closer until almost touching the sun. But the wings did not resist the heat, falling apart and causing Icarus to pre-jump into the void and die.";
            m4.Photo = "icarius.png";
            MythModel m5 = new MythModel();
            m5.Name = "The myrmidons";
            m5.Description = "Legend has it that the king of Olympus, Zeus, maintained relations with the nymph Aegis and later named an island off the Peloponnese after her. However, when Hera found out about her husband's adventure and the name given to the island, she decided to send a horrible plague that ended up killing the vast majority of those who inhabited it. Among the few survivors was the island's king, Aeacus of Aegina, who pleaded with Zeus to repopulate the island.\r\n\r\nWhile praying a ray of the sun illuminated a line of ants in an oak tree, something that made the king decide to ask for as many people to emerge as he had seen on the tree. Aeacus of Aegina fell asleep and dreamed that the ants in the oak fell to the ground and in doing so they transformed In person. Upon awakening, the island had recovered the number of inhabitants of yesteryear, being named in honor of the ants from which they came (myrmidon could be translated as ant men)";
            m5.Photo = "myrmidons.png";
            MythModel m6 = new MythModel();
            m6.Name = "The myth of Sisyphus";
            m6.Description = "There was a time when the region of Ephira had a king named Sisyphus, of great cunning but who had the great defect of being tremendously manipulative and greedy. But a day came when his ambition and his actions would provoke the wrath of Zeus by accusing him of the kidnapping of the nymph Aegina before her father, Asopo, in exchange for sources of fresh water for his city. Zeus ordered Thanatos to go and take King Sisyphus to the underworld, but once there the devious king invited the deity of death to eat, deceiving him in such a way that he managed to chain him in a cell.\r\n\r\nAs death was locked up, no deaths occurred, something that ended up enraging Hades and make it finally be decided that Ares should free Thanatos and bring Sisyphus to the underworld. However, the clever king asked his wife not to honor him at his funeral at his death, a request that she complied with. This fact would be used by Sisyphus to deceive Hades, asking him to bring him back to life since his wife had not celebrated the funeral properly and had not paid him honors.\r\n\r\n The god of the underworld accepted in exchange for her returning after doing so. But Sisyphus did not return, until death came many years later. Sisyphus would eventually be punished by Zeus and Hades. His sentence was having to climb a stone up the side of a mountain to the top. However when arriving there it would fall towards the other side of the mountain, with which it would have to be pushed again to the top, something that would be repeated in an eternal cycle.";
            m6.Photo = "sisyphus.png";
            MythModel m7 = new MythModel();
            m7.Name = "The myth of Tiresias";
            m7.Description = "Legend has it that while walking through the mountains one day, Tiresias found two snakes in full copulation on his way on the mountain. Tiresias wanted to separate them and hit the female with his rod, killing her. But in doing so, his action had as a consequence that he was cursed and in revenge his sex was changed, becoming a woman. Tiresias would live as a woman for 8 years, after which she would meet the same snakes again. This time he struck and killed the male, turning back to being male.\r\n\r\nYears later, the gods Zeus and Hera would have a dispute over which of the two sexes enjoyed sex more. Tiresias was chosen as judge, since he had lived as a man and as a woman. But Tiresias's response, proposing that the woman enjoyed more, drew Hera's ire. As punishment, the goddess made him blind. However, as compensation for such action, Zeus gave him the gift of clairvoyance. This would make Tiresias one of the most famous seers in all of Greek mythology throughout his life.";
            m7.Photo = "tiresias.png";
            MythModel m8 = new MythModel();
            m8.Name = "The myth of Eco";
            m8.Description = "Echo was an oreades or nymphs of the forest and of the mountain. The most beautiful words came from her lips, but they were so beautiful that Zeus would begin to be attracted to her. Hera, the betrayal discovered, he cursed Eco snatching his voice and making it possible for him to only repeat the last words that his interlocutor said to him.\r\n\r\nTime passed and the nymph fell in love with the young Narcissus, watching him secretly. One day, the young man withdrew from his companions and would perceive the nymph. However, he cruelly rejected her, something that caused the nymph to hide in a cave, where she was consumed until only her voice remained. ";
            m8.Photo = "echo.jpg";
            MythModel m9 = new MythModel();
            m9.Name = "The myth of Narcissus";
            m9.Description = "Son of the god Cefiso and Liriope, Narcissus was a very beautiful and attractive young man, who according to the great diviner Tiresias would live many years as long as he did not see his reflection. The young man generated the admiration of both men and women and was aware of his attractiveness, to the point of being highly conceited and despising the virtues and feelings of others, among which was the nymph Echo or the young Aminias.\r\n\r\n To the latter he would give a sword, with which the rejected young man would kill himself. Shortly before dying, he prayed to the goddess of vengeance Nemesis asking that Narcissus know unrequited love. The deity responded. \r\n\r\n One day, as he approached to drink, Narcissus saw his reflection in the water of a pond and fell madly in love with him. Finally, trying to get closer to his loved one, Narcissus fell into the water and ended up drowning.";
            m9.Photo = "narcissus.jpg";
            MythModel m10 = new MythModel();
            m10.Name = "The myth of Prometheus";
            m10.Description = "Prometheus was one of the Titans, son of Iapetus and Clymene. According to some myths, together with his brother Epimetheus, he was commissioned with the task of creating animals and humans, it being Prometheus who decided to give man the ability to walk upright.\r\n\r\nHe also mocked and deceived the gods to favor mortals. On an occasion when Zeus forbade fire to mortals and seeing the needs and difficulties of man to survive, decided to give them fire. Therefore Prometheus entered Olympus and stole the fire from Helios' chariot using a reed, after which he gave it to mortals in such a way that they could be heated and illuminated.\r\n\r\nBut Zeus was enraged at the theft, condemning the Titan to be chained to Mount Caucaso, where every day and forever, an eagle would come to devour his liver. The organ would grow back during the day, so that the torment would repeat itself eternally for this immortal being. ";
            m10.Photo = "prometheus.jpg";

            vm.MythDataFromCode.Add(m1);
            vm.MythDataFromCode.Add(m2);
            vm.MythDataFromCode.Add(m3);
            vm.MythDataFromCode.Add(m4);
            vm.MythDataFromCode.Add(m5);
            vm.MythDataFromCode.Add(m6);
            vm.MythDataFromCode.Add(m7);
            vm.MythDataFromCode.Add(m8);
            vm.MythDataFromCode.Add(m9);
            vm.MythDataFromCode.Add(m10);





        }
        private void NewGod_Click(object sender, RoutedEventArgs e)
        {
            NewWindow myNewWindow = new NewWindow();
            ViewModel vm = this.DataContext as ViewModel;
            myNewWindow.DataContext = vm;
            myNewWindow.ShowDialog();
        }

        private void NewMyth_Click(object sender, RoutedEventArgs e)
        {
            SecondNewWindow myNewWindow2 = new SecondNewWindow();
            ViewModel vm = this.DataContext as ViewModel;
            myNewWindow2.DataContext = vm;
            myNewWindow2.ShowDialog();
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            ViewModel vm = this.DataContext as ViewModel;
            vm.DeleteItem();
        }

        private void Button_Myths_Click(object sender, RoutedEventArgs e)
        {
            MythWindow mythWindow = new MythWindow();
            ViewModel vm = this.DataContext as ViewModel;
            mythWindow.DataContext = vm;
            mythWindow.ShowDialog();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewModel vm = this.DataContext as ViewModel;
            vm.FilterMyths();
        }
        private void OnDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string imagePath = files[0];
                // Do something with the imagePath
            }
        }
            
        private void openFile(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
           
                if (openFileDialog.ShowDialog() == true)
                {
                    string imagePath = openFileDialog.FileName;
                    BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
                    uploadedImage.Source = bitmap;
                }
            

        }

    }
}
