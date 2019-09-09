using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChooser1 : MonoBehaviour
{
    public void Process ()
    {
        // Makes main menu disappear and level buttons appear
        LevelChooser.process = 1;
    }

    public void Process1 ()
    {
        // opposite effect of process = 1
        LevelChooser.process = 0;
    }
}
