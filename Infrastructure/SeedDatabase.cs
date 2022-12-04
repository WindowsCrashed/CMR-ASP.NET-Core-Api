using CMRWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CMRWebApi.Infrastructure
{
    public class SeedDatabase
    {
        public static void Seed(CMRDbContext context)
        {
            context.Database.Migrate();

            if (!context.Composers.Any() && !context.Pieces.Any()
                && !context.AudioRecordings.Any() && !context.VideoRecordings.Any()
                && !context.SheetMusic.Any() && !context.Tonality.Any())
            //&& !context.Instruments.Any())
            {
                Composer bach = new() {
                    Id = Guid.NewGuid(),
                    Name = "Johann Sebastian",
                    LastName = "Bach",
                    Nationality = "German",
                    Period = "Baroque",
                    Birth = "Eisenach, 31 March 1685",
                    Death = "Leipzig, 28 July 1750 (age 65)",
                    ImgPath = "63863d83560da.jpg",
                    History = "Johann Sebastian Bach was a German composer and musician of the late Baroque period. He is known for his orchestral music such as the Brandenburg Concertos; instrumental compositions such as the Cello Suites; keyboard works such as the Goldberg Variations and The Well-Tempered Clavier; organ works such as the Schubler Chorales and the Toccata and Fugue in D minor; and vocal music such as the St Matthew Passion and the Mass in B minor. Since the 19th-century Bach revival he has been generally regarded as one of the greatest composers in the history of Western music.{?p?}The Bach family already counted several composers when Johann Sebastian was born as the last child of a city musician in Eisenach. After being orphaned at the age of 10, he lived for five years with his eldest brother Johann Christoph, after which he continued his musical education in Lüneburg. From 1703 he was back in Thuringia, working as a musician for Protestant churches in Arnstadt and Mühlhausen and, for longer stretches of time, at courts in Weimar, where he expanded his organ repertory, and Köthen, where he was mostly engaged with chamber music. From 1723 he was employed as Thomaskantor (cantor at St Thomas's) in Leipzig. There he composed music for the principal Lutheran churches of the city, and for its university's student ensemble Collegium Musicum. From 1726 he published some of his keyboard and organ music. In Leipzig, as had happened during some of his earlier positions, he had difficult relations with his employer, a situation that was little remedied when he was granted the title of court composer by his sovereign, Augustus III, Elector of Saxony and King of Poland, in 1736. In the last decades of his life he reworked and extended many of his earlier compositions. He died of complications after eye surgery in 1750 at the age of 65.{?p?}Bach enriched established German styles through his mastery of counterpoint, harmonic, and motivic organization, and his adaptation of rhythms, forms, and textures from abroad, particularly from Italy and France. Bach's compositions include hundreds of cantatas, both sacred and secular. He composed Latin church music, Passions, oratorios, and motets. He often adopted Lutheran hymns, not only in his larger vocal works, but for instance also in his four-part chorales and his sacred songs. He wrote extensively for organ and for other keyboard instruments. He composed concertos, for instance for violin and for harpsichord, and suites, as chamber music as well as for orchestra. Many of his works employ the genres of canon and fugue.{?p?}Throughout the 18th century, Bach was primarily valued as an organist, while his keyboard music, such as The Well-Tempered Clavier, was appreciated for its didactic qualities. The 19th century saw the publication of some major Bach biographies, and by the end of that century all of his known music had been printed. Dissemination of scholarship on the composer continued through periodicals (and later also websites) exclusively devoted to him, and other publications such as the Bach-Werke-Verzeichnis (BWV, a numbered catalogue of his works) and new critical editions of his compositions. His music was further popularized through a multitude of arrangements, including the Air on the G String and \"Jesu, Joy of Man's Desiring\", and of recordings, such as three different box sets with complete performances of the composer's oeuvre marking the 250th anniversary of his death."
                };

                Composer beethoven = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ludwig van",
                    LastName = "Beethoven",
                    Nationality = "German",
                    Period = "Classical",
                    Birth = "Bonn, 17 December 1770 (baptised)",
                    Death = "Vienna, 26 March 1827 (age 56)",
                    ImgPath = "63863d83558bb.jpg",
                    History = "Ludwig van Beethoven was a German composer and pianist. Beethoven remains one of the most admired composers in the history of Western music; his works rank amongst the most performed of the classical music repertoire and span the transition from the Classical period to the Romantic era in classical music. His career has conventionally been divided into early, middle, and late periods. His early period, during which he forged his craft, is typically considered to have lasted until 1802. From 1802 to around 1812, his middle period showed an individual development from the styles of Joseph Haydn and Wolfgang Amadeus Mozart, and is sometimes characterized as heroic. During this time, he began to grow increasingly deaf. In his late period, from 1812 to 1827, he extended his innovations in musical form and expression.{?p?}Beethoven was born in Bonn. His musical talent was obvious at an early age. He was initially harshly and intensively taught by his father Johann van Beethoven. Beethoven was later taught by the composer and conductor Christian Gottlob Neefe, under whose tutelage he published his first work, a set of keyboard variations, in 1783. He found relief from a dysfunctional home life with the family of Helene von Breuning, whose children he loved, befriended, and taught piano. At age 21, he moved to Vienna, which subsequently became his base, and studied composition with Haydn. Beethoven then gained a reputation as a virtuoso pianist, and he was soon patronized by Karl Alois, Prince Lichnowsky for compositions, which resulted in his three Opus 1 piano trios (the earliest works to which he accorded an opus number) in 1795.{?p?}His first major orchestral work, the First Symphony, premiered in 1800, and his first set of string quartets was published in 1801. Despite his hearing deteriorating during this period, he continued to conduct, premiering his Third and Fifth Symphonies in 1804 and 1808, respectively. His Violin Concerto appeared in 1806. His last piano concerto (No. 5, Op. 73, known as the Emperor), dedicated to his frequent patron Archduke Rudolf of Austria, was premiered in 1811, without Beethoven as soloist. He was almost completely deaf by 1814, and he then gave up performing and appearing in public. He described his problems with health and his unfulfilled personal life in two letters, his Heiligenstadt Testament (1802) to his brothers and his unsent love letter to an unknown \"Immortal Beloved\" (1812).{?p?}After 1810, increasingly less socially involved, Beethoven composed many of his most admired works, including later symphonies, mature chamber music and the late piano sonatas. His only opera, Fidelio, first performed in 1805, was revised to its final version in 1814. He composed Missa solemnis between 1819 and 1823 and his final Symphony, No. 9, one of the first examples of a choral symphony, between 1822 and 1824. Written in his last years, his late string quartets, including the Grosse Fuge, of 1825-1826 are among his final achievements. After some months of bedridden illness, he died in 1827. Beethoven's works remain mainstays of the classical music repertoire."
                };

                Composer chopin = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Frédéric",
                    LastName = "Chopin",
                    Nationality = "Polish",
                    Period = "Romantic",
                    Birth = "Żelazowa Wola, 1 March 1810",
                    Death = "Paris, 17 October 1849 (age 39)",
                    ImgPath = "63863d8355e2e.jpeg",
                    History = "Frédéric François Chopin (born Fryderyk Franciszek Chopin) was a Polish composer and virtuoso pianist of the Romantic period, who wrote primarily for solo piano. He has maintained worldwide renown as a leading musician of his era, one whose \"poetic genius was based on a professional technique that was without equal in his generation\".{?p?}Chopin was born in Żelazowa Wola in the Duchy of Warsaw and grew up in Warsaw, which in 1815 became part of Congress Poland. A child prodigy, he completed his musical education and composed his earlier works in Warsaw before leaving Poland at the age of 20, less than a month before the outbreak of the November 1830 Uprising. At 21, he settled in Paris. Thereafter – in the last 18 years of his life – he gave only 30 public performances, preferring the more intimate atmosphere of the salon. He supported himself by selling his compositions and by giving piano lessons, for which he was in high demand. Chopin formed a friendship with Franz Liszt and was admired by many of his other musical contemporaries, including Robert Schumann.{?p?}After a failed engagement to Maria Wodzińska from 1836 to 1837, he maintained an often troubled relationship with the French writer Aurore Dupin (known by her pen name George Sand). A brief and unhappy visit to Mallorca with Sand in 1838–39 would prove one of his most productive periods of composition. In his final years, he was supported financially by his admirer Jane Stirling, who also arranged for him to visit Scotland in 1848. For most of his life, Chopin was in poor health. He died in Paris in 1849 at the age of 39, probably of pericarditis aggravated by tuberculosis.{?p?}All of Chopin's compositions include the piano. Most are for solo piano, though he also wrote two piano concertos, a few chamber pieces, and some 19 songs set to Polish lyrics. His piano writing was technically demanding and expanded the limits of the instrument, his own performances noted for their nuance and sensitivity. His major piano works also include mazurkas, waltzes, nocturnes, polonaises, the instrumental ballade (which Chopin created as an instrumental genre), études, impromptus, scherzi, preludes, and sonatas, some published only posthumously. Among the influences on his style of composition were Polish folk music, the classical tradition of J. S. Bach, Mozart, and Schubert, and the atmosphere of the Paris salons, of which he was a frequent guest. His innovations in style, harmony, and musical form, and his association of music with nationalism, were influential throughout and after the late Romantic period.{?p?}Chopin\'s music, his status as one of music\'s earliest celebrities, his indirect association with political insurrection, his high-profile love-life, and his early death have made him a leading symbol of the Romantic era. His works remain popular, and he has been the subject of numerous films and biographies of varying historical fidelity. Among his many memorials is the Fryderyk Chopin Institute, which was created by the Parliament of Poland to research and promote his life and works. It hosts the International Chopin Piano Competition, a prestigious competition devoted entirely to his works."
                };

                Composer debussy = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Claude",
                    LastName = "Debussy",
                    Nationality = "French",
                    Period = "20th Century",
                    Birth = "Saint-Germain-en-Laye, 22 August 1862",
                    Death = "Paris, 25 March 1918 (age 55)",
                    ImgPath = "63863d8355b71.jpg",
                    History = "Claude Debussy was a French composer. He is sometimes seen as the first Impressionist composer, although he vigorously rejected the term. He was among the most influential composers of the late 19th and early 20th centuries.{?p?}Born to a family of modest means and little cultural involvement, Debussy showed enough musical talent to be admitted at the age of ten to France's leading music college, the Conservatoire de Paris. He originally studied the piano, but found his vocation in innovative composition, despite the disapproval of the Conservatoire's conservative professors. He took many years to develop his mature style, and was nearly 40 when he achieved international fame in 1902 with the only opera he completed, Pelléas et Mélisande.{?p?}Debussy's orchestral works include Prélude à l'après-midi d'un faune (1894), Nocturnes (1897–1899) and Images (1905–1912). His music was to a considerable extent a reaction against Wagner and the German musical tradition. He regarded the classical symphony as obsolete and sought an alternative in his \"symphonic sketches\", La mer (1903–1905). His piano works include sets of 24 Préludes and 12 Études. Throughout his career he wrote mélodies based on a wide variety of poetry, including his own. He was greatly influenced by the Symbolist poetic movement of the later 19th century. A small number of works, including the early La Damoiselle élue and the late Le Martyre de saint Sébastien have important parts for chorus. In his final years, he focused on chamber music, completing three of six planned sonatas for different combinations of instruments.{?p?}With early influences including Russian and Far Eastern music, Debussy developed his own style of harmony and orchestral coloring, derided – and unsuccessfully resisted – by much of the musical establishment of the day. His works have strongly influenced a wide range of composers including Béla Bartók, Olivier Messiaen, George Benjamin, and the jazz pianist and composer Bill Evans. Debussy died from cancer at his home in Paris at the age of 55 after a composing career of a little more than 30 years."
                };

                Tonality dMinor = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "D minor"
                };

                Tonality cMinor = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "C minor"
                };

                Tonality fMinor = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "F minor"
                };

                Tonality fMajor = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "F major"
                };

                Tonality aMajor = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "A major"
                };

                Piece frenchSuite = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "French Suite No. 1",
                    Tonality = dMinor,
                    Catalog = "BWV 812",
                    Composer = bach,
                    Movements = 6,
                    Year = "1722 or before"
                };

                Piece kbPartita = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Keyboard Partita No. 2",
                    Tonality = cMinor,
                    Catalog = "BWV 826",
                    Composer = bach,
                    Movements = 6,
                    Year = "1726"
                };

                Piece appassionata = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Sonata No. 23 (Appassionata)",
                    Tonality = fMinor,
                    Catalog = "Op. 57",
                    Composer = beethoven,
                    Movements = 3,
                    Year = "1804–06"
                };

                Piece symph = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Symphony No. 7",
                    Tonality = aMajor,
                    Catalog = "Op. 92",
                    Composer = beethoven,
                    Movements = 4,
                    Year = "1811-1812"
                };

                Piece ballade = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ballade No. 4",
                    Tonality = fMinor,
                    Catalog = "Op. 52",
                    Composer = chopin,
                    Movements = 1,
                    Year = "1842 (revised 1843)"
                };

                Piece prelude = new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Prélude (Suite Bergamasque)",
                    Tonality = fMajor,
                    Catalog = "L. 75 No. 1",
                    Composer = debussy,
                    Movements = 1,
                    Year = "1890 - 1905"
                };

                context.AddRange(
                    new AudioRecording()
                    {
                        Id= Guid.NewGuid(),
                        AudioPath = "6384f2790c141.mp3",
                        ImagePath = "6384f20abfb51.jpg",
                        Performers = "ingrid haebler",
                        RecordLabel = "Philips Classics",
                        Piece = frenchSuite
                    },
                    new AudioRecording()
                    {
                        Id = Guid.NewGuid(),
                        AudioPath = "6384f2790c55a.mp3",
                        ImagePath = "6384f20ac2615.jpg",
                        Performers = "Martha Argerich",
                        RecordLabel = "Deutsche Grammophon",
                        Piece = kbPartita
                    },
                    new AudioRecording()
                    {
                        Id = Guid.NewGuid(),
                        AudioPath = "6384f2790ccf7.mp3",
                        ImagePath = "6384f20ac0362.jpg",
                        Performers = "Gerhard Oppitz",
                        RecordLabel = "Deutsche Grammophon",
                        Piece = appassionata
                    },
                    new AudioRecording()
                    {
                        Id = Guid.NewGuid(),
                        AudioPath = "6384f2790d109.mp3",
                        ImagePath = "6384f20abf350.jpg",
                        Performers = "Leonard bernstein, Wiener Philharmoniker",
                        RecordLabel = "Deutsche Grammophon",
                        Piece = symph
                    },
                    new AudioRecording()
                    {
                        Id = Guid.NewGuid(),
                        AudioPath = "6384f2790dc2d.mp3",
                        ImagePath = "6384f20ac2223.jpg",
                        Performers = "Martha Argerich",
                        RecordLabel = "Doremi Records",
                        Piece = ballade
                    },
                    new AudioRecording()
                    {
                        Id = Guid.NewGuid(),
                        AudioPath = "6384f2790e67c.mp3",
                        ImagePath = "6384f20ac1c81.jpg",
                        Performers = "Seong-Jin Cho",
                        RecordLabel = "Deutsche Grammophon",
                        Piece = prelude
                    }
                );

                context.AddRange(
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "aTnN5rPpdwE",
                        Performers = "András Schiff",
                        Channel = "o_o",
                        Piece = frenchSuite
                    },
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "VNG8Jmz5zqI",
                        Performers = "Martha Argerich",
                        Channel = "Les beaux-arts channel",
                        Piece = kbPartita
                    },
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "E5JObP74jcw",
                        Performers = "Valentina Lisitsa",
                        Channel = "Valentina Lisitsa QOR Records Official channel",
                        Piece = appassionata
                    },
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "fWGCB81TFPQ",
                        Performers = "Andrés Orozco-Estrada, Frankfurt Radio Symphony",
                        Channel = "hr-Sinfonieorchester – Frankfurt Radio Symphony",
                        Piece = symph
                    },
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "pe-GrRQz8pk",
                        Performers = "Krystian Zimerman",
                        Channel = "Classical Vault 1",
                        Piece = ballade
                    },
                    new VideoRecording()
                    {
                        Id = Guid.NewGuid(),
                        Url = "g9F4yAww9H0",
                        Performers = "Paul Crossley",
                        Channel = "ClassicalScores",
                        Piece = prelude
                    }
                );

                context.AddRange(
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/5/58/IMSLP02100-BWV0812.pdf",
                        Piece = frenchSuite
                    },
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/6/6d/IMSLP00790-BWV0826.pdf",
                        Piece = kbPartita
                    },
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/0/01/IMSLP51795-PMLP01480-Beethoven_Werke_Breitkopf_Serie_16_No_146_Op_57.pdf",
                        Piece = appassionata
                    },
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/a/ab/IMSLP312601-PMLP01600-LvBeethoven_Symphony_No.7_BH_Werke_fs.pdf",
                        Piece = symph
                    },
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/0/0d/IMSLP113142-PMLP01649-FChopin_Ballade_No.4,_Op.52_BHBand1.pdf",
                        Piece = ballade
                    },
                    new SheetMusic()
                    {
                        Id = Guid.NewGuid(),
                        Url = "https://vmirror.imslp.org/files/imglnks/usimg/f/f0/IMSLP00511-Debussy_-_Suite_Bergamasque_-_1_-_Prelude.pdf",
                        Piece = prelude
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
