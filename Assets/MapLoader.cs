using UnityEngine;
using System.Collections;
using System.IO;
using AssemblyCSharp;
using System;

public class MapLoader
{

    public int[,] MapArray;
    public BlockD[,] DArray;
    //public static PUPID[,] DA2;
    public delegate Square BlockD(int code);
    //public delegate IBody PUPID(int code);
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
                //BuildPUPI(c, column, row);
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
    public void InitDArray()
    {
        DArray = new BlockD[2, 257];

        DArray[1, 172] = new BlockD(Brick);
        DArray[1, 173] = new BlockD(Brick);
        DArray[1, 174] = new BlockD(Brick);
        DArray[1, 49] = new BlockD(Beton);
        DArray[1, 48] = new BlockD(Ground);
        DArray[1, 50] = new BlockD(Sand);
        DArray[1, 51] = new BlockD(Sand);
        DArray[1, 52] = new BlockD(Sand);
        DArray[1, 55] = new BlockD(Rock);
        DArray[1, 54] = new BlockD(Rock);
        DArray[1, 53] = new BlockD(Rock);
        DArray[1, 56] = new BlockD(Rock);
        DArray[1, 57] = new BlockD(Rock);
        DArray[1, 65] = new BlockD(Rock);
        DArray[1, 67] = new BlockD(Rock);
        DArray[1, 68] = new BlockD(Rock);
        DArray[1, 69] = new BlockD(Rock);
        DArray[1, 70] = new BlockD(Rock);

        DArray[1, 112] = new BlockD(Rock);
        DArray[1, 113] = new BlockD(Rock);
        	DArray[1, 155] = new BlockD(PU);
		DArray[1, 111] = new BlockD(BioSlime);
        DArray[1, 108] = new BlockD(Cell);
        DArray[1, 180] = new BlockD(CellKey);
       /* DA2 = new PUPID[2, 257];
        DA2[1, 152] = new PUPID(Sceptre);
        DA2[1, 149] = new PUPID(BrassBraclet);
        DA2[1, 148] = new PUPID(PileOfCoins);
        DA2[1, 151] = new PUPID(GoldenCross);
        DA2[1, 154] = new PUPID(Crown);
        DA2[1, 153] = new PUPID(Rubin);
        DA2[1, 146] = new PUPID(AncientShield);
        DA2[1, 147] = new PUPID(GoldenEgg);
        DA2[1, 150] = new PUPID(GoldebBar);
        DA2[1, 109] = new PUPID(Medkit);
        DA2[1, 121] = new PUPID(ArmorBox);
        DA2[1, 156] = new PUPID(Teleport);
        DA2[1, 143] = new PUPID(Axe);
        DA2[1, 144] = new PUPID(AxeBig);
        DA2[1, 145] = new PUPID(RockDrill);*/
    }


    public void LoadVisualLevel()
    {
       GameObject prefab = (GameObject)Resources.Load ("Prefabs/Square");
        /*Sprite sp1 = Resources.Load<UnityEngine.Sprite> ("map/mb_ground");
        Sprite sp2 = Resources.Load<UnityEngine.Sprite> ("map/mb_beton");
        prefab.GetComponent<SpriteRenderer>().sprite =sp1;*/

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

                }
                //заполняем pickuplayer
                /*if ((PickupLayer(i / 10, y / 10) != null)) {
                    PoleG.Children.Add(PickupLayer(i / 10, y / 10).ExtractImage);
                    Canvas.SetZIndex(PickupLayer(i / 10, y / 10).ExtractImage, 0);
                    Canvas.SetLeft(PickupLayer(i / 10, y / 10).ExtractImage, i);
                    Canvas.SetTop(PickupLayer(i / 10, y / 10).ExtractImage, y);
                }*/

            }

        }
    }

}
