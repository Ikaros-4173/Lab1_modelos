//Original Scripts by IIColour (IIColour_Spectrum)

using UnityEngine;
using System.Collections;

public class PokemonData
{
    private int ID;
    private string name;

    public enum Type
    {
        NONE,
        NORMAL,
        FIGHTING,
        FLYING,
        POISON,
        GROUND,
        ROCK,
        BUG,
        GHOST,
        STEEL,
        FIRE,
        WATER,
        GRASS,
        ELECTRIC,
        PSYCHIC,
        ICE,
        DRAGON,
        DARK,
        FAIRY
    };

    public enum EggGroup
    {
        NONE,
        MONSTER,
        WATER1,
        BUG,
        FLYING,
        FIELD,
        FAIRY,
        GRASS,
        HUMANLIKE,
        WATER3,
        MINERAL,
        AMORPHOUS,
        WATER2,
        DITTO,
        DRAGON,
        UNDISCOVERED
    };

    public enum LevelingRate
    {
        ERRATIC,
        FAST,
        MEDIUMFAST,
        MEDIUMSLOW,
        SLOW,
        FLUCTUATING
    };

    public enum PokedexColor
    {
        RED,
        BLUE,
        YELLOW,
        GREEN,
        BLACK,
        BROWN,
        PURPLE,
        GRAY,
        WHITE,
        PINK
    };

    private Type type1;
    private Type type2;
    private string ability1;
    private string ability2;
    private string hiddenAbility;

    private float maleRatio; //-1f is interpreted as genderless
    private int catchRate;
    private EggGroup eggGroup1;
    private EggGroup eggGroup2;
    private int hatchTime;

    private float height;
    private float weight;

    private int baseExpYield;
    private LevelingRate levelingRate;

    private int evYieldHP;
    private int evYieldATK;
    private int evYieldDEF;
    private int evYieldSPA;
    private int evYieldSPD;
    private int evYieldSPE;

    private PokedexColor pokedexColor;
    private int baseFriendship;

    private string species;
    private string pokedexEntry;

    private int baseStatsHP;
    private int baseStatsATK;
    private int baseStatsDEF;
    private int baseStatsSPA;
    private int baseStatsSPD;
    private int baseStatsSPE;

    private float luminance;
    private Color lightColor;

    //private string[] heldItem;

    private int[] movesetLevels;
    private string[] movesetMoves;

    private string[] tmList;

    private int[] evolutionID;
    private string[] evolutionRequirements;
    private int v1;
    private string v2;
    private Type dRAGON1;
    private Type wATER;
    private string v3;
    private object p1;
    private string v4;
    private object p2;
    private string v5;
    private int v6;
    private int v7;
    private EggGroup wATER1;
    private EggGroup dRAGON2;
    private int v8;
    private float v9;
    private double v10;
    private int v11;
    private LevelingRate sLOW;
    private int v12;
    private int v13;
    private int v14;
    private int v15;
    private int v16;
    private int v17;
    private PokedexColor bLUE;
    private int v18;
    private string v19;
    private string v20;
    private int v21;
    private int v22;
    private int v23;
    private int v24;
    private int v25;
    private int v26;
    private int v27;
    private int v28;
    private Color blue;
    private int[] v29;
    private string[] v30;
    private string[] v31;
    private int[] v32;
    private string[] v33;

    //E.G.	Poliwhirl(61)
    //		new int[]{62,186},
    //		new string[]{"Stone,Water Stone","Trade\Item,King's Rock"}),
    //
    //E.G. to evolve to sylveon
    //		new int[]{..., 700},
    //		new string[]{..., "Amie\Move,2\Fairy"}),
    //
    //
    //Level,int level
    //	if pokemon's level is greater or equal to int level
    //Stone,string itemName
    //	if name of stone is equal to string itemName
    //Trade
    //	if currently trading pokemon
    //Friendship
    //	if pokemon's friendship is greater or equal to 220
    //Item,string itemName
    //	if pokemon's heldItem is equal to string itemName
    //Gender,Pokemon.Gender
    //  if pokemon's gender is equal to Pokemon.Gender
    //Move,string moveName
    //	if pokemon has a move thats name or typing is equal to string moveName
    //Map,string mapName
    //  if currentMap is equal to string mapName
    //Time,string dayNight
    //	if time is between 9PM and 4AM time is "Night". else time is "Day".
    //	if time is equal to string dayNight (either Day, or Night)
    //
    //		Unique evolution methods:
    //Mantine
    //	if party contains a Remoraid
    //Pangoro
    //	if party contains a dark pokemon
    //Goodra
    //	if currentMap's weather is rain
    //Hitmonlee
    //	if pokemon's ATK is greater than DEF
    //Hitmonchan
    //	if pokemon's ATK is lower than DEF
    //Hitmontop
    //  if pokemon's ATK is equal to DEF
    //Silcoon
    //  if pokemon's shinyValue divided by 2's remainder is equal to 0
    //Cascoon
    //	if pokemon's shinyValue divided by 2's remainder is equal to 1


