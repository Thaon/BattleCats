using UnityEngine;
using System.Collections;

/// <summary>
/// This class will hold the attributes and actions of a Cat.
/// It will take care of representing the Cat during battles.
/// </summary>

public class Cat : MonoBehaviour {

    #region member variables

    //stats, calculated from 0 to 10;
    private byte m_speed; //affects if cat will be idle, initiative and dodge
    private byte m_strength; //affects damage
    private byte m_dodge;
    private byte m_parry; //affects if cat will be parrying as a next action (adds points to parrying an attack)
    private byte m_special;

    //should this be related to strength?
    private byte m_health;

    #endregion

    void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    #region getters and setters

    public void SetupCat(byte spd, byte str, byte dod, byte par, byte spe)
    {
        m_speed = spd;
        m_strength = str;
        m_dodge = dod;
        m_parry = par;
        m_special = spe;
    }

    public byte GetHealth() { return m_health; }
    public byte GetSpeed() { return m_speed; }


    #endregion
}
