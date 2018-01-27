using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInfectable
{
    void Infect(bool _infected);

    void Uninfected();
}
