using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// This class takes care of generating the "script" that actors will execute during the battle.
/// </summary>

public class AIDirector : MonoBehaviour {

    #region member variables

    //this list will hold the OPCodes for the actions (and reactions) that have to be performed during the battle.
    private Queue<KeyValuePair<byte, byte>> m_opCodes;
    /**
     * 0 - Idle (could lay on the ground and regain some health)
     * 1 - Attack
     * 2 - Parry
     * 3 - Dodge
     * 4 - Special
    */

    public Cat m_cat1;
    public Cat m_cat2;


    #endregion

    void Start ()
    {
        m_opCodes = new Queue<KeyValuePair<byte, byte>>();

	}

    private void GenerateBattle()
    {
        m_opCodes.Clear();

        //faster cat starts
        Cat currentCat = (m_cat1.GetSpeed() >= m_cat2.GetSpeed()) ? m_cat1 : m_cat2;

        //cats will fight to the death!
        while (m_cat1.GetHealth() > 0 && m_cat2.GetHealth() > 0)
        {
            /**
             * FIGHT STRUCTURE:
             * cat 1 decides what to do in his turn:
             *  idle
             *  attack
             *  defend
             * cat 2 reacts in the order:
             *  try dodge
             *  try parry
             * if cat 1 was idle, cat 2 starts a new turn as cat 1
            */ 
            //decide what the cat will do rolling a D10 and checking against the various attributes starting from the highest priority ones

        }
    }
	
    IEnumerator PerformAction(byte opCode)
    {
        //pop from queue
        byte currentAction = opCode;
        float time;
        //execute appropriate action
        switch (currentAction)
        {
            case 0:
                //do stuff here;
                time = 0;
            break;

            default:
                Debug.Log("Wrong action selected");
                time = 0;
            break;
        }
        //wait for it to finish
        yield return new WaitForSeconds(time);
    }
}
