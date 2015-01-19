using UnityEngine;
using System.Collections;
using System.IO;
using AssemblyCSharp;
using System;
using Enums;
using AssemblyCSharp.Assets.cls.board.pupi;
using AssemblyCSharp.Assets.cls.board.Squares;

public class MapLoader
{

    public int[,] MapArray;
    public BlockArrayDelegate[,] DArray;
    public  PUPIArrayDelegate[,] DA2;
    public delegate Square BlockArrayDelegate(int code);
    public delegate PUPI PUPIArrayDelegate(int code);
    public void Setup()
    {
        InitDArray();
    }
    public void LoadLogicalLevel()
    {
        TextAsset asset = (TextAsset)Resources.Load("ANZULABY");

        Stream s = new MemoryStream(asset.bytes);


        BinaryReader sr = new BinaryReader(s);
        int c = 0;
        long l = 0;

        int row = 0;
        int column = 0;


        while (l < sr.BaseStream.Length)
        {
            if (row > GameController.MaxYInt)
            {
                break; // TODO: might not be correct. Was : Exit While
            }
            try
            {
                c = sr.ReadByte();
            }
            catch (Exception ex)
            {
				if (StaticVars.EnableLog) {
                Debug.Log("error");
				}
            }

            l = l + 1;
            if (c == 10)
            {
                continue;
            }
            if (c == 13)
            {
                row = row + 1;
                column = 0;
                continue;
            }
            if (column == 0)
            {
				if (StaticVars.EnableLog) {
                Debug.Log("gotcha");
				}

            }
            Router(c, column, row);

            column = column + 1;


        }
		if (StaticVars.EnableLog) {
						Debug.Log ("road1");
				}
    }
    public void Router(int c, int column, int row)
    {
        switch (c)
        {
            case 172:
            case 173:
            case 174:
            case 48:
            case 49:
            case 50:
            case 51:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            case 57:
            case 65:
            case 67:
            case 68:
            case 69:
            case 70:
            case 155:
            case 112:
            case 113:
            case 111:
            case 108:
            case 180:
                BuildBoard(c, column, row);
                break;
            case 66:
            case 164:
                //передвигаемый объект
                BuildBoard(48, column, row);
                //BuildTrackItem(c, column, row);
                break;
            default:
                BuildBoard(48, column, row);
                BuildPUPI(c, column, row);
                break;
        }
    }
    public void BuildBoard(int c, int column, int row)
    {
        try
        {
			if (StaticVars.EnableLog) {
            Debug.Log("found: " + c.ToString() + " at " + column.ToString() + "." + row.ToString());
			}
            GameController.board[column, row] = DArray[1, c](c);


        }
        catch (Exception ex)
        {
			if (StaticVars.EnableLog) {
            Debug.Log("block:" + ex.Message);
			}
        }

    }
    public  void BuildPUPI(int c, int column, int row)
    {
        try
        {
            GameController.PickupLayer[column, row] = DA2[1, c](c);
            if (GameController.PickupLayer[column, row] is Teleport)
            {
                //TeleportLayer.Add(PickupLayer(column, row));
            }
        }
        catch (Exception ex)
        {
            if (StaticVars.EnableLog)
            {
                Debug.Log("block:" + ex.Message);
            }
        }


    }
    public Square Ground(int code)
    {
        return new Square() { Code = code.ToString() };
    }
    public Square Beton(int code)
    {
        return new Square(new Beton()) { Code = code.ToString() };
    }
    public Square Sand(int code)
    {
        switch (code)
        {
            case 50:
                return new Square(new Sand());
            case 51:
                return new Square(new Sand2());
            case 52:
                return new Square(new Sand3());
        }
        return null;
    }
    public Square Brick(int code)
    {
        switch (code)
        {
            case 172:
                return new Square(new Brick());
            case 173:
                return new Square(new Brick(1));
            case 174:
                return new Square(new Brick(2));
        }
        return null;
    }
    public Square Cell(int code)
    {
        return new Square(new Cell());
    }
    public Square Rock(int code)
    {
        switch (code)
        {
            case 53:
                return new Square(new Rock9());
            case 54:
                return new Square(new Rock10());
            case 55:
                return new Square(new Rock());
            case 56:
                return new Square(new Rock2());
            case 57:
                return new Square(new Rock3());
            case 65:
                return new Square(new Rock4());
            case 67:
                return new Square(new Rock5());
            case 68:
                return new Square(new Rock6());
            case 69:
                //(Rock3)
                return new Square(new Rock7());
            case 70:
                return new Square(new Rock8());
            case 112:
                return new Square(new Rock11());
            case 113:
                return new Square(new Rock12());
        }
        return new Square(new Rock());
    }
    public Square BioSlime(int code)
    {
        return new Square(new BioSlime());
    }
    public Square CellKey(int code)
    {
        return new Square(new CellKey());
    }
    public Square PU(int code)
    {
        return new Square(new PU());
    }

    public static Square C4(int code)
    {
        return new Square(new C4());
    }
    public static PUPI RockDrill(int code)
    {
        return new RockDrill();
    }
    public static PUPI Axe(int code)
    {
        return new Axe();
    }
    public static PUPI AxeBig(int code)
    {
        return new AxeBig();
    }

