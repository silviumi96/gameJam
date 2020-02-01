using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public List<GameObject> puzzles;
    private List<int> completed = new List<int>();
    public GameObject obstruction;
    
    public void addCompletedPuzzle(int puzzle) 
    {
        completed.Add(puzzle);
        if (puzzlesFinished()) {
            killObstruction();
        }
    }

    private bool puzzlesFinished() 
    {
        if (completed.Count >= puzzles.Count)
            return true;
        return false;
    }

    private void killObstruction() 
    {
        obstruction.GetComponentInChildren<Obstruction>().DisableObstruction();
    }

    public int getPuzzleIdByName(string puzzleName)
    {
        foreach (GameObject puzzle in puzzles)
        {
            if (puzzle.name == puzzleName) {
                return puzzle.GetInstanceID();
            }
        }

        return -1;
    }
}
