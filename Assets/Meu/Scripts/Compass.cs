using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour {
    public Transform player;
    public Texture compBg;
    public Texture blipTex;
    public Transform fim;
    void OnGUI() {
        GUI.DrawTexture(new Rect(600, 0, 120, 120), compBg);
        GUI.DrawTexture(CreateBlip(), blipTex);
        GUI.DrawTexture(LookTheEnd(), blipTex);

    }

    Rect CreateBlip() {


        float angDeg = player.eulerAngles.y - 90;
        float angRed = angDeg * Mathf.Deg2Rad;

        float blipX = 25 * Mathf.Cos(angRed);
        float blipY = 25 * Mathf.Sin(angRed);

        blipX += 55;
        blipY += 55;

        return new Rect(blipX, blipY, 10, 10);
    }

    Rect LookTheEnd() {

        fim = GameObject.FindGameObjectWithTag("Fim").transform;
        //float Direcao = Vector2.Distance(fim.position , transform.position);
        //float distanciaPlayer = Vector2.Distance(transform.position, fim.position);


        float angDeg = fim.eulerAngles.y - 90;
        float angRed = angDeg * Mathf.Deg2Rad;

        float blipX = 25 * Mathf.Cos(angRed);
        float blipY = 25 * Mathf.Sin(angRed);

        blipX += 55;
        blipY += 55;

        return new Rect(blipX, blipY, 10, 10);

    }

}