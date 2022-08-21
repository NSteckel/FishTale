using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Dialogs;

public class Demo : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        // show dialog
        DialogUI.Instance
        .SetTitle ("Instructions & Controls")
        .SetMessage ("1. Use WASD or the Arrow Keys to move around. \n2. Use SPACE to jump. \n3. Collect all the DNA to unlock the next level. \n4. Crates are pushable, but hard to stand on.")
        .Show ( );

    }

}