    public PokemonData(int ID, string name, Type type1, Type type2, string ability1, string ability2,
        string hiddenAbility,
        float maleRatio, int catchRate, EggGroup eggGroup1, EggGroup eggGroup2, int hatchTime,
        float height, float weight, int baseExpYield, LevelingRate levelingRate,
        int evYieldHP, int evYieldATK, int evYieldDEF, int evYieldSPA, int evYieldSPD, int evYieldSPE,
        PokedexColor pokedexColor, int baseFriendship,
        string species, string pokedexEntry,
        int baseStatsHP, int baseStatsATK, int baseStatsDEF, int baseStatsSPA, int baseStatsSPD, int baseStatsSPE,
        float luminance, Color lightColor, //string[] heldItem,
        int[] movesetLevels, string[] movesetMoves, string[] tmList,
        int[] evolutionID, string[] evolutionRequirements)
    {
        this.ID = ID;
        this.name = name;
        this.type1 = type1;
        this.type2 = type2;
        this.ability1 = ability1;
        this.ability2 = ability2;
        this.hiddenAbility = hiddenAbility;

        this.maleRatio = maleRatio;
        this.catchRate = catchRate;
        this.eggGroup1 = eggGroup1;
        this.eggGroup2 = eggGroup2;
        this.hatchTime = hatchTime;

        this.height = height;
        this.weight = weight;
        this.baseExpYield = baseExpYield;
        this.levelingRate = levelingRate;

        this.evYieldHP = evYieldHP;
        this.evYieldATK = evYieldATK;
        this.evYieldDEF = evYieldDEF;
        this.evYieldSPA = evYieldSPA;
        this.evYieldSPD = evYieldSPD;
        this.evYieldSPE = evYieldSPE;

        this.pokedexColor = pokedexColor;
        this.baseFriendship = baseFriendship;

        this.species = species;
        this.pokedexEntry = pokedexEntry;

        this.baseStatsHP = baseStatsHP;
        this.baseStatsATK = baseStatsATK;
        this.baseStatsDEF = baseStatsDEF;
        this.baseStatsSPA = baseStatsSPA;
        this.baseStatsSPD = baseStatsSPD;
        this.baseStatsSPE = baseStatsSPE;

        this.luminance = luminance;
        this.lightColor = lightColor;

        //wild pokemon held items not yet implemented
        //this.heldItem = heldItem;

        this.movesetLevels = movesetLevels;
        this.movesetMoves = movesetMoves;
        this.tmList = tmList;

        this.evolutionID = evolutionID;
        this.evolutionRequirements = evolutionRequirements;
    }

