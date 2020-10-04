﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopManagement : MonoBehaviour
{
    private int loopNumber;

    [SerializeField]
    private Transform player, spawnposition;

    [SerializeField]
    private ConversationPlayer playerDialogue;
    [SerializeField]
    private DialogueCharacter startingDiaCharacter;

    [SerializeField]
    private DistortedDialogueTextDisplay dialogueText;

    private void Start()
    {
        GoToNextLoop();
    }

    public void GoToNextLoop()
    {
        AddLoopIteration(1);
    }

    public void AddLoopIteration(int amount)
    {
        loopNumber += amount;
        ChangePositionsPeople();
        dialogueText.SetDistortionLevel(loopNumber-1);
        if (loopNumber >= 10)
        {
            EndGame();
        }
    }

    private void ChangePositionsPeople()
    {
        player.position = spawnposition.position;
        playerDialogue.StartDialogue(startingDiaCharacter);
    }

    private void EndGame()
    {
        //TODO end game
    }

}
