using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGetChild
{
    List<GameObject> Child { get; set; }
    void GetChildren();
}
