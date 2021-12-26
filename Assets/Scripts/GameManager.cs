using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScored() {

        _playerScore++;
        Debug.Log(_playerScore);
        
        this.ball.ResetPosition();
    }

    public void ComputerScored() {

        _computerScore++;
        Debug.Log(_computerScore);

        this.ball.ResetPosition();
    }

}



    
