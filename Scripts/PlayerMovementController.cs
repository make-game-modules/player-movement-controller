// ����Unity����Ŀ�
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * ���ű�����ʵ����ҵĻ����ƶ����ơ���ͨ�����̵��������һ���W��A��S��D��������ҽ�ɫ�����������ƶ���
 * ʹ�÷��������ű����ص���Ҷ����ϣ�����Unity�༭����Inspector������������ҵ��ƶ��ٶȲ�����
 */
public class PlayerMovementController : MonoBehaviour
{
    public float speed = 5.0f; // ����һ�������ĸ����ͱ��������ڿ�����ҵ��ƶ��ٶȣ�������Unity�༭���н��е�����

    // Unity��Update����������ÿһ֡���ᱻ���á�
    void Update()
    {
        // ��ȡˮƽ��������룬�������/�Ҽ�ͷ������A/D������Χ��-1��1��������ʾ����������ʾ���ҡ�
        float moveHorizontal = Input.GetAxis("Horizontal");

        // ��ȡ��ֱ��������룬�������/�¼�ͷ������W/S������Χ��-1��1��������ʾ���£�������ʾ���ϡ�
        float moveVertical = Input.GetAxis("Vertical");

        // ����ˮƽ�ʹ�ֱ��������룬����һ����ά������������ʾ�ƶ��ķ���ʹ�С��
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // ʹ�����洴�����������ƶ���ҡ�����speed�����������ƶ����ٶȡ�
        // Time.deltaTime����һ֡��ʱ�䣬�������ֵ���Ա�֤�ڸ����豸�ϣ�����֡����Σ���ҵ��ƶ��ٶȶ���һ�µġ�
        transform.position = (Vector2)transform.position + movement * speed * Time.deltaTime;
    }
}
