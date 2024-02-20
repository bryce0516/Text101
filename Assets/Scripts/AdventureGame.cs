using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
  [SerializeField] Text textComponent;
  [SerializeField] State startingState;

  int[] oddNumbers = { 1, 3, 5, 7, 9 };
  string[] dayOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
  State state;

  // Start is called before the first frame update
  void Start() {
    if (textComponent == null)
    {
      Debug.LogError("textComponent is not assigned in the inspector!");
      return; // Early return to prevent further execution
    }

    if (startingState == null)
    {
      Debug.LogError("startingState is not assigned in the inspector!");
      return; // Early return to prevent further execution
    }


    state = startingState;
    textComponent.text = state.GetStateStory();

    Debug.Log("first print dayOfTheWeek 3 >> " + dayOfTheWeek[3]);
  }

  // Update is called once per frame
  void Update()
  {
    ManageState();
  }

  private void ManageState()
  {
    var nextStates = state.GetNextStates();

    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      state = nextStates[0];
    }
    else if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      state = nextStates[1];
    }
    else if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      state = nextStates[2];
    }

    textComponent.text = state.GetStateStory();
  }
}
