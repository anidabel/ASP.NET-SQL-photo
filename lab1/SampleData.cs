using lab1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class SampleData
    {
        public static byte[] Convert(string path)
        {
            byte[] imageData = null;
            //string path = "~/photo/" + name;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(path).Length;
            imageData = br.ReadBytes((int)numBytes);
            fs.Close();
            br.Close();
            return imageData;
        }
        public static void Initialize(HockeyPlayerContext context)
        {
            if (!context.hockeyPlayer.Any())
            {
                context.hockeyPlayer.AddRange(
                    new HockeyPlayer
                    {
                        playerid = "adamlem",
                        jersey = 12,
                        fname = "Mike",
                        sname = "Adamle",
                        position = "RW",
                        birthday = new DateTime(2001, 9, 21),
                        weight = 73,
                        height = 197,
                        birthcity = "Stamford",
                        birthstate = "CT",
                        photo = Convert("wwwroot/photo/mike_adamle.jpg")
                    },
                     new HockeyPlayer
                     {
                         playerid = "adamles",
                         jersey = 17,
                         fname = "Scott",
                         sname = "Adamle",
                         position = "D",
                         birthday = new DateTime(1999, 3, 1),
                         weight = 70,
                         height = 184,
                         birthcity = "Columbs",
                         birthstate = "OH",
                         photo = Convert("wwwroot/photo/scott_adamle.jpg")
                     },
                     new HockeyPlayer
                     {
                         playerid = "aramnova",
                         jersey = 31,
                         fname = "Arcady",
                         sname = "Armanov",
                         position = "LW",
                         birthday = new DateTime(1998, 10, 25),
                         weight = 71,
                         height = 195,
                         birthcity = "Minsk",
                         birthstate = "RU",
                         photo = Convert("wwwroot/photo/arcady_armanov.jpg")
                     },
                     new HockeyPlayer
                     {
                         playerid = "boolea",
                         jersey = 8,
                         fname = "Alexi",
                         sname = "Boole",
                         position = "RW",
                         birthday = new DateTime(1997, 09, 14),
                         weight = 72,
                         height = 194,
                         birthcity = "Kiev",
                         birthstate = "UK",
                         photo = Convert("wwwroot/photo/alexi_boole.jpg")
                     },
                    new HockeyPlayer
                    {
                        playerid = "choakd",
                        jersey = 11,
                        fname = "Dominick",
                        sname = "Choak",
                        position = "RW",
                        birthday = new DateTime(1997, 2, 22),
                        weight = 72,
                        height = 196,
                        birthcity = "Prague",
                        birthstate = "CZ",
                        photo = Convert("wwwroot/photo/dominick_choak.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "clobberk",
                        jersey = 24,
                        fname = "Kirloy",
                        sname = "Clobber",
                        position = "D",
                        birthday = new DateTime(2002, 6, 21),
                        weight = 73,
                        height = 200,
                        birthcity = "Bangor",
                        birthstate = "ME",
                        photo = Convert("wwwroot/photo/kirloy_clobber.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "clubbes",
                        jersey = 7,
                        fname = "Sam",
                        sname = "Clubbe",
                        position = "LW",
                        birthday = new DateTime(1999, 7, 26),
                        weight = 75,
                        height = 190,
                        birthcity = "Paramus",
                        birthstate = "Hj",
                        photo = Convert("wwwroot/photo/sam_clubbe.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "finleyp",
                        jersey = 14,
                        fname = "Peter",
                        sname = "Finley",
                        position = "D",
                        birthday = new DateTime(1987, 6, 8),
                        weight = 76,
                        height = 194,
                        birthcity = "Denver",
                        birthstate = "CO",
                        photo = Convert("wwwroot/photo/peter_finley.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "fiskj",
                        jersey = 25,
                        fname = "jerke",
                        sname = "Fisk",
                        position = "D",
                        birthday = new DateTime(2001, 11, 25),
                        weight = 71,
                        height = 193,
                        birthcity = "Helsinki",
                        birthstate = "FI",
                        photo = Convert("wwwroot/photo/jerke_fisk.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "gruberh",
                        jersey = 29,
                        fname = "Hans",
                        sname = "Gruber",
                        position = "D",
                        birthday = new DateTime(1991, 2, 11),
                        weight = 70,
                        height = 175,
                        birthcity = "Munich",
                        birthstate = "DE",
                        photo = Convert("wwwroot/photo/hans_gruber.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "Grunwala",
                        jersey = 6,
                        fname = "Allan",
                        sname = "Grunwald",
                        position = "C",
                        birthday = new DateTime(1990, 10, 17),
                        weight = 74,
                        height = 189,
                        birthcity = "Buffalo",
                        birthstate = "NY",
                        photo = Convert("wwwroot/photo/allan_grunwald.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "ivanovv",
                        jersey = 4,
                        fname = "Valerei",
                        sname = "Ivanovich",
                        position = "C",
                        birthday = new DateTime(2004, 9, 20),
                        weight = 72,
                        height = 175,
                        birthcity = "Moscow",
                        birthstate = "RU",
                        photo = Convert("wwwroot/photo/valerei_ivanovich.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "jeffriea",
                        jersey = 30,
                        fname = "Angus",
                        sname = "jeffries",
                        position = "G",
                        birthday = new DateTime(1995, 11, 8),
                        weight = 70,
                        height = 185,
                        birthcity = "Springfield",
                        birthstate = "MA",
                        photo = Convert("wwwroot/photo/angus_jeffries.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "jonesr",
                        jersey = 35,
                        fname = "Robert",
                        sname = "jones",
                        position = "C",
                        birthday = new DateTime(1997, 5, 22),
                        weight = 73,
                        height = 189,
                        birthcity = "Hartford",
                        birthstate = "CT",
                        photo = Convert("wwwroot/photo/robert_jones.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "lexourb",
                        jersey = 9,
                        fname = "Bruce",
                        sname = "Lexour",
                        position = "D",
                        birthday = new DateTime(2001, 9, 5),
                        weight = 75,
                        height = 198,
                        birthcity = "Quincy",
                        birthstate = "IL",
                        photo = Convert("wwwroot/photo/bruce_lexour.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "lunds",
                        jersey = 93,
                        fname = "Steven",
                        sname = "Lund",
                        position = "D",
                        birthday = new DateTime(1997, 5, 22),
                        weight = 71,
                        height = 193,
                        birthcity = "St.Paul",
                        birthstate = "MN",
                        photo = Convert("wwwroot/photo/steven_lund.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "manguirea",
                        jersey = 34,
                        fname = "Andre",
                        sname = "Manguire",
                        position = "LW",
                        birthday = new DateTime(1999, 12, 8),
                        weight = 75,
                        height = 191,
                        birthcity = "Detroit",
                        birthstate = "MI",
                        photo = Convert("wwwroot/photo/andre_maguire.png")
                    },
                    new HockeyPlayer
                    {
                    playerid = "meyersd",
                        jersey = 28,
                        fname = "Doug",
                        sname = "Meyers",
                        position = "G",
                        birthday = new DateTime(1998, 2, 11),
                        weight = 70,
                        height = 195,
                        birthcity = "Chicago",
                        birthstate = "IL",
                        photo = Convert("wwwroot/photo/doug_meyers.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "olsens",
                        jersey = 37,
                        fname = "Sandish",
                        sname = "Olsen",
                        position = "D",
                        birthday = new DateTime(1999, 8, 16),
                        weight = 72,
                        height = 192,
                        birthcity = "Stockholm",
                        birthstate = "IL",
                        photo = Convert("wwwroot/photo/sandish_olsen.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "quivep",
                        jersey = 20,
                        fname = "Pierre",
                        sname = "Quive",
                        position = "LW",
                        birthday = new DateTime(1991, 7, 19),
                        weight = 71,
                        height = 197,
                        birthcity = "Quebec",
                        birthstate = "QU",
                        photo = Convert("wwwroot/photo/pierre_quive.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "springej",
                        jersey = 38,
                        fname = "junior",
                        sname = "Springer",
                        position = "C",
                        birthday = new DateTime(1995, 10, 14),
                        weight = 71,
                        height = 184,
                        birthcity = "Toronto",
                        birthstate = "ON",
                        photo = Convert("wwwroot/photo/junior_springer.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "sullivar",
                        jersey = 39,
                        fname = "Russel",
                        sname = "Sullivan",
                        position = "G",
                        birthday = new DateTime(2000, 3, 8),
                        weight = 70,
                        height = 186,
                        birthcity = "Vancouver",
                        birthstate = "BC",
                        photo = Convert("wwwroot/photo/russel_sullivan.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "travisj",
                        jersey = 19,
                        fname = "john",
                        sname = "Travis",
                        position = "C",
                        birthday = new DateTime(2003, 6, 23),
                        weight = 74,
                        height = 200,
                        birthcity = "Boston",
                        birthstate = "MA",
                        photo = Convert("wwwroot/photo/john_travis.jpg")
                    },
                    new HockeyPlayer
                    {
                        playerid = "zauberz",
                        jersey = 22,
                        fname = "Zeke",
                        sname = "Zauber",
                        position = "RW",
                        birthday = new DateTime(1988, 8, 31),
                        weight = 74,
                        height = 203,
                        birthcity = "Moosehead",
                        birthstate = "MA",
                        photo = Convert("wwwroot/photo/zeke_zauber.jpg")
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
