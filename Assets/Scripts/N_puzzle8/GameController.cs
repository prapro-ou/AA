using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
     public GameObject PieceBase;

    public Sprite[] PieceFaces;
    public Vector3[] Pos;

    private List<GameObject> PieceList = new List<GameObject>();

    public GameObject key;
    
void Start()

    {
        SetCorrectPos();
        CreatePieces();

    }

 void SetCorrectPos()

    {

        int n = 0;

        float offsetY = -1.63f;

        float offsetX = 1.3f;

        for (int i = 0; i < 3; i++)

        {

            for (int j = 0; j < 3; j++)

            {

                Pos[n] = new Vector2(j * offsetX , i * offsetY);

                n++;

            }

        }

    }

 private int[,] puzzle1 = new int[3, 3]

    {

        {2,6,0},
        {7,8,5},
        {1,3,4},

    };

void CreatePieces()

    {

        for (int i = 0; i < 9; i++)

        {

            var piece = Instantiate(PieceBase);

            piece.GetComponent<SpriteRenderer>().sprite = PieceFaces[i];

            PieceList.Add(piece);

        }
        PieceList[8].SetActive(false);
        Dealing();

    }

void Dealing()

    {

        float offsetY = -1.63f;
        float offsetX = 1.3f;

        for (int i = 0; i < 3; i++)

        {

            for (int j = 0; j < 3; j++)

            {

                if (puzzle1[i,j]==8)

                {

                    continue;

                }

                PieceList[puzzle1[i,j]].transform.position = new Vector2(j*offsetX, i*offsetY);

            }

        }

       

    }

public void ClearCheck()

    {

        if (PieceList[0].transform.position==Pos[0]

            && PieceList[1].transform.position==Pos[1]

            && PieceList[2].transform.position == Pos[2]

            && PieceList[3].transform.position == Pos[3]

            && PieceList[4].transform.position == Pos[4]

            && PieceList[5].transform.position == Pos[5]

            && PieceList[6].transform.position == Pos[6]

            && PieceList[7].transform.position == Pos[7] )

        {

            //クリアしたときの演出

           PieceList[8].SetActive(true);

           PieceList[8].transform.position = new Vector2(1.3f * 2, -3.26f);

            key.SetActive(true);
        }

    }


}