    public PokemonData(int v1, string v2, Type dRAGON1, Type wATER, string v3, object p1, string v4, object p2, string v5, int v6, int v7, EggGroup wATER1, EggGroup dRAGON2, int v8, float v9, double v10, int v11, LevelingRate sLOW, int v12, int v13, int v14, int v15, int v16, int v17, PokedexColor bLUE, int v18, string v19, string v20, int v21, int v22, int v23, int v24, int v25, int v26, int v27, int v28, Color blue, int[] v29, string[] v30, string[] v31, int[] v32, string[] v33)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.dRAGON1 = dRAGON1;
        this.wATER = wATER;
        this.v3 = v3;
        this.p1 = p1;
        this.v4 = v4;
        this.p2 = p2;
        this.v5 = v5;
        this.v6 = v6;
        this.v7 = v7;
        this.wATER1 = wATER1;
        this.dRAGON2 = dRAGON2;
        this.v8 = v8;
        this.v9 = v9;
        this.v10 = v10;
        this.v11 = v11;
        this.sLOW = sLOW;
        this.v12 = v12;
        this.v13 = v13;
        this.v14 = v14;
        this.v15 = v15;
        this.v16 = v16;
        this.v17 = v17;
        this.bLUE = bLUE;
        this.v18 = v18;
        this.v19 = v19;
        this.v20 = v20;
        this.v21 = v21;
        this.v22 = v22;
        this.v23 = v23;
        this.v24 = v24;
        this.v25 = v25;
        this.v26 = v26;
        this.v27 = v27;
        this.v28 = v28;
        this.blue = blue;
        this.v29 = v29;
        this.v30 = v30;
        this.v31 = v31;
        this.v32 = v32;
        this.v33 = v33;
    }

    public override string ToString()
    {
        string result = ID.ToString() + ", " + name + ", " + type1.ToString() + ", ";
        result += type2.ToString() + ", ";
        result += ability1 + ", ";
        if (ability2 != null)
        {
            result += ability2 + ", ";
        }
        result += hiddenAbility + ", ";
        return result;
    }

    public int getID()
    {
        return ID;
    }

    public string getName()
    {
        return name;
    }

    public float getMaleRatio()
    {
        return maleRatio;
    }

    public PokemonData.Type getType1()
    {
        return type1;
    }

    public PokemonData.Type getType2()
    {
        return type2;
    }

    public string getAbility(int ability)
    {
        if (ability == 0)
        {
            return ability1;
        }
        else if (ability == 1)
        {
            if (ability2 == null)
            {
                return ability1;
            }
            return ability2;
        }
        else if (ability == 2)
        {
            if (hiddenAbility == null)
            {
                return ability1;
            }
            return hiddenAbility;
        }
        return null;
    }

    public int getBaseFriendship()
    {
        return baseFriendship;
    }

    public int getBaseExpYield()
    {
        return baseExpYield;
    }

    public int[] getBaseStats()
    {
        return new int[] {baseStatsHP, baseStatsATK, baseStatsDEF, baseStatsSPA, baseStatsSPD, baseStatsSPE};
    }

    public bool hasLight()
    {
        if (luminance > 0)
        {
            return true;
        }
        return false;
    }

    public float getLuminance()
    {
        return luminance;
    }

    public Color getLightColor()
    {
        return lightColor;
    }

    public int[] getMovesetLevels()
    {
        return movesetLevels;
    }

    public string[] getMovesetMoves()
    {
        return movesetMoves;
    }

    public string[] getTmList()
    {
        return tmList;
    }

    public int[] getEvolutions()
    {
        return evolutionID;
    }

    public string[] getEvolutionRequirements()
    {
        return evolutionRequirements;
    }

    public PokemonData.LevelingRate getLevelingRate()
    {
        return levelingRate;
    }

    public int getCatchRate()
    {
        return catchRate;
    }

    public string[] GenerateMoveset(int level)
    {
        //Set moveset based off of the highest level moves possible.
        string[] moveset = new string[4];
        int i = movesetLevels.Length - 1; //work backwards so that the highest level move possible is grabbed first
        while (moveset[3] == null)
        {
            if (movesetLevels[i] <= level)
            {
                moveset[3] = movesetMoves[i];
            }
            i -= 1;
        }
        if (i >= 0)
        {
            //if i is at least 0 still, then you can grab the next move down.
            moveset[2] = movesetMoves[i];
            i -= 1;
            if (i >= 0)
            {
                //if i is at least 0 still, then you can grab the next move down.
                moveset[1] = movesetMoves[i];
                i -= 1;
                if (i >= 0)
                {
                    //if i is at least 0 still, then you can grab the last move down.
                    moveset[0] = movesetMoves[i];
                    i -= 1;
                }
            }
        }
        i = 0;
        int i2 = 0; //if the first move is null, then the array will need to be packed down
        if (moveset[0] == null)
        {
            //(nulls moved to the end of the array)
            while (i < 3)
            {
                while (moveset[i] == null)
                {
                    i += 1;
                }
                moveset[i2] = moveset[i];
                moveset[i] = null;
                i2 += 1;
            }
        }
        return moveset;
    }
}