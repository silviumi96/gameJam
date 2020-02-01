﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public List<GameObject> puzzles;
    private List<GameObject> completed;
    public GameObject obstruction;
    
    public void addCompletedPuzzle(GameObject puzzle) 
    {
        completed.Add(puzzle);
        if (isPuzzlesFinished()) {
            killObstruction();
        }
    }

    private bool isPuzzlesFinished() 
    {
        if (completed.Count == puzzles.Count)
            return true;
        return false;
    }

    private void killObstruction() 
    {
        obstruction.GetComponentInChildren<Obstruction>().DisableObstruction();
    }
}
