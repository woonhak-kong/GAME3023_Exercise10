using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerController))]
public class PlayerControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        PlayerController myPlayerController = (PlayerController)target;

        EditorGUILayout.FloatField("Speed", myPlayerController.Speed);

        Vector2 velocity = myPlayerController.velocity;

        if (velocity == Vector2.zero)
        {
            EditorGUILayout.LabelField("Walking Direction", "Stay");
        }
        else if (velocity.x > 0.0f && velocity.y > 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Right_Up");
        }
        else if (velocity.x < 0.0f && velocity.y > 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Left_Up");
        }
        else if (velocity.x < 0.0f && velocity.y < 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Left_Down");
        }
        else if (velocity.x > 0.0f && velocity.y < 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Right_Down");
        }
        else if (velocity.x < 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Left");
        }
        else if (velocity.x > 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Right");
        }
        else if (velocity.y < 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Down");
        }
        else if (velocity.y > 0.0f)
        {
            EditorGUILayout.LabelField("Walking Direction", "Up");
        }


    }

}
