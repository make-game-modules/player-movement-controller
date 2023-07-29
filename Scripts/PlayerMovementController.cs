// 引入Unity所需的库
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 本脚本负责实现玩家的基础移动控制。它通过键盘的上下左右或者W、A、S、D键进行玩家角色的上下左右移动。
 * 使用方法：将脚本挂载到玩家对象上，可在Unity编辑器的Inspector窗口中设置玩家的移动速度参数。
 */
public class PlayerMovementController : MonoBehaviour
{
    public float speed = 5.0f; // 这是一个公开的浮点型变量，用于控制玩家的移动速度，可以在Unity编辑器中进行调整。

    // Unity的Update函数，它在每一帧都会被调用。
    void Update()
    {
        // 获取水平方向的输入，这包括左/右箭头键或者A/D键，范围是-1到1，负数表示向左，正数表示向右。
        float moveHorizontal = Input.GetAxis("Horizontal");

        // 获取垂直方向的输入，这包括上/下箭头键或者W/S键，范围是-1到1，负数表示向下，正数表示向上。
        float moveVertical = Input.GetAxis("Vertical");

        // 根据水平和垂直方向的输入，创建一个二维向量，用来表示移动的方向和大小。
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // 使用上面创建的向量来移动玩家。乘以speed变量来控制移动的速度。
        // Time.deltaTime是上一帧的时间，乘以这个值可以保证在各种设备上，无论帧率如何，玩家的移动速度都是一致的。
        transform.position = (Vector2)transform.position + movement * speed * Time.deltaTime;
    }
}
