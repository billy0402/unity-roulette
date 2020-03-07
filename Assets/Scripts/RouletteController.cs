using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {
    private float _rotSpeed = 0; // 旋轉速度

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        // 若點擊滑鼠就要設定旋轉速度
        if (Input.GetMouseButtonDown(0)) {
            this._rotSpeed = 10;
        }

        // 旋轉速度、讓輪盤旋轉
        transform.Rotate(0, 0, this._rotSpeed);

        // 讓輪盤減速
        this._rotSpeed *= 0.96f;
    }
}