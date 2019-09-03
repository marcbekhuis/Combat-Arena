using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChooser1 : MonoBehaviour
{
    public void Process ()
    {
        LevelChooser.process = 1;
    }

    public void Process1 ()
    {
        LevelChooser.process = 0;
    }
}
