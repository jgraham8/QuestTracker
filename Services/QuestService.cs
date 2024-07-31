namespace QuestTracker.Services;
public class QuestService
{
    #region Shoreline
    public List<Quest> GetShorelineQuests()
    {
        return new List<Quest>
        {
            new()
            {
                Name = "Anaesthesia",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Anesthesia",
                Locations = new List<QuestLocation>()
                {
                    new(250, 320, 0),
                    new(488, 212, 0),
                    new(520, 580, 0),
                }
            },
            new()
            {
                Name = "Signal Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(635, 429, 0),
                    new(460, 200, 0),
                }

            },
            new()
            {
                Name = "Signal Part 3",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(635, 429, 0),
                    new(460, 200, 0),
                    new(780, 325, 0),
                }

            },
            new()
            {
                Name = "Chemistry Closet",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(525, 210, 0),
                }

            },
            new()
            {
                Name = "Courtesy Visit",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(80, 180, 0),
                    new(50, 240, 0),
                    new(125, 240, 0),
                }

            },
            new()
            {
                Name = "Nostalgia",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(440, 210, 0),
                }

            },
            new()
            {
                Name = "Health Care Privacy Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Health_Care_Privacy_-_Part_1",
                Locations = new List<QuestLocation>()
                {
                    new(90, 450, 0),
                    new(120, 455, 0),
                    new(485, 225, 0)
                }

            },
            new()
            {
                Name = "Health Care Privacy Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Health_Care_Privacy_-_Part_2",
                Locations = new List<QuestLocation>()
                {
                    new(455, 210, 0),
                }

            },
            new()
            {
                Name = "Colleagues Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Colleagues_-_Part_1",
                Locations = new List<QuestLocation>()
                {
                    new(485, 225, 0),
                    new(520, 580, 0),
                    new(250, 320, 0),
                }

            },
            new()
            {
                Name = "Colleagues Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Colleagues_-_Part_2",
                Locations = new List<QuestLocation>()
                {
                    new(250, 320, 0),
                    new(520, 580, 0),
                }

            },
            new()
            {
                Name = "Vitamins Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Vitamins_-_Part_1",
                Locations = new List<QuestLocation>()
                {
                    new(415, 210, 0),
                }

            },
            new()
            {
                Name = "Lend-Lease Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Lend-Lease_-_Part_1",
                Locations = new List<QuestLocation>()
                {
                    new(540, 210, 0),
                    new(810, 370, 0),
                    new(440, 210, 0),
                }

            },
            new()
            {
                Name = "Rigged Game",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Rigged_Game",
                Locations = new List<QuestLocation>()
                {
                    new(250, 320, 0),
                    new(488, 212, 0),
                    new(520, 580, 0)
                }

            },
            new()
            {
                Name = "Fishing Gear",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(435, 547, 0)
                }

            },
            new()
            {
                Name = "Scrap Metal",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(60, 360, 0),
                    new(550, 370, 0),
                    new(410, 80, 0),
                }

            },
            new()
            {
                Name = "Eagle Eye",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(360, 60, 0),
                    new(800, 400, 0),
                }

            },
            new()
            {
                Name = "Humanitarian Supplies",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(730, 570, 0),
                    new(460, 180, 0),
                }

            },
            new()
            {
                Name = "The Cult Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(150, 190, 0),
                    new(125, 235, 0),
                }

            },
            new()
            {
                Name = "The Cult Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(540, 210, 0)
                }

            },
            new()
            {
                Name = "Spa Tour Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(483, 238, 0),
                    new(503, 238, 0),
                }

            },
            new()
            {
                Name = "Spa Tour Part 4",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(420, 210, 0)
                }

            },
            new()
            {
                Name = "Spa Tour Part 5",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(415, 70, 0)
                }

            },
            new()
            {
                Name = "Cargo X Part 1",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(540, 210, 0)
                }
            },
            new()
            {
                Name = "Cargo X Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(540, 210, 0)
                }

            },
            new()
            {
                Name = "Cargo X Part 3",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(430, 210, 0)
                }

            },
            new()
            {
                Name = "Wet Job Part 2",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(160, 540, 0)
                }

            },
            new()
            {
                Name = "Wet Job Part 3",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(245, 472, 0)
                }

            },
            new()
            {
                Name = "Wet Job Part 4",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Fishing_Gear",
                Locations = new List<QuestLocation>()
                {
                    new(483, 186, 0)
                }

            },
            new()
            {
                Name = "Wet Job Part 5",
                WikiURL = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_5",
                Locations = new List<QuestLocation>()
                {
                    new(540, 210, 0)
                }

            },
            new()
            {
                Name = "Out Of Time",
                Locations = new List<QuestLocation>()
                {
                    new(470, 375, 0)
                }

            },
        };
    }

    public List<ExtractLocation> GetShorelineExtracts()
    {
        return new List<ExtractLocation>
        {
            new(100, 100, "Lighthouse"),
            new(60, 455, "Tunnel"),
            new(877, 277, "Customs"),
            new(970, 462, "Bridge")
        };
    }

    public List<SpawnLocation> GetShorelineSpawns()
    {
        return new List<SpawnLocation>
        {
            new(600, 80, "North"),
            new(120,120, "North West"),
            new(880, 350, "East"),
            new(775, 570, "South"),
            new(80, 350, "West")
        };
    }
    #endregion

    #region Customs
    public List<Quest> GetCustomsQuests()
    {
        var threestory = new QuestLocation(485, 510, 0);
        var twostory = new QuestLocation(435, 490, 0);

        var chemwarehouse = new QuestLocation(195, 250, 0);

        var bigred = new QuestLocation(860, 180, 0);

        return new List<Quest>()
        {
            new()
            {
                Name = "Checking",
                Locations = new List<QuestLocation>()
                {
                    new(559, 307, 0),
                }
            },        
            new()
            {
                Name = "BP Depot",
                Locations = new List<QuestLocation>()
                {
                    new(975, 133, 0),
                    new(559, 307, 0),
                    new(335, 97, 0),
                    new(243, 344, 0)
                }
            },
            new()
            {
                Name = "Bad Rep Evidence",
                Locations = new List<QuestLocation>()
                {
                    new(460, 335, 0)
                }
            },
            new()
            {
                Name = "Shaking Up The Teller",
                Locations = new List<QuestLocation>()
                {
                    threestory,
                }
            },
            new()
            {
                Name = "The Extortionist",
                Locations = new List<QuestLocation>()
                {
                    new(300, 265, 0),
                }
            },
            new()
            {
                Name = "Golden Swag",
                Locations = new List<QuestLocation>()
                {
                    threestory,
                    new(840, 77, 0),
                }
            },
            new()
            {
                Name = "Chemical Part 1",
                Locations = new List<QuestLocation>()
                {
                    new(175, 160, 0),
                }
            },
            new()
            {
                Name = "Chemical Part 2",
                Locations = new List<QuestLocation>()
                {
                    threestory,
                }
            },
            new()
            {
                Name = "Big Customer",
                Locations = new List<QuestLocation>()
                {
                    chemwarehouse,
                }
            },
            new()
            {
                Name = "Chemical Part 4",
                Locations = new List<QuestLocation>()
                {
                   chemwarehouse,
                }
            },
            new()
            {
                Name = "Out Of Curiosity",
                Locations = new List<QuestLocation>()
                {
                   chemwarehouse,
                }
            },
            new()
            {
                Name = "Operation Aquarius Part 1",
                Locations = new List<QuestLocation>()
                {
                    twostory,
                }
            },
            new()
            {
                Name = "Pharmacist",
                Locations = new List<QuestLocation>()
                {
                    twostory,
                }
            },
            new()
            {
                Name = "Informed Means Armed",
                Locations = new List<QuestLocation>()
                {
                    new(635, 440, 0),
                }
            },
            new()
            {
                Name = "Chumming",
                Locations = new List<QuestLocation>()
                {
                    threestory,
                }
            },
            new()
            {
                Name = "Tigr Safari",
                Locations = new List<QuestLocation>()
                {
                    new(110, 293, 0),
                    new(175, 310, 0),
                    new(640, 325, 0),
                }
            },
            new()
            {
                Name = "The Cult Part 2",
                Locations = new List<QuestLocation>()
                {
                    threestory,
                }
            },
            new()
            {
                Name = "Delivery From The Past",
                Locations = new List<QuestLocation>()
                {
                    bigred,
                }
            },
            new()
            {
                Name = "The Courier",
                Locations = new List<QuestLocation>()
                {
                    new(495, 190, 0),
                    new(245, 360, 0),
                }
            },
            new()
            {
                Name = "Bullshit",
                Locations = new List<QuestLocation>()
                {
                    new(760, 335, 0),
                    threestory,
                }
            },
            new()
            {
                Name = "Out Of Time",
                Locations = new List<QuestLocation>()
                {
                    new(465, 170, 0),
                }
            },
        };
    }

    public List<ExtractLocation> GetCustomsExtracts()
    {
        return new List<ExtractLocation>
        {
            new(663, 150, "RUAF"),
            new(60, 160, "ZB-11"),
            new(950, 250, "Crossroads"),
            new(950, 70, "Trailer Park")
        };
    }

    public List<SpawnLocation> GetCustomsSpawns()
    {
        return new List<SpawnLocation>
        {
            new(170, 175, "North"),
            new(950, 150, "East"),
            new(250, 500, "South")
        };
    }
    #endregion

    #region Woods
    public List<Quest> GetWoodsQuests()
    {
        var cabins = new QuestLocation(468, 385, 0);
        var useccamp = new QuestLocation(275, 225, 0);
        return new List<Quest>
        {
            new()
            {
                Name = "Introduction",
                Locations = new List<QuestLocation>()
                {
                    new(640, 405, 0),
                }
            },
            new()
            {
                Name = "Search Mission",
                Locations = new List<QuestLocation>()
                {
                    new(330, 160, 0),
                    useccamp,
                }
            },
            new()
            {
                Name = "Supply Plans",
                Locations = new List<QuestLocation>()
                {
                    cabins,
                }
            },
            new()
            {
                Name = "Health Care Privacy Part 2",
                Locations = new List<QuestLocation>()
                {
                    new(535, 515, 0),
                }
            },
            new()
            {
                Name = "Informed Means Armed",
                Locations = new List<QuestLocation>()
                {
                    new(445, 450, 0),
                }
            },
            new()
            {
                Name = "Chumming",
                Locations = new List<QuestLocation>()
                {
                    cabins,
                }
            },
            new()
            {
                Name = "Lend Lease Part 1",
                Locations = new List<QuestLocation>()
                {
                    new(300, 390, 0),
                    new(430, 395, 0),
                }
            },
            new()
            {
                Name = "The Cult Part 2",
                Locations = new List<QuestLocation>()
                {
                    new(315, 415, 0),
                    new(540, 100, 0),
                }
            },
            new()
            {
                Name = "Assessment Part 2",
                Locations = new List<QuestLocation>()
                {
                    new(580, 315, 0),
                    new(560, 295, 0),
                    new(160, 445, 0),
                    new(265, 190, 0),

                }
            },
            new()
            {
                Name = "Gratitude",
                Locations = new List<QuestLocation>()
                {
                    new(450, 460, 0),
                }
            },
            new()
            {
                Name = "The Blood Of War Part 3",
                Locations = new List<QuestLocation>()
                {
                    new(220, 380, 0),
                    new(685, 430, 0),
                    new(610, 325, 0),
                }
            },
            new()
            {
                Name = "The Survivalist Path - Thrifty",
                Locations = new List<QuestLocation>()
                {
                    new(740, 425, 0),
                    new(160, 445, 0),
                }
            },
            new()
            {
                Name = "Return The Favour",
                Locations = new List<QuestLocation>()
                {
                    new(265, 190, 0),
                    useccamp,
                }
            },
        };
    }

    public List<SpawnLocation> GetWoodsSpawns()
    {
        return new List<SpawnLocation>
        {
            new(330, 120, "North West"),
            new(800, 290, "North East"),
            new(200, 470, "South West"),
            new(700, 500, "South East")
        };
    }

    public List<ExtractLocation> GetWoodsExtracts()
    {
        return new List<ExtractLocation>
        {
            new(230, 570, "Outskirts"),
            new(830, 545, "UN RB"),
            new(850, 390, "North UN RB"),
        };
    }
    #endregion

    #region Lighthouse
    public List<Quest> GetLighthouseQuests()
    {
        var maingate = new QuestLocation(395, 340, 0);

        var building1 = new QuestLocation(300, 350, 0);
        var building2 = new QuestLocation(240, 265, 0);
        var building3 = new QuestLocation(280, 215, 0);

        var heli = new QuestLocation(340, 270, 0);

        var sunken = new QuestLocation(780, 400, 0);

        var chalet = new QuestLocation(680, 250, 0);

        var radar = new QuestLocation(920, 525, 0);

        var pier = new QuestLocation(560, 400, 0);

        var court = new QuestLocation(700, 275, 0);

        return new List<Quest>
        {
            new()
            {
                Name = "Snatch",
                Locations = new List<QuestLocation>()
                {
                    maingate,
                }
            },
            new()
            {
                Name = "Out Of Time",
                Locations = new List<QuestLocation>()
                {
                    building1,
                    building2,
                    building3,
                }
            },
            new()
            {
                Name = "Energy Crisis",
                Locations = new List<QuestLocation>()
                {
                    new(405, 350, 0),
                    new(145, 260, 0),
                    new(160, 280, 0),
                    new(315, 235, 0)
                }
            },
            new()
            {
                Name = "Corporate Secrets",
                Locations = new List<QuestLocation>()
                {
                    building1,
                    building2,
                }
            },
            new()
            {
                Name = "Network Provider Part 2",
                Locations = new List<QuestLocation>()
                {
                    heli,
                    chalet,
                    sunken,
                    new(840, 365, 0),
                }
            },
            new()
            {
                Name = "Key To The Tower",
                Locations = new List<QuestLocation>()
                {
                    sunken
                }
            },
            new()
            {
                Name = "Knock Knock",
                Locations = new List<QuestLocation>()
                {
                    new(905, 400, 0),
                }
            },
            new()
            {
                Name = "Cargo X Part 4",
                Locations = new List<QuestLocation>()
                {
                    new(660, 400, 0),
                }
            },
            new()
            {
                Name = "Revision",
                Locations = new List<QuestLocation>()
                {
                    new(260, 290, 0),
                    new(360, 330, 0),
                    new(645, 300, 0),
                    new(900, 365, 0),
                }
            },
            new()
            {
                Name = "Missing Cargo",
                Locations = new List<QuestLocation>()
                {
                    chalet,
                    new(780, 250, 0),
                }
            },
            new()
            {
                Name = "Top Secret",
                Locations = new List<QuestLocation>()
                {
                    radar,
                }
            },
            new()
            {
                Name = "Seaside Vacation",
                Locations = new List<QuestLocation>()
                {
                    pier,
                }
            },
            new()
            {
                Name = "Lost Contact",
                Locations = new List<QuestLocation>()
                {
                    court,
                }
            },
            new()
            {
                Name = "Drug Trafficking",
                Locations = new List<QuestLocation>()
                {
                    new(185, 255, 0),
                }
            },
            new()
            {
                Name = "Easy Job",
                Locations = new List<QuestLocation>()
                {
                    heli,
                }
            },
            new()
            {
                Name = "Reconnaissance",
                Locations = new List<QuestLocation>()
                {
                    building1,
                    building2,
                    building3,
                }
            }
        };
    }

    public List<SpawnLocation> GetLighthouseSpawns()
    {
        return new List<SpawnLocation>
        {
            new(450, 75, "North East"),
            new(600, 240, "Middle"),
            new(820, 330, "South"),
        };
    }

    public List<ExtractLocation> GetLighthouseExtracts()
    {
        return new List<ExtractLocation>
        {
            new(850, 150, "Southern Road"),
            new(115, 395, "Northern Checkpoint"),
            new(560, 120, "Path To Shoreline"),
        };
    }
    #endregion

    #region Streets
    public List<Quest> GetStreetsQuests()
    {
        var postoffice = new QuestLocation(515, 275, 0);
        var apartments = new QuestLocation(455, 350, 0);
        return new List<Quest>
        {
            new()
            {
                Name = "You've Got Mail",
                Locations = new List<QuestLocation>()
                {
                    postoffice,
                }
            },
            new()
            {
                Name = "Glory to the CPSU Part 1",
                Locations = new List<QuestLocation>()
                {
                    apartments,
                }
            },
            new()
            {
                Name = "Glory to the CPSU Part 2",
                Locations = new List<QuestLocation>()
                {
                    new(350, 220, 0),
                }
            },
            new()
            {
                Name = "Convoy",
                Locations = new List<QuestLocation>()
                {
                    new(500, 380, 0),
                    new(550, 340, 0),
                }
            },
            new()
            {
                Name = "Population Census",
                Locations = new List<QuestLocation>()
                {
                    new(485, 280, 0),
                }
            },
            new()
            {
                Name = "Urban Medicine",
                Locations = new List<QuestLocation>()
                {
                    new(475, 415, 0),
                }
            },
            new()
            {
                Name = "Pets Won't Need It",
                Locations = new List<QuestLocation>()
                {
                    new(370, 310, 0),
                }
            },
            new()
            {
                Name = "House Arrest Part 1",
                Locations = new List<QuestLocation>()
                {
                    apartments,
                }
            },
            new()
            {
                Name = "House Arrest Part 2",
                Locations = new List<QuestLocation>()
                {
                    apartments,
                }
            },
            new()
            {
                Name = "Debtor",
                Locations = new List<QuestLocation>()
                {
                    new(610, 230, 0),
                }
            },
            new()
            {
                Name = "Beyond The Red Meat Part 1",
                Locations = new List<QuestLocation>()
                {
                    new(580, 150, 0),
                }
            },
            new()
            {
                Name = "Beyond The Red Meat Part 2",
                Locations = new List<QuestLocation>()
                {
                    new(510, 130, 0),
                    new(575, 100, 0),
                }
            },
        };
    }

    public List<SpawnLocation> GetStreetsSpawns()
    {
        return new List<SpawnLocation>
        {
            new(400, 180, "Residential"),
            new(600, 180, "Pinewood"),
            new(400, 450, "Concordia"),
            new(600, 475, "Cinema"),
        };
    }

    public List<ExtractLocation> GetStreetsExtracts()
    {
        return new List<ExtractLocation>
        {
            new(380, 400, "Crane"),
            new(310, 480, "Crash Site"),
            new(680, 550, "Courtyard"),
            new(750, 445, "Damaged House"),
            new(740, 340, "Sewer River"),
            new(625, 150, "Elevator"),
            new(375, 110, "Expo Checkpoint"),
            new(475, 50, "Apt Complex"),
        };
    }
    #endregion
}