    public static PUPI Teleport(int code)
    {
        return new Teleport();
    }
    public static PUPI ArmorBox(int code)
    {
        return new ArmorBox();
    }
    public static PUPI Medkit(int code)
    {
        return new MedKit();
    }
    public static PUPI GoldebBar(int code)
    {
        return new GoldenBar();
    }
    public static PUPI GoldenEgg(int code)
    {
        return new GoldenEgg();
    }
    public static PUPI AncientShield(int code)
    {
        return new AncientShield();
    }
    public static PUPI Sceptre(int code)
    {
        return new Sceptre();
    }
    public static PUPI BrassBraclet(int code)
    {
        return new BrassBraclet();
    }
    public static PUPI PileOfCoins(int code)
    {
        return new PileOfCoins();
    }
    public static PUPI GoldenCross(int code)
    {
        return new GoldenCross();
    }
    public static PUPI Crown(int code)
    {
        return new Crown();
    }
    public static PUPI Rubin(int code)
    {
        return new Rubin();
    }


    public void InitDArray()
    {
        DArray = new BlockArrayDelegate[2, 257];

        DArray[1, 172] = new BlockArrayDelegate(Brick);
        DArray[1, 173] = new BlockArrayDelegate(Brick);
        DArray[1, 174] = new BlockArrayDelegate(Brick);
        DArray[1, 49] = new BlockArrayDelegate(Beton);
        DArray[1, 48] = new BlockArrayDelegate(Ground);
        DArray[1, 50] = new BlockArrayDelegate(Sand);
        DArray[1, 51] = new BlockArrayDelegate(Sand);
        DArray[1, 52] = new BlockArrayDelegate(Sand);
        DArray[1, 55] = new BlockArrayDelegate( Rock);
        DArray[1, 54] = new BlockArrayDelegate(Rock);
        DArray[1, 53] = new BlockArrayDelegate(Rock);
        DArray[1, 56] = new BlockArrayDelegate(Rock);
        DArray[1, 57] = new BlockArrayDelegate(Rock);
        DArray[1, 65] = new BlockArrayDelegate(Rock);
        DArray[1, 67] = new BlockArrayDelegate(Rock);
        DArray[1, 68] = new BlockArrayDelegate(Rock);
        DArray[1, 69] = new BlockArrayDelegate(Rock);
        DArray[1, 70] = new BlockArrayDelegate(Rock);

        DArray[1, 112] = new BlockArrayDelegate(Rock);
        DArray[1, 113] = new BlockArrayDelegate(Rock);
        	DArray[1, 155] = new BlockArrayDelegate(PU);
		DArray[1, 111] = new BlockArrayDelegate(BioSlime);
        DArray[1, 108] = new BlockArrayDelegate(Cell);
        DArray[1, 180] = new BlockArrayDelegate(CellKey);
         DA2 = new PUPIArrayDelegate[2, 257];
         DA2[1, 152] = new PUPIArrayDelegate(Sceptre);
         DA2[1, 149] = new PUPIArrayDelegate(BrassBraclet);
         DA2[1, 148] = new PUPIArrayDelegate(PileOfCoins);
         DA2[1, 151] = new PUPIArrayDelegate(GoldenCross);
         DA2[1, 154] = new PUPIArrayDelegate(Crown);
         DA2[1, 153] = new PUPIArrayDelegate(Rubin);
         DA2[1, 146] = new PUPIArrayDelegate(AncientShield);
         DA2[1, 147] = new PUPIArrayDelegate(GoldenEgg);
         DA2[1, 150] = new PUPIArrayDelegate(GoldebBar);
         DA2[1, 109] = new PUPIArrayDelegate(Medkit);
         DA2[1, 121] = new PUPIArrayDelegate(ArmorBox);
         DA2[1, 156] = new PUPIArrayDelegate(Teleport);
         DA2[1, 143] = new PUPIArrayDelegate(Axe);
         DA2[1, 144] = new PUPIArrayDelegate(AxeBig);
         DA2[1, 145] = new PUPIArrayDelegate(RockDrill);
    }


    public void LoadVisualLevel()
    {
       GameObject prefab = (GameObject)Resources.Load ("Prefabs/Square");
       GameObject prefabpupi = (GameObject)Resources.Load("Prefabs/Pupi");

        for (int i = 0; i <= GameController.MaxX; i += 10)
        {

            for (int y = 0; y <= GameController.MaxY; y += 10)
            {

                if ((GameController.board[i / 10, y / 10] != null))
                {
                    Vector3 v3 = new Vector3();


                    v3.x =(float) i / 100;
                    v3.y = (float)-y / 100;
                    v3.z = 0;

                    GameController.board[i / 10, y / 10].Prefab = (GameObject)MonoBehaviour.Instantiate(prefab, v3, Quaternion.identity);

                    GameController.board[i / 10, y / 10].Update();
                    if (GameController.board[i / 10, y / 10].Current is Ground)
                    {
                        GameController.board[i / 10, y / 10].PreUpdateDecals(WhoIs.Ground);
                    }
                }
                //заполняем pickuplayer
                if ((GameController.PickupLayer[i / 10, y / 10] != null))
                {
                    Vector3 v3 = new Vector3();


                    v3.x = (float)i / 100;
                    v3.y = (float)-y / 100;

                    v3.z = -1;


                    GameController.PickupLayer[i / 10, y / 10].Prefab = (GameObject)MonoBehaviour.Instantiate(prefabpupi, v3, Quaternion.identity);
                   GameController.PickupLayer[i / 10, y / 10].Update();
             
                }

            }

        }

        //устанавливаем декорации у земли и pupi(так как под pupi всегда земля, то в одном блоке все происходит.

        
            //for (int i = 0; i <= GameController.MaxX; i += 10)
            //{

            //    for (int y = 0; y <= GameController.MaxY; y += 10)
            //    {

            //        if ((GameController.board[i / 10, y / 10] != null))
            //        {
                        
            //        }


            //    }

            //}
        

    }

}
