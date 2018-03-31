using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMethod : MonoBehaviour {

    string m_name, m_type;
    int m_damage, m_level;
    Texture2D m_image;

    public AttackMethod(string name, string type, int damage, int level, Texture2D image)
    {
        m_name = name;
        m_type = type;
        m_damage = damage;
        m_level = level;
        m_image = image;
    }


}
