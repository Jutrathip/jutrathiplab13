using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private int playerScore;
    public int PlayerScore {  get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private GameObject ballPrefab;

    [SerializeField]
    private GameObject[] ballPositions;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        SetBall(BallColor.White, 0);
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
        SetBall(BallColor.Black, 7);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetBall(BallColor col, int i )
    {
        GameObject obj = Instantiate(ballPrefab, ballPositions[i].transform.position,Quaternion.identity);

        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);


    }

}
